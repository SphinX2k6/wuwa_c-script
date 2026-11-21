using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x0200279D RID: 10141
[NullableContext(2)]
[Nullable(0)]
public class NpcShopPerformParams
{
	// Token: 0x060196AD RID: 104109 RVA: 0x007C630C File Offset: 0x007C450C
	public void TryLoadAllMontage()
	{
		NpcSystemUiMontageInfo enterMontageInfo = this.EnterMontageInfo;
		if (enterMontageInfo != null)
		{
			enterMontageInfo.TryLoadAsset();
		}
		NpcSystemUiMontageInfo standByMontageInfo = this.StandByMontageInfo;
		if (standByMontageInfo != null)
		{
			standByMontageInfo.TryLoadAsset();
		}
		NpcSystemUiMontageInfo shopSuccessMontageInfo = this.ShopSuccessMontageInfo;
		if (shopSuccessMontageInfo != null)
		{
			shopSuccessMontageInfo.TryLoadAsset();
		}
		NpcSystemUiMontageInfo switchMusicMontageInfo = this.SwitchMusicMontageInfo;
		if (switchMusicMontageInfo != null)
		{
			switchMusicMontageInfo.TryLoadAsset();
		}
		NpcSystemUiMontageInfo exitMontageInfo = this.ExitMontageInfo;
		if (exitMontageInfo != null)
		{
			exitMontageInfo.TryLoadAsset();
		}
		NpcSystemUiMontageInfo completeMontageInfo = this.CompleteMontageInfo;
		if (completeMontageInfo != null)
		{
			completeMontageInfo.TryLoadAsset();
		}
		NpcSystemUiMontageInfo deliverSuccessMontageInfo = this.DeliverSuccessMontageInfo;
		if (deliverSuccessMontageInfo == null)
		{
			return;
		}
		deliverSuccessMontageInfo.TryLoadAsset();
	}

	// Token: 0x0400DEB6 RID: 57014
	public NpcSystemUiMontageInfo EnterMontageInfo;

	// Token: 0x0400DEB7 RID: 57015
	public NpcSystemUiMontageInfo StandByMontageInfo;

	// Token: 0x0400DEB8 RID: 57016
	public NpcSystemUiMontageInfo ShopSuccessMontageInfo;

	// Token: 0x0400DEB9 RID: 57017
	public NpcSystemUiMontageInfo SwitchMusicMontageInfo;

	// Token: 0x0400DEBA RID: 57018
	public NpcSystemUiMontageInfo ExitMontageInfo;

	// Token: 0x0400DEBB RID: 57019
	public NpcSystemUiMontageInfo DeliverSuccessMontageInfo;

	// Token: 0x0400DEBC RID: 57020
	public NpcSystemUiMontageInfo CompleteMontageInfo;

	// Token: 0x0400DEBD RID: 57021
	public NpcSystemUiMontageInfo FirstDollMontageInfo;

	// Token: 0x0400DEBE RID: 57022
	public NpcSystemUiMontageInfo SubsequentDollMontageInfo;

	// Token: 0x0400DEBF RID: 57023
	public NpcSystemUiMontageInfo FirstDollPartMontageInfo;

	// Token: 0x0400DEC0 RID: 57024
	public NpcSystemUiMontageInfo SubsequentDollPartMontageInfo;

	// Token: 0x0400DEC1 RID: 57025
	public PlayFlow EnterFlow;

	// Token: 0x0400DEC2 RID: 57026
	public PlayFlow ShopSuccessFlow;

	// Token: 0x0400DEC3 RID: 57027
	public PlayFlow ShopFailedFlow;

	// Token: 0x0400DEC4 RID: 57028
	public PlayFlow UpgradeFlow;

	// Token: 0x0400DEC5 RID: 57029
	public PlayFlow DeliverSuccessFlow;

	// Token: 0x0400DEC6 RID: 57030
	public PlayFlow CompleteFlow;

	// Token: 0x0400DEC7 RID: 57031
	public PlayFlow FirstDollFlow;

	// Token: 0x0400DEC8 RID: 57032
	public PlayFlow SubsequentDollFlow;

	// Token: 0x0400DEC9 RID: 57033
	public PlayFlow FirstDollPartFlow;

	// Token: 0x0400DECA RID: 57034
	public PlayFlow SubsequentDollPartFlow;

	// Token: 0x0400DECB RID: 57035
	public string UpgradeSequencePath;

	// Token: 0x0400DECC RID: 57036
	[Nullable(1)]
	public string FinishDeliverySequence = "";

	// Token: 0x0400DECD RID: 57037
	public bool ShowNpcWhilePlayingSequence;
}
