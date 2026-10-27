using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021D6 RID: 8662
[NullableContext(1)]
[Nullable(0)]
public class MailTotalDropDownItem : MailDropDownItem
{
	// Token: 0x06010DD3 RID: 69075 RVA: 0x0041A40C File Offset: 0x0041860C
	public MailTotalDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010DD4 RID: 69076 RVA: 0x0041A418 File Offset: 0x00418618
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

	// Token: 0x06010DD5 RID: 69077 RVA: 0x0041A47C File Offset: 0x0041867C
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

	// Token: 0x06010DD6 RID: 69078 RVA: 0x0041A531 File Offset: 0x00418731
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
