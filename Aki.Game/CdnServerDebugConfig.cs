using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F42 RID: 3906
[NullableContext(1)]
[Nullable(0)]
public class CdnServerDebugConfig : Singleton
{
	// Token: 0x06009C17 RID: 39959 RVA: 0x002E434F File Offset: 0x002E254F
	[NullableContext(2)]
	public string TryGetMarqueeDebugUrl(string normalHttp)
	{
		if (this.IsOpenDebug)
		{
			return PublicUtil.Instance.GetMarqueeUrl2(PublicUtil.Instance.GetGameId(), this.Address.MarqueeServerId);
		}
		return normalHttp;
	}

	// Token: 0x06009C18 RID: 39960 RVA: 0x002E437C File Offset: 0x002E257C
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

	// Token: 0x06009C19 RID: 39961 RVA: 0x002E43DC File Offset: 0x002E25DC
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

	// Token: 0x06009C1A RID: 39962 RVA: 0x002E443C File Offset: 0x002E263C
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

	// Token: 0x06009C1B RID: 39963 RVA: 0x002E449C File Offset: 0x002E269C
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

	// Token: 0x17001093 RID: 4243
	// (get) Token: 0x06009C1C RID: 39964 RVA: 0x002E44B9 File Offset: 0x002E26B9
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

	// Token: 0x06009C1D RID: 39965 RVA: 0x002E44DC File Offset: 0x002E26DC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009C1E RID: 39966 RVA: 0x002E44DE File Offset: 0x002E26DE
	public static void ResetStaticDefaultValue()
	{
		CdnServerDebugConfig instance = CdnServerDebugConfig._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CdnServerDebugConfig._instance = null;
	}

	// Token: 0x06009C1F RID: 39967 RVA: 0x002E44F7 File Offset: 0x002E26F7
	static CdnServerDebugConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CdnServerDebugConfig.CreateStaticDefaultValue), new Action(CdnServerDebugConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005D29 RID: 23849
	private bool IsOpenDebug;

	// Token: 0x04005D2A RID: 23850
	[Nullable(2)]
	private ICdnServerAddress Address;

	// Token: 0x04005D2B RID: 23851
	[Nullable(2)]
	private static CdnServerDebugConfig _instance;
}
