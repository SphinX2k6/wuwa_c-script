using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C26 RID: 19494
	public class SkillButtonCustomHandleOverrideAttributeColorByTag : SkillButtonCustomHandleBase
	{
		// Token: 0x06032729 RID: 206633 RVA: 0x00BC1774 File Offset: 0x00BBF974
		public override void Refresh()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.TagIds.Count == 0 || this.TagIds.Count != this.Params.Count)
			{
				return;
			}
			BaseTagComponent gameplayTagComponent = this.SkillButtonData.GameplayTagComponent;
			FColor? customOverrideFrameSpriteColor = this.SkillButtonData.GetCustomOverrideFrameSpriteColor();
			FLinearColor? customOverrideMaxAttributeColor = this.SkillButtonData.GetCustomOverrideMaxAttributeColor();
			int i = 0;
			while (i < this.TagIds.Count)
			{
				if (gameplayTagComponent != null && gameplayTagComponent.HasTag(this.TagIds[i]))
				{
					FColor value = FColor.FromHex(this.Params[i]);
					FLinearColor value2 = new FLinearColor(ref value);
					if (customOverrideFrameSpriteColor != null && customOverrideMaxAttributeColor != null && value.Equals(customOverrideFrameSpriteColor.Value) && value2.Equals(customOverrideMaxAttributeColor.Value))
					{
						return;
					}
					this.SkillButtonData.SetCustomOverrideFrameSpriteColor(new FColor?(value));
					this.SkillButtonData.SetCustomOverrideMaxAttributeColor(new FLinearColor?(value2));
					this.CustomHdModifyMark = true;
					this.CustomHdMarkFrom = 8;
					return;
				}
				else
				{
					i++;
				}
			}
			if (customOverrideFrameSpriteColor == null && customOverrideMaxAttributeColor == null)
			{
				return;
			}
			this.SkillButtonData.SetCustomOverrideFrameSpriteColor(null);
			this.SkillButtonData.SetCustomOverrideMaxAttributeColor(null);
			this.CustomHdModifyMark = true;
			this.CustomHdMarkFrom = 8;
		}

		// Token: 0x0603272A RID: 206634 RVA: 0x00BC18DA File Offset: 0x00BBFADA
		public override void RefreshByTagChanged()
		{
			this.Refresh();
		}
	}
}
