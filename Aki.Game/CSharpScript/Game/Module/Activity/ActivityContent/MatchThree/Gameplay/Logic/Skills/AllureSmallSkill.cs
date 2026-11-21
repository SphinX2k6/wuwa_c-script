using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02005481 RID: 21633
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AllureSmallSkill : ISkill
	{
		// Token: 0x06035B50 RID: 219984 RVA: 0x00F022EC File Offset: 0x00F004EC
		public AllureSmallSkill(MatchThreeSkill cfg)
		{
		}

		// Token: 0x17006871 RID: 26737
		// (get) Token: 0x06035B51 RID: 219985 RVA: 0x00F02328 File Offset: 0x00F00528
		public int Id { get; } = cfg.Id;

		// Token: 0x17006872 RID: 26738
		// (get) Token: 0x06035B52 RID: 219986 RVA: 0x00F02330 File Offset: 0x00F00530
		public int EnergyNode { get; } = cfg.Energy;

		// Token: 0x17006873 RID: 26739
		// (get) Token: 0x06035B53 RID: 219987 RVA: 0x00F02338 File Offset: 0x00F00538
		public string Icon { get; } = cfg.Icon;

		// Token: 0x17006874 RID: 26740
		// (get) Token: 0x06035B54 RID: 219988 RVA: 0x00F02340 File Offset: 0x00F00540
		public string Name { get; } = cfg.Name;

		// Token: 0x17006875 RID: 26741
		// (get) Token: 0x06035B55 RID: 219989 RVA: 0x00F02348 File Offset: 0x00F00548
		public ESkillCastEffect CastEffect
		{
			get
			{
				return ESkillCastEffect.Allure;
			}
		}

		// Token: 0x06035B56 RID: 219990 RVA: 0x00F0234B File Offset: 0x00F0054B
		[NullableContext(1)]
		public void Release(ISkillContext ctx)
		{
			ctx.ApplyAllureSmallRecolor(this.Id);
		}
	}
}
