using System;
using System.Diagnostics;
using System.Threading;

namespace System.Buffers
{
	// Token: 0x02000342 RID: 834
	internal sealed class ConfigurableArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x06003A9F RID: 15007 RVA: 0x000C3180 File Offset: 0x000C1380
		internal ConfigurableArrayPool() : this(1048576, 50)
		{
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x000C3190 File Offset: 0x000C1390
		internal ConfigurableArrayPool(int maxArrayLength, int maxArraysPerBucket)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(maxArrayLength, "maxArrayLength");
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(maxArraysPerBucket, "maxArraysPerBucket");
			if (maxArrayLength > 1073741824)
			{
				maxArrayLength = 1073741824;
			}
			else if (maxArrayLength < 16)
			{
				maxArrayLength = 16;
			}
			int id = this.Id;
			ConfigurableArrayPool<T>.Bucket[] array = new ConfigurableArrayPool<T>.Bucket[Utilities.SelectBucketIndex(maxArrayLength) + 1];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new ConfigurableArrayPool<T>.Bucket(Utilities.GetMaxSizeForBucket(i), maxArraysPerBucket, id);
			}
			this._buckets = array;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x000C320D File Offset: 0x000C140D
		private int Id
		{
			get
			{
				return this.GetHashCode();
			}
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x000C3218 File Offset: 0x000C1418
		public override T[] Rent(int minimumLength)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(minimumLength, "minimumLength");
			if (minimumLength == 0)
			{
				return Array.Empty<T>();
			}
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			int num = Utilities.SelectBucketIndex(minimumLength);
			T[] array;
			if (num < this._buckets.Length)
			{
				int num2 = num;
				for (;;)
				{
					array = this._buckets[num2].Rent();
					if (array != null)
					{
						break;
					}
					if (++num2 >= this._buckets.Length || num2 == num + 2)
					{
						goto IL_80;
					}
				}
				if (log.IsEnabled())
				{
					log.BufferRented(array.GetHashCode(), array.Length, this.Id, this._buckets[num2].Id);
				}
				return array;
				IL_80:
				array = new T[this._buckets[num]._bufferLength];
			}
			else
			{
				array = new T[minimumLength];
			}
			if (log.IsEnabled())
			{
				int hashCode = array.GetHashCode();
				log.BufferRented(hashCode, array.Length, this.Id, -1);
				log.BufferAllocated(hashCode, array.Length, this.Id, -1, (num >= this._buckets.Length) ? ArrayPoolEventSource.BufferAllocatedReason.OverMaximumSize : ArrayPoolEventSource.BufferAllocatedReason.PoolExhausted);
			}
			return array;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x000C3308 File Offset: 0x000C1508
		public override void Return(T[] array, bool clearArray = false)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Length == 0)
			{
				return;
			}
			int num = Utilities.SelectBucketIndex(array.Length);
			bool flag = num < this._buckets.Length;
			if (flag)
			{
				if (clearArray)
				{
					Array.Clear(array);
				}
				this._buckets[num].Return(array);
			}
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			if (log.IsEnabled())
			{
				int hashCode = array.GetHashCode();
				log.BufferReturned(hashCode, array.Length, this.Id);
				if (!flag)
				{
					log.BufferDropped(hashCode, array.Length, this.Id, -1, ArrayPoolEventSource.BufferDroppedReason.Full);
				}
			}
		}

		// Token: 0x04000C3B RID: 3131
		private readonly ConfigurableArrayPool<T>.Bucket[] _buckets;

		// Token: 0x02000343 RID: 835
		private sealed class Bucket
		{
			// Token: 0x06003AA4 RID: 15012 RVA: 0x000C338E File Offset: 0x000C158E
			internal Bucket(int bufferLength, int numberOfBuffers, int poolId)
			{
				this._lock = new SpinLock(Debugger.IsAttached);
				this._buffers = new T[numberOfBuffers][];
				this._bufferLength = bufferLength;
				this._poolId = poolId;
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x000C320D File Offset: 0x000C140D
			internal int Id
			{
				get
				{
					return this.GetHashCode();
				}
			}

			// Token: 0x06003AA6 RID: 15014 RVA: 0x000C33C0 File Offset: 0x000C15C0
			internal T[] Rent()
			{
				T[][] buffers = this._buffers;
				T[] array = null;
				bool flag = false;
				bool flag2 = false;
				try
				{
					this._lock.Enter(ref flag);
					if (this._index < buffers.Length)
					{
						array = buffers[this._index];
						T[][] array2 = buffers;
						int index = this._index;
						this._index = index + 1;
						array2[index] = null;
						flag2 = (array == null);
					}
				}
				finally
				{
					if (flag)
					{
						this._lock.Exit(false);
					}
				}
				if (flag2)
				{
					array = new T[this._bufferLength];
					ArrayPoolEventSource log = ArrayPoolEventSource.Log;
					if (log.IsEnabled())
					{
						log.BufferAllocated(array.GetHashCode(), this._bufferLength, this._poolId, this.Id, ArrayPoolEventSource.BufferAllocatedReason.Pooled);
					}
				}
				return array;
			}

			// Token: 0x06003AA7 RID: 15015 RVA: 0x000C347C File Offset: 0x000C167C
			internal void Return(T[] array)
			{
				if (array.Length != this._bufferLength)
				{
					throw new ArgumentException(SR.ArgumentException_BufferNotFromPool, "array");
				}
				bool flag = false;
				bool flag2;
				try
				{
					this._lock.Enter(ref flag);
					flag2 = (this._index != 0);
					if (flag2)
					{
						T[][] buffers = this._buffers;
						int num = this._index - 1;
						this._index = num;
						buffers[num] = array;
					}
				}
				finally
				{
					if (flag)
					{
						this._lock.Exit(false);
					}
				}
				if (!flag2)
				{
					ArrayPoolEventSource log = ArrayPoolEventSource.Log;
					if (log.IsEnabled())
					{
						log.BufferDropped(array.GetHashCode(), this._bufferLength, this._poolId, this.Id, ArrayPoolEventSource.BufferDroppedReason.Full);
					}
				}
			}

			// Token: 0x04000C3C RID: 3132
			internal readonly int _bufferLength;

			// Token: 0x04000C3D RID: 3133
			private readonly T[][] _buffers;

			// Token: 0x04000C3E RID: 3134
			private readonly int _poolId;

			// Token: 0x04000C3F RID: 3135
			private SpinLock _lock;

			// Token: 0x04000C40 RID: 3136
			private int _index;
		}
	}
}
