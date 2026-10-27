using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1C RID: 23580
	public class TExploreSkillSearchTargetCfgUnion
	{
		// Token: 0x1700B1F0 RID: 45552
		// (get) Token: 0x06028715 RID: 165653 RVA: 0x00590E14 File Offset: 0x0058F014
		// (set) Token: 0x06028716 RID: 165654 RVA: 0x00590E1C File Offset: 0x0058F01C
		public TExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x1700B1F1 RID: 45553
		// (get) Token: 0x06028717 RID: 165655 RVA: 0x00590E25 File Offset: 0x0058F025
		// (set) Token: 0x06028718 RID: 165656 RVA: 0x00590E2D File Offset: 0x0058F02D
		public object Value { get; set; }

		// Token: 0x06028719 RID: 165657 RVA: 0x00590E36 File Offset: 0x0058F036
		public TExploreSkillSearchTargetCfgUnion()
		{
			this.Type = TExploreSkillSearchTargetCfg.NONE;
			this.Value = null;
		}

		// Token: 0x0602871A RID: 165658 RVA: 0x00590E4C File Offset: 0x0058F04C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602871B RID: 165659 RVA: 0x00590E5E File Offset: 0x0058F05E
		public IAngleWeightT AsIAngleWeight()
		{
			return this.As<IAngleWeightT>();
		}

		// Token: 0x0602871C RID: 165660 RVA: 0x00590E66 File Offset: 0x0058F066
		public static TExploreSkillSearchTargetCfgUnion FromIAngleWeight(IAngleWeightT _iangleweight)
		{
			return new TExploreSkillSearchTargetCfgUnion
			{
				Type = TExploreSkillSearchTargetCfg.IAngleWeight,
				Value = _iangleweight
			};
		}

		// Token: 0x0602871D RID: 165661 RVA: 0x00590E7B File Offset: 0x0058F07B
		public IEnterScreenWeightT AsIEnterScreenWeight()
		{
			return this.As<IEnterScreenWeightT>();
		}

		// Token: 0x0602871E RID: 165662 RVA: 0x00590E83 File Offset: 0x0058F083
		public static TExploreSkillSearchTargetCfgUnion FromIEnterScreenWeight(IEnterScreenWeightT _ienterscreenweight)
		{
			return new TExploreSkillSearchTargetCfgUnion
			{
				Type = TExploreSkillSearchTargetCfg.IEnterScreenWeight,
				Value = _ienterscreenweight
			};
		}

		// Token: 0x0602871F RID: 165663 RVA: 0x00590E98 File Offset: 0x0058F098
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
