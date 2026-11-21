using System;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD8 RID: 15320
	public class SkillButtonCustomHandleExploreAsFight : SkillButtonCustomHandleBase
	{
		// Token: 0x060274DF RID: 160991 RVA: 0x00B06504 File Offset: 0x00B04704
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			foreach (int item in this.TagIds)
			{
				this.SkillButtonData.ExploreAsFightTagIds.Add(item);
			}
		}
	}
}
