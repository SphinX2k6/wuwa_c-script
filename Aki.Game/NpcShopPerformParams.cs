using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x0200322E RID: 12846
[NullableContext(2)]
[Nullable(0)]
public class NpcShopPerformParams
{
	// Token: 0x0601BB28 RID: 113448 RVA: 0x0079DB70 File Offset: 0x0079BD70
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

	// Token: 0x0400DA17 RID: 55831
	public NpcSystemUiMontageInfo EnterMontageInfo;

	// Token: 0x0400DA18 RID: 55832
	public NpcSystemUiMontageInfo StandByMontageInfo;

	// Token: 0x0400DA19 RID: 55833
	public NpcSystemUiMontageInfo ShopSuccessMontageInfo;

	// Token: 0x0400DA1A RID: 55834
	public NpcSystemUiMontageInfo SwitchMusicMontageInfo;

	// Token: 0x0400DA1B RID: 55835
	public NpcSystemUiMontageInfo ExitMontageInfo;

	// Token: 0x0400DA1C RID: 55836
	public NpcSystemUiMontageInfo DeliverSuccessMontageInfo;

	// Token: 0x0400DA1D RID: 55837
	public NpcSystemUiMontageInfo CompleteMontageInfo;

	// Token: 0x0400DA1E RID: 55838
	public NpcSystemUiMontageInfo FirstDollMontageInfo;

	// Token: 0x0400DA1F RID: 55839
	public NpcSystemUiMontageInfo SubsequentDollMontageInfo;

	// Token: 0x0400DA20 RID: 55840
	public NpcSystemUiMontageInfo FirstDollPartMontageInfo;

	// Token: 0x0400DA21 RID: 55841
	public NpcSystemUiMontageInfo SubsequentDollPartMontageInfo;

	// Token: 0x0400DA22 RID: 55842
	public PlayFlow EnterFlow;

	// Token: 0x0400DA23 RID: 55843
	public PlayFlow ShopSuccessFlow;

	// Token: 0x0400DA24 RID: 55844
	public PlayFlow ShopFailedFlow;

	// Token: 0x0400DA25 RID: 55845
	public PlayFlow UpgradeFlow;

	// Token: 0x0400DA26 RID: 55846
	public PlayFlow DeliverSuccessFlow;

	// Token: 0x0400DA27 RID: 55847
	public PlayFlow CompleteFlow;

	// Token: 0x0400DA28 RID: 55848
	public PlayFlow FirstDollFlow;

	// Token: 0x0400DA29 RID: 55849
	public PlayFlow SubsequentDollFlow;

	// Token: 0x0400DA2A RID: 55850
	public PlayFlow FirstDollPartFlow;

	// Token: 0x0400DA2B RID: 55851
	public PlayFlow SubsequentDollPartFlow;

	// Token: 0x0400DA2C RID: 55852
	public string UpgradeSequencePath;

	// Token: 0x0400DA2D RID: 55853
	[Nullable(1)]
	public string FinishDeliverySequence = "";

	// Token: 0x0400DA2E RID: 55854
	public bool ShowNpcWhilePlayingSequence;
}
