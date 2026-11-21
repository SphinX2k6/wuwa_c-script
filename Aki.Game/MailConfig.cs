using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020016AD RID: 5805
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MailConfig : ConfigBase
{
	// Token: 0x0600E178 RID: 57720 RVA: 0x00421B17 File Offset: 0x0041FD17
	public int? GetMailSize()
	{
		return ConfigCommonParamById.GetIntConfig("mail_size");
	}

	// Token: 0x0600E179 RID: 57721 RVA: 0x00421B23 File Offset: 0x0041FD23
	public int? GetFavoriteMailSize()
	{
		return ConfigCommonParamById.GetIntConfig("MailFavoriteSize");
	}

	// Token: 0x0600E17A RID: 57722 RVA: 0x00421B30 File Offset: 0x0041FD30
	public int GetMailSpaceWarningThresholdRate()
	{
		return ConfigCommonParamById.GetIntConfig("MailWarningThreshold").GetValueOrDefault();
	}

	// Token: 0x0600E17B RID: 57723 RVA: 0x00421B50 File Offset: 0x0041FD50
	public int GetMailSpaceWarningThreshold()
	{
		double valueOrDefault = (double)this.GetMailSize().GetValueOrDefault();
		int mailSpaceWarningThresholdRate = this.GetMailSpaceWarningThresholdRate();
		return (int)Math.Floor(valueOrDefault * (double)mailSpaceWarningThresholdRate / 100.0);
	}

	// Token: 0x0600E17C RID: 57724 RVA: 0x00421B88 File Offset: 0x0041FD88
	public IReadOnlyList<MailFilter> GetAllMailFilterConfig()
	{
		IReadOnlyList<MailFilter> configList = ConfigMailFilterAll.GetConfigList(true);
		if (configList != null)
		{
			return configList;
		}
		return new List<MailFilter>();
	}

	// Token: 0x0600E17D RID: 57725 RVA: 0x00421BA8 File Offset: 0x0041FDA8
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

	// Token: 0x0600E17E RID: 57726 RVA: 0x00421C4C File Offset: 0x0041FE4C
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

	// Token: 0x0600E17F RID: 57727 RVA: 0x00421CA0 File Offset: 0x0041FEA0
	public MailTo? GetMailToConfigById(int id)
	{
		if (id <= 0)
		{
			return null;
		}
		return ConfigMailToById.GetConfig(id, true);
	}

	// Token: 0x0600E180 RID: 57728 RVA: 0x00421CC4 File Offset: 0x0041FEC4
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

	// Token: 0x17001590 RID: 5520
	// (get) Token: 0x0600E181 RID: 57729 RVA: 0x00421D2C File Offset: 0x0041FF2C
	public static MailConfig Instance
	{
		get
		{
			return MailConfig._Instance;
		}
	}

	// Token: 0x0600E182 RID: 57730 RVA: 0x00421D33 File Offset: 0x0041FF33
	public static MailConfig GetOrCreateInstance()
	{
		if (MailConfig._Instance == null)
		{
			MailConfig.CreateInstance();
		}
		return MailConfig._Instance;
	}

	// Token: 0x0600E183 RID: 57731 RVA: 0x00421D47 File Offset: 0x0041FF47
	public static bool CreateInstance()
	{
		if (MailConfig._Instance != null)
		{
			return true;
		}
		MailConfig._Instance = new MailConfig();
		return true;
	}

	// Token: 0x0600E184 RID: 57732 RVA: 0x00421D5D File Offset: 0x0041FF5D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E185 RID: 57733 RVA: 0x00421D5F File Offset: 0x0041FF5F
	public static void ResetStaticDefaultValue()
	{
		MailConfig._Instance = null;
	}

	// Token: 0x0600E186 RID: 57734 RVA: 0x00421D67 File Offset: 0x0041FF67
	static MailConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailConfig.CreateStaticDefaultValue), new Action(MailConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008119 RID: 33049
	[Nullable(2)]
	private static MailConfig _Instance;
}
