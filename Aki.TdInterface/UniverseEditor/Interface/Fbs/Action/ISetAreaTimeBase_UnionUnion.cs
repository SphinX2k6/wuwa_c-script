using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA6 RID: 28582
	public class ISetAreaTimeBase_UnionUnion
	{
		// Token: 0x1700D441 RID: 54337
		// (get) Token: 0x0603282B RID: 206891 RVA: 0x006D1289 File Offset: 0x006CF489
		// (set) Token: 0x0603282C RID: 206892 RVA: 0x006D1291 File Offset: 0x006CF491
		public ISetAreaTimeBase_Union Type { get; set; }

		// Token: 0x1700D442 RID: 54338
		// (get) Token: 0x0603282D RID: 206893 RVA: 0x006D129A File Offset: 0x006CF49A
		// (set) Token: 0x0603282E RID: 206894 RVA: 0x006D12A2 File Offset: 0x006CF4A2
		public object Value { get; set; }

		// Token: 0x0603282F RID: 206895 RVA: 0x006D12AB File Offset: 0x006CF4AB
		public ISetAreaTimeBase_UnionUnion()
		{
			this.Type = ISetAreaTimeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032830 RID: 206896 RVA: 0x006D12C1 File Offset: 0x006CF4C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032831 RID: 206897 RVA: 0x006D12D3 File Offset: 0x006CF4D3
		public ISetAreaTimeBaseT AsISetAreaTimeBase()
		{
			return this.As<ISetAreaTimeBaseT>();
		}

		// Token: 0x06032832 RID: 206898 RVA: 0x006D12DB File Offset: 0x006CF4DB
		public static ISetAreaTimeBase_UnionUnion FromISetAreaTimeBase(ISetAreaTimeBaseT _isetareatimebase)
		{
			return new ISetAreaTimeBase_UnionUnion
			{
				Type = ISetAreaTimeBase_Union.ISetAreaTimeBase,
				Value = _isetareatimebase
			};
		}

		// Token: 0x06032833 RID: 206899 RVA: 0x006D12F0 File Offset: 0x006CF4F0
		public ISetAreaTimeLockT AsISetAreaTimeLock()
		{
			return this.As<ISetAreaTimeLockT>();
		}

		// Token: 0x06032834 RID: 206900 RVA: 0x006D12F8 File Offset: 0x006CF4F8
		public static ISetAreaTimeBase_UnionUnion FromISetAreaTimeLock(ISetAreaTimeLockT _isetareatimelock)
		{
			return new ISetAreaTimeBase_UnionUnion
			{
				Type = ISetAreaTimeBase_Union.ISetAreaTimeLock,
				Value = _isetareatimelock
			};
		}

		// Token: 0x06032835 RID: 206901 RVA: 0x006D130D File Offset: 0x006CF50D
		public ISetAreaTimeUnLockT AsISetAreaTimeUnLock()
		{
			return this.As<ISetAreaTimeUnLockT>();
		}

		// Token: 0x06032836 RID: 206902 RVA: 0x006D1315 File Offset: 0x006CF515
		public static ISetAreaTimeBase_UnionUnion FromISetAreaTimeUnLock(ISetAreaTimeUnLockT _isetareatimeunlock)
		{
			return new ISetAreaTimeBase_UnionUnion
			{
				Type = ISetAreaTimeBase_Union.ISetAreaTimeUnLock,
				Value = _isetareatimeunlock
			};
		}

		// Token: 0x06032837 RID: 206903 RVA: 0x006D132C File Offset: 0x006CF52C
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
