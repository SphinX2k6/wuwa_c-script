using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Buffers
{
	// Token: 0x0200034D RID: 845
	internal sealed class SharedArrayPoolPartitions
	{
		// Token: 0x06003AD5 RID: 15061 RVA: 0x000C3DD0 File Offset: 0x000C1FD0
		public SharedArrayPoolPartitions()
		{
			SharedArrayPoolPartitions.Partition[] array = new SharedArrayPoolPartitions.Partition[SharedArrayPoolStatics.s_partitionCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new SharedArrayPoolPartitions.Partition();
			}
			this._partitions = array;
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x000C3E0C File Offset: 0x000C200C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryPush(Array array)
		{
			SharedArrayPoolPartitions.Partition[] partitions = this._partitions;
			int num = Thread.GetCurrentProcessorId() % SharedArrayPoolStatics.s_partitionCount;
			for (int i = 0; i < partitions.Length; i++)
			{
				if (partitions[num].TryPush(array))
				{
					return true;
				}
				if (++num == partitions.Length)
				{
					num = 0;
				}
			}
			return false;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x000C3E54 File Offset: 0x000C2054
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Array TryPop()
		{
			SharedArrayPoolPartitions.Partition[] partitions = this._partitions;
			int num = Thread.GetCurrentProcessorId() % SharedArrayPoolStatics.s_partitionCount;
			for (int i = 0; i < partitions.Length; i++)
			{
				Array result;
				if ((result = partitions[num].TryPop()) != null)
				{
					return result;
				}
				if (++num == partitions.Length)
				{
					num = 0;
				}
			}
			return null;
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x000C3EA0 File Offset: 0x000C20A0
		public void Trim(int currentMilliseconds, int id, Utilities.MemoryPressure pressure)
		{
			SharedArrayPoolPartitions.Partition[] partitions = this._partitions;
			for (int i = 0; i < partitions.Length; i++)
			{
				partitions[i].Trim(currentMilliseconds, id, pressure);
			}
		}

		// Token: 0x04000C55 RID: 3157
		private readonly SharedArrayPoolPartitions.Partition[] _partitions;

		// Token: 0x0200034E RID: 846
		private sealed class Partition
		{
			// Token: 0x06003AD9 RID: 15065 RVA: 0x000C3ED0 File Offset: 0x000C20D0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryPush(Array array)
			{
				bool result = false;
				Monitor.Enter(this);
				Array[] arrays = this._arrays;
				int count = this._count;
				if (count < arrays.Length)
				{
					if (count == 0)
					{
						this._millisecondsTimestamp = 0;
					}
					*Unsafe.Add<Array>(MemoryMarshal.GetArrayDataReference<Array>(arrays), count) = array;
					this._count = count + 1;
					result = true;
				}
				Monitor.Exit(this);
				return result;
			}

			// Token: 0x06003ADA RID: 15066 RVA: 0x000C3F24 File Offset: 0x000C2124
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public Array TryPop()
			{
				Array result = null;
				Monitor.Enter(this);
				Array[] arrays = this._arrays;
				int num = this._count - 1;
				if (num < arrays.Length)
				{
					result = arrays[num];
					arrays[num] = null;
					this._count = num;
				}
				Monitor.Exit(this);
				return result;
			}

			// Token: 0x06003ADB RID: 15067 RVA: 0x000C3F68 File Offset: 0x000C2168
			public void Trim(int currentMilliseconds, int id, Utilities.MemoryPressure pressure)
			{
				if (this._count == 0)
				{
					return;
				}
				int num = (pressure == Utilities.MemoryPressure.High) ? 10000 : 60000;
				lock (this)
				{
					if (this._count != 0)
					{
						if (this._millisecondsTimestamp == 0)
						{
							this._millisecondsTimestamp = currentMilliseconds;
						}
						else if (currentMilliseconds - this._millisecondsTimestamp > num)
						{
							int num2;
							if (pressure != Utilities.MemoryPressure.Medium)
							{
								if (pressure == Utilities.MemoryPressure.High)
								{
									num2 = SharedArrayPoolStatics.s_maxArraysPerPartition;
								}
								else
								{
									num2 = 1;
								}
							}
							else
							{
								num2 = 2;
							}
							int num3 = num2;
							ArrayPoolEventSource log = ArrayPoolEventSource.Log;
							while (this._count > 0 && num3-- > 0)
							{
								Array[] arrays = this._arrays;
								num2 = this._count - 1;
								this._count = num2;
								Array array = arrays[num2];
								this._arrays[this._count] = null;
								if (log.IsEnabled())
								{
									log.BufferTrimmed(array.GetHashCode(), array.Length, id);
								}
							}
							this._millisecondsTimestamp = ((this._count > 0) ? (this._millisecondsTimestamp + num / 4) : 0);
						}
					}
				}
			}

			// Token: 0x04000C56 RID: 3158
			private readonly Array[] _arrays = new Array[SharedArrayPoolStatics.s_maxArraysPerPartition];

			// Token: 0x04000C57 RID: 3159
			private int _count;

			// Token: 0x04000C58 RID: 3160
			private int _millisecondsTimestamp;
		}
	}
}
