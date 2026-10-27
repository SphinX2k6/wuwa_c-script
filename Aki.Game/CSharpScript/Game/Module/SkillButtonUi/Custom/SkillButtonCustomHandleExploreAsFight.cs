using System;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C27 RID: 19495
	public class SkillButtonCustomHandleExploreAsFight : SkillButtonCustomHandleBase
	{
		// Token: 0x0603272C RID: 206636 RVA: 0x00BC18EC File Offset: 0x00BBFAEC
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
