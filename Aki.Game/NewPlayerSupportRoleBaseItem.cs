using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020013C4 RID: 5060
public class NewPlayerSupportRoleBaseItem : UiPanelBase
{
	// Token: 0x06008ED1 RID: 36561 RVA: 0x001ED5EB File Offset: 0x001EB7EB
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06008ED2 RID: 36562 RVA: 0x001ED600 File Offset: 0x001EB800
	public UniTask PlayStartSeqAsync()
	{
		NewPlayerSupportRoleBaseItem.<PlayStartSeqAsync>d__4 <PlayStartSeqAsync>d__;
		<PlayStartSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSeqAsync>d__.<>4__this = this;
		<PlayStartSeqAsync>d__.<>1__state = -1;
		<PlayStartSeqAsync>d__.<>t__builder.Start<NewPlayerSupportRoleBaseItem.<PlayStartSeqAsync>d__4>(ref <PlayStartSeqAsync>d__);
		return <PlayStartSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008ED3 RID: 36563 RVA: 0x001ED644 File Offset: 0x001EB844
	public void PlayStartSeq()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06008ED4 RID: 36564 RVA: 0x001ED670 File Offset: 0x001EB870
	public void PlaySwitchSeq()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x06008ED5 RID: 36565 RVA: 0x001ED69C File Offset: 0x001EB89C
	public UniTask PlaySwitchSeqAsync()
	{
		NewPlayerSupportRoleBaseItem.<PlaySwitchSeqAsync>d__7 <PlaySwitchSeqAsync>d__;
		<PlaySwitchSeqAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySwitchSeqAsync>d__.<>4__this = this;
		<PlaySwitchSeqAsync>d__.<>1__state = -1;
		<PlaySwitchSeqAsync>d__.<>t__builder.Start<NewPlayerSupportRoleBaseItem.<PlaySwitchSeqAsync>d__7>(ref <PlaySwitchSeqAsync>d__);
		return <PlaySwitchSeqAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008ED6 RID: 36566 RVA: 0x001ED6E0 File Offset: 0x001EB8E0
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

	// Token: 0x06008ED7 RID: 36567 RVA: 0x001ED72E File Offset: 0x001EB92E
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

	// Token: 0x06008ED8 RID: 36568 RVA: 0x001ED749 File Offset: 0x001EB949
	public virtual void Refresh()
	{
	}

	// Token: 0x04003F29 RID: 16169
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003F2A RID: 16170
	protected TrialRoleInfo? TrialRoleInfo;

	// Token: 0x04003F2B RID: 16171
	protected int RoleId;
}
