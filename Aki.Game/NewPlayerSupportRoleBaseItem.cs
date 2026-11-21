using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000878 RID: 2168
public class NewPlayerSupportRoleBaseItem : UiPanelBase
{
	// Token: 0x06006266 RID: 25190 RVA: 0x001F610B File Offset: 0x001F430B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x001F6120 File Offset: 0x001F4320
	public UniTask PlayStartSeqAsync()
	{
		NewPlayerSupportRoleBaseItem.<PlayStartSeqAsync>d__4 <PlayStartSeqAsync>d__;
		<PlayStartSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSeqAsync>d__.<>4__this = this;
		<PlayStartSeqAsync>d__.<>1__state = -1;
		<PlayStartSeqAsync>d__.<>t__builder.Start<NewPlayerSupportRoleBaseItem.<PlayStartSeqAsync>d__4>(ref <PlayStartSeqAsync>d__);
		return <PlayStartSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x001F6164 File Offset: 0x001F4364
	public void PlayStartSeq()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x001F6190 File Offset: 0x001F4390
	public void PlaySwitchSeq()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x001F61BC File Offset: 0x001F43BC
	public UniTask PlaySwitchSeqAsync()
	{
		NewPlayerSupportRoleBaseItem.<PlaySwitchSeqAsync>d__7 <PlaySwitchSeqAsync>d__;
		<PlaySwitchSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySwitchSeqAsync>d__.<>4__this = this;
		<PlaySwitchSeqAsync>d__.<>1__state = -1;
		<PlaySwitchSeqAsync>d__.<>t__builder.Start<NewPlayerSupportRoleBaseItem.<PlaySwitchSeqAsync>d__7>(ref <PlaySwitchSeqAsync>d__);
		return <PlaySwitchSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x001F6200 File Offset: 0x001F4400
	public void Update(TrialRoleInfo trialRoleInfo)
	{
		bool flag = this.TrialRoleInfo != null && this.TrialRoleInfo.Value.GroupId == trialRoleInfo.GroupId;
		this.TrialRoleInfo = new TrialRoleInfo?(trialRoleInfo);
		if (flag)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x001F624E File Offset: 0x001F444E
	public void UpdateByRoleId(int roleId)
	{
		bool flag = this.RoleId == roleId;
		this.RoleId = roleId;
		if (flag)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x001F6269 File Offset: 0x001F4469
	public virtual void Refresh()
	{
	}

	// Token: 0x04003FC1 RID: 16321
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003FC2 RID: 16322
	protected TrialRoleInfo? TrialRoleInfo;

	// Token: 0x04003FC3 RID: 16323
	protected int RoleId;
}
