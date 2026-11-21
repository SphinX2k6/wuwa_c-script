using System;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD2 RID: 15314
	public class SkillButtonCustomHandleZanNiUltimate : SkillButtonCustomHandleBase
	{
		// Token: 0x060274CA RID: 160970 RVA: 0x00B05E03 File Offset: 0x00B04003
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.HideCoolDownTextCustom = true;
		}

		// Token: 0x060274CB RID: 160971 RVA: 0x00B05E1C File Offset: 0x00B0401C
		public override void Refresh()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.TagIds.Count < 1 || this.BuffIds.Count < 1)
			{
				return;
			}
			BaseTagComponent gameplayTagComponent = this.SkillButtonData.GameplayTagComponent;
			BaseBuffComponent buffComponent = this.SkillButtonData.BuffComponent;
			if (gameplayTagComponent == null || buffComponent == null)
			{
				return;
			}
			if (gameplayTagComponent.HasTag(this.TagIds[0]))
			{
				bool flag = true;
				for (int i = 1; i < this.TagIds.Count; i++)
				{
					if (gameplayTagComponent.HasTag(this.TagIds[i]))
					{
						flag = false;
						break;
					}
				}
				if (this.ForceEnable != flag)
				{
					this.ForceEnable = flag;
					this.EnableModifyMark = true;
				}
				ActiveBuffInternal buffById = buffComponent.GetBuffById(this.BuffIds[0]);
				this.SkillButtonData.TotalCoolDownCustom = (int)((buffById != null) ? buffById.Duration : 0f);
				return;
			}
			this.SkillButtonData.TotalCoolDownCustom = 0;
			if (this.ForceEnable)
			{
				this.ForceEnable = false;
				this.EnableModifyMark = true;
			}
		}

		// Token: 0x060274CC RID: 160972 RVA: 0x00B05F20 File Offset: 0x00B04120
		public override void RefreshByTagChanged()
		{
			this.Refresh();
			this.SkillCdModifyMark = true;
		}
	}
}
