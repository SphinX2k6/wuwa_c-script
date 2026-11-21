using System;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059FD RID: 23037
	public sealed class SolarSchoolRewardTipPropItem : SolarSchoolRewardTipIconTextItemBase
	{
		// Token: 0x06038BB0 RID: 232368 RVA: 0x00FE063C File Offset: 0x00FDE83C
		public override void InitData()
		{
			SolarSchoolItem? solarSchoolItem = (this.Data == null) ? null : SolarSchoolConfig.Instance.GetItem(this.Data.TargetId);
			if (solarSchoolItem == null)
			{
				return;
			}
			base.SetTextureByPath(solarSchoolItem.Value.Icon, base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), solarSchoolItem.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(SolarSchoolRewardTipItemBase.FormatDelta(this.Data.Delta), true);
			}
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
