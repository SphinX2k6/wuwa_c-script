using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RacingBets.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200691E RID: 26910
	public class AnniversarySubActivityDangoRunUiItem : AnniversaryActivityEnterItem
	{
		// Token: 0x06043195 RID: 274837 RVA: 0x0105A1F7 File Offset: 0x010583F7
		public override void ChildUpdateStateInfo()
		{
			if (this.Data == null)
			{
				return;
			}
			this.SetDangoIcon();
		}

		// Token: 0x06043196 RID: 274838 RVA: 0x0105A208 File Offset: 0x01058408
		public override void ChildUpdateTips()
		{
			this.SetDangoIcon();
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
			AnniversarySubActivityDataBase data = this.Data;
			if (((data != null) ? new EAnniversaryActivityState?(data.GetCurrentState()) : null).GetValueOrDefault() != EAnniversaryActivityState.Unlock)
			{
				return;
			}
			AnniversarySubActivityDangoRun anniversarySubActivityDangoRun = this.Data as AnniversarySubActivityDangoRun;
			if (anniversarySubActivityDangoRun == null)
			{
				return;
			}
			string matchStateDisplayTextForEntranceActivityId = RacingBetsSeasonData.GetMatchStateDisplayTextForEntranceActivityId(anniversarySubActivityDangoRun.GetActivityId());
			if (matchStateDisplayTextForEntranceActivityId.Length == 0)
			{
				return;
			}
			text.SetUIActive(true);
			text.SetText(matchStateDisplayTextForEntranceActivityId, true);
		}

		// Token: 0x06043197 RID: 274839 RVA: 0x0105A290 File Offset: 0x01058490
		private void SetDangoIcon()
		{
			if (this.Data == null)
			{
				return;
			}
			AnniversarySubActivityDangoRun anniversarySubActivityDangoRun = this.Data as AnniversarySubActivityDangoRun;
			if (anniversarySubActivityDangoRun == null)
			{
				return;
			}
			string currentDangoIconStr = anniversarySubActivityDangoRun.GetCurrentDangoIconStr();
			bool uiactive = !string.IsNullOrEmpty(currentDangoIconStr);
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUITexture texture = base.GetTexture(5);
			if (texture != null)
			{
				texture.SetUIActive(uiactive);
			}
			if (this.CachedDangoIconPath == currentDangoIconStr)
			{
				return;
			}
			this.CachedDangoIconPath = currentDangoIconStr;
			base.TrySetTextureByPath(currentDangoIconStr, base.GetTexture(5), null, null);
		}

		// Token: 0x04022EED RID: 143085
		[Nullable(2)]
		private string CachedDangoIconPath;
	}
}
