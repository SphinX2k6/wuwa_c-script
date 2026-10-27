using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021D7 RID: 8663
[NullableContext(1)]
[Nullable(0)]
public class MailUnReadDropDownItem : MailDropDownItem
{
	// Token: 0x06010DD7 RID: 69079 RVA: 0x0041A55C File Offset: 0x0041875C
	public MailUnReadDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010DD8 RID: 69080 RVA: 0x0041A568 File Offset: 0x00418768
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

	// Token: 0x06010DD9 RID: 69081 RVA: 0x0041A5CC File Offset: 0x004187CC
	public override string GetTitleText()
	{
		return this.GetFilteredMailList().Length.ToString();
	}

	// Token: 0x06010DDA RID: 69082 RVA: 0x0041A5E9 File Offset: 0x004187E9
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
