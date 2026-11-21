using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02005480 RID: 21632
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AllureBigSkill : ISkill
	{
		// Token: 0x06035B49 RID: 219977 RVA: 0x00F02240 File Offset: 0x00F00440
		public AllureBigSkill(MatchThreeSkill cfg)
		{
		}

		// Token: 0x1700686C RID: 26732
		// (get) Token: 0x06035B4A RID: 219978 RVA: 0x00F022AF File Offset: 0x00F004AF
		public int Id { get; } = cfg.Id;

		// Token: 0x1700686D RID: 26733
		// (get) Token: 0x06035B4B RID: 219979 RVA: 0x00F022B7 File Offset: 0x00F004B7
		public int EnergyNode { get; } = cfg.Energy;

		// Token: 0x1700686E RID: 26734
		// (get) Token: 0x06035B4C RID: 219980 RVA: 0x00F022BF File Offset: 0x00F004BF
		public string Icon { get; } = cfg.Icon;

		// Token: 0x1700686F RID: 26735
		// (get) Token: 0x06035B4D RID: 219981 RVA: 0x00F022C7 File Offset: 0x00F004C7
		public string Name { get; } = cfg.Name;

		// Token: 0x17006870 RID: 26736
		// (get) Token: 0x06035B4E RID: 219982 RVA: 0x00F022CF File Offset: 0x00F004CF
		public ESkillCastEffect CastEffect
		{
			get
			{
				return ESkillCastEffect.Allure;
			}
		}

		// Token: 0x06035B4F RID: 219983 RVA: 0x00F022D2 File Offset: 0x00F004D2
		[NullableContext(1)]
		public void Release(ISkillContext ctx)
		{
			ctx.ApplyAllureUltimateRecolor(this.Id, this.SourceRanks, this.TargetRank);
		}

		// Token: 0x0401C692 RID: 116370
		[Nullable(1)]
		private readonly int[] SourceRanks = cfg.GetParamsArray();

		// Token: 0x0401C693 RID: 116371
		private readonly int TargetRank = (cfg.ExtraParamsLength > 0) ? cfg.ExtraParams(0) : 0;
	}
}
