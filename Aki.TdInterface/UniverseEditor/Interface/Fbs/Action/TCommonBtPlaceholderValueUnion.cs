using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E98 RID: 32408
	public class TCommonBtPlaceholderValueUnion
	{
		// Token: 0x1700F22D RID: 61997
		// (get) Token: 0x0603A805 RID: 239621 RVA: 0x007DFAF8 File Offset: 0x007DDCF8
		// (set) Token: 0x0603A806 RID: 239622 RVA: 0x007DFB00 File Offset: 0x007DDD00
		public TCommonBtPlaceholderValue Type { get; set; }

		// Token: 0x1700F22E RID: 61998
		// (get) Token: 0x0603A807 RID: 239623 RVA: 0x007DFB09 File Offset: 0x007DDD09
		// (set) Token: 0x0603A808 RID: 239624 RVA: 0x007DFB11 File Offset: 0x007DDD11
		public object Value { get; set; }

		// Token: 0x0603A809 RID: 239625 RVA: 0x007DFB1A File Offset: 0x007DDD1A
		public TCommonBtPlaceholderValueUnion()
		{
			this.Type = TCommonBtPlaceholderValue.NONE;
			this.Value = null;
		}

		// Token: 0x0603A80A RID: 239626 RVA: 0x007DFB30 File Offset: 0x007DDD30
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A80B RID: 239627 RVA: 0x007DFB42 File Offset: 0x007DDD42
		public ICommonBtOverrideActionInfoT AsICommonBtOverrideActionInfo()
		{
			return this.As<ICommonBtOverrideActionInfoT>();
		}

		// Token: 0x0603A80C RID: 239628 RVA: 0x007DFB4A File Offset: 0x007DDD4A
		public static TCommonBtPlaceholderValueUnion FromICommonBtOverrideActionInfo(ICommonBtOverrideActionInfoT _icommonbtoverrideactioninfo)
		{
			return new TCommonBtPlaceholderValueUnion
			{
				Type = TCommonBtPlaceholderValue.ICommonBtOverrideActionInfo,
				Value = _icommonbtoverrideactioninfo
			};
		}

		// Token: 0x0603A80D RID: 239629 RVA: 0x007DFB5F File Offset: 0x007DDD5F
		public ICommonBtOverrideConditionInfoT AsICommonBtOverrideConditionInfo()
		{
			return this.As<ICommonBtOverrideConditionInfoT>();
		}

		// Token: 0x0603A80E RID: 239630 RVA: 0x007DFB67 File Offset: 0x007DDD67
		public static TCommonBtPlaceholderValueUnion FromICommonBtOverrideConditionInfo(ICommonBtOverrideConditionInfoT _icommonbtoverrideconditioninfo)
		{
			return new TCommonBtPlaceholderValueUnion
			{
				Type = TCommonBtPlaceholderValue.ICommonBtOverrideConditionInfo,
				Value = _icommonbtoverrideconditioninfo
			};
		}

		// Token: 0x0603A80F RID: 239631 RVA: 0x007DFB7C File Offset: 0x007DDD7C
		public static int Pack(FlatBufferBuilder builder, TCommonBtPlaceholderValueUnion _o)
		{
			TCommonBtPlaceholderValue type = _o.Type;
			if (type == TCommonBtPlaceholderValue.ICommonBtOverrideActionInfo)
			{
				return ICommonBtOverrideActionInfo.Pack(builder, _o.AsICommonBtOverrideActionInfo()).Value;
			}
			if (type != TCommonBtPlaceholderValue.ICommonBtOverrideConditionInfo)
			{
				return 0;
			}
			return ICommonBtOverrideConditionInfo.Pack(builder, _o.AsICommonBtOverrideConditionInfo()).Value;
		}
	}
}
