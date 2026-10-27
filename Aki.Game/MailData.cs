using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020021CB RID: 8651
[NullableContext(1)]
[Nullable(0)]
public class MailData : ScrollViewDataBase
{
	// Token: 0x06010D1C RID: 68892 RVA: 0x004166AA File Offset: 0x004148AA
	public EMailAttachment GetAttachmentStatus()
	{
		return this.AttachmentStatus;
	}

	// Token: 0x06010D1D RID: 68893 RVA: 0x004166B4 File Offset: 0x004148B4
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

	// Token: 0x06010D1E RID: 68894 RVA: 0x00416725 File Offset: 0x00414925
	public bool GetWasScanned()
	{
		return this.MailScannedState == 1;
	}

	// Token: 0x06010D1F RID: 68895 RVA: 0x00416730 File Offset: 0x00414930
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

	// Token: 0x06010D20 RID: 68896 RVA: 0x004167A8 File Offset: 0x004149A8
	public void SetShowSubIconId(int iconId)
	{
		this.ShowSubIconId = iconId;
	}

	// Token: 0x06010D21 RID: 68897 RVA: 0x004167B1 File Offset: 0x004149B1
	public void SetShowSubContentColor(string color)
	{
		this.ShowSubContentColor = color;
	}

	// Token: 0x06010D22 RID: 68898 RVA: 0x004167BA File Offset: 0x004149BA
	public void SetShowSubContentJumpId(int jumpId)
	{
		this.ShowSubContentJumpId = jumpId;
	}

	// Token: 0x06010D23 RID: 68899 RVA: 0x004167C3 File Offset: 0x004149C3
	public void SetShowSubContentJumpParam(int jumpParam)
	{
		this.ShowSubContentJumpParam = jumpParam;
	}

	// Token: 0x06010D24 RID: 68900 RVA: 0x004167CC File Offset: 0x004149CC
	public void SetShowSubContentJumpParam2(int jumpParam2)
	{
		this.ShowSubContentJumpParam2 = jumpParam2;
	}

	// Token: 0x06010D25 RID: 68901 RVA: 0x004167D5 File Offset: 0x004149D5
	public void SetQuestionActiveId(string questionId)
	{
		this.QuestionActiveId = questionId;
	}

	// Token: 0x06010D26 RID: 68902 RVA: 0x004167DE File Offset: 0x004149DE
	public void SetSubTitle(string title)
	{
		this.SubTitle = title;
	}

	// Token: 0x06010D27 RID: 68903 RVA: 0x004167E7 File Offset: 0x004149E7
	public void SetSubUrl(string url)
	{
		this.SubUrl = url;
	}

	// Token: 0x06010D28 RID: 68904 RVA: 0x004167F0 File Offset: 0x004149F0
	public void SetIsQuestion(bool isQuestion)
	{
		this.IsQuestion = isQuestion;
	}

	// Token: 0x06010D29 RID: 68905 RVA: 0x004167F9 File Offset: 0x004149F9
	public void SetIfShowNewMail(bool show)
	{
		this.IfShowNewMail = show;
	}

	// Token: 0x06010D2A RID: 68906 RVA: 0x00416802 File Offset: 0x00414A02
	public void SetUseDefaultBrowser(bool use)
	{
		this.UseDefaultBrowser = use;
	}

	// Token: 0x06010D2B RID: 68907 RVA: 0x0041680B File Offset: 0x00414A0B
	public void SetQuestionPass(string pass)
	{
		this.QuestionPass = pass;
	}

	// Token: 0x06010D2C RID: 68908 RVA: 0x00416814 File Offset: 0x00414A14
	public void SetIfLandscape(bool landscape)
	{
		this.IfLandscape = landscape;
	}

	// Token: 0x06010D2D RID: 68909 RVA: 0x0041681D File Offset: 0x00414A1D
	public void SetNeedPlayerInfo(bool need)
	{
		this.NeedPlayerInfo = need;
	}

	// Token: 0x06010D2E RID: 68910 RVA: 0x00416826 File Offset: 0x00414A26
	public void SetPlayerInfoFormatStyle(int style)
	{
		this.PlayerInfoFormatStyle = style;
	}

	// Token: 0x06010D2F RID: 68911 RVA: 0x0041682F File Offset: 0x00414A2F
	public int GetReceiveTime()
	{
		return this.Time;
	}

	// Token: 0x06010D30 RID: 68912 RVA: 0x00416837 File Offset: 0x00414A37
	public int GetMailLevel()
	{
		return this.Level;
	}

	// Token: 0x06010D31 RID: 68913 RVA: 0x0041683F File Offset: 0x00414A3F
	public string GetTitle()
	{
		return this.Title;
	}

	// Token: 0x06010D32 RID: 68914 RVA: 0x00416848 File Offset: 0x00414A48
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

	// Token: 0x06010D33 RID: 68915 RVA: 0x0041688C File Offset: 0x00414A8C
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
		List<string> list = (from key in MailParamHandlerDefine.mailParamHandlerMapDefine.Keys
		orderby key.Length descending
		select key).ToList<string>();
		string separator = "|";
		IEnumerable<string> source = list;
		Func<string, string> selector;
		if ((selector = MailData.<>O.<0>__Escape) == null)
		{
			selector = (MailData.<>O.<0>__Escape = new Func<string, string>(Regex.Escape));
		}
		string str = string.Join(separator, source.Select(selector));
		foreach (string text in (from item in new Regex("[,\\s;]+(?=(?:" + str + ")(?:=|[,\\s;]|$))").Split(subText)
		where item.Length > 0
		select item).ToArray<string>())
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

	// Token: 0x06010D34 RID: 68916 RVA: 0x00416A08 File Offset: 0x00414C08
	public bool GetIfLandscape()
	{
		return this.IfLandscape;
	}

	// Token: 0x06010D35 RID: 68917 RVA: 0x00416A10 File Offset: 0x00414C10
	public bool GetUseDefaultBrowser()
	{
		return this.UseDefaultBrowser;
	}

	// Token: 0x06010D36 RID: 68918 RVA: 0x00416A18 File Offset: 0x00414C18
	public bool GetIfShowNewMail()
	{
		return this.IfShowNewMail;
	}

	// Token: 0x06010D37 RID: 68919 RVA: 0x00416A20 File Offset: 0x00414C20
	public string GetText()
	{
		return this.ShowMainContent;
	}

	// Token: 0x06010D38 RID: 68920 RVA: 0x00416A28 File Offset: 0x00414C28
	public string GetSubText()
	{
		return this.ShowSubContent;
	}

	// Token: 0x06010D39 RID: 68921 RVA: 0x00416A30 File Offset: 0x00414C30
	public string GetQuestionPass()
	{
		return this.QuestionPass;
	}

	// Token: 0x06010D3A RID: 68922 RVA: 0x00416A38 File Offset: 0x00414C38
	public int GetSubTextIconId()
	{
		return this.ShowSubIconId;
	}

	// Token: 0x06010D3B RID: 68923 RVA: 0x00416A40 File Offset: 0x00414C40
	public string GetSubTextColor()
	{
		return this.ShowSubContentColor;
	}

	// Token: 0x06010D3C RID: 68924 RVA: 0x00416A48 File Offset: 0x00414C48
	public bool IsQuestionMail()
	{
		return this.IsQuestion;
	}

	// Token: 0x06010D3D RID: 68925 RVA: 0x00416A50 File Offset: 0x00414C50
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

	// Token: 0x06010D3E RID: 68926 RVA: 0x00416BA4 File Offset: 0x00414DA4
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

	// Token: 0x06010D3F RID: 68927 RVA: 0x00416BF5 File Offset: 0x00414DF5
	public string GetSubTitle()
	{
		return this.SubTitle;
	}

	// Token: 0x06010D40 RID: 68928 RVA: 0x00416BFD File Offset: 0x00414DFD
	public string GetLinkButtonTitle()
	{
		if (this.ShowSubContent.Length > 0)
		{
			return this.ShowSubContent;
		}
		return this.SubTitle;
	}

	// Token: 0x06010D41 RID: 68929 RVA: 0x00416C1A File Offset: 0x00414E1A
	public int GetSubContentJumpId()
	{
		return this.ShowSubContentJumpId;
	}

	// Token: 0x06010D42 RID: 68930 RVA: 0x00416C22 File Offset: 0x00414E22
	public int GetSubContentJumpParam()
	{
		return this.ShowSubContentJumpParam;
	}

	// Token: 0x06010D43 RID: 68931 RVA: 0x00416C2A File Offset: 0x00414E2A
	public int GetSubContentJumpParam2()
	{
		return this.ShowSubContentJumpParam2;
	}

	// Token: 0x06010D44 RID: 68932 RVA: 0x00416C32 File Offset: 0x00414E32
	public string GetSender()
	{
		return this.Sender;
	}

	// Token: 0x06010D45 RID: 68933 RVA: 0x00416C3A File Offset: 0x00414E3A
	public PbMailAttachment[] GetAttachmentInfo()
	{
		return this.AttachmentInfos;
	}

	// Token: 0x06010D46 RID: 68934 RVA: 0x00416C42 File Offset: 0x00414E42
	public long GetExpiryTime()
	{
		return this.ExpiryTime;
	}

	// Token: 0x06010D47 RID: 68935 RVA: 0x00416C4C File Offset: 0x00414E4C
	public bool IsPastScheduledDeletionTime()
	{
		if (!this.IsIntervalMail)
		{
			return false;
		}
		long num = (this.IntervalExpiryTime > 0L) ? this.IntervalExpiryTime : this.ExpiryTime;
		return num > 0L && TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond >= (double)num;
	}

	// Token: 0x06010D48 RID: 68936 RVA: 0x00416CA0 File Offset: 0x00414EA0
	public bool NeedExpiredUnfavoriteConfirm()
	{
		return this.IsIntervalMail && this.IsFavorite && this.IsPastScheduledDeletionTime();
	}

	// Token: 0x06010D49 RID: 68937 RVA: 0x00416CBA File Offset: 0x00414EBA
	public bool CanShowFavoriteControl()
	{
		return this.GetWasScanned() && this.GetAttachmentStatus() != EMailAttachment.AttachmentRemained;
	}

	// Token: 0x06010D4A RID: 68938 RVA: 0x00416CD2 File Offset: 0x00414ED2
	public void SetFavorite(bool isFavorite)
	{
		this.IsFavorite = isFavorite;
	}

	// Token: 0x06010D4B RID: 68939 RVA: 0x00416CDB File Offset: 0x00414EDB
	public void SetAddReason(int reason)
	{
		this.AddReason = reason;
	}

	// Token: 0x06010D4C RID: 68940 RVA: 0x00416CE4 File Offset: 0x00414EE4
	public int GetAddReason()
	{
		return this.AddReason;
	}

	// Token: 0x04007FD4 RID: 32724
	public string Id = "0";

	// Token: 0x04007FD5 RID: 32725
	public int ConfigId;

	// Token: 0x04007FD6 RID: 32726
	public int Time;

	// Token: 0x04007FD7 RID: 32727
	public int FinishTime;

	// Token: 0x04007FD8 RID: 32728
	public int Level = 1;

	// Token: 0x04007FD9 RID: 32729
	public string Title = "";

	// Token: 0x04007FDA RID: 32730
	public string Content = "";

	// Token: 0x04007FDB RID: 32731
	public string Sender = "";

	// Token: 0x04007FDC RID: 32732
	public long ExpiryTime;

	// Token: 0x04007FDD RID: 32733
	public bool IsIntervalMail;

	// Token: 0x04007FDE RID: 32734
	public long IntervalExpiryTime;

	// Token: 0x04007FDF RID: 32735
	public PbMailAttachment[] AttachmentInfos = new PbMailAttachment[0];

	// Token: 0x04007FE0 RID: 32736
	public long ReadTime;

	// Token: 0x04007FE1 RID: 32737
	private EMailAttachment AttachmentStatus;

	// Token: 0x04007FE2 RID: 32738
	private int MailScannedState;

	// Token: 0x04007FE3 RID: 32739
	private string ShowMainContent = "";

	// Token: 0x04007FE4 RID: 32740
	private string ShowSubContent = "";

	// Token: 0x04007FE5 RID: 32741
	private int ShowSubIconId;

	// Token: 0x04007FE6 RID: 32742
	private string ShowSubContentColor = "";

	// Token: 0x04007FE7 RID: 32743
	private int ShowSubContentJumpId;

	// Token: 0x04007FE8 RID: 32744
	private int ShowSubContentJumpParam;

	// Token: 0x04007FE9 RID: 32745
	private int ShowSubContentJumpParam2;

	// Token: 0x04007FEA RID: 32746
	private string QuestionActiveId = "";

	// Token: 0x04007FEB RID: 32747
	private string SubTitle = "";

	// Token: 0x04007FEC RID: 32748
	private string SubUrl = "";

	// Token: 0x04007FED RID: 32749
	private bool IsQuestion;

	// Token: 0x04007FEE RID: 32750
	private bool IfShowNewMail;

	// Token: 0x04007FEF RID: 32751
	private bool UseDefaultBrowser;

	// Token: 0x04007FF0 RID: 32752
	private string QuestionPass = "";

	// Token: 0x04007FF1 RID: 32753
	private bool IfLandscape = true;

	// Token: 0x04007FF2 RID: 32754
	private bool NeedPlayerInfo;

	// Token: 0x04007FF3 RID: 32755
	private int PlayerInfoFormatStyle;

	// Token: 0x04007FF4 RID: 32756
	public bool IsFavorite;

	// Token: 0x04007FF5 RID: 32757
	private int AddReason;

	// Token: 0x0200870E RID: 34574
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BECA RID: 179914
		[Nullable(0)]
		public static Func<string, string> <0>__Escape;
	}
}
