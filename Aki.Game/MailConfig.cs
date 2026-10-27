using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020021C9 RID: 8649
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MailConfig : ConfigBase
{
	// Token: 0x06010CE7 RID: 68839 RVA: 0x00415237 File Offset: 0x00413437
	public int? GetMailSize()
	{
		return ConfigCommonParamById.GetIntConfig("mail_size");
	}

	// Token: 0x06010CE8 RID: 68840 RVA: 0x00415243 File Offset: 0x00413443
	public int? GetFavoriteMailSize()
	{
		return ConfigCommonParamById.GetIntConfig("MailFavoriteSize");
	}

	// Token: 0x06010CE9 RID: 68841 RVA: 0x00415250 File Offset: 0x00413450
	public int GetMailSpaceWarningThresholdRate()
	{
		return ConfigCommonParamById.GetIntConfig("MailWarningThreshold").GetValueOrDefault();
	}

	// Token: 0x06010CEA RID: 68842 RVA: 0x00415270 File Offset: 0x00413470
	public int GetMailSpaceWarningThreshold()
	{
		double valueOrDefault = (double)this.GetMailSize().GetValueOrDefault();
		int mailSpaceWarningThresholdRate = this.GetMailSpaceWarningThresholdRate();
		return (int)Math.Floor(valueOrDefault * (double)mailSpaceWarningThresholdRate / 100.0);
	}

	// Token: 0x06010CEB RID: 68843 RVA: 0x004152A8 File Offset: 0x004134A8
	public IReadOnlyList<MailFilter> GetAllMailFilterConfig()
	{
		IReadOnlyList<MailFilter> configList = ConfigMailFilterAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return new List<MailFilter>();
	}

	// Token: 0x06010CEC RID: 68844 RVA: 0x004152C8 File Offset: 0x004134C8
	public EMailFilter[] GetFilterTypeList()
	{
		HashSet<EMailFilter> hashSet = new HashSet<EMailFilter>();
		foreach (MailFilter mailFilter in this.GetAllMailFilterConfig())
		{
			EMailFilter id = (EMailFilter)mailFilter.Id;
			if (id != EMailFilter.FilterUnScanned)
			{
				hashSet.Add(id);
			}
		}
		List<EMailFilter> list = new List<EMailFilter>();
		foreach (EMailFilter item in MailFilterDisplayOrder.mailFilterDisplayOrder)
		{
			if (hashSet.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06010CED RID: 68845 RVA: 0x0041536C File Offset: 0x0041356C
	public MailFilter GetMailFilterConfigById(int id)
	{
		MailFilter? config = ConfigMailFilterById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Mail;
			ELogAuthor author = ELogAuthor.LK;
			string message = "缺少邮件筛选配置 ID:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x06010CEE RID: 68846 RVA: 0x004153C0 File Offset: 0x004135C0
	public MailTo? GetMailToConfigById(int id)
	{
		if (id <= 0)
		{
			return null;
		}
		return ConfigMailToById.GetConfig(id, true);
	}

	// Token: 0x06010CEF RID: 68847 RVA: 0x004153E4 File Offset: 0x004135E4
	public void ApplyTemplateJumpId(MailData mailData)
	{
		if (mailData.GetSubContentJumpId() > 0)
		{
			return;
		}
		Mail? mail = (mailData.ConfigId > 0) ? ConfigMailByMailId.GetConfig(mailData.ConfigId, true) : null;
		if (mail != null && mail.Value.JumpId > 0)
		{
			mailData.SetShowSubContentJumpId(mail.Value.JumpId);
		}
	}

	// Token: 0x17001559 RID: 5465
	// (get) Token: 0x06010CF0 RID: 68848 RVA: 0x0041544C File Offset: 0x0041364C
	public static MailConfig Instance
	{
		get
		{
			return MailConfig._Instance;
		}
	}

	// Token: 0x06010CF1 RID: 68849 RVA: 0x00415453 File Offset: 0x00413653
	public static MailConfig GetOrCreateInstance()
	{
		if (MailConfig._Instance == null)
		{
			MailConfig.CreateInstance();
		}
		return MailConfig._Instance;
	}

	// Token: 0x06010CF2 RID: 68850 RVA: 0x00415467 File Offset: 0x00413667
	public static bool CreateInstance()
	{
		if (MailConfig._Instance != null)
		{
			return true;
		}
		MailConfig._Instance = new MailConfig();
		return true;
	}

	// Token: 0x06010CF3 RID: 68851 RVA: 0x0041547D File Offset: 0x0041367D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010CF4 RID: 68852 RVA: 0x0041547F File Offset: 0x0041367F
	public static void ResetStaticDefaultValue()
	{
		MailConfig._Instance = null;
	}

	// Token: 0x06010CF5 RID: 68853 RVA: 0x00415487 File Offset: 0x00413687
	static MailConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailConfig.CreateStaticDefaultValue), new Action(MailConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007FD2 RID: 32722
	[Nullable(2)]
	private static MailConfig _Instance;
}
