using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RacingBets.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200586E RID: 22638
	public class AnniversarySubActivityDangoRunUiItem : AnniversaryActivityEnterItem
	{
		// Token: 0x06037CED RID: 228589 RVA: 0x00F9B823 File Offset: 0x00F99A23
		public override void ChildUpdateStateInfo()
		{
			if (this.Data == null)
			{
				return;
			}
			this.SetDangoIcon();
		}

		// Token: 0x06037CEE RID: 228590 RVA: 0x00F9B834 File Offset: 0x00F99A34
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

		// Token: 0x06037CEF RID: 228591 RVA: 0x00F9B8BC File Offset: 0x00F99ABC
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

		// Token: 0x0401D749 RID: 120649
		[Nullable(2)]
		private string CachedDangoIconPath;
	}
}
