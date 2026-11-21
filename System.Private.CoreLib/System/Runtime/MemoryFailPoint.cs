using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace System.Runtime
{
	// Token: 0x02000503 RID: 1283
	public sealed class MemoryFailPoint : CriticalFinalizerObject, IDisposable
	{
		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x000F06F1 File Offset: 0x000EE8F1
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x000F06FD File Offset: 0x000EE8FD
		private static long LastKnownFreeAddressSpace
		{
			get
			{
				return Volatile.Read(ref MemoryFailPoint.s_hiddenLastKnownFreeAddressSpace);
			}
			set
			{
				Volatile.Write(ref MemoryFailPoint.s_hiddenLastKnownFreeAddressSpace, value);
			}
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x000F070A File Offset: 0x000EE90A
		private static void AddToLastKnownFreeAddressSpace(long addend)
		{
			Interlocked.Add(ref MemoryFailPoint.s_hiddenLastKnownFreeAddressSpace, addend);
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x000F0718 File Offset: 0x000EE918
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x000F0724 File Offset: 0x000EE924
		private static long LastTimeCheckingAddressSpace
		{
			get
			{
				return Volatile.Read(ref MemoryFailPoint.s_hiddenLastTimeCheckingAddressSpace);
			}
			set
			{
				Volatile.Write(ref MemoryFailPoint.s_hiddenLastTimeCheckingAddressSpace, value);
			}
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x000F0734 File Offset: 0x000EE934
		public MemoryFailPoint(int sizeInMegabytes)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(sizeInMegabytes, "sizeInMegabytes");
			ulong num = (ulong)((ulong)((long)sizeInMegabytes) << 20);
			this._reservedMemory = num;
			ulong num2 = (ulong)(Math.Ceiling(num / MemoryFailPoint.s_GCSegmentSize) * MemoryFailPoint.s_GCSegmentSize);
			if (num2 >= MemoryFailPoint.s_topOfMemory)
			{
				throw new InsufficientMemoryException(SR.InsufficientMemory_MemFailPoint_TooBig);
			}
			ulong num3 = (ulong)(Math.Ceiling((double)sizeInMegabytes / 16.0) * 16.0);
			num3 <<= 20;
			for (int i = 0; i < 3; i++)
			{
				ulong num4;
				ulong num5;
				if (!MemoryFailPoint.CheckForAvailableMemory(out num4, out num5))
				{
					return;
				}
				ulong memoryFailPointReservedMemory = MemoryFailPoint.MemoryFailPointReservedMemory;
				ulong num6 = num2 + memoryFailPointReservedMemory;
				bool flag = num6 < num2 || num6 < memoryFailPointReservedMemory;
				bool flag2 = num4 < num3 + memoryFailPointReservedMemory + 16777216UL || flag;
				bool flag3 = num5 < num6 || flag;
				long num7 = (long)Environment.TickCount;
				if (num7 > MemoryFailPoint.LastTimeCheckingAddressSpace + 10000L || num7 < MemoryFailPoint.LastTimeCheckingAddressSpace || MemoryFailPoint.LastKnownFreeAddressSpace < (long)num2)
				{
					MemoryFailPoint.CheckForFreeAddressSpace(num2, false);
				}
				bool flag4 = MemoryFailPoint.LastKnownFreeAddressSpace < (long)num2;
				if (!flag2 && !flag3 && !flag4)
				{
					break;
				}
				switch (i)
				{
				case 0:
					GC.Collect();
					break;
				case 1:
					if (flag2)
					{
						MemoryFailPoint.GrowPageFileIfNecessaryAndPossible(new UIntPtr(num2));
					}
					break;
				case 2:
					if (flag2 || flag3)
					{
						throw new InsufficientMemoryException(SR.InsufficientMemory_MemFailPoint);
					}
					if (flag4)
					{
						throw new InsufficientMemoryException(SR.InsufficientMemory_MemFailPoint_VAFrag);
					}
					break;
				}
			}
			MemoryFailPoint.AddToLastKnownFreeAddressSpace((long)(-(long)num));
			if (MemoryFailPoint.LastKnownFreeAddressSpace < 0L)
			{
				MemoryFailPoint.CheckForFreeAddressSpace(num2, true);
			}
			MemoryFailPoint.AddMemoryFailPointReservation((long)num);
			this._mustSubtractReservation = true;
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x000F08C0 File Offset: 0x000EEAC0
		~MemoryFailPoint()
		{
			this.Disposing();
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x000F08EC File Offset: 0x000EEAEC
		public void Dispose()
		{
			this.Disposing();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x000F08FA File Offset: 0x000EEAFA
		private void Disposing()
		{
			if (this._mustSubtractReservation)
			{
				MemoryFailPoint.AddMemoryFailPointReservation((long)(-(long)this._reservedMemory));
				this._mustSubtractReservation = false;
			}
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x000F0918 File Offset: 0x000EEB18
		internal static long AddMemoryFailPointReservation(long size)
		{
			return Interlocked.Add(ref MemoryFailPoint.s_failPointReservedMemory, size);
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x000F0925 File Offset: 0x000EEB25
		internal static ulong MemoryFailPointReservedMemory
		{
			get
			{
				return (ulong)Volatile.Read(ref MemoryFailPoint.s_failPointReservedMemory);
			}
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x000F0934 File Offset: 0x000EEB34
		private unsafe static ulong GetTopOfMemory()
		{
			Interop.Kernel32.SYSTEM_INFO system_INFO;
			Interop.Kernel32.GetSystemInfo(&system_INFO);
			return (ulong)((long)system_INFO.lpMaximumApplicationAddress);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x000F0950 File Offset: 0x000EEB50
		private unsafe static bool CheckForAvailableMemory(out ulong availPageFile, out ulong totalAddressSpaceFree)
		{
			Interop.Kernel32.MEMORYSTATUSEX memorystatusex = default(Interop.Kernel32.MEMORYSTATUSEX);
			memorystatusex.dwLength = (uint)sizeof(Interop.Kernel32.MEMORYSTATUSEX);
			if (Interop.Kernel32.GlobalMemoryStatusEx(&memorystatusex) == Interop.BOOL.FALSE)
			{
				availPageFile = 0UL;
				totalAddressSpaceFree = 0UL;
				return false;
			}
			availPageFile = memorystatusex.ullAvailPageFile;
			totalAddressSpaceFree = memorystatusex.ullAvailVirtual;
			return true;
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x000F0997 File Offset: 0x000EEB97
		private static void CheckForFreeAddressSpace(ulong size, bool shouldThrow)
		{
			ulong num = (ulong)(MemoryFailPoint.LastKnownFreeAddressSpace = (long)MemoryFailPoint.MemFreeAfterAddress(null, size));
			MemoryFailPoint.LastTimeCheckingAddressSpace = (long)Environment.TickCount;
			if (num < size && shouldThrow)
			{
				throw new InsufficientMemoryException(SR.InsufficientMemory_MemFailPoint_VAFrag);
			}
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x000F09C4 File Offset: 0x000EEBC4
		private unsafe static ulong MemFreeAfterAddress(void* address, ulong size)
		{
			if (size >= MemoryFailPoint.s_topOfMemory)
			{
				return 0UL;
			}
			ulong num = 0UL;
			Interop.Kernel32.MEMORY_BASIC_INFORMATION memory_BASIC_INFORMATION = default(Interop.Kernel32.MEMORY_BASIC_INFORMATION);
			UIntPtr dwLength = (UIntPtr)((IntPtr)sizeof(Interop.Kernel32.MEMORY_BASIC_INFORMATION));
			while ((byte*)address + size < MemoryFailPoint.s_topOfMemory)
			{
				if (Interop.Kernel32.VirtualQuery(address, ref memory_BASIC_INFORMATION, dwLength) == UIntPtr.Zero)
				{
					throw Win32Marshal.GetExceptionForLastWin32Error("");
				}
				ulong num2 = memory_BASIC_INFORMATION.RegionSize.ToUInt64();
				if (memory_BASIC_INFORMATION.State == 65536U)
				{
					if (num2 >= size)
					{
						return num2;
					}
					num = Math.Max(num, num2);
				}
				address = (void*)((byte*)address + num2);
			}
			return num;
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x000F0A48 File Offset: 0x000EEC48
		private unsafe static void GrowPageFileIfNecessaryAndPossible(UIntPtr numBytes)
		{
			void* ptr = Interop.Kernel32.VirtualAlloc(null, numBytes, 4096, 4);
			if (ptr != null && !Interop.Kernel32.VirtualFree(ptr, UIntPtr.Zero, 32768))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
		}

		// Token: 0x0400112B RID: 4395
		private static readonly ulong s_topOfMemory = MemoryFailPoint.GetTopOfMemory();

		// Token: 0x0400112C RID: 4396
		private static long s_hiddenLastKnownFreeAddressSpace;

		// Token: 0x0400112D RID: 4397
		private static long s_hiddenLastTimeCheckingAddressSpace;

		// Token: 0x0400112E RID: 4398
		private static readonly ulong s_GCSegmentSize = 16777216UL;

		// Token: 0x0400112F RID: 4399
		private static long s_failPointReservedMemory;

		// Token: 0x04001130 RID: 4400
		private readonly ulong _reservedMemory;

		// Token: 0x04001131 RID: 4401
		private bool _mustSubtractReservation;
	}
}
