using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200128D RID: 4749
[NullableContext(2)]
[Nullable(0)]
public class InviteNewbieProtocolContext : ActivityBaseData
{
	// Token: 0x17000B2A RID: 2858
	// (get) Token: 0x060081D6 RID: 33238 RVA: 0x001B88F0 File Offset: 0x001B6AF0
	// (set) Token: 0x060081D7 RID: 33239 RVA: 0x001B88F8 File Offset: 0x001B6AF8
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

	// Token: 0x060081D8 RID: 33240 RVA: 0x001B8947 File Offset: 0x001B6B47
	[NullableContext(1)]
	public InviteNewbieProtocolContext(InviteNewbieModel model)
	{
		this.AttachedModel = model;
	}

	// Token: 0x060081D9 RID: 33241 RVA: 0x001B8956 File Offset: 0x001B6B56
	public void Dispose()
	{
	}

	// Token: 0x060081DA RID: 33242 RVA: 0x001B8958 File Offset: 0x001B6B58
	protected override bool GetExDataFinishShowState()
	{
		return this.RewardClaimState;
	}

	// Token: 0x060081DB RID: 33243 RVA: 0x001B8960 File Offset: 0x001B6B60
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

	// Token: 0x17000B2B RID: 2859
	// (get) Token: 0x060081DC RID: 33244 RVA: 0x001B89A8 File Offset: 0x001B6BA8
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

	// Token: 0x060081DD RID: 33245 RVA: 0x001B89DC File Offset: 0x001B6BDC
	public void SetCurrentLoginClickState(bool state)
	{
		this.CurrentLoginClickState = state;
	}

	// Token: 0x060081DE RID: 33246 RVA: 0x001B89E5 File Offset: 0x001B6BE5
	public bool GetClickRedDotState()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
	}

	// Token: 0x060081DF RID: 33247 RVA: 0x001B89FE File Offset: 0x001B6BFE
	public void SaveClickRedDotState()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
	}

	// Token: 0x060081E0 RID: 33248 RVA: 0x001B8A14 File Offset: 0x001B6C14
	public void ChangeServerRedDotState(bool state)
	{
		this.RedDotInternal = state;
	}

	// Token: 0x060081E1 RID: 33249 RVA: 0x001B8A1D File Offset: 0x001B6C1D
	public override bool GetExDataRedPointShowState()
	{
		return this.GetClickRedDotState() || (this.RedDotInternal && !this.CurrentLoginClickState);
	}

	// Token: 0x04003AC1 RID: 15041
	private const int CLICKKEY = 1;

	// Token: 0x04003AC2 RID: 15042
	private string InviteCodeInternal;

	// Token: 0x04003AC3 RID: 15043
	private bool RedDotInternal;

	// Token: 0x04003AC4 RID: 15044
	private bool CurrentLoginClickState;

	// Token: 0x04003AC5 RID: 15045
	public bool RewardClaimState;

	// Token: 0x04003AC6 RID: 15046
	public int Score;

	// Token: 0x04003AC7 RID: 15047
	protected readonly InviteNewbieModel AttachedModel;
}
