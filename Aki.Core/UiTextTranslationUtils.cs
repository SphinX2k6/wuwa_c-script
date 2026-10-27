using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200010A RID: 266
[NullableContext(1)]
[Nullable(0)]
public class UiTextTranslationUtils : IStaticVariableResetter
{
	// Token: 0x060009EF RID: 2543 RVA: 0x00032963 File Offset: 0x00030B63
	static UiTextTranslationUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiTextTranslationUtils.CreateStaticDefaultValue), new Action(UiTextTranslationUtils.ResetStaticDefaultValue));
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00032982 File Offset: 0x00030B82
	private static void FixBestFit(UUIText uiText)
	{
		if (uiText.overflowType == UITextOverflowType.VerticalOverflow)
		{
			uiText.bBestFit = uiText.verticalOverflowBestFitSwitch;
		}
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x0003299C File Offset: 0x00030B9C
	public static void TranslateText(UUIText uiText)
	{
		if (uiText.TranslateId == 0U)
		{
			uiText.text = "";
			return;
		}
		PrefabTextItem? config = ConfigPrefabTextItemByItemId.GetConfig((long)((ulong)uiText.TranslateId), true);
		if (config != null)
		{
			UiTextTranslationUtils.FixBestFit(uiText);
			uiText.ShowTextNew(config.Value.Text);
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x000329EF File Offset: 0x00030BEF
	private static void HandleTextComponentRichText(string textKey, UUIText uiText)
	{
		uiText.SetGameRichText(true);
		uiText.SetRichText(true);
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00032A00 File Offset: 0x00030C00
	[return: Nullable(2)]
	private unsafe static string GetLocalTextNew(string textKey, UUIText uiText, bool isMainText)
	{
		if (UiTextTranslationUtils.TextShowTranslateId)
		{
			return uiText.TranslateId.ToString();
		}
		UiTextTranslationUtils.HandleTextComponentRichText(textKey, uiText);
		string text = ConfigMultiTextLang.GetLocalTextNew(textKey, null);
		if (isMainText)
		{
			if (text == null)
			{
				text = uiText.GetText();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TextLanguageSearch;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[GetLocalTextNew]预制体固定文本多语言切换失败，该文本控件Id还没有收集到，将显示预制体上的文本";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("控件Id", uiText.TranslateId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("控件自身文本", text);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (text != uiText.GetText())
			{
				UiTextTranslationUtils.FixBestFit(uiText);
			}
		}
		else if (text == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.TextLanguageSearch;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "[GetLocalTextNew]格式化字符串传入的表名与文本id无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("文本id", textKey);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return text;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00032AE8 File Offset: 0x00030CE8
	public static void GmReplaceText(UUIText uiText)
	{
		if (UiTextTranslationUtils.AkiFontData != null)
		{
			uiText.SetFont(UiTextTranslationUtils.AkiFontData);
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00032AFC File Offset: 0x00030CFC
	public static void Initialize()
	{
		Action<UUIText> callback;
		if ((callback = UiTextTranslationUtils.<>O.<0>__TranslateText) == null)
		{
			callback = (UiTextTranslationUtils.<>O.<0>__TranslateText = new Action<UUIText>(UiTextTranslationUtils.TranslateText));
		}
		FLGUITextTranslateDelegate flguitextTranslateDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUITextTranslateDelegate>(callback);
		UUIText.SetTextTranslateDelegate(flguitextTranslateDelegate);
		Func<string, UUIText, bool, string> callback2;
		if ((callback2 = UiTextTranslationUtils.<>O.<1>__GetLocalTextNew) == null)
		{
			callback2 = (UiTextTranslationUtils.<>O.<1>__GetLocalTextNew = new Func<string, UUIText, bool, string>(UiTextTranslationUtils.GetLocalTextNew));
		}
		FLocalTextNewDelegate flocalTextNewDelegate = DelegateUtils.ToManualReleaseDelegate<FLocalTextNewDelegate>(callback2);
		UUIText.SetLocalTextNewDelegate(flocalTextNewDelegate);
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00032B5C File Offset: 0x00030D5C
	public static void Destroy()
	{
		FLGUITextTranslateDelegate flguitextTranslateDelegate = null;
		UUIText.SetTextTranslateDelegate(flguitextTranslateDelegate);
		FLocalTextDelegate flocalTextDelegate = null;
		UUIText.SetLocalTextDelegate(flocalTextDelegate);
		FLocalTextNewDelegate flocalTextNewDelegate = null;
		UUIText.SetLocalTextNewDelegate(flocalTextNewDelegate);
		Action<UUIText> callBack;
		if ((callBack = UiTextTranslationUtils.<>O.<0>__TranslateText) == null)
		{
			callBack = (UiTextTranslationUtils.<>O.<0>__TranslateText = new Action<UUIText>(UiTextTranslationUtils.TranslateText));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack);
		Func<string, UUIText, bool, string> callBack2;
		if ((callBack2 = UiTextTranslationUtils.<>O.<1>__GetLocalTextNew) == null)
		{
			callBack2 = (UiTextTranslationUtils.<>O.<1>__GetLocalTextNew = new Func<string, UUIText, bool, string>(UiTextTranslationUtils.GetLocalTextNew));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack2);
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00032BC4 File Offset: 0x00030DC4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00032BC6 File Offset: 0x00030DC6
	public static void ResetStaticDefaultValue()
	{
		UiTextTranslationUtils.AkiFontData = null;
		UiTextTranslationUtils.TextShowTranslateId = false;
	}

	// Token: 0x0400069B RID: 1691
	[Nullable(2)]
	public static ULGUIFontData_BaseObject AkiFontData;

	// Token: 0x0400069C RID: 1692
	public static bool TextShowTranslateId;

	// Token: 0x020001D4 RID: 468
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400088A RID: 2186
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIText> <0>__TranslateText;

		// Token: 0x0400088B RID: 2187
		[Nullable(new byte[]
		{
			0,
			1,
			1,
			2
		})]
		public static Func<string, UUIText, bool, string> <1>__GetLocalTextNew;

		// Token: 0x0400088C RID: 2188
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIText> <2>__GmReplaceText;
	}
}
