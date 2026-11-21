using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016BB RID: 5819
[NullableContext(1)]
[Nullable(0)]
public class MailUnReadDropDownItem : MailDropDownItem
{
	// Token: 0x0600E268 RID: 57960 RVA: 0x00426E3C File Offset: 0x0042503C
	public MailUnReadDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600E269 RID: 57961 RVA: 0x00426E48 File Offset: 0x00425048
	public override MailData[] GetFilteredMailList()
	{
		List<MailData> unScanMails = MailModel.Instance.GetUnScanMails(null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：获取未读邮件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("length", (unScanMails != null) ? new int?(unScanMails.Count) : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return unScanMails.ToArray();
	}

	// Token: 0x0600E26A RID: 57962 RVA: 0x00426EAC File Offset: 0x004250AC
	public override string GetTitleText()
	{
		return this.GetFilteredMailList().Length.ToString();
	}

	// Token: 0x0600E26B RID: 57963 RVA: 0x00426EC9 File Offset: 0x004250C9
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
