using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200623B RID: 25147
	public class TExploreSkillSearchTargetCfgUnion
	{
		// Token: 0x1700BB3E RID: 47934
		// (get) Token: 0x0602AD07 RID: 175367 RVA: 0x005D8DA1 File Offset: 0x005D6FA1
		// (set) Token: 0x0602AD08 RID: 175368 RVA: 0x005D8DA9 File Offset: 0x005D6FA9
		public TExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x1700BB3F RID: 47935
		// (get) Token: 0x0602AD09 RID: 175369 RVA: 0x005D8DB2 File Offset: 0x005D6FB2
		// (set) Token: 0x0602AD0A RID: 175370 RVA: 0x005D8DBA File Offset: 0x005D6FBA
		public object Value { get; set; }

		// Token: 0x0602AD0B RID: 175371 RVA: 0x005D8DC3 File Offset: 0x005D6FC3
		public TExploreSkillSearchTargetCfgUnion()
		{
			this.Type = TExploreSkillSearchTargetCfg.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD0C RID: 175372 RVA: 0x005D8DD9 File Offset: 0x005D6FD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD0D RID: 175373 RVA: 0x005D8DEB File Offset: 0x005D6FEB
		public IAngleWeightT AsIAngleWeight()
		{
			return this.As<IAngleWeightT>();
		}

		// Token: 0x0602AD0E RID: 175374 RVA: 0x005D8DF3 File Offset: 0x005D6FF3
		public static TExploreSkillSearchTargetCfgUnion FromIAngleWeight(IAngleWeightT _iangleweight)
		{
			return new TExploreSkillSearchTargetCfgUnion
			{
				Type = TExploreSkillSearchTargetCfg.IAngleWeight,
				Value = _iangleweight
			};
		}

		// Token: 0x0602AD0F RID: 175375 RVA: 0x005D8E08 File Offset: 0x005D7008
		public IEnterScreenWeightT AsIEnterScreenWeight()
		{
			return this.As<IEnterScreenWeightT>();
		}

		// Token: 0x0602AD10 RID: 175376 RVA: 0x005D8E10 File Offset: 0x005D7010
		public static TExploreSkillSearchTargetCfgUnion FromIEnterScreenWeight(IEnterScreenWeightT _ienterscreenweight)
		{
			return new TExploreSkillSearchTargetCfgUnion
			{
				Type = TExploreSkillSearchTargetCfg.IEnterScreenWeight,
				Value = _ienterscreenweight
			};
		}

		// Token: 0x0602AD11 RID: 175377 RVA: 0x005D8E28 File Offset: 0x005D7028
		public static int Pack(FlatBufferBuilder builder, TExploreSkillSearchTargetCfgUnion _o)
		{
			TExploreSkillSearchTargetCfg type = _o.Type;
			if (type == TExploreSkillSearchTargetCfg.IAngleWeight)
			{
				return IAngleWeight.Pack(builder, _o.AsIAngleWeight()).Value;
			}
			if (type != TExploreSkillSearchTargetCfg.IEnterScreenWeight)
			{
				return 0;
			}
			return IEnterScreenWeight.Pack(builder, _o.AsIEnterScreenWeight()).Value;
		}
	}
}
