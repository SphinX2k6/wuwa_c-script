using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020016AF RID: 5807
[NullableContext(1)]
[Nullable(0)]
public class MailData : ScrollViewDataBase
{
	// Token: 0x0600E1AD RID: 57773 RVA: 0x00422F56 File Offset: 0x00421156
	public EMailAttachment GetAttachmentStatus()
	{
		return this.AttachmentStatus;
	}

	// Token: 0x0600E1AE RID: 57774 RVA: 0x00422F60 File Offset: 0x00421160
	public unsafe void SetAttachmentStatus(EMailAttachment attachmentStatus)
	{
		this.AttachmentStatus = attachmentStatus;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件详情：设置附件领取状态";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MailId", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("attachmentStatus", attachmentStatus);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600E1AF RID: 57775 RVA: 0x00422FD1 File Offset: 0x004211D1
	public bool GetWasScanned()
	{
		return this.MailScannedState == 1;
	}

	// Token: 0x0600E1B0 RID: 57776 RVA: 0x00422FDC File Offset: 0x004211DC
	public unsafe void SetWasScanned(int scanned)
	{
		this.MailScannedState = ((scanned == 1) ? scanned : 0);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件详情：设置阅读状态";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MailId", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("scanned", scanned);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600E1B1 RID: 57777 RVA: 0x00423054 File Offset: 0x00421254
	public void SetShowSubIconId(int iconId)
	{
		this.ShowSubIconId = iconId;
	}

	// Token: 0x0600E1B2 RID: 57778 RVA: 0x0042305D File Offset: 0x0042125D
	public void SetShowSubContentColor(string color)
	{
		this.ShowSubContentColor = color;
	}

	// Token: 0x0600E1B3 RID: 57779 RVA: 0x00423066 File Offset: 0x00421266
	public void SetShowSubContentJumpId(int jumpId)
	{
		this.ShowSubContentJumpId = jumpId;
	}

	// Token: 0x0600E1B4 RID: 57780 RVA: 0x0042306F File Offset: 0x0042126F
	public void SetShowSubContentJumpParam(int jumpParam)
	{
		this.ShowSubContentJumpParam = jumpParam;
	}

	// Token: 0x0600E1B5 RID: 57781 RVA: 0x00423078 File Offset: 0x00421278
	public void SetShowSubContentJumpParam2(int jumpParam2)
	{
		this.ShowSubContentJumpParam2 = jumpParam2;
	}

	// Token: 0x0600E1B6 RID: 57782 RVA: 0x00423081 File Offset: 0x00421281
	public void SetQuestionActiveId(string questionId)
	{
		this.QuestionActiveId = questionId;
	}

	// Token: 0x0600E1B7 RID: 57783 RVA: 0x0042308A File Offset: 0x0042128A
	public void SetSubTitle(string title)
	{
		this.SubTitle = title;
	}

	// Token: 0x0600E1B8 RID: 57784 RVA: 0x00423093 File Offset: 0x00421293
	public void SetSubUrl(string url)
	{
		this.SubUrl = url;
	}

	// Token: 0x0600E1B9 RID: 57785 RVA: 0x0042309C File Offset: 0x0042129C
	public void SetIsQuestion(bool isQuestion)
	{
		this.IsQuestion = isQuestion;
	}

	// Token: 0x0600E1BA RID: 57786 RVA: 0x004230A5 File Offset: 0x004212A5
	public void SetIfShowNewMail(bool show)
	{
		this.IfShowNewMail = show;
	}

	// Token: 0x0600E1BB RID: 57787 RVA: 0x004230AE File Offset: 0x004212AE
	public void SetUseDefaultBrowser(bool use)
	{
		this.UseDefaultBrowser = use;
	}

	// Token: 0x0600E1BC RID: 57788 RVA: 0x004230B7 File Offset: 0x004212B7
	public void SetQuestionPass(string pass)
	{
		this.QuestionPass = pass;
	}

	// Token: 0x0600E1BD RID: 57789 RVA: 0x004230C0 File Offset: 0x004212C0
	public void SetIfLandscape(bool landscape)
	{
		this.IfLandscape = landscape;
	}

	// Token: 0x0600E1BE RID: 57790 RVA: 0x004230C9 File Offset: 0x004212C9
	public void SetNeedPlayerInfo(bool need)
	{
		this.NeedPlayerInfo = need;
	}

	// Token: 0x0600E1BF RID: 57791 RVA: 0x004230D2 File Offset: 0x004212D2
	public void SetPlayerInfoFormatStyle(int style)
	{
		this.PlayerInfoFormatStyle = style;
	}

	// Token: 0x0600E1C0 RID: 57792 RVA: 0x004230DB File Offset: 0x004212DB
	public int GetReceiveTime()
	{
		return this.Time;
	}

	// Token: 0x0600E1C1 RID: 57793 RVA: 0x004230E3 File Offset: 0x004212E3
	public int GetMailLevel()
	{
		return this.Level;
	}

	// Token: 0x0600E1C2 RID: 57794 RVA: 0x004230EB File Offset: 0x004212EB
	public string GetTitle()
	{
		return this.Title;
	}

	// Token: 0x0600E1C3 RID: 57795 RVA: 0x004230F4 File Offset: 0x004212F4
	public void SetText(string text)
	{
		this.Content = text;
		string[] array = text.Split(new string[]
		{
			"@&&"
		}, StringSplitOptions.None);
		this.ShowMainContent = array[0];
		if (array.Length > 1)
		{
			this.PhraseExtraItem(array[1]);
		}
	}

	// Token: 0x0600E1C4 RID: 57796 RVA: 0x00423138 File Offset: 0x00421338
	private void PhraseExtraItem(string subText)
	{
		this.ShowSubContentColor = "FFFFFFFF";
		this.ShowSubIconId = 0;
		this.ShowSubContentJumpId = 0;
		this.ShowSubContentJumpParam = 0;
		this.ShowSubContentJumpParam2 = 0;
		this.SubUrl = "";
		this.IsQuestion = false;
		this.QuestionActiveId = "";
		this.ShowSubContent = "";
		List<string> list = NoLinq.OrderByDescendingToList<string, int>(MailParamHandlerDefine.mailParamHandlerMapDefine.Keys, (string key) => key.Length);
		List<string> list2 = new List<string>(list.Count);
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(Regex.Escape(list[i]));
		}
		string str = string.Join("|", list2);
		string[] array = new Regex("[,\\s;]+(?=(?:" + str + ")(?:=|[,\\s;]|$))").Split(subText);
		List<string> list3 = new List<string>(array.Length);
		for (int j = 0; j < array.Length; j++)
		{
			if (array[j].Length > 0)
			{
				list3.Add(array[j]);
			}
		}
		foreach (string text in list3)
		{
			int num = text.IndexOf('=');
			string key2 = (num != -1) ? text.Substring(0, num) : text;
			IMailParamHandler mailParamHandler;
			if (MailParamHandlerDefine.mailParamHandlerMapDefine.TryGetValue(key2, out mailParamHandler))
			{
				string value = (num != -1) ? text.Substring(num + 1) : "";
				mailParamHandler.Handler(this, value);
			}
			else
			{
				this.ShowSubContent += text;
			}
		}
	}

	// Token: 0x0600E1C5 RID: 57797 RVA: 0x004232F8 File Offset: 0x004214F8
	public bool GetIfLandscape()
	{
		return this.IfLandscape;
	}

	// Token: 0x0600E1C6 RID: 57798 RVA: 0x00423300 File Offset: 0x00421500
	public bool GetUseDefaultBrowser()
	{
		return this.UseDefaultBrowser;
	}

	// Token: 0x0600E1C7 RID: 57799 RVA: 0x00423308 File Offset: 0x00421508
	public bool GetIfShowNewMail()
	{
		return this.IfShowNewMail;
	}

	// Token: 0x0600E1C8 RID: 57800 RVA: 0x00423310 File Offset: 0x00421510
	public string GetText()
	{
		return this.ShowMainContent;
	}

	// Token: 0x0600E1C9 RID: 57801 RVA: 0x00423318 File Offset: 0x00421518
	public string GetSubText()
	{
		return this.ShowSubContent;
	}

	// Token: 0x0600E1CA RID: 57802 RVA: 0x00423320 File Offset: 0x00421520
	public string GetQuestionPass()
	{
		return this.QuestionPass;
	}

	// Token: 0x0600E1CB RID: 57803 RVA: 0x00423328 File Offset: 0x00421528
	public int GetSubTextIconId()
	{
		return this.ShowSubIconId;
	}

	// Token: 0x0600E1CC RID: 57804 RVA: 0x00423330 File Offset: 0x00421530
	public string GetSubTextColor()
	{
		return this.ShowSubContentColor;
	}

	// Token: 0x0600E1CD RID: 57805 RVA: 0x00423338 File Offset: 0x00421538
	public bool IsQuestionMail()
	{
		return this.IsQuestion;
	}

	// Token: 0x0600E1CE RID: 57806 RVA: 0x00423340 File Offset: 0x00421540
	public string GetQuestionUrl()
	{
		LoginModel instance = LoginModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		string stringConfig = ConfigCommonParamById.GetStringConfig("mail_question_key");
		string[] array = new string[5];
		array[0] = this.QuestionActiveId;
		int num = 1;
		int? id = instance2.GetId();
		array[num] = ((id != null) ? id.GetValueOrDefault().ToString() : null);
		array[2] = ";";
		int num2 = 3;
		string serverId = instance.GetServerId();
		array[num2] = ((serverId != null) ? serverId.ToString() : null);
		array[4] = stringConfig;
		string text = string.Concat(array);
		text = UKuroStaticLibrary.HashStringWithSHA1(text);
		int questionnaireId = LanguageConfig.Instance.GetLanguageDefineByLanguageCode(LanguageSystem.Instance.PackageLanguage).Value.QuestionnaireId;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 5);
		defaultInterpolatedStringHandler.AppendFormatted(this.SubUrl);
		defaultInterpolatedStringHandler.AppendLiteral("?sojumpparm=");
		id = instance2.GetId();
		defaultInterpolatedStringHandler.AppendFormatted((id != null) ? id.GetValueOrDefault().ToString() : null);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		string serverId2 = instance.GetServerId();
		defaultInterpolatedStringHandler.AppendFormatted((serverId2 != null) ? serverId2.ToString() : null);
		defaultInterpolatedStringHandler.AppendLiteral("&parmsign=");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		defaultInterpolatedStringHandler.AppendLiteral("&langv=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(questionnaireId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600E1CF RID: 57807 RVA: 0x00423494 File Offset: 0x00421694
	public string GetSubUrl()
	{
		string text = this.SubUrl;
		if (this.NeedPlayerInfo)
		{
			PublicUtil.EExternalUrlReason reason = (this.PlayerInfoFormatStyle == 0) ? PublicUtil.EExternalUrlReason.Mail : PublicUtil.EExternalUrlReason.MailH5;
			text = (PublicUtil.Instance.GetExternalUrl(text, reason) ?? text);
			text = PublicUtil.Instance.GetExtendExternalUrl(text, !this.UseDefaultBrowser);
		}
		return text;
	}

	// Token: 0x0600E1D0 RID: 57808 RVA: 0x004234E5 File Offset: 0x004216E5
	public string GetSubTitle()
	{
		return this.SubTitle;
	}

	// Token: 0x0600E1D1 RID: 57809 RVA: 0x004234ED File Offset: 0x004216ED
	public string GetLinkButtonTitle()
	{
		if (this.ShowSubContent.Length > 0)
		{
			return this.ShowSubContent;
		}
		return this.SubTitle;
	}

	// Token: 0x0600E1D2 RID: 57810 RVA: 0x0042350A File Offset: 0x0042170A
	public int GetSubContentJumpId()
	{
		return this.ShowSubContentJumpId;
	}

	// Token: 0x0600E1D3 RID: 57811 RVA: 0x00423512 File Offset: 0x00421712
	public int GetSubContentJumpParam()
	{
		return this.ShowSubContentJumpParam;
	}

	// Token: 0x0600E1D4 RID: 57812 RVA: 0x0042351A File Offset: 0x0042171A
	public int GetSubContentJumpParam2()
	{
		return this.ShowSubContentJumpParam2;
	}

	// Token: 0x0600E1D5 RID: 57813 RVA: 0x00423522 File Offset: 0x00421722
	public string GetSender()
	{
		return this.Sender;
	}

	// Token: 0x0600E1D6 RID: 57814 RVA: 0x0042352A File Offset: 0x0042172A
	public PbMailAttachment[] GetAttachmentInfo()
	{
		return this.AttachmentInfos;
	}

	// Token: 0x0600E1D7 RID: 57815 RVA: 0x00423532 File Offset: 0x00421732
	public long GetExpiryTime()
	{
		return this.ExpiryTime;
	}

	// Token: 0x0600E1D8 RID: 57816 RVA: 0x0042353C File Offset: 0x0042173C
	public bool IsPastScheduledDeletionTime()
	{
		if (!this.IsIntervalMail)
		{
			return false;
		}
		long num = (this.IntervalExpiryTime > 0L) ? this.IntervalExpiryTime : this.ExpiryTime;
		return num > 0L && TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond >= (double)num;
	}

	// Token: 0x0600E1D9 RID: 57817 RVA: 0x00423590 File Offset: 0x00421790
	public bool NeedExpiredUnfavoriteConfirm()
	{
		return this.IsIntervalMail && this.IsFavorite && this.IsPastScheduledDeletionTime();
	}

	// Token: 0x0600E1DA RID: 57818 RVA: 0x004235AA File Offset: 0x004217AA
	public bool CanShowFavoriteControl()
	{
		return this.GetWasScanned() && this.GetAttachmentStatus() != EMailAttachment.AttachmentRemained;
	}

	// Token: 0x0600E1DB RID: 57819 RVA: 0x004235C2 File Offset: 0x004217C2
	public void SetFavorite(bool isFavorite)
	{
		this.IsFavorite = isFavorite;
	}

	// Token: 0x0600E1DC RID: 57820 RVA: 0x004235CB File Offset: 0x004217CB
	public void SetAddReason(int reason)
	{
		this.AddReason = reason;
	}

	// Token: 0x0600E1DD RID: 57821 RVA: 0x004235D4 File Offset: 0x004217D4
	public int GetAddReason()
	{
		return this.AddReason;
	}

	// Token: 0x0400811B RID: 33051
	public string Id = "0";

	// Token: 0x0400811C RID: 33052
	public int ConfigId;

	// Token: 0x0400811D RID: 33053
	public int Time;

	// Token: 0x0400811E RID: 33054
	public int FinishTime;

	// Token: 0x0400811F RID: 33055
	public int Level = 1;

	// Token: 0x04008120 RID: 33056
	public string Title = "";

	// Token: 0x04008121 RID: 33057
	public string Content = "";

	// Token: 0x04008122 RID: 33058
	public string Sender = "";

	// Token: 0x04008123 RID: 33059
	public long ExpiryTime;

	// Token: 0x04008124 RID: 33060
	public bool IsIntervalMail;

	// Token: 0x04008125 RID: 33061
	public long IntervalExpiryTime;

	// Token: 0x04008126 RID: 33062
	public PbMailAttachment[] AttachmentInfos = new PbMailAttachment[0];

	// Token: 0x04008127 RID: 33063
	public long ReadTime;

	// Token: 0x04008128 RID: 33064
	private EMailAttachment AttachmentStatus;

	// Token: 0x04008129 RID: 33065
	private int MailScannedState;

	// Token: 0x0400812A RID: 33066
	private string ShowMainContent = "";

	// Token: 0x0400812B RID: 33067
	private string ShowSubContent = "";

	// Token: 0x0400812C RID: 33068
	private int ShowSubIconId;

	// Token: 0x0400812D RID: 33069
	private string ShowSubContentColor = "";

	// Token: 0x0400812E RID: 33070
	private int ShowSubContentJumpId;

	// Token: 0x0400812F RID: 33071
	private int ShowSubContentJumpParam;

	// Token: 0x04008130 RID: 33072
	private int ShowSubContentJumpParam2;

	// Token: 0x04008131 RID: 33073
	private string QuestionActiveId = "";

	// Token: 0x04008132 RID: 33074
	private string SubTitle = "";

	// Token: 0x04008133 RID: 33075
	private string SubUrl = "";

	// Token: 0x04008134 RID: 33076
	private bool IsQuestion;

	// Token: 0x04008135 RID: 33077
	private bool IfShowNewMail;

	// Token: 0x04008136 RID: 33078
	private bool UseDefaultBrowser;

	// Token: 0x04008137 RID: 33079
	private string QuestionPass = "";

	// Token: 0x04008138 RID: 33080
	private bool IfLandscape = true;

	// Token: 0x04008139 RID: 33081
	private bool NeedPlayerInfo;

	// Token: 0x0400813A RID: 33082
	private int PlayerInfoFormatStyle;

	// Token: 0x0400813B RID: 33083
	public bool IsFavorite;

	// Token: 0x0400813C RID: 33084
	private int AddReason;
}
