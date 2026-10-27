using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777E RID: 30590
	public class TSetAreaTimeTypeUnion
	{
		// Token: 0x1700E697 RID: 59031
		// (get) Token: 0x060378B2 RID: 227506 RVA: 0x007841CA File Offset: 0x007823CA
		// (set) Token: 0x060378B3 RID: 227507 RVA: 0x007841D2 File Offset: 0x007823D2
		public TSetAreaTimeType Type { get; set; }

		// Token: 0x1700E698 RID: 59032
		// (get) Token: 0x060378B4 RID: 227508 RVA: 0x007841DB File Offset: 0x007823DB
		// (set) Token: 0x060378B5 RID: 227509 RVA: 0x007841E3 File Offset: 0x007823E3
		public object Value { get; set; }

		// Token: 0x060378B6 RID: 227510 RVA: 0x007841EC File Offset: 0x007823EC
		public TSetAreaTimeTypeUnion()
		{
			this.Type = TSetAreaTimeType.NONE;
			this.Value = null;
		}

		// Token: 0x060378B7 RID: 227511 RVA: 0x00784202 File Offset: 0x00782402
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378B8 RID: 227512 RVA: 0x00784214 File Offset: 0x00782414
		public ISetAreaTimeLockT AsISetAreaTimeLock()
		{
			return this.As<ISetAreaTimeLockT>();
		}

		// Token: 0x060378B9 RID: 227513 RVA: 0x0078421C File Offset: 0x0078241C
		public static TSetAreaTimeTypeUnion FromISetAreaTimeLock(ISetAreaTimeLockT _isetareatimelock)
		{
			return new TSetAreaTimeTypeUnion
			{
				Type = TSetAreaTimeType.ISetAreaTimeLock,
				Value = _isetareatimelock
			};
		}

		// Token: 0x060378BA RID: 227514 RVA: 0x00784231 File Offset: 0x00782431
		public ISetAreaTimeUnLockT AsISetAreaTimeUnLock()
		{
			return this.As<ISetAreaTimeUnLockT>();
		}

		// Token: 0x060378BB RID: 227515 RVA: 0x00784239 File Offset: 0x00782439
		public static TSetAreaTimeTypeUnion FromISetAreaTimeUnLock(ISetAreaTimeUnLockT _isetareatimeunlock)
		{
			return new TSetAreaTimeTypeUnion
			{
				Type = TSetAreaTimeType.ISetAreaTimeUnLock,
				Value = _isetareatimeunlock
			};
		}

		// Token: 0x060378BC RID: 227516 RVA: 0x00784250 File Offset: 0x00782450
		public static int Pack(FlatBufferBuilder builder, TSetAreaTimeTypeUnion _o)
		{
			TSetAreaTimeType type = _o.Type;
			if (type == TSetAreaTimeType.ISetAreaTimeLock)
			{
				return ISetAreaTimeLock.Pack(builder, _o.AsISetAreaTimeLock()).Value;
			}
			if (type != TSetAreaTimeType.ISetAreaTimeUnLock)
			{
				return 0;
			}
			return ISetAreaTimeUnLock.Pack(builder, _o.AsISetAreaTimeUnLock()).Value;
		}
	}
}
