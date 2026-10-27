using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02006502 RID: 25858
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AllureBigSkill : ISkill
	{
		// Token: 0x06040E85 RID: 265861 RVA: 0x00FBB210 File Offset: 0x00FB9410
		public AllureBigSkill(MatchThreeSkill cfg)
		{
		}

		// Token: 0x1700950A RID: 38154
		// (get) Token: 0x06040E86 RID: 265862 RVA: 0x00FBB27F File Offset: 0x00FB947F
		public int Id { get; } = cfg.Id;

		// Token: 0x1700950B RID: 38155
		// (get) Token: 0x06040E87 RID: 265863 RVA: 0x00FBB287 File Offset: 0x00FB9487
		public int EnergyNode { get; } = cfg.Energy;

		// Token: 0x1700950C RID: 38156
		// (get) Token: 0x06040E88 RID: 265864 RVA: 0x00FBB28F File Offset: 0x00FB948F
		public string Icon { get; } = cfg.Icon;

		// Token: 0x1700950D RID: 38157
		// (get) Token: 0x06040E89 RID: 265865 RVA: 0x00FBB297 File Offset: 0x00FB9497
		public string Name { get; } = cfg.Name;

		// Token: 0x1700950E RID: 38158
		// (get) Token: 0x06040E8A RID: 265866 RVA: 0x00FBB29F File Offset: 0x00FB949F
		public ESkillCastEffect CastEffect
		{
			get
			{
				return ESkillCastEffect.Allure;
			}
		}

		// Token: 0x06040E8B RID: 265867 RVA: 0x00FBB2A2 File Offset: 0x00FB94A2
		[NullableContext(1)]
		public void Release(ISkillContext ctx)
		{
			ctx.ApplyAllureUltimateRecolor(this.Id, this.SourceRanks, this.TargetRank);
		}

		// Token: 0x04021D61 RID: 138593
		[Nullable(1)]
		private readonly int[] SourceRanks = cfg.GetParamsArray();

		// Token: 0x04021D62 RID: 138594
		private readonly int TargetRank = (cfg.ExtraParamsLength > 0) ? cfg.ExtraParams(0) : 0;
	}
}
