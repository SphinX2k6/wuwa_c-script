using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200128C RID: 4748
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InviteNewbieModel : ModelBase
{
	// Token: 0x060081C2 RID: 33218 RVA: 0x001B861C File Offset: 0x001B681C
	protected override bool OnInit()
	{
		this.ProtocolContext = new InviteNewbieProtocolContext(this);
		return true;
	}

	// Token: 0x060081C3 RID: 33219 RVA: 0x001B862B File Offset: 0x001B682B
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

	// Token: 0x17000B20 RID: 2848
	// (get) Token: 0x060081C4 RID: 33220 RVA: 0x001B8646 File Offset: 0x001B6846
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

	// Token: 0x17000B21 RID: 2849
	// (get) Token: 0x060081C5 RID: 33221 RVA: 0x001B8662 File Offset: 0x001B6862
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

	// Token: 0x17000B22 RID: 2850
	// (get) Token: 0x060081C6 RID: 33222 RVA: 0x001B8675 File Offset: 0x001B6875
	public bool HasRedDot
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			return protocolContext != null && protocolContext.RedPointShowState;
		}
	}

	// Token: 0x060081C7 RID: 33223 RVA: 0x001B8688 File Offset: 0x001B6888
	public void SaveClickState()
	{
		InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
		if (protocolContext == null)
		{
			return;
		}
		protocolContext.SaveClickRedDotState();
	}

	// Token: 0x17000B23 RID: 2851
	// (get) Token: 0x060081C8 RID: 33224 RVA: 0x001B869A File Offset: 0x001B689A
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

	// Token: 0x17000B24 RID: 2852
	// (get) Token: 0x060081C9 RID: 33225 RVA: 0x001B86AD File Offset: 0x001B68AD
	public string InviteCode
	{
		get
		{
			InviteNewbieProtocolContext protocolContext = this.ProtocolContext;
			return ((protocolContext != null) ? protocolContext.InviteCode : null) ?? "";
		}
	}

	// Token: 0x17000B25 RID: 2853
	// (get) Token: 0x060081CA RID: 33226 RVA: 0x001B86CC File Offset: 0x001B68CC
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

	// Token: 0x17000B26 RID: 2854
	// (get) Token: 0x060081CB RID: 33227 RVA: 0x001B871D File Offset: 0x001B691D
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

	// Token: 0x17000B27 RID: 2855
	// (get) Token: 0x060081CC RID: 33228 RVA: 0x001B8730 File Offset: 0x001B6930
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

	// Token: 0x17000B28 RID: 2856
	// (get) Token: 0x060081CD RID: 33229 RVA: 0x001B87BC File Offset: 0x001B69BC
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

	// Token: 0x060081CE RID: 33230 RVA: 0x001B8800 File Offset: 0x001B6A00
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

	// Token: 0x17000B29 RID: 2857
	// (get) Token: 0x060081CF RID: 33231 RVA: 0x001B888E File Offset: 0x001B6A8E
	public static InviteNewbieModel Instance
	{
		get
		{
			return InviteNewbieModel._Instance;
		}
	}

	// Token: 0x060081D0 RID: 33232 RVA: 0x001B8895 File Offset: 0x001B6A95
	public static InviteNewbieModel GetOrCreateInstance()
	{
		if (InviteNewbieModel._Instance == null)
		{
			InviteNewbieModel.CreateInstance();
		}
		return InviteNewbieModel._Instance;
	}

	// Token: 0x060081D1 RID: 33233 RVA: 0x001B88A9 File Offset: 0x001B6AA9
	public static bool CreateInstance()
	{
		if (InviteNewbieModel._Instance != null)
		{
			return true;
		}
		InviteNewbieModel._Instance = new InviteNewbieModel();
		return true;
	}

	// Token: 0x060081D2 RID: 33234 RVA: 0x001B88BF File Offset: 0x001B6ABF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060081D3 RID: 33235 RVA: 0x001B88C1 File Offset: 0x001B6AC1
	public static void ResetStaticDefaultValue()
	{
		InviteNewbieModel._Instance = null;
	}

	// Token: 0x060081D4 RID: 33236 RVA: 0x001B88C9 File Offset: 0x001B6AC9
	static InviteNewbieModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InviteNewbieModel.CreateStaticDefaultValue), new Action(InviteNewbieModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003ABE RID: 15038
	[Nullable(2)]
	public string GmUrl;

	// Token: 0x04003ABF RID: 15039
	[Nullable(2)]
	private InviteNewbieProtocolContext ProtocolContext;

	// Token: 0x04003AC0 RID: 15040
	[Nullable(2)]
	private static InviteNewbieModel _Instance;
}
