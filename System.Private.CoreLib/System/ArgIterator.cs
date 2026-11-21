using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000070 RID: 112
	[StructLayout(LayoutKind.Auto)]
	public ref struct ArgIterator
	{
		// Token: 0x0600021B RID: 539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Setup(IntPtr argsp, IntPtr start);

		// Token: 0x0600021C RID: 540 RVA: 0x0000682C File Offset: 0x00004A2C
		public ArgIterator(RuntimeArgumentHandle arglist)
		{
			this.sig = IntPtr.Zero;
			this.args = IntPtr.Zero;
			this.next_arg = (this.num_args = 0);
			if (arglist.args == IntPtr.Zero)
			{
				throw new PlatformNotSupportedException();
			}
			this.Setup(arglist.args, IntPtr.Zero);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00006888 File Offset: 0x00004A88
		[CLSCompliant(false)]
		public unsafe ArgIterator(RuntimeArgumentHandle arglist, void* ptr)
		{
			this.sig = IntPtr.Zero;
			this.args = IntPtr.Zero;
			this.next_arg = (this.num_args = 0);
			if (arglist.args == IntPtr.Zero)
			{
				throw new PlatformNotSupportedException();
			}
			this.Setup(arglist.args, ptr);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000068DD File Offset: 0x00004ADD
		public void End()
		{
			this.next_arg = this.num_args;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000068EB File Offset: 0x00004AEB
		[NullableContext(2)]
		public override bool Equals(object o)
		{
			throw new NotSupportedException(SR.NotSupported_NYI);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000068F7 File Offset: 0x00004AF7
		public override int GetHashCode()
		{
			return this.sig.GetHashCode();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00006904 File Offset: 0x00004B04
		[CLSCompliant(false)]
		public unsafe TypedReference GetNextArg()
		{
			if (this.num_args == this.next_arg)
			{
				throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
			}
			TypedReference result = default(TypedReference);
			this.IntGetNextArg((void*)(&result));
			return result;
		}

		// Token: 0x06000222 RID: 546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe extern void IntGetNextArg(void* res);

		// Token: 0x06000223 RID: 547 RVA: 0x0000693C File Offset: 0x00004B3C
		[CLSCompliant(false)]
		public unsafe TypedReference GetNextArg(RuntimeTypeHandle rth)
		{
			if (this.num_args == this.next_arg)
			{
				throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
			}
			TypedReference result = default(TypedReference);
			this.IntGetNextArgWithType((void*)(&result), rth.Value);
			return result;
		}

		// Token: 0x06000224 RID: 548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe extern void IntGetNextArgWithType(void* res, IntPtr rth);

		// Token: 0x06000225 RID: 549 RVA: 0x0000697B File Offset: 0x00004B7B
		public RuntimeTypeHandle GetNextArgType()
		{
			if (this.num_args == this.next_arg)
			{
				throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
			}
			return new RuntimeTypeHandle(this.IntGetNextArgType());
		}

		// Token: 0x06000226 RID: 550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr IntGetNextArgType();

		// Token: 0x06000227 RID: 551 RVA: 0x000069A1 File Offset: 0x00004BA1
		public int GetRemainingCount()
		{
			return this.num_args - this.next_arg;
		}

		// Token: 0x040001E0 RID: 480
		private IntPtr sig;

		// Token: 0x040001E1 RID: 481
		private IntPtr args;

		// Token: 0x040001E2 RID: 482
		private int next_arg;

		// Token: 0x040001E3 RID: 483
		private int num_args;
	}
}
