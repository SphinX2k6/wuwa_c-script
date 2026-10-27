using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C22 RID: 19490
	public class SkillButtonCustomHandleAimisiMobileUpDown : SkillButtonCustomHandleBase
	{
		// Token: 0x0603271B RID: 206619 RVA: 0x00BC1320 File Offset: 0x00BBF520
		public override void Refresh()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.TagIds.Count < 1)
			{
				return;
			}
			bool isEnableSlideControl = this.SkillButtonData.IsEnableSlideControl;
			string customSkillTexturePath = this.SkillButtonData.CustomSkillTexturePath;
			string customSkillIconName = this.SkillButtonData.CustomSkillIconName;
			if (!Info.Instance.IsInTouch())
			{
				this.SkillButtonData.CustomSkillIconName = null;
				this.SkillButtonData.CustomSkillTexturePath = null;
				this.SkillButtonData.IsEnableSlideControl = false;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = this.SkillButtonData.GameplayTagComponent;
				if (gameplayTagComponent != null && !gameplayTagComponent.HasTag(this.TagIds[0]) && gameplayTagComponent.HasTag(this.TagIds[1]))
				{
					this.SkillButtonData.CustomSkillTexturePath = ((this.Params.Count > 0) ? this.Params[0] : null);
					this.SkillButtonData.CustomSkillIconName = ((this.Params.Count > 1) ? this.Params[1] : null);
					this.SkillButtonData.IsEnableSlideControl = true;
				}
				else
				{
					this.SkillButtonData.CustomSkillIconName = null;
					this.SkillButtonData.CustomSkillTexturePath = null;
					this.SkillButtonData.IsEnableSlideControl = false;
				}
			}
			this.EnableSlideControlModifyMark = (isEnableSlideControl != this.SkillButtonData.IsEnableSlideControl);
			this.CustomSkillTexturePathModifyMark = (customSkillTexturePath != this.SkillButtonData.CustomSkillTexturePath);
			this.CustomSkillIconNameModifyMark = (customSkillIconName != this.SkillButtonData.CustomSkillIconName);
		}

		// Token: 0x0603271C RID: 206620 RVA: 0x00BC149F File Offset: 0x00BBF69F
		public override void RefreshByTagChanged()
		{
			this.Refresh();
		}

		// Token: 0x0603271D RID: 206621 RVA: 0x00BC14A7 File Offset: 0x00BBF6A7
		public override bool RefreshOnInputControllerChange()
		{
			this.Refresh();
			return true;
		}
	}
}
