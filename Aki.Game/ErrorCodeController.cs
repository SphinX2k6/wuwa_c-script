using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001A8F RID: 6799
[NullableContext(1)]
[Nullable(0)]
public class ErrorCodeController : UiControllerBase
{
	// Token: 0x0600C89D RID: 51357 RVA: 0x002DBF1C File Offset: 0x002DA11C
	protected override bool OnInit()
	{
		Net.Instance.SetExceptionHandle(new Net.TExceptionHandle(this.OpenExceptionTipView));
		return true;
	}

	// Token: 0x0600C89E RID: 51358 RVA: 0x002DBF35 File Offset: 0x002DA135
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600C89F RID: 51359 RVA: 0x002DBF38 File Offset: 0x002DA138
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MessageDecodeFailNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMessageDecodeFailNotify));
		Net.Instance.Register(ENotifyMessageId.SysInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnErrorNotify));
	}

	// Token: 0x0600C8A0 RID: 51360 RVA: 0x002DBF72 File Offset: 0x002DA172
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MessageDecodeFailNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SysInfoNotify);
	}

	// Token: 0x0600C8A1 RID: 51361 RVA: 0x002DBF94 File Offset: 0x002DA194
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

	// Token: 0x0600C8A2 RID: 51362 RVA: 0x002DC03C File Offset: 0x002DA23C
	[NullableContext(2)]
	private void OnErrorNotify(IMessage msg, Net.CallbackStatus status)
	{
		SysInfoNotify sysInfoNotify = (SysInfoNotify)msg;
		RepeatedField<string> errorParams = sysInfoNotify.ErrorParams;
		Aki.Protocol.ErrorCode errorCode = sysInfoNotify.ErrorCode;
		this.OpenErrorCodeScrollingTipsView(errorCode, errorParams.ToArray<string>());
	}

	// Token: 0x0600C8A3 RID: 51363 RVA: 0x002DC06C File Offset: 0x002DA26C
	public unsafe void OpenErrorCodeScrollingTipsView(Aki.Protocol.ErrorCode errorCode, string[] errorParams)
	{
		string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(errorCode);
		if (errorCode == Aki.Protocol.ErrorCode.PropRewardTips)
		{
			string s = errorParams[0];
			errorParams[0] = PropertyIndexConfig.Instance.GetPropertyIndexLocalName(int.Parse(s));
		}
		string text = this.ReplaceWildCard(textByErrorId, errorParams);
		ScrollingTipsController.Instance.ShowTipsByText(text);
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ErrorCode;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "服务器错误信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("error", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("errorParams", errorParams);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600C8A4 RID: 51364 RVA: 0x002DC117 File Offset: 0x002DA317
	public void OpenErrorCodeTipView(Aki.Protocol.ErrorCode errorCode, EResponseMessageId messageId, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> errorParams = null, bool showToScreen = true, bool isShowErrorCode = true)
	{
		this.OpenErrorCodeTipView(errorCode, (int)messageId, errorParams, showToScreen, isShowErrorCode);
	}

	// Token: 0x0600C8A5 RID: 51365 RVA: 0x002DC128 File Offset: 0x002DA328
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

	// Token: 0x0600C8A6 RID: 51366 RVA: 0x002DC264 File Offset: 0x002DA464
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

	// Token: 0x0600C8A7 RID: 51367 RVA: 0x002DC2FC File Offset: 0x002DA4FC
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

	// Token: 0x0600C8A8 RID: 51368 RVA: 0x002DC3AC File Offset: 0x002DA5AC
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

	// Token: 0x0600C8A9 RID: 51369 RVA: 0x002DC414 File Offset: 0x002DA614
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

	// Token: 0x0600C8AA RID: 51370 RVA: 0x002DC460 File Offset: 0x002DA660
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
		if (!Info.Instance.IsBuildShipping)
		{
			this.OpenErrorCodeTipView((Aki.Protocol.ErrorCode)errorCode, (EResponseMessageId)messageId, null, true, true);
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

	// Token: 0x0600C8AB RID: 51371 RVA: 0x002DC5FC File Offset: 0x002DA7FC
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

	// Token: 0x0600C8AC RID: 51372 RVA: 0x002DC64C File Offset: 0x002DA84C
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

	// Token: 0x0600C8AD RID: 51373 RVA: 0x002DC68C File Offset: 0x002DA88C
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

	// Token: 0x17001073 RID: 4211
	// (get) Token: 0x0600C8AE RID: 51374 RVA: 0x002DC727 File Offset: 0x002DA927
	public static ErrorCodeController Instance
	{
		get
		{
			return ErrorCodeController._Instance;
		}
	}

	// Token: 0x0600C8AF RID: 51375 RVA: 0x002DC72E File Offset: 0x002DA92E
	public static ErrorCodeController GetOrCreateInstance()
	{
		if (ErrorCodeController._Instance == null)
		{
			ErrorCodeController.CreateInstance();
		}
		return ErrorCodeController._Instance;
	}

	// Token: 0x0600C8B0 RID: 51376 RVA: 0x002DC742 File Offset: 0x002DA942
	public static bool CreateInstance()
	{
		if (ErrorCodeController._Instance != null)
		{
			return true;
		}
		ErrorCodeController._Instance = new ErrorCodeController();
		return true;
	}

	// Token: 0x0600C8B1 RID: 51377 RVA: 0x002DC758 File Offset: 0x002DA958
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C8B2 RID: 51378 RVA: 0x002DC75A File Offset: 0x002DA95A
	public static void ResetStaticDefaultValue()
	{
		ErrorCodeController._Instance = null;
	}

	// Token: 0x0600C8B3 RID: 51379 RVA: 0x002DC762 File Offset: 0x002DA962
	static ErrorCodeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ErrorCodeController.CreateStaticDefaultValue), new Action(ErrorCodeController.ResetStaticDefaultValue));
	}

	// Token: 0x04005C7B RID: 23675
	public bool IsErrorCodeOpen = true;

	// Token: 0x04005C7C RID: 23676
	public readonly Action<string> OpenConfirmBoxByText = delegate(string text)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	};

	// Token: 0x04005C7D RID: 23677
	[Nullable(2)]
	private static ErrorCodeController _Instance;
}
