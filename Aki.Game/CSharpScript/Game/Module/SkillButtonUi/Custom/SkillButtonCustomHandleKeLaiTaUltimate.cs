using System;
using System.Reflection;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C1F RID: 19487
	public class SkillButtonCustomHandleKeLaiTaUltimate : SkillButtonCustomHandleBase
	{
		// Token: 0x0603270E RID: 206606 RVA: 0x00BC0EFD File Offset: 0x00BBF0FD
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.HideCoolDownTextCustom = true;
		}

		// Token: 0x0603270F RID: 206607 RVA: 0x00BC0F14 File Offset: 0x00BBF114
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
				object obj;
				if (buffById == null)
				{
					obj = null;
				}
				else
				{
					PropertyInfo property = buffById.GetType().GetProperty("Duration");
					obj = ((property != null) ? property.GetValue(buffById) : null);
				}
				int? num = obj as int?;
				this.SkillButtonData.TotalCoolDownCustom = num.GetValueOrDefault();
				return;
			}
			this.SkillButtonData.TotalCoolDownCustom = 0;
			if (this.ForceEnable)
			{
				this.ForceEnable = false;
				this.EnableModifyMark = true;
			}
		}

		// Token: 0x06032710 RID: 206608 RVA: 0x00BC1068 File Offset: 0x00BBF268
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
			MethodInfo method = buffById.GetType().GetMethod("GetRemainDuration");
			return (((method != null) ? method.Invoke(buffById, null) : null) as float?).GetValueOrDefault();
		}

		// Token: 0x06032711 RID: 206609 RVA: 0x00BC10F8 File Offset: 0x00BBF2F8
		public override void RefreshByTagChanged()
		{
			this.Refresh();
			this.SkillCdModifyMark = true;
		}
	}
}
