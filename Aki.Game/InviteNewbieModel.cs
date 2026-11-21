using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000740 RID: 1856
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InviteNewbieModel : ModelBase
{
	// Token: 0x06005559 RID: 21849 RVA: 0x001C12EC File Offset: 0x001BF4EC
	protected override bool OnInit()
	{
		this.ProtocolContext = new InviteNewbieProtocolContext(this);
		return true;
	}

	// Token: 0x0600555A RID: 21850 RVA: 0x001C12FB File Offset: 0x001BF4FB
	protected override bool OnClear()
	{
		InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext != null)
		{
			protocolContext.Dispose();
		}
		this.ProtocolContext = null;
		return true;
	}

	// Token: 0x17000B40 RID: 2880
	// (get) Token: 0x0600555B RID: 21851 RVA: 0x001C1316 File Offset: 0x001BF516
	public ActivityBaseData ActivityData
	{
		get
		{
			if (this.ProtocolContext == null)
			{
				this.ProtocolContext = new InviteNewbieProtocolContext(this);
			}
			return this.ProtocolContext;
		}
	}

	// Token: 0x17000B41 RID: 2881
	// (get) Token: 0x0600555C RID: 21852 RVA: 0x001C1332 File Offset: 0x001BF532
	public int CurrentActivityId
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			if (protocolContext == null)
			{
				return 0;
			}
			return protocolContext.Id;
		}
	}

	// Token: 0x17000B42 RID: 2882
	// (get) Token: 0x0600555D RID: 21853 RVA: 0x001C1345 File Offset: 0x001BF545
	public bool HasRedDot
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			return protocolContext != null && protocolContext.RedPointShowState;
		}
	}

	// Token: 0x0600555E RID: 21854 RVA: 0x001C1358 File Offset: 0x001BF558
	public void SaveClickState()
	{
		InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.SaveClickRedDotState();
	}

	// Token: 0x17000B43 RID: 2883
	// (get) Token: 0x0600555F RID: 21855 RVA: 0x001C136A File Offset: 0x001BF56A
	public int HelpId
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			if (protocolContext == null)
			{
				return 0;
			}
			return protocolContext.GetHelpId();
		}
	}

	// Token: 0x17000B44 RID: 2884
	// (get) Token: 0x06005560 RID: 21856 RVA: 0x001C137D File Offset: 0x001BF57D
	public string InviteCode
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			return ((protocolContext != null) ? protocolContext.InviteCode : null) ?? "";
		}
	}

	// Token: 0x17000B45 RID: 2885
	// (get) Token: 0x06005561 RID: 21857 RVA: 0x001C139C File Offset: 0x001BF59C
	public string ScoreTextId
	{
		get
		{
			if (this.ProtocolContext == null)
			{
				return "";
			}
			H5CircumUrl? config = ConfigH5CircumUrlById.GetConfig(this.ProtocolContext.Id, true);
			return ((config != null) ? config.GetValueOrDefault().ScoreText : null) ?? " ";
		}
	}

	// Token: 0x17000B46 RID: 2886
	// (get) Token: 0x06005562 RID: 21858 RVA: 0x001C13ED File Offset: 0x001BF5ED
	public int Score
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			if (protocolContext == null)
			{
				return 0;
			}
			return protocolContext.Score;
		}
	}

	// Token: 0x17000B47 RID: 2887
	// (get) Token: 0x06005563 RID: 21859 RVA: 0x001C1400 File Offset: 0x001BF600
	[Nullable(2)]
	public string RootUrl
	{
		[NullableContext(2)]
		get
		{
			if (this.GmUrl != null && this.GmUrl != "")
			{
				return this.GmUrl;
			}
			if (this.ProtocolContext == null)
			{
				return null;
			}
			H5CircumUrl? config = ConfigH5CircumUrlById.GetConfig(this.ProtocolContext.Id, true);
			if (!KuroSdkController.Instance.GetIfGlobalSdk())
			{
				if (config == null)
				{
					return null;
				}
				return config.GetValueOrDefault().RootUrl;
			}
			else
			{
				if (config == null)
				{
					return null;
				}
				return config.GetValueOrDefault().OverseaRootUrl;
			}
		}
	}

	// Token: 0x17000B48 RID: 2888
	// (get) Token: 0x06005564 RID: 21860 RVA: 0x001C148C File Offset: 0x001BF68C
	public bool IsInternalBrowser
	{
		get
		{
			if (this.ProtocolContext == null)
			{
				return false;
			}
			H5CircumUrl? config = ConfigH5CircumUrlById.GetConfig(this.ProtocolContext.Id, true);
			return config != null && config.GetValueOrDefault().IsInternalBrowser;
		}
	}

	// Token: 0x06005565 RID: 21861 RVA: 0x001C14D0 File Offset: 0x001BF6D0
	public void SyncActivityNotify(H5CircumFluenceActivityDataNotify notify)
	{
		H5CircumFluenceActivityData activityData = notify.ActivityData;
		if (this.ProtocolContext != null)
		{
			this.ProtocolContext.InviteCode = ((activityData != null) ? activityData.InviteCode : null);
			this.ProtocolContext.Score = ((activityData != null) ? activityData.Score : 0);
			this.ProtocolContext.RewardClaimState = (activityData != null && activityData.AllRewardClaimed);
			this.ProtocolContext.ChangeServerRedDotState(activityData != null && activityData.RedDot);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.CurrentActivityId);
	}

	// Token: 0x17000B49 RID: 2889
	// (get) Token: 0x06005566 RID: 21862 RVA: 0x001C155E File Offset: 0x001BF75E
	public static InviteNewbieModel Instance
	{
		get
		{
			return InviteNewbieModel._Instance;
		}
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x001C1565 File Offset: 0x001BF765
	public static InviteNewbieModel GetOrCreateInstance()
	{
		if (InviteNewbieModel._Instance == null)
		{
			InviteNewbieModel.CreateInstance();
		}
		return InviteNewbieModel._Instance;
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x001C1579 File Offset: 0x001BF779
	public static bool CreateInstance()
	{
		if (InviteNewbieModel._Instance != null)
		{
			return true;
		}
		InviteNewbieModel._Instance = new InviteNewbieModel();
		return true;
	}

	// Token: 0x06005569 RID: 21865 RVA: 0x001C158F File Offset: 0x001BF78F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600556A RID: 21866 RVA: 0x001C1591 File Offset: 0x001BF791
	public static void ResetStaticDefaultValue()
	{
		InviteNewbieModel._Instance = null;
	}

	// Token: 0x0600556B RID: 21867 RVA: 0x001C1599 File Offset: 0x001BF799
	static InviteNewbieModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InviteNewbieModel.CreateStaticDefaultValue), new Action(InviteNewbieModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003B56 RID: 15190
	[Nullable(2)]
	public string GmUrl;

	// Token: 0x04003B57 RID: 15191
	[Nullable(2)]
	private InviteNewbieProtocolContext ProtocolContext;

	// Token: 0x04003B58 RID: 15192
	[Nullable(2)]
	private static InviteNewbieModel _Instance;
}
