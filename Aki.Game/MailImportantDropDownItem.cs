using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021D5 RID: 8661
[NullableContext(1)]
[Nullable(0)]
public class MailImportantDropDownItem : MailDropDownItem
{
	// Token: 0x06010DCF RID: 69071 RVA: 0x0041A354 File Offset: 0x00418554
	public MailImportantDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010DD0 RID: 69072 RVA: 0x0041A360 File Offset: 0x00418560
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

	// Token: 0x06010DD1 RID: 69073 RVA: 0x0041A3C4 File Offset: 0x004185C4
	public override string GetTitleText()
	{
		return this.GetFilteredMailList().Length.ToString();
	}

	// Token: 0x06010DD2 RID: 69074 RVA: 0x0041A3E1 File Offset: 0x004185E1
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
