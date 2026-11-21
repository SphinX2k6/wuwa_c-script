using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD3 RID: 15315
	public class SkillButtonCustomHandleAimisiMobileUpDown : SkillButtonCustomHandleBase
	{
		// Token: 0x060274CE RID: 160974 RVA: 0x00B05F38 File Offset: 0x00B04138
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

		// Token: 0x060274CF RID: 160975 RVA: 0x00B060B7 File Offset: 0x00B042B7
		public override void RefreshByTagChanged()
		{
			this.Refresh();
		}

		// Token: 0x060274D0 RID: 160976 RVA: 0x00B060BF File Offset: 0x00B042BF
		public override bool RefreshOnInputControllerChange()
		{
			this.Refresh();
			return true;
		}
	}
}
