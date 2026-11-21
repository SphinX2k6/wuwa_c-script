using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200010A RID: 266
[NullableContext(1)]
[Nullable(0)]
public class UiTextTranslationUtils : IStaticVariableResetter
{
	// Token: 0x06000A40 RID: 2624 RVA: 0x000332BF File Offset: 0x000314BF
	static UiTextTranslationUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiTextTranslationUtils.CreateStaticDefaultValue), new Action(UiTextTranslationUtils.ResetStaticDefaultValue));
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x000332DE File Offset: 0x000314DE
	private static void FixBestFit(UUIText uiText)
	{
		if (uiText.overflowType == UITextOverflowType.VerticalOverflow)
		{
			uiText.bBestFit = uiText.verticalOverflowBestFitSwitch;
		}
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x000332F8 File Offset: 0x000314F8
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

	// Token: 0x06000A43 RID: 2627 RVA: 0x0003334B File Offset: 0x0003154B
	private static void HandleTextComponentRichText(string textKey, UUIText uiText)
	{
		uiText.SetGameRichText(true);
		uiText.SetRichText(true);
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0003335C File Offset: 0x0003155C
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

	// Token: 0x06000A45 RID: 2629 RVA: 0x00033444 File Offset: 0x00031644
	public static void GmReplaceText(UUIText uiText)
	{
		if (UiTextTranslationUtils.AkiFontData != null)
		{
			uiText.SetFont(UiTextTranslationUtils.AkiFontData);
		}
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00033458 File Offset: 0x00031658
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

	// Token: 0x06000A47 RID: 2631 RVA: 0x000334B8 File Offset: 0x000316B8
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

	// Token: 0x06000A48 RID: 2632 RVA: 0x00033520 File Offset: 0x00031720
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00033522 File Offset: 0x00031722
	public static void ResetStaticDefaultValue()
	{
		UiTextTranslationUtils.AkiFontData = null;
		UiTextTranslationUtils.TextShowTranslateId = false;
	}

	// Token: 0x040006A6 RID: 1702
	[Nullable(2)]
	public static ULGUIFontData_BaseObject AkiFontData;

	// Token: 0x040006A7 RID: 1703
	public static bool TextShowTranslateId;

	// Token: 0x020001D9 RID: 473
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040008AC RID: 2220
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIText> <0>__TranslateText;

		// Token: 0x040008AD RID: 2221
		[Nullable(new byte[]
		{
			0,
			1,
			1,
			2
		})]
		public static Func<string, UUIText, bool, string> <1>__GetLocalTextNew;

		// Token: 0x040008AE RID: 2222
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIText> <2>__GmReplaceText;
	}
}
