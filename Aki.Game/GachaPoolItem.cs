using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C86 RID: 7302
[NullableContext(2)]
[Nullable(0)]
public class GachaPoolItem : UiPanelBase
{
	// Token: 0x0600DC4C RID: 56396 RVA: 0x00335C75 File Offset: 0x00333E75
	public GachaPoolItem(GachaDefine.EGachaViewType gachaType)
	{
		this.GachaType = new GachaDefine.EGachaViewType?(gachaType);
	}

	// Token: 0x0600DC4D RID: 56397 RVA: 0x00335C89 File Offset: 0x00333E89
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600DC4E RID: 56398 RVA: 0x00335C9C File Offset: 0x00333E9C
	public UniTask PlayStartSeqAsync()
	{
		GachaPoolItem.<PlayStartSeqAsync>d__6 <PlayStartSeqAsync>d__;
		<PlayStartSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSeqAsync>d__.<>4__this = this;
		<PlayStartSeqAsync>d__.<>1__state = -1;
		<PlayStartSeqAsync>d__.<>t__builder.Start<GachaPoolItem.<PlayStartSeqAsync>d__6>(ref <PlayStartSeqAsync>d__);
		return <PlayStartSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC4F RID: 56399 RVA: 0x00335CE0 File Offset: 0x00333EE0
	public void PlayStartSeq()
	{
		this.OnPlayStartSeq();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600DC50 RID: 56400 RVA: 0x00335D12 File Offset: 0x00333F12
	protected virtual void OnPlayStartSeq()
	{
	}

	// Token: 0x0600DC51 RID: 56401 RVA: 0x00335D14 File Offset: 0x00333F14
	public void PlaySwitchSeq()
	{
		this.OnPlaySwitchSeq();
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x0600DC52 RID: 56402 RVA: 0x00335D44 File Offset: 0x00333F44
	public UniTask PlaySwitchSeqAsync()
	{
		GachaPoolItem.<PlaySwitchSeqAsync>d__10 <PlaySwitchSeqAsync>d__;
		<PlaySwitchSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySwitchSeqAsync>d__.<>4__this = this;
		<PlaySwitchSeqAsync>d__.<>1__state = -1;
		<PlaySwitchSeqAsync>d__.<>t__builder.Start<GachaPoolItem.<PlaySwitchSeqAsync>d__10>(ref <PlaySwitchSeqAsync>d__);
		return <PlaySwitchSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC53 RID: 56403 RVA: 0x00335D87 File Offset: 0x00333F87
	protected virtual void OnPlaySwitchSeq()
	{
	}

	// Token: 0x0600DC54 RID: 56404 RVA: 0x00335D89 File Offset: 0x00333F89
	protected virtual UniTask OnPlayingSwitchSeqAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600DC55 RID: 56405 RVA: 0x00335D90 File Offset: 0x00333F90
	[NullableContext(1)]
	public void Update(GachaPoolData gachaPoolData)
	{
		this.GachaPoolData = gachaPoolData;
		if (this.GachaPoolData == null)
		{
			return;
		}
		int id = this.GachaPoolData.PoolInfo.Id;
		this.GachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(id);
		this.Refresh();
	}

	// Token: 0x0600DC56 RID: 56406 RVA: 0x00335DD5 File Offset: 0x00333FD5
	public virtual void Refresh()
	{
	}

	// Token: 0x04006510 RID: 25872
	protected GachaPoolData GachaPoolData;

	// Token: 0x04006511 RID: 25873
	protected GachaViewInfo? GachaViewInfo;

	// Token: 0x04006512 RID: 25874
	protected readonly GachaDefine.EGachaViewType? GachaType;

	// Token: 0x04006513 RID: 25875
	protected LevelSequencePlayer LevelSequencePlayer;
}
