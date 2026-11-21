using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A77 RID: 19063
	public class TLevelPlayRewardUnion
	{
		// Token: 0x170085AA RID: 34218
		// (get) Token: 0x0601CA8A RID: 117386 RVA: 0x0040AFD4 File Offset: 0x004091D4
		// (set) Token: 0x0601CA8B RID: 117387 RVA: 0x0040AFDC File Offset: 0x004091DC
		public TLevelPlayReward Type { get; set; }

		// Token: 0x170085AB RID: 34219
		// (get) Token: 0x0601CA8C RID: 117388 RVA: 0x0040AFE5 File Offset: 0x004091E5
		// (set) Token: 0x0601CA8D RID: 117389 RVA: 0x0040AFED File Offset: 0x004091ED
		public object Value { get; set; }

		// Token: 0x0601CA8E RID: 117390 RVA: 0x0040AFF6 File Offset: 0x004091F6
		public TLevelPlayRewardUnion()
		{
			this.Type = TLevelPlayReward.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA8F RID: 117391 RVA: 0x0040B00C File Offset: 0x0040920C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA90 RID: 117392 RVA: 0x0040B01E File Offset: 0x0040921E
		public IAutomaticRewardParamT AsIAutomaticRewardParam()
		{
			return this.As<IAutomaticRewardParamT>();
		}

		// Token: 0x0601CA91 RID: 117393 RVA: 0x0040B026 File Offset: 0x00409226
		public static TLevelPlayRewardUnion FromIAutomaticRewardParam(IAutomaticRewardParamT _iautomaticrewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.IAutomaticRewardParam,
				Value = _iautomaticrewardparam
			};
		}

		// Token: 0x0601CA92 RID: 117394 RVA: 0x0040B03B File Offset: 0x0040923B
		public IInteractRewardParamT AsIInteractRewardParam()
		{
			return this.As<IInteractRewardParamT>();
		}

		// Token: 0x0601CA93 RID: 117395 RVA: 0x0040B043 File Offset: 0x00409243
		public static TLevelPlayRewardUnion FromIInteractRewardParam(IInteractRewardParamT _iinteractrewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.IInteractRewardParam,
				Value = _iinteractrewardparam
			};
		}

		// Token: 0x0601CA94 RID: 117396 RVA: 0x0040B058 File Offset: 0x00409258
		public INoneRewardParamT AsINoneRewardParam()
		{
			return this.As<INoneRewardParamT>();
		}

		// Token: 0x0601CA95 RID: 117397 RVA: 0x0040B060 File Offset: 0x00409260
		public static TLevelPlayRewardUnion FromINoneRewardParam(INoneRewardParamT _inonerewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.INoneRewardParam,
				Value = _inonerewardparam
			};
		}

		// Token: 0x0601CA96 RID: 117398 RVA: 0x0040B075 File Offset: 0x00409275
		public IVariableRewardParamT AsIVariableRewardParam()
		{
			return this.As<IVariableRewardParamT>();
		}

		// Token: 0x0601CA97 RID: 117399 RVA: 0x0040B07D File Offset: 0x0040927D
		public static TLevelPlayRewardUnion FromIVariableRewardParam(IVariableRewardParamT _ivariablerewardparam)
		{
			return new TLevelPlayRewardUnion
			{
				Type = TLevelPlayReward.IVariableRewardParam,
				Value = _ivariablerewardparam
			};
		}

		// Token: 0x0601CA98 RID: 117400 RVA: 0x0040B094 File Offset: 0x00409294
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
