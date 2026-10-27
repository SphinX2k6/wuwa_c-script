using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02006503 RID: 25859
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AllureSmallSkill : ISkill
	{
		// Token: 0x06040E8C RID: 265868 RVA: 0x00FBB2BC File Offset: 0x00FB94BC
		public AllureSmallSkill(MatchThreeSkill cfg)
		{
		}

		// Token: 0x1700950F RID: 38159
		// (get) Token: 0x06040E8D RID: 265869 RVA: 0x00FBB2F8 File Offset: 0x00FB94F8
		public int Id { get; } = cfg.Id;

		// Token: 0x17009510 RID: 38160
		// (get) Token: 0x06040E8E RID: 265870 RVA: 0x00FBB300 File Offset: 0x00FB9500
		public int EnergyNode { get; } = cfg.Energy;

		// Token: 0x17009511 RID: 38161
		// (get) Token: 0x06040E8F RID: 265871 RVA: 0x00FBB308 File Offset: 0x00FB9508
		public string Icon { get; } = cfg.Icon;

		// Token: 0x17009512 RID: 38162
		// (get) Token: 0x06040E90 RID: 265872 RVA: 0x00FBB310 File Offset: 0x00FB9510
		public string Name { get; } = cfg.Name;

		// Token: 0x17009513 RID: 38163
		// (get) Token: 0x06040E91 RID: 265873 RVA: 0x00FBB318 File Offset: 0x00FB9518
		public ESkillCastEffect CastEffect
		{
			get
			{
				return ESkillCastEffect.Allure;
			}
		}

		// Token: 0x06040E92 RID: 265874 RVA: 0x00FBB31B File Offset: 0x00FB951B
		[NullableContext(1)]
		public void Release(ISkillContext ctx)
		{
			ctx.ApplyAllureSmallRecolor(this.Id);
		}
	}
}
