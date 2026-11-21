using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016BA RID: 5818
[NullableContext(1)]
[Nullable(0)]
public class MailTotalDropDownItem : MailDropDownItem
{
	// Token: 0x0600E264 RID: 57956 RVA: 0x00426CEC File Offset: 0x00424EEC
	public MailTotalDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600E265 RID: 57957 RVA: 0x00426CF8 File Offset: 0x00424EF8
	public override MailData[] GetFilteredMailList()
	{
		List<MailData> mailList = MailModel.Instance.GetMailList();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：获取全部邮件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("length", (mailList != null) ? new int?(mailList.Count) : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return mailList.ToArray();
	}

	// Token: 0x0600E266 RID: 57958 RVA: 0x00426D5C File Offset: 0x00424F5C
	public override string GetTitleText()
	{
		int mailListLength = MailModel.Instance.GetMailListLength();
		int mailCapacity = MailModel.Instance.GetMailCapacity();
		if (MailModel.Instance.IsMailSpaceNearFull())
		{
			return StringUtils.Format("<color=#c25757>{0}</color>/{1}", new string[]
			{
				mailListLength.ToString(),
				mailCapacity.ToString()
			});
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Email_Inbox_Number", null);
		if (string.IsNullOrEmpty(localTextNew))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(mailListLength);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(mailCapacity);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return StringUtils.Format(localTextNew, new string[]
		{
			mailListLength.ToString(),
			mailCapacity.ToString()
		});
	}

	// Token: 0x0600E267 RID: 57959 RVA: 0x00426E11 File Offset: 0x00425011
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
