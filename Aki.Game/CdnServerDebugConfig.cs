using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A83 RID: 6787
[NullableContext(1)]
[Nullable(0)]
public class CdnServerDebugConfig : Singleton
{
	// Token: 0x0600C807 RID: 51207 RVA: 0x002D9233 File Offset: 0x002D7433
	[NullableContext(2)]
	public string TryGetMarqueeDebugUrl(string normalHttp)
	{
		if (this.IsOpenDebug)
		{
			return PublicUtil.Instance.GetMarqueeUrl2(PublicUtil.Instance.GetGameId(), this.Address.MarqueeServerId);
		}
		return normalHttp;
	}

	// Token: 0x0600C808 RID: 51208 RVA: 0x002D9260 File Offset: 0x002D7460
	public string TryGetGachaDetailDebugUrl(string urlPattern, string prefix, string serverId)
	{
		if (this.IsOpenDebug)
		{
			string[] array = new string[2];
			int num = 0;
			ICdnServerAddress address = this.Address;
			array[num] = ((address != null) ? address.GachaDetailServerAddressPrefix : null);
			int num2 = 1;
			ICdnServerAddress address2 = this.Address;
			array[num2] = ((address2 != null) ? address2.GachaDetailServerId : null);
			return StringUtils.Format(urlPattern, array);
		}
		return StringUtils.Format(urlPattern, new string[]
		{
			prefix,
			serverId
		});
	}

	// Token: 0x0600C809 RID: 51209 RVA: 0x002D92C0 File Offset: 0x002D74C0
	public string TryGetGachaRecordDebugUrl(string urlPattern, string prefix, string serverId)
	{
		if (this.IsOpenDebug)
		{
			string[] array = new string[2];
			int num = 0;
			ICdnServerAddress address = this.Address;
			array[num] = ((address != null) ? address.GachaRecordServerAddressPrefix : null);
			int num2 = 1;
			ICdnServerAddress address2 = this.Address;
			array[num2] = ((address2 != null) ? address2.GachaRecordServerId : null);
			return StringUtils.Format(urlPattern, array);
		}
		return StringUtils.Format(urlPattern, new string[]
		{
			prefix,
			serverId
		});
	}

	// Token: 0x0600C80A RID: 51210 RVA: 0x002D9320 File Offset: 0x002D7520
	public string TryGetGachaInfoDebugUrl(string urlPattern, string prefix, string serverId)
	{
		if (this.IsOpenDebug)
		{
			string[] array = new string[2];
			int num = 0;
			ICdnServerAddress address = this.Address;
			array[num] = ((address != null) ? address.GachaInfoServerPrefixAddress : null);
			int num2 = 1;
			ICdnServerAddress address2 = this.Address;
			array[num2] = ((address2 != null) ? address2.GachaInfoServerId : null);
			return StringUtils.Format(urlPattern, array);
		}
		return StringUtils.Format(urlPattern, new string[]
		{
			prefix,
			serverId
		});
	}

	// Token: 0x0600C80B RID: 51211 RVA: 0x002D9380 File Offset: 0x002D7580
	[return: Nullable(2)]
	public string TryGetNoticeServerPrefixAddress(string cdn)
	{
		if (!this.IsOpenDebug)
		{
			return cdn;
		}
		ICdnServerAddress address = this.Address;
		if (address == null)
		{
			return null;
		}
		return address.NoticeServerPrefixAddress;
	}

	// Token: 0x1700106E RID: 4206
	// (get) Token: 0x0600C80C RID: 51212 RVA: 0x002D939D File Offset: 0x002D759D
	public static CdnServerDebugConfig Instance
	{
		get
		{
			if (CdnServerDebugConfig._instance == null)
			{
				CdnServerDebugConfig._instance = new CdnServerDebugConfig();
				CdnServerDebugConfig._instance.OnInit();
			}
			return CdnServerDebugConfig._instance;
		}
	}

	// Token: 0x0600C80D RID: 51213 RVA: 0x002D93C0 File Offset: 0x002D75C0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C80E RID: 51214 RVA: 0x002D93C2 File Offset: 0x002D75C2
	public static void ResetStaticDefaultValue()
	{
		CdnServerDebugConfig instance = CdnServerDebugConfig._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CdnServerDebugConfig._instance = null;
	}

	// Token: 0x0600C80F RID: 51215 RVA: 0x002D93DB File Offset: 0x002D75DB
	static CdnServerDebugConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CdnServerDebugConfig.CreateStaticDefaultValue), new Action(CdnServerDebugConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005C5A RID: 23642
	private bool IsOpenDebug;

	// Token: 0x04005C5B RID: 23643
	[Nullable(2)]
	private ICdnServerAddress Address;

	// Token: 0x04005C5C RID: 23644
	[Nullable(2)]
	private static CdnServerDebugConfig _instance;
}
