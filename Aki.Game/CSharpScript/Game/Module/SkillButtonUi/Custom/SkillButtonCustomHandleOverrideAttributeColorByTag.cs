using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD7 RID: 15319
	public class SkillButtonCustomHandleOverrideAttributeColorByTag : SkillButtonCustomHandleBase
	{
		// Token: 0x060274DC RID: 160988 RVA: 0x00B0638C File Offset: 0x00B0458C
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

		// Token: 0x060274DD RID: 160989 RVA: 0x00B064F2 File Offset: 0x00B046F2
		public override void RefreshByTagChanged()
		{
			this.Refresh();
		}
	}
}
