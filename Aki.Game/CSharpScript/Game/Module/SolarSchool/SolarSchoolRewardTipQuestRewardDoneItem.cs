using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A00 RID: 23040
	public sealed class SolarSchoolRewardTipQuestRewardDoneItem : SolarSchoolRewardTipIconTextItemBase
	{
		// Token: 0x06038BB6 RID: 232374 RVA: 0x00FE08A0 File Offset: 0x00FDEAA0
		public override void InitData()
		{
			if (this.Data == null)
			{
				return;
			}
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath("T_SolarSchoolIconDone"), base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SolarSchool_QuestPanel_Left1", Array.Empty<object>());
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, "SolarSchool_QuestPanel_Left2", new <>z__ReadOnlySingleElementList<object>(this.Data.Delta.ToString()));
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
