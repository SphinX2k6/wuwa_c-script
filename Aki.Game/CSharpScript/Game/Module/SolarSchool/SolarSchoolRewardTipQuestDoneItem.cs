using System;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059FF RID: 23039
	public sealed class SolarSchoolRewardTipQuestDoneItem : SolarSchoolRewardTipIconTextItemBase
	{
		// Token: 0x06038BB4 RID: 232372 RVA: 0x00FE07D0 File Offset: 0x00FDE9D0
		public override void InitData()
		{
			SolarSchoolQuest? solarSchoolQuest = (this.Data == null) ? null : SolarSchoolConfig.Instance.GetQuest(this.Data.TargetId);
			if (solarSchoolQuest == null)
			{
				return;
			}
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath("T_SolarSchoolIconDone"), base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), solarSchoolQuest.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, "SolarSchool_QuestPanel_Left", Array.Empty<object>());
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = true;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
		}
	}
}
