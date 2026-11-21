using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001145 RID: 4421
[NullableContext(2)]
[Nullable(0)]
public class GachaPoolItem : UiPanelBase
{
	// Token: 0x0600B062 RID: 45154 RVA: 0x003411A1 File Offset: 0x0033F3A1
	public GachaPoolItem(GachaDefine.EGachaViewType gachaType)
	{
		this.GachaType = new GachaDefine.EGachaViewType?(gachaType);
	}

	// Token: 0x0600B063 RID: 45155 RVA: 0x003411B5 File Offset: 0x0033F3B5
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B064 RID: 45156 RVA: 0x003411C8 File Offset: 0x0033F3C8
	public UniTask PlayStartSeqAsync()
	{
		GachaPoolItem.<PlayStartSeqAsync>d__6 <PlayStartSeqAsync>d__;
		<PlayStartSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSeqAsync>d__.<>4__this = this;
		<PlayStartSeqAsync>d__.<>1__state = -1;
		<PlayStartSeqAsync>d__.<>t__builder.Start<GachaPoolItem.<PlayStartSeqAsync>d__6>(ref <PlayStartSeqAsync>d__);
		return <PlayStartSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B065 RID: 45157 RVA: 0x0034120C File Offset: 0x0033F40C
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

	// Token: 0x0600B066 RID: 45158 RVA: 0x0034123E File Offset: 0x0033F43E
	protected virtual void OnPlayStartSeq()
	{
	}

	// Token: 0x0600B067 RID: 45159 RVA: 0x00341240 File Offset: 0x0033F440
	public void PlaySwitchSeq()
	{
		this.OnPlaySwitchSeq();
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x0600B068 RID: 45160 RVA: 0x00341270 File Offset: 0x0033F470
	public UniTask PlaySwitchSeqAsync()
	{
		GachaPoolItem.<PlaySwitchSeqAsync>d__10 <PlaySwitchSeqAsync>d__;
		<PlaySwitchSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySwitchSeqAsync>d__.<>4__this = this;
		<PlaySwitchSeqAsync>d__.<>1__state = -1;
		<PlaySwitchSeqAsync>d__.<>t__builder.Start<GachaPoolItem.<PlaySwitchSeqAsync>d__10>(ref <PlaySwitchSeqAsync>d__);
		return <PlaySwitchSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B069 RID: 45161 RVA: 0x003412B3 File Offset: 0x0033F4B3
	protected virtual void OnPlaySwitchSeq()
	{
	}

	// Token: 0x0600B06A RID: 45162 RVA: 0x003412B5 File Offset: 0x0033F4B5
	protected virtual UniTask OnPlayingSwitchSeqAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600B06B RID: 45163 RVA: 0x003412BC File Offset: 0x0033F4BC
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

	// Token: 0x0600B06C RID: 45164 RVA: 0x00341301 File Offset: 0x0033F501
	public virtual void Refresh()
	{
	}

	// Token: 0x040065E2 RID: 26082
	protected GachaPoolData GachaPoolData;

	// Token: 0x040065E3 RID: 26083
	protected GachaViewInfo? GachaViewInfo;

	// Token: 0x040065E4 RID: 26084
	protected readonly GachaDefine.EGachaViewType? GachaType;

	// Token: 0x040065E5 RID: 26085
	protected LevelSequencePlayer LevelSequencePlayer;
}
