using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Buffers
{
	// Token: 0x0200034A RID: 842
	internal sealed class SharedArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x06003ACA RID: 15050 RVA: 0x000C38A8 File Offset: 0x000C1AA8
		private SharedArrayPoolPartitions CreatePerCorePartitions(int bucketIndex)
		{
			SharedArrayPoolPartitions sharedArrayPoolPartitions = new SharedArrayPoolPartitions();
			return Interlocked.CompareExchange<SharedArrayPoolPartitions>(ref this._buckets[bucketIndex], sharedArrayPoolPartitions, null) ?? sharedArrayPoolPartitions;
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x000C320D File Offset: 0x000C140D
		private int Id
		{
			get
			{
				return this.GetHashCode();
			}
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x000C38D4 File Offset: 0x000C1AD4
		public override T[] Rent(int minimumLength)
		{
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			int num = Utilities.SelectBucketIndex(minimumLength);
			SharedArrayPoolThreadLocalArray[] array = SharedArrayPool<T>.t_tlsBuckets;
			T[] array2;
			if (array != null && num < array.Length)
			{
				array2 = Unsafe.As<T[]>(array[num].Array);
				if (array2 != null)
				{
					array[num].Array = null;
					if (log.IsEnabled())
					{
						log.BufferRented(array2.GetHashCode(), array2.Length, this.Id, num);
					}
					return array2;
				}
			}
			SharedArrayPoolPartitions[] buckets = this._buckets;
			if (num < buckets.Length)
			{
				SharedArrayPoolPartitions sharedArrayPoolPartitions = buckets[num];
				if (sharedArrayPoolPartitions != null)
				{
					array2 = Unsafe.As<T[]>(sharedArrayPoolPartitions.TryPop());
					if (array2 != null)
					{
						if (log.IsEnabled())
						{
							log.BufferRented(array2.GetHashCode(), array2.Length, this.Id, num);
						}
						return array2;
					}
				}
				minimumLength = Utilities.GetMaxSizeForBucket(num);
			}
			else
			{
				if (minimumLength == 0)
				{
					return Array.Empty<T>();
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(minimumLength, "minimumLength");
			}
			array2 = GC.AllocateUninitializedArray<T>(minimumLength, false);
			if (log.IsEnabled())
			{
				int hashCode = array2.GetHashCode();
				log.BufferRented(hashCode, array2.Length, this.Id, -1);
				log.BufferAllocated(hashCode, array2.Length, this.Id, -1, (num >= this._buckets.Length) ? ArrayPoolEventSource.BufferAllocatedReason.OverMaximumSize : ArrayPoolEventSource.BufferAllocatedReason.PoolExhausted);
			}
			return array2;
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x000C39F4 File Offset: 0x000C1BF4
		public override void Return(T[] array, bool clearArray = false)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			int num = Utilities.SelectBucketIndex(array.Length);
			SharedArrayPoolThreadLocalArray[] array2 = SharedArrayPool<T>.t_tlsBuckets ?? this.InitializeTlsBucketsAndTrimming();
			bool flag = false;
			bool flag2 = true;
			if (num < array2.Length)
			{
				flag = true;
				if (clearArray)
				{
					Array.Clear(array);
				}
				if (array.Length != Utilities.GetMaxSizeForBucket(num))
				{
					throw new ArgumentException(SR.ArgumentException_BufferNotFromPool, "array");
				}
				SharedArrayPoolThreadLocalArray[] array3 = array2;
				int num2 = num;
				Array array4 = array3[num2].Array;
				array3[num2] = new SharedArrayPoolThreadLocalArray(array);
				if (array4 != null)
				{
					flag2 = (this._buckets[num] ?? this.CreatePerCorePartitions(num)).TryPush(array4);
				}
			}
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			if (log.IsEnabled() && array.Length != 0)
			{
				log.BufferReturned(array.GetHashCode(), array.Length, this.Id);
				if (!flag || !flag2)
				{
					log.BufferDropped(array.GetHashCode(), array.Length, this.Id, flag ? num : -1, flag ? ArrayPoolEventSource.BufferDroppedReason.Full : ArrayPoolEventSource.BufferDroppedReason.OverMaximumSize);
				}
			}
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x000C3AE0 File Offset: 0x000C1CE0
		public bool Trim()
		{
			int tickCount = Environment.TickCount;
			Utilities.MemoryPressure memoryPressure = Utilities.GetMemoryPressure();
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			if (log.IsEnabled())
			{
				log.BufferTrimPoll(tickCount, (int)memoryPressure);
			}
			foreach (SharedArrayPoolPartitions sharedArrayPoolPartitions in this._buckets)
			{
				if (sharedArrayPoolPartitions != null)
				{
					sharedArrayPoolPartitions.Trim(tickCount, this.Id, memoryPressure);
				}
			}
			if (memoryPressure == Utilities.MemoryPressure.High)
			{
				if (!log.IsEnabled())
				{
					using (IEnumerator<KeyValuePair<SharedArrayPoolThreadLocalArray[], object>> enumerator = ((IEnumerable<KeyValuePair<SharedArrayPoolThreadLocalArray[], object>>)this._allTlsBuckets).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<SharedArrayPoolThreadLocalArray[], object> keyValuePair = enumerator.Current;
							Array.Clear(keyValuePair.Key);
						}
						return true;
					}
				}
				using (IEnumerator<KeyValuePair<SharedArrayPoolThreadLocalArray[], object>> enumerator = ((IEnumerable<KeyValuePair<SharedArrayPoolThreadLocalArray[], object>>)this._allTlsBuckets).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<SharedArrayPoolThreadLocalArray[], object> keyValuePair2 = enumerator.Current;
						SharedArrayPoolThreadLocalArray[] key = keyValuePair2.Key;
						for (int j = 0; j < key.Length; j++)
						{
							T[] array = Interlocked.Exchange<Array>(ref key[j].Array, null) as T[];
							if (array != null)
							{
								log.BufferTrimmed(array.GetHashCode(), array.Length, this.Id);
							}
						}
					}
					return true;
				}
			}
			uint num;
			if (memoryPressure == Utilities.MemoryPressure.Medium)
			{
				num = 15000U;
			}
			else
			{
				num = 30000U;
			}
			uint num2 = num;
			foreach (KeyValuePair<SharedArrayPoolThreadLocalArray[], object> keyValuePair3 in ((IEnumerable<KeyValuePair<SharedArrayPoolThreadLocalArray[], object>>)this._allTlsBuckets))
			{
				SharedArrayPoolThreadLocalArray[] key2 = keyValuePair3.Key;
				for (int k = 0; k < key2.Length; k++)
				{
					if (key2[k].Array != null)
					{
						int millisecondsTimeStamp = key2[k].MillisecondsTimeStamp;
						if (millisecondsTimeStamp == 0)
						{
							key2[k].MillisecondsTimeStamp = tickCount;
						}
						else if ((long)(tickCount - millisecondsTimeStamp) >= (long)((ulong)num2))
						{
							T[] array2 = Interlocked.Exchange<Array>(ref key2[k].Array, null) as T[];
							if (array2 != null && log.IsEnabled())
							{
								log.BufferTrimmed(array2.GetHashCode(), array2.Length, this.Id);
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x000C3D28 File Offset: 0x000C1F28
		private SharedArrayPoolThreadLocalArray[] InitializeTlsBucketsAndTrimming()
		{
			SharedArrayPoolThreadLocalArray[] array = new SharedArrayPoolThreadLocalArray[27];
			SharedArrayPool<T>.t_tlsBuckets = array;
			this._allTlsBuckets.Add(array, null);
			if (!Interlocked.Exchange<bool>(ref this._trimCallbackCreated, true))
			{
				Gen2GcCallback.Register((object s) => ((SharedArrayPool<T>)s).Trim(), this);
			}
			return array;
		}

		// Token: 0x04000C4D RID: 3149
		[ThreadStatic]
		private static SharedArrayPoolThreadLocalArray[] t_tlsBuckets;

		// Token: 0x04000C4E RID: 3150
		private readonly ConditionalWeakTable<SharedArrayPoolThreadLocalArray[], object> _allTlsBuckets = new ConditionalWeakTable<SharedArrayPoolThreadLocalArray[], object>();

		// Token: 0x04000C4F RID: 3151
		private readonly SharedArrayPoolPartitions[] _buckets = new SharedArrayPoolPartitions[27];

		// Token: 0x04000C50 RID: 3152
		private bool _trimCallbackCreated;
	}
}
