using System;
using System.Reflection;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C21 RID: 19489
	public class SkillButtonCustomHandleZanNiUltimate : SkillButtonCustomHandleBase
	{
		// Token: 0x06032717 RID: 206615 RVA: 0x00BC11C3 File Offset: 0x00BBF3C3
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.HideCoolDownTextCustom = true;
		}

		// Token: 0x06032718 RID: 206616 RVA: 0x00BC11DC File Offset: 0x00BBF3DC
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

		// Token: 0x06032719 RID: 206617 RVA: 0x00BC1308 File Offset: 0x00BBF508
		public override void RefreshByTagChanged()
		{
			this.Refresh();
			this.SkillCdModifyMark = true;
		}
	}
}
