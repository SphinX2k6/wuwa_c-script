using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000741 RID: 1857
[NullableContext(2)]
[Nullable(0)]
public class InviteNewbieProtocolContext : ActivityBaseData
{
	// Token: 0x17000B4A RID: 2890
	// (get) Token: 0x0600556D RID: 21869 RVA: 0x001C15C0 File Offset: 0x001BF7C0
	// (set) Token: 0x0600556E RID: 21870 RVA: 0x001C15C8 File Offset: 0x001BF7C8
	public string InviteCode
	{
		get
		{
			return this.InviteCodeInternal;
		}
		set
		{
			this.InviteCodeInternal = value;
			EventSystem.Instance.Emit<string>(EEventName.InviteNewbieInviteCodeChanged, value);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InviteNewbie;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "邀请码变更";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InviteCode", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0600556F RID: 21871 RVA: 0x001C1617 File Offset: 0x001BF817
	[NullableContext(1)]
	public InviteNewbieProtocolContext(InviteNewbieModel model)
	{
		this.AttachedModel = model;
	}

	// Token: 0x06005570 RID: 21872 RVA: 0x001C1626 File Offset: 0x001BF826
	public void Dispose()
	{
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x001C1628 File Offset: 0x001BF828
	protected override bool GetExDataFinishShowState()
	{
		return this.RewardClaimState;
	}

	// Token: 0x06005572 RID: 21874 RVA: 0x001C1630 File Offset: 0x001BF830
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		H5CircumFluenceActivityData h5CircumFluenceData = data.H5CircumFluenceData;
		if (h5CircumFluenceData != null)
		{
			this.InviteCode = h5CircumFluenceData.InviteCode;
			this.Score = h5CircumFluenceData.Score;
			this.RewardClaimState = h5CircumFluenceData.AllRewardClaimed;
			this.ChangeServerRedDotState(h5CircumFluenceData.RedDot);
		}
	}

	// Token: 0x17000B4B RID: 2891
	// (get) Token: 0x06005573 RID: 21875 RVA: 0x001C1678 File Offset: 0x001BF878
	public string BgPath
	{
		get
		{
			H5CircumUrl? config = ConfigH5CircumUrlById.GetConfig(base.Id, true);
			if (config == null)
			{
				return null;
			}
			return config.GetValueOrDefault().BgPath;
		}
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x001C16AC File Offset: 0x001BF8AC
	public void SetCurrentLoginClickState(bool state)
	{
		this.CurrentLoginClickState = state;
	}

	// Token: 0x06005575 RID: 21877 RVA: 0x001C16B5 File Offset: 0x001BF8B5
	public bool GetClickRedDotState()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x001C16CE File Offset: 0x001BF8CE
	public void SaveClickRedDotState()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x001C16E4 File Offset: 0x001BF8E4
	public void ChangeServerRedDotState(bool state)
	{
		this.RedDotInternal = state;
	}

	// Token: 0x06005578 RID: 21880 RVA: 0x001C16ED File Offset: 0x001BF8ED
	public override bool GetExDataRedPointShowState()
	{
		return this.GetClickRedDotState() || (this.RedDotInternal && !this.CurrentLoginClickState);
	}

	// Token: 0x04003B59 RID: 15193
	private const int CLICKKEY = 1;

	// Token: 0x04003B5A RID: 15194
	private string InviteCodeInternal;

	// Token: 0x04003B5B RID: 15195
	private bool RedDotInternal;

	// Token: 0x04003B5C RID: 15196
	private bool CurrentLoginClickState;

	// Token: 0x04003B5D RID: 15197
	public bool RewardClaimState;

	// Token: 0x04003B5E RID: 15198
	public int Score;

	// Token: 0x04003B5F RID: 15199
	protected readonly InviteNewbieModel AttachedModel;
}
