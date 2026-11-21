using System;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD0 RID: 15312
	public class SkillButtonCustomHandleKeLaiTaUltimate : SkillButtonCustomHandleBase
	{
		// Token: 0x060274C1 RID: 160961 RVA: 0x00B05B89 File Offset: 0x00B03D89
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.HideCoolDownTextCustom = true;
		}

		// Token: 0x060274C2 RID: 160962 RVA: 0x00B05BA0 File Offset: 0x00B03DA0
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
			this.SkillButtonData.IsLimitCountCustom = false;
			this.SkillButtonData.RemainingCountCustom = 0;
			if (gameplayTagComponent.HasTag(this.TagIds[0]))
			{
				if (!this.ForceEnable)
				{
					this.ForceEnable = true;
					this.EnableModifyMark = true;
				}
				if (this.TagIds.Count > 1)
				{
					this.SkillButtonData.RemainingCountCustom = gameplayTagComponent.GetTagCount(this.TagIds[1]);
					if (this.SkillButtonData.RemainingCountCustom > 0)
					{
						this.SkillButtonData.IsLimitCountCustom = true;
					}
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

		// Token: 0x060274C3 RID: 160963 RVA: 0x00B05CD0 File Offset: 0x00B03ED0
		public override float GetCustomRemainingCoolDown()
		{
			if (this.SkillButtonData == null)
			{
				return 0f;
			}
			if (this.SkillButtonData.TotalCoolDownCustom <= 0)
			{
				return 0f;
			}
			BaseBuffComponent buffComponent = this.SkillButtonData.BuffComponent;
			if (buffComponent == null)
			{
				return 0f;
			}
			ActiveBuffInternal buffById = buffComponent.GetBuffById(this.BuffIds[0]);
			if (buffById == null)
			{
				return 0f;
			}
			return buffById.GetRemainDuration();
		}

		// Token: 0x060274C4 RID: 160964 RVA: 0x00B05D36 File Offset: 0x00B03F36
		public override void RefreshByTagChanged()
		{
			this.Refresh();
			this.SkillCdModifyMark = true;
		}
	}
}
