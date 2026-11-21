using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADA RID: 27354
	public class ICommonBtOverrideTaskInfoBase_UnionUnion
	{
		// Token: 0x1700C8D8 RID: 51416
		// (get) Token: 0x0602EFE2 RID: 192482 RVA: 0x00668BC5 File Offset: 0x00666DC5
		// (set) Token: 0x0602EFE3 RID: 192483 RVA: 0x00668BCD File Offset: 0x00666DCD
		public ICommonBtOverrideTaskInfoBase_Union Type { get; set; }

		// Token: 0x1700C8D9 RID: 51417
		// (get) Token: 0x0602EFE4 RID: 192484 RVA: 0x00668BD6 File Offset: 0x00666DD6
		// (set) Token: 0x0602EFE5 RID: 192485 RVA: 0x00668BDE File Offset: 0x00666DDE
		public object Value { get; set; }

		// Token: 0x0602EFE6 RID: 192486 RVA: 0x00668BE7 File Offset: 0x00666DE7
		public ICommonBtOverrideTaskInfoBase_UnionUnion()
		{
			this.Type = ICommonBtOverrideTaskInfoBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EFE7 RID: 192487 RVA: 0x00668BFD File Offset: 0x00666DFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EFE8 RID: 192488 RVA: 0x00668C0F File Offset: 0x00666E0F
		public ICommonBtOverrideTaskInfoBaseT AsICommonBtOverrideTaskInfoBase()
		{
			return this.As<ICommonBtOverrideTaskInfoBaseT>();
		}

		// Token: 0x0602EFE9 RID: 192489 RVA: 0x00668C17 File Offset: 0x00666E17
		public static ICommonBtOverrideTaskInfoBase_UnionUnion FromICommonBtOverrideTaskInfoBase(ICommonBtOverrideTaskInfoBaseT _icommonbtoverridetaskinfobase)
		{
			return new ICommonBtOverrideTaskInfoBase_UnionUnion
			{
				Type = ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideTaskInfoBase,
				Value = _icommonbtoverridetaskinfobase
			};
		}

		// Token: 0x0602EFEA RID: 192490 RVA: 0x00668C2C File Offset: 0x00666E2C
		public ICommonBtOverrideActionInfoT AsICommonBtOverrideActionInfo()
		{
			return this.As<ICommonBtOverrideActionInfoT>();
		}

		// Token: 0x0602EFEB RID: 192491 RVA: 0x00668C34 File Offset: 0x00666E34
		public static ICommonBtOverrideTaskInfoBase_UnionUnion FromICommonBtOverrideActionInfo(ICommonBtOverrideActionInfoT _icommonbtoverrideactioninfo)
		{
			return new ICommonBtOverrideTaskInfoBase_UnionUnion
			{
				Type = ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideActionInfo,
				Value = _icommonbtoverrideactioninfo
			};
		}

		// Token: 0x0602EFEC RID: 192492 RVA: 0x00668C49 File Offset: 0x00666E49
		public ICommonBtOverrideConditionInfoT AsICommonBtOverrideConditionInfo()
		{
			return this.As<ICommonBtOverrideConditionInfoT>();
		}

		// Token: 0x0602EFED RID: 192493 RVA: 0x00668C51 File Offset: 0x00666E51
		public static ICommonBtOverrideTaskInfoBase_UnionUnion FromICommonBtOverrideConditionInfo(ICommonBtOverrideConditionInfoT _icommonbtoverrideconditioninfo)
		{
			return new ICommonBtOverrideTaskInfoBase_UnionUnion
			{
				Type = ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideConditionInfo,
				Value = _icommonbtoverrideconditioninfo
			};
		}

		// Token: 0x0602EFEE RID: 192494 RVA: 0x00668C68 File Offset: 0x00666E68
		public static int Pack(FlatBufferBuilder builder, ICommonBtOverrideTaskInfoBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideTaskInfoBase:
				return ICommonBtOverrideTaskInfoBase.Pack(builder, _o.AsICommonBtOverrideTaskInfoBase()).Value;
			case ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideActionInfo:
				return ICommonBtOverrideActionInfo.Pack(builder, _o.AsICommonBtOverrideActionInfo()).Value;
			case ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideConditionInfo:
				return ICommonBtOverrideConditionInfo.Pack(builder, _o.AsICommonBtOverrideConditionInfo()).Value;
			default:
				return 0;
			}
		}
	}
}
