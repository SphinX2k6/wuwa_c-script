using System;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059FE RID: 23038
	public sealed class SolarSchoolRewardTipFavorItem : SolarSchoolRewardTipIconTextItemBase
	{
		// Token: 0x06038BB2 RID: 232370 RVA: 0x00FE0714 File Offset: 0x00FDE914
		public override void InitData()
		{
			SolarSchoolRole? solarSchoolRole = (this.Data == null) ? null : SolarSchoolConfig.Instance.GetRole(this.Data.TargetId);
			if (solarSchoolRole == null)
			{
				return;
			}
			base.SetTextureByPath(solarSchoolRole.Value.HeadIcon, base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), solarSchoolRole.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(SolarSchoolRewardTipItemBase.FormatDelta(this.Data.Delta), true);
		}
	}
}
