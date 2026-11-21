using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using UnrealEngine;

// Token: 0x02001287 RID: 4743
[NullableContext(1)]
[Nullable(0)]
public class GuideDescribeNew
{
	// Token: 0x0600BBD2 RID: 48082 RVA: 0x00375B01 File Offset: 0x00373D01
	public GuideDescribeNew(UUIText uiText)
	{
		this.GuideDescribe = uiText;
		this.GuideDescribe.SetRichText(true);
	}

	// Token: 0x0600BBD3 RID: 48083 RVA: 0x00375B34 File Offset: 0x00373D34
	public unsafe void SetUpText(string descTextId, params string[] actionNames)
	{
		UUIText guideDescribe = this.GuideDescribe;
		string guideText = GuideConfig.Instance.GetGuideText(descTextId);
		if (actionNames.Length == 0)
		{
			int num = guideText.Split('\n', StringSplitOptions.None).Length - 1;
			guideDescribe.SetHeight(guideDescribe.Height + guideDescribe.size * (float)num);
			LguiUtil.Instance.SetLocalTextNew(guideDescribe, descTextId, Array.Empty<object>());
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(descTextId, null);
		int count = new Regex("\\{[0-9]+\\}").Matches(localTextNew).Count;
		if (count != actionNames.Length)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "按钮的数量与通配符的数量不一致！";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("出错的文本", localTextNew);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("通配符数量", count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("按钮数量", actionNames.Length);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			LguiUtil.Instance.SetLocalTextNew(guideDescribe, descTextId, Array.Empty<object>());
			return;
		}
		List<string> list = new List<string>();
		foreach (string text in actionNames)
		{
			int index = 0;
			string text2;
			if (text.IndexOf('#') >= 0)
			{
				string[] array = text.Split('#', StringSplitOptions.None);
				index = int.Parse(array[0]);
				text2 = array[1];
			}
			else
			{
				text2 = text;
			}
			string item = "";
			string[] array2 = null;
			string[] array3 = null;
			if (InputSettingsManager.Instance.GetActionKeyDisplayData(this.KeyDisplayDataBuffer, text2))
			{
				array2 = this.KeyDisplayDataBuffer.GetDisplayKeyNameList(index);
				array3 = this.KeyDisplayDataBuffer.GetDisplayKeyIconPathList(index);
			}
			else if (InputSettingsManager.Instance.GetAxisKeyDisplayData(this.KeyDisplayDataBuffer, text2))
			{
				array2 = this.KeyDisplayDataBuffer.GetDisplayKeyNameList(index);
				array3 = this.KeyDisplayDataBuffer.GetDisplayKeyIconPathList(index);
			}
			if (array2 == null || array3 == null)
			{
				return;
			}
			if (array2.Length == 1)
			{
				item = this.ParseKeyContent(array2[0], array3[0]);
			}
			else if (array2.Length == 2)
			{
				item = this.ParseKeyContent(array2[0], array3[0]) + "+" + this.ParseKeyContent(array2[1], array3[1]);
			}
			list.Add(item);
		}
		int num2 = guideText.Split('\n', StringSplitOptions.None).Length - 1;
		float num3 = (list.Count > 0) ? this.Factor : 1f;
		guideDescribe.SetHeight(guideDescribe.Height + guideDescribe.size * (float)num2 * num3);
		LguiUtil.Instance.SetLocalTextNew(guideDescribe, descTextId, list.ToArray());
	}

	// Token: 0x0600BBD4 RID: 48084 RVA: 0x00375DC0 File Offset: 0x00373FC0
	private string ParseKeyContent(string keyName, string keyIconPath)
	{
		if (!StringUtils.IsEmpty(keyIconPath))
		{
			return "<texture=" + keyIconPath + "/>";
		}
		return "(" + keyName + ")";
	}

	// Token: 0x04006C0A RID: 27658
	private const string LINKER = "+";

	// Token: 0x04006C0B RID: 27659
	[Nullable(2)]
	private readonly UUIText GuideDescribe;

	// Token: 0x04006C0C RID: 27660
	private readonly float Factor = 1.6f;

	// Token: 0x04006C0D RID: 27661
	private readonly InputKeyDisplayData KeyDisplayDataBuffer = new InputKeyDisplayData();
}
