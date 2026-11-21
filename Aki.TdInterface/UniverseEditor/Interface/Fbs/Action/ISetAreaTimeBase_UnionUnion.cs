using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776C RID: 30572
	public class ISetAreaTimeBase_UnionUnion
	{
		// Token: 0x1700E010 RID: 57360
		// (get) Token: 0x06035A7B RID: 219771 RVA: 0x00730C41 File Offset: 0x0072EE41
		// (set) Token: 0x06035A7C RID: 219772 RVA: 0x00730C49 File Offset: 0x0072EE49
		public ISetAreaTimeBase_Union Type { get; set; }

		// Token: 0x1700E011 RID: 57361
		// (get) Token: 0x06035A7D RID: 219773 RVA: 0x00730C52 File Offset: 0x0072EE52
		// (set) Token: 0x06035A7E RID: 219774 RVA: 0x00730C5A File Offset: 0x0072EE5A
		public object Value { get; set; }

		// Token: 0x06035A7F RID: 219775 RVA: 0x00730C63 File Offset: 0x0072EE63
		public ISetAreaTimeBase_UnionUnion()
		{
			this.Type = ISetAreaTimeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035A80 RID: 219776 RVA: 0x00730C79 File Offset: 0x0072EE79
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035A81 RID: 219777 RVA: 0x00730C8B File Offset: 0x0072EE8B
		public ISetAreaTimeBaseT AsISetAreaTimeBase()
		{
			return this.As<ISetAreaTimeBaseT>();
		}

		// Token: 0x06035A82 RID: 219778 RVA: 0x00730C93 File Offset: 0x0072EE93
		public static ISetAreaTimeBase_UnionUnion FromISetAreaTimeBase(ISetAreaTimeBaseT _isetareatimebase)
		{
			return new ISetAreaTimeBase_UnionUnion
			{
				Type = ISetAreaTimeBase_Union.ISetAreaTimeBase,
				Value = _isetareatimebase
			};
		}

		// Token: 0x06035A83 RID: 219779 RVA: 0x00730CA8 File Offset: 0x0072EEA8
		public ISetAreaTimeLockT AsISetAreaTimeLock()
		{
			return this.As<ISetAreaTimeLockT>();
		}

		// Token: 0x06035A84 RID: 219780 RVA: 0x00730CB0 File Offset: 0x0072EEB0
		public static ISetAreaTimeBase_UnionUnion FromISetAreaTimeLock(ISetAreaTimeLockT _isetareatimelock)
		{
			return new ISetAreaTimeBase_UnionUnion
			{
				Type = ISetAreaTimeBase_Union.ISetAreaTimeLock,
				Value = _isetareatimelock
			};
		}

		// Token: 0x06035A85 RID: 219781 RVA: 0x00730CC5 File Offset: 0x0072EEC5
		public ISetAreaTimeUnLockT AsISetAreaTimeUnLock()
		{
			return this.As<ISetAreaTimeUnLockT>();
		}

		// Token: 0x06035A86 RID: 219782 RVA: 0x00730CCD File Offset: 0x0072EECD
		public static ISetAreaTimeBase_UnionUnion FromISetAreaTimeUnLock(ISetAreaTimeUnLockT _isetareatimeunlock)
		{
			return new ISetAreaTimeBase_UnionUnion
			{
				Type = ISetAreaTimeBase_Union.ISetAreaTimeUnLock,
				Value = _isetareatimeunlock
			};
		}

		// Token: 0x06035A87 RID: 219783 RVA: 0x00730CE4 File Offset: 0x0072EEE4
		public static int Pack(FlatBufferBuilder builder, ISetAreaTimeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetAreaTimeBase_Union.ISetAreaTimeBase:
				return ISetAreaTimeBase.Pack(builder, _o.AsISetAreaTimeBase()).Value;
			case ISetAreaTimeBase_Union.ISetAreaTimeLock:
				return ISetAreaTimeLock.Pack(builder, _o.AsISetAreaTimeLock()).Value;
			case ISetAreaTimeBase_Union.ISetAreaTimeUnLock:
				return ISetAreaTimeUnLock.Pack(builder, _o.AsISetAreaTimeUnLock()).Value;
			default:
				return 0;
			}
		}
	}
}
