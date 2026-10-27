using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200460F RID: 17935
	public class TLevelPlayRewardUnion
	{
		// Token: 0x17007F69 RID: 32617
		// (get) Token: 0x0601B2B5 RID: 111285 RVA: 0x003DED38 File Offset: 0x003DCF38
		// (set) Token: 0x0601B2B6 RID: 111286 RVA: 0x003DED40 File Offset: 0x003DCF40
		public TLevelPlayReward Type { get; set; }

		// Token: 0x17007F6A RID: 32618
		// (get) Token: 0x0601B2B7 RID: 111287 RVA: 0x003DED49 File Offset: 0x003DCF49
		// (set) Token: 0x0601B2B8 RID: 111288 RVA: 0x003DED51 File Offset: 0x003DCF51
		public object Value { get; set; }

		// Token: 0x0601B2B9 RID: 111289 RVA: 0x003DED5A File Offset: 0x003DCF5A
		public TLevelPlayRewardUnion()
		{
			this.Type = TLevelPlayReward.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2BA RID: 111290 RVA: 0x003DED70 File Offset: 0x003DCF70
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2BB RID: 111291 RVA: 0x003DED82 File Offset: 0x003DCF82
		public IAutomaticRewardParamT AsIAutomaticRewardParam()
		{
			return this.As<IAutomaticRewardParamT>();
		}

		// Token: 0x0601B2BC RID: 111292 RVA: 0x003DED8A File Offset: 0x003DCF8A
		public static TLevelPlayRewardUnion FromIAutomaticRewardParam(IAutomaticRewardParamT _iautomaticrewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.IAutomaticRewardParam,
				Value = _iautomaticrewardparam
			};
		}

		// Token: 0x0601B2BD RID: 111293 RVA: 0x003DED9F File Offset: 0x003DCF9F
		public IInteractRewardParamT AsIInteractRewardParam()
		{
			return this.As<IInteractRewardParamT>();
		}

		// Token: 0x0601B2BE RID: 111294 RVA: 0x003DEDA7 File Offset: 0x003DCFA7
		public static TLevelPlayRewardUnion FromIInteractRewardParam(IInteractRewardParamT _iinteractrewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.IInteractRewardParam,
				Value = _iinteractrewardparam
			};
		}

		// Token: 0x0601B2BF RID: 111295 RVA: 0x003DEDBC File Offset: 0x003DCFBC
		public INoneRewardParamT AsINoneRewardParam()
		{
			return this.As<INoneRewardParamT>();
		}

		// Token: 0x0601B2C0 RID: 111296 RVA: 0x003DEDC4 File Offset: 0x003DCFC4
		public static TLevelPlayRewardUnion FromINoneRewardParam(INoneRewardParamT _inonerewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.INoneRewardParam,
				Value = _inonerewardparam
			};
		}

		// Token: 0x0601B2C1 RID: 111297 RVA: 0x003DEDD9 File Offset: 0x003DCFD9
		public IVariableRewardParamT AsIVariableRewardParam()
		{
			return this.As<IVariableRewardParamT>();
		}

		// Token: 0x0601B2C2 RID: 111298 RVA: 0x003DEDE1 File Offset: 0x003DCFE1
		public static TLevelPlayRewardUnion FromIVariableRewardParam(IVariableRewardParamT _ivariablerewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.IVariableRewardParam,
				Value = _ivariablerewardparam
			};
		}

		// Token: 0x0601B2C3 RID: 111299 RVA: 0x003DEDF8 File Offset: 0x003DCFF8
		public static int Pack(FlatBufferBuilder builder, TLevelPlayRewardUnion _o)
		{
			switch (_o.Type)
			{
			case TLevelPlayReward.IAutomaticRewardParam:
				return IAutomaticRewardParam.Pack(builder, _o.AsIAutomaticRewardParam()).Value;
			case TLevelPlayReward.IInteractRewardParam:
				return IInteractRewardParam.Pack(builder, _o.AsIInteractRewardParam()).Value;
			case TLevelPlayReward.INoneRewardParam:
				return INoneRewardParam.Pack(builder, _o.AsINoneRewardParam()).Value;
			case TLevelPlayReward.IVariableRewardParam:
				return IVariableRewardParam.Pack(builder, _o.AsIVariableRewardParam()).Value;
			default:
				return 0;
			}
		}
	}
}
