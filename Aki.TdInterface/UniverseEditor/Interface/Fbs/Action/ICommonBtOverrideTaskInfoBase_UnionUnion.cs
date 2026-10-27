using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006472 RID: 25714
	public class ICommonBtOverrideTaskInfoBase_UnionUnion
	{
		// Token: 0x1700BF56 RID: 48982
		// (get) Token: 0x0602C891 RID: 182417 RVA: 0x0061D5B9 File Offset: 0x0061B7B9
		// (set) Token: 0x0602C892 RID: 182418 RVA: 0x0061D5C1 File Offset: 0x0061B7C1
		public ICommonBtOverrideTaskInfoBase_Union Type { get; set; }

		// Token: 0x1700BF57 RID: 48983
		// (get) Token: 0x0602C893 RID: 182419 RVA: 0x0061D5CA File Offset: 0x0061B7CA
		// (set) Token: 0x0602C894 RID: 182420 RVA: 0x0061D5D2 File Offset: 0x0061B7D2
		public object Value { get; set; }

		// Token: 0x0602C895 RID: 182421 RVA: 0x0061D5DB File Offset: 0x0061B7DB
		public ICommonBtOverrideTaskInfoBase_UnionUnion()
		{
			this.Type = ICommonBtOverrideTaskInfoBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C896 RID: 182422 RVA: 0x0061D5F1 File Offset: 0x0061B7F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C897 RID: 182423 RVA: 0x0061D603 File Offset: 0x0061B803
		public ICommonBtOverrideTaskInfoBaseT AsICommonBtOverrideTaskInfoBase()
		{
			return this.As<ICommonBtOverrideTaskInfoBaseT>();
		}

		// Token: 0x0602C898 RID: 182424 RVA: 0x0061D60B File Offset: 0x0061B80B
		public static ICommonBtOverrideTaskInfoBase_UnionUnion FromICommonBtOverrideTaskInfoBase(ICommonBtOverrideTaskInfoBaseT _icommonbtoverridetaskinfobase)
		{
			return new ICommonBtOverrideTaskInfoBase_UnionUnion
			{
				Type = ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideTaskInfoBase,
				Value = _icommonbtoverridetaskinfobase
			};
		}

		// Token: 0x0602C899 RID: 182425 RVA: 0x0061D620 File Offset: 0x0061B820
		public ICommonBtOverrideActionInfoT AsICommonBtOverrideActionInfo()
		{
			return this.As<ICommonBtOverrideActionInfoT>();
		}

		// Token: 0x0602C89A RID: 182426 RVA: 0x0061D628 File Offset: 0x0061B828
		public static ICommonBtOverrideTaskInfoBase_UnionUnion FromICommonBtOverrideActionInfo(ICommonBtOverrideActionInfoT _icommonbtoverrideactioninfo)
		{
			return new ICommonBtOverrideTaskInfoBase_UnionUnion
			{
				Type = ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideActionInfo,
				Value = _icommonbtoverrideactioninfo
			};
		}

		// Token: 0x0602C89B RID: 182427 RVA: 0x0061D63D File Offset: 0x0061B83D
		public ICommonBtOverrideConditionInfoT AsICommonBtOverrideConditionInfo()
		{
			return this.As<ICommonBtOverrideConditionInfoT>();
		}

		// Token: 0x0602C89C RID: 182428 RVA: 0x0061D645 File Offset: 0x0061B845
		public static ICommonBtOverrideTaskInfoBase_UnionUnion FromICommonBtOverrideConditionInfo(ICommonBtOverrideConditionInfoT _icommonbtoverrideconditioninfo)
		{
			return new ICommonBtOverrideTaskInfoBase_UnionUnion
			{
				Type = ICommonBtOverrideTaskInfoBase_Union.ICommonBtOverrideConditionInfo,
				Value = _icommonbtoverrideconditioninfo
			};
		}

		// Token: 0x0602C89D RID: 182429 RVA: 0x0061D65C File Offset: 0x0061B85C
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
