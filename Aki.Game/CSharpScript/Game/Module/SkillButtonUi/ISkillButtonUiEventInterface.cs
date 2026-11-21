using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BAE RID: 15278
	[NullableContext(1)]
	public interface ISkillButtonUiEventInterface
	{
		// Token: 0x0602727E RID: 160382 RVA: 0x00AF4BD9 File Offset: 0x00AF2DD9
		void EquipExplorePhantomSkill()
		{
		}

		// Token: 0x0602727F RID: 160383 RVA: 0x00AF4BDB File Offset: 0x00AF2DDB
		void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
		}

		// Token: 0x06027280 RID: 160384 RVA: 0x00AF4BDD File Offset: 0x00AF2DDD
		void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
		}
	}
}
