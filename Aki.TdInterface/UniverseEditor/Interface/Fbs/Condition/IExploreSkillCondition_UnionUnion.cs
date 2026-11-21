using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005113 RID: 20755
	public class IExploreSkillCondition_UnionUnion
	{
		// Token: 0x170094BA RID: 38074
		// (get) Token: 0x060209FD RID: 133629 RVA: 0x00485DA5 File Offset: 0x00483FA5
		// (set) Token: 0x060209FE RID: 133630 RVA: 0x00485DAD File Offset: 0x00483FAD
		public IExploreSkillCondition_Union Type { get; set; }

		// Token: 0x170094BB RID: 38075
		// (get) Token: 0x060209FF RID: 133631 RVA: 0x00485DB6 File Offset: 0x00483FB6
		// (set) Token: 0x06020A00 RID: 133632 RVA: 0x00485DBE File Offset: 0x00483FBE
		public object Value { get; set; }

		// Token: 0x06020A01 RID: 133633 RVA: 0x00485DC7 File Offset: 0x00483FC7
		public IExploreSkillCondition_UnionUnion()
		{
			this.Type = IExploreSkillCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020A02 RID: 133634 RVA: 0x00485DDD File Offset: 0x00483FDD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020A03 RID: 133635 RVA: 0x00485DEF File Offset: 0x00483FEF
		public IExploreSkillConditionT AsIExploreSkillCondition()
		{
			return this.As<IExploreSkillConditionT>();
		}

		// Token: 0x06020A04 RID: 133636 RVA: 0x00485DF7 File Offset: 0x00483FF7
		public static IExploreSkillCondition_UnionUnion FromIExploreSkillCondition(IExploreSkillConditionT _iexploreskillcondition)
		{
			return new IExploreSkillCondition_UnionUnion
			{
				Type = IExploreSkillCondition_Union.IExploreSkillCondition,
				Value = _iexploreskillcondition
			};
		}

		// Token: 0x06020A05 RID: 133637 RVA: 0x00485E0C File Offset: 0x0048400C
		public ICheckPlayerAirBubbleEnabledT AsICheckPlayerAirBubbleEnabled()
		{
			return this.As<ICheckPlayerAirBubbleEnabledT>();
		}

		// Token: 0x06020A06 RID: 133638 RVA: 0x00485E14 File Offset: 0x00484014
		public static IExploreSkillCondition_UnionUnion FromICheckPlayerAirBubbleEnabled(ICheckPlayerAirBubbleEnabledT _icheckplayerairbubbleenabled)
		{
			return new IExploreSkillCondition_UnionUnion
			{
				Type = IExploreSkillCondition_Union.ICheckPlayerAirBubbleEnabled,
				Value = _icheckplayerairbubbleenabled
			};
		}

		// Token: 0x06020A07 RID: 133639 RVA: 0x00485E2C File Offset: 0x0048402C
		public static int Pack(FlatBufferBuilder builder, IExploreSkillCondition_UnionUnion _o)
		{
			IExploreSkillCondition_Union type = _o.Type;
			if (type == IExploreSkillCondition_Union.IExploreSkillCondition)
			{
				return IExploreSkillCondition.Pack(builder, _o.AsIExploreSkillCondition()).Value;
			}
			if (type != IExploreSkillCondition_Union.ICheckPlayerAirBubbleEnabled)
			{
				return 0;
			}
			return ICheckPlayerAirBubbleEnabled.Pack(builder, _o.AsICheckPlayerAirBubbleEnabled()).Value;
		}
	}
}
