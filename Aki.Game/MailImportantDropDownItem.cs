using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016B9 RID: 5817
[NullableContext(1)]
[Nullable(0)]
public class MailImportantDropDownItem : MailDropDownItem
{
	// Token: 0x0600E260 RID: 57952 RVA: 0x00426C34 File Offset: 0x00424E34
	public MailImportantDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600E261 RID: 57953 RVA: 0x00426C40 File Offset: 0x00424E40
	public override MailData[] GetFilteredMailList()
	{
		List<MailData> importantMails = MailModel.Instance.GetImportantMails(null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：获取重要邮件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("length", (importantMails != null) ? new int?(importantMails.Count) : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return importantMails.ToArray();
	}

	// Token: 0x0600E262 RID: 57954 RVA: 0x00426CA4 File Offset: 0x00424EA4
	public override string GetTitleText()
	{
		return this.GetFilteredMailList().Length.ToString();
	}

	// Token: 0x0600E263 RID: 57955 RVA: 0x00426CC1 File Offset: 0x00424EC1
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
