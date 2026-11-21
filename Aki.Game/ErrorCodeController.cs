using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02000F4E RID: 3918
[NullableContext(1)]
[Nullable(0)]
public class ErrorCodeController : UiControllerBase
{
	// Token: 0x06009CAE RID: 40110 RVA: 0x002E70A0 File Offset: 0x002E52A0
	protected override bool OnInit()
	{
		Net.Instance.SetExceptionHandle(new Net.TExceptionHandle(this.OpenExceptionTipView));
		return true;
	}

	// Token: 0x06009CAF RID: 40111 RVA: 0x002E70B9 File Offset: 0x002E52B9
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06009CB0 RID: 40112 RVA: 0x002E70BC File Offset: 0x002E52BC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MessageDecodeFailNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMessageDecodeFailNotify));
		Net.Instance.Register(ENotifyMessageId.SysInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnErrorNotify));
	}

	// Token: 0x06009CB1 RID: 40113 RVA: 0x002E70F6 File Offset: 0x002E52F6
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MessageDecodeFailNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SysInfoNotify);
	}

	// Token: 0x06009CB2 RID: 40114 RVA: 0x002E7118 File Offset: 0x002E5318
	[NullableContext(2)]
	private void OnMessageDecodeFailNotify(IMessage msg, Net.CallbackStatus status)
	{
		MessageDecodeFailNotify messageDecodeFailNotify = (MessageDecodeFailNotify)msg;
		MessageDecodeData messageDecodeData = new MessageDecodeData();
		messageDecodeData.s_channel_id = messageDecodeFailNotify.ChannelId;
		messageDecodeData.i_kcp_conv = messageDecodeFailNotify.Conv;
		messageDecodeData.i_error_code = (int)messageDecodeFailNotify.Code;
		messageDecodeData.i_seq_no = messageDecodeFailNotify.SeqNo;
		messageDecodeData.s_client_ip = PublicUtil.Instance.GetLocalHost();
		ValueTuple<int, int, string, string> cachedMessageData = Net.Instance.GetCachedMessageData(messageDecodeFailNotify.SeqNo);
		messageDecodeData.i_message_id = cachedMessageData.Item1;
		messageDecodeData.i_crc = cachedMessageData.Item2;
		messageDecodeData.s_before_hexdump = cachedMessageData.Item3;
		messageDecodeData.s_after_hexdump = cachedMessageData.Item4;
		LogReportController.Instance.LogReport(messageDecodeData);
	}

	// Token: 0x06009CB3 RID: 40115 RVA: 0x002E71C0 File Offset: 0x002E53C0
	[NullableContext(2)]
	private void OnErrorNotify(IMessage msg, Net.CallbackStatus status)
	{
		SysInfoNotify sysInfoNotify = (SysInfoNotify)msg;
		RepeatedField<string> errorParams = sysInfoNotify.ErrorParams;
		Aki.Protocol.ErrorCode errorCode = sysInfoNotify.ErrorCode;
		string[] array = new string[errorParams.Count];
		for (int i = 0; i < errorParams.Count; i++)
		{
			array[i] = errorParams[i];
		}
		this.OpenErrorCodeScrollingTipsView(errorCode, array);
	}

	// Token: 0x06009CB4 RID: 40116 RVA: 0x002E7218 File Offset: 0x002E5418
	public void OpenErrorCodeScrollingTipsView(Aki.Protocol.ErrorCode errorCode, string[] errorParams)
	{
		string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(errorCode);
		if (errorCode == Aki.Protocol.ErrorCode.PropRewardTips)
		{
			string s = errorParams[0];
			errorParams[0] = PropertyIndexConfig.Instance.GetPropertyIndexLocalName(int.Parse(s));
		}
		string text = this.ReplaceWildCard(textByErrorId, errorParams);
		ScrollingTipsController.Instance.ShowTipsByText(text);
	}

	// Token: 0x06009CB5 RID: 40117 RVA: 0x002E7264 File Offset: 0x002E5464
	public void OpenErrorCodeTipView(Aki.Protocol.ErrorCode errorCode, EResponseMessageId messageId, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> errorParams = null, bool showToScreen = true, bool isShowErrorCode = true)
	{
		this.OpenErrorCodeTipView(errorCode, (int)messageId, errorParams, showToScreen, isShowErrorCode);
	}

	// Token: 0x06009CB6 RID: 40118 RVA: 0x002E7274 File Offset: 0x002E5474
	public unsafe void OpenErrorCodeTipView(Aki.Protocol.ErrorCode errorCode, int messageId, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> errorParams = null, bool showToScreen = true, bool isShowErrorCode = true)
	{
		if (errorCode == Aki.Protocol.ErrorCode.ErrorBanInteractEntity)
		{
			return;
		}
		ErrorCodeConfig instance = ErrorCodeConfig.Instance;
		string textByErrorId = instance.GetTextByErrorId(errorCode);
		string text = this.ReplaceWildCard(textByErrorId, errorParams);
		bool flag = instance.IsTipsOnly(errorCode);
		bool flag2 = BaseConfigController.Instance.GetPackageConfigOrDefault("Stream", null) == "mainline";
		if (showToScreen && this.IsErrorCodeOpen)
		{
			if (flag && !flag2)
			{
				GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.FloatLinePrompt, null, null, new object[]
				{
					text
				}, null, null, null);
				return;
			}
			if (isShowErrorCode)
			{
				text = this.FormatErrorCodeInfo(messageId, errorCode, text);
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				text
			});
			confirmBoxDataNew.ErrorCode = new int?((int)errorCode);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.ErrorCode;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "服务器错误信息";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("error", text);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("errorCode", errorCode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("errorParams", errorParams);
		instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06009CB7 RID: 40119 RVA: 0x002E73B0 File Offset: 0x002E55B0
	private string FormatErrorCodeInfo(int messageId, Aki.Protocol.ErrorCode errorCode, string showText)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (messageId > 0)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<int>(messageId);
			defaultInterpolatedStringHandler.AppendLiteral("][");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)errorCode);
			defaultInterpolatedStringHandler.AppendLiteral("]:");
			defaultInterpolatedStringHandler.AppendFormatted(showText);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
		defaultInterpolatedStringHandler.AppendLiteral("[-][");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)errorCode);
		defaultInterpolatedStringHandler.AppendLiteral("]:");
		defaultInterpolatedStringHandler.AppendFormatted(showText);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06009CB8 RID: 40120 RVA: 0x002E7448 File Offset: 0x002E5648
	public unsafe void LogOnlyErrorCode(Aki.Protocol.ErrorCode errorCode, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> errorParams = null)
	{
		string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(errorCode);
		string text = this.ReplaceWildCard(textByErrorId, errorParams);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendLiteral("[");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)errorCode);
		defaultInterpolatedStringHandler.AppendLiteral("]:");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		text = defaultInterpolatedStringHandler.ToStringAndClear();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ErrorCode;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "服务器错误信息";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("error", text);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("errorParams", errorParams);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06009CB9 RID: 40121 RVA: 0x002E74F8 File Offset: 0x002E56F8
	private string ReplaceWildCard(string text, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> @params)
	{
		string text2 = text;
		if (@params != null)
		{
			for (int i = 0; i < @params.Count; i++)
			{
				string newValue = @params[i];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("{");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral("}");
				string oldValue = defaultInterpolatedStringHandler.ToStringAndClear();
				text2 = text2.Replace(oldValue, newValue);
			}
		}
		return text2;
	}

	// Token: 0x06009CBA RID: 40122 RVA: 0x002E7560 File Offset: 0x002E5760
	public void OpenLoginStatusCodeTipView(Aki.Protocol.ErrorCode errorCode)
	{
		if (this.IsErrorCodeOpen)
		{
			this.OpenErrorCodeTipView(errorCode, 0, null, true, true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ErrorCode;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "Http登录返回错误码";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("code", (int)errorCode);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06009CBB RID: 40123 RVA: 0x002E75AC File Offset: 0x002E57AC
	private unsafe void OpenExceptionTipView(int rpcId, int errorCode, int messageId, object message, string errorMessage)
	{
		if (errorCode == 64)
		{
			ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("FunctionClose", null));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ErrorCode;
			ELogAuthor author = ELogAuthor.YYZ;
			string message2 = "服务器异常: 功能关闭";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("errorCode", errorCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RpcId", rpcId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("msgId", messageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("message", message);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("errorMessage", errorMessage);
			instance.Info(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.ErrorCode;
		ELogAuthor author2 = ELogAuthor.ZJC;
		string message3 = "服务器异常";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("errorCode", errorCode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("RpcId", rpcId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("msgId", messageId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("message", message);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("errorMessage", errorMessage);
		instance2.Error(module2, author2, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
	}

	// Token: 0x06009CBC RID: 40124 RVA: 0x002E7730 File Offset: 0x002E5930
	public void OpenConfirmBoxByTextId(string textId)
	{
		if (!this.IsErrorCodeOpen)
		{
			return;
		}
		string textById = TextConfig.Instance.GetTextById(textId);
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			textById
		});
		confirmBoxDataNew.NotAddChildToTopStackView = true;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06009CBD RID: 40125 RVA: 0x002E7780 File Offset: 0x002E5980
	public void OpenConfirmBoxByTextIdNew(string textId)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(textId, null);
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			localTextNew
		});
		confirmBoxDataNew.NotAddChildToTopStackView = true;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06009CBE RID: 40126 RVA: 0x002E77C0 File Offset: 0x002E59C0
	public unsafe bool CheckErrorCode(Aki.Protocol.ErrorCode? response, EResponseMessageId msgId, bool isShowTip = true)
	{
		if (response == null)
		{
			return true;
		}
		if (response.Value != Aki.Protocol.ErrorCode.Success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ErrorCode;
			ELogAuthor author = ELogAuthor.CX;
			string message = "CheckErrorCode";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ErrorCode", response.Value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MsgId", msgId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (isShowTip)
			{
				this.OpenErrorCodeTipView(response.Value, msgId, null, true, true);
			}
			return true;
		}
		return false;
	}

	// Token: 0x17001098 RID: 4248
	// (get) Token: 0x06009CBF RID: 40127 RVA: 0x002E785B File Offset: 0x002E5A5B
	public static ErrorCodeController Instance
	{
		get
		{
			return ErrorCodeController._Instance;
		}
	}

	// Token: 0x06009CC0 RID: 40128 RVA: 0x002E7862 File Offset: 0x002E5A62
	public static ErrorCodeController GetOrCreateInstance()
	{
		if (ErrorCodeController._Instance == null)
		{
			ErrorCodeController.CreateInstance();
		}
		return ErrorCodeController._Instance;
	}

	// Token: 0x06009CC1 RID: 40129 RVA: 0x002E7876 File Offset: 0x002E5A76
	public static bool CreateInstance()
	{
		if (ErrorCodeController._Instance != null)
		{
			return true;
		}
		ErrorCodeController._Instance = new ErrorCodeController();
		return true;
	}

	// Token: 0x06009CC2 RID: 40130 RVA: 0x002E788C File Offset: 0x002E5A8C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009CC3 RID: 40131 RVA: 0x002E788E File Offset: 0x002E5A8E
	public static void ResetStaticDefaultValue()
	{
		ErrorCodeController._Instance = null;
	}

	// Token: 0x06009CC4 RID: 40132 RVA: 0x002E7896 File Offset: 0x002E5A96
	static ErrorCodeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ErrorCodeController.CreateStaticDefaultValue), new Action(ErrorCodeController.ResetStaticDefaultValue));
	}

	// Token: 0x04005D4A RID: 23882
	public bool IsErrorCodeOpen = true;

	// Token: 0x04005D4B RID: 23883
	public readonly Action<string> OpenConfirmBoxByText = delegate(string text)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	};

	// Token: 0x04005D4C RID: 23884
	[Nullable(2)]
	private static ErrorCodeController _Instance;
}
