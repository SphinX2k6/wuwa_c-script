using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002232 RID: 8754
[NullableContext(1)]
[Nullable(0)]
public class LguiUtil : Singleton
{
	// Token: 0x060159C9 RID: 88521 RVA: 0x00645044 File Offset: 0x00643244
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<AActor> LoadPrefabByResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parent, [Nullable(2)] UWorld world = null, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default, string memoryTag = "js_undefined")
	{
		LguiUtil.<LoadPrefabByResourceIdAsync>d__31 <LoadPrefabByResourceIdAsync>d__;
		<LoadPrefabByResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
		<LoadPrefabByResourceIdAsync>d__.<>4__this = this;
		<LoadPrefabByResourceIdAsync>d__.resourceId = resourceId;
		<LoadPrefabByResourceIdAsync>d__.parent = parent;
		<LoadPrefabByResourceIdAsync>d__.world = world;
		<LoadPrefabByResourceIdAsync>d__.priority = priority;
		<LoadPrefabByResourceIdAsync>d__.memoryTag = memoryTag;
		<LoadPrefabByResourceIdAsync>d__.<>1__state = -1;
		<LoadPrefabByResourceIdAsync>d__.<>t__builder.Start<LguiUtil.<LoadPrefabByResourceIdAsync>d__31>(ref <LoadPrefabByResourceIdAsync>d__);
		return <LoadPrefabByResourceIdAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060159CA RID: 88522 RVA: 0x006450B4 File Offset: 0x006432B4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<AActor> LoadPrefabByAsync(string path, [Nullable(2)] UUIItem parent, [Nullable(2)] UWorld world = null, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default, string memoryTag = "js_undefined")
	{
		LguiUtil.<LoadPrefabByAsync>d__32 <LoadPrefabByAsync>d__;
		<LoadPrefabByAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
		<LoadPrefabByAsync>d__.<>4__this = this;
		<LoadPrefabByAsync>d__.path = path;
		<LoadPrefabByAsync>d__.parent = parent;
		<LoadPrefabByAsync>d__.world = world;
		<LoadPrefabByAsync>d__.priority = priority;
		<LoadPrefabByAsync>d__.memoryTag = memoryTag;
		<LoadPrefabByAsync>d__.<>1__state = -1;
		<LoadPrefabByAsync>d__.<>t__builder.Start<LguiUtil.<LoadPrefabByAsync>d__32>(ref <LoadPrefabByAsync>d__);
		return <LoadPrefabByAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060159CB RID: 88523 RVA: 0x00645121 File Offset: 0x00643321
	public UUIItem CopyItem(UUIItem item, [Nullable(2)] USceneComponent parent)
	{
		return this.DuplicateActor(item.GetOwner(), parent).GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
	}

	// Token: 0x060159CC RID: 88524 RVA: 0x00645144 File Offset: 0x00643344
	[NullableContext(2)]
	public AActor DuplicateActor([Nullable(1)] AActor actor, USceneComponent parent)
	{
		return ULGUIBPLibrary.DuplicateActor(actor, parent);
	}

	// Token: 0x060159CD RID: 88525 RVA: 0x00645150 File Offset: 0x00643350
	public void SetLocalText([Nullable(2)] UUIText uiText, string textTableId, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
		string textContentIdById = TextConfig.Instance.GetTextContentIdById(textTableId);
		this.SetLocalTextNew(uiText, textContentIdById, args);
	}

	// Token: 0x060159CE RID: 88526 RVA: 0x00645174 File Offset: 0x00643374
	[NullableContext(2)]
	public void SetLocalTextNew(UUIText uiText, string textStringId, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (object obj in args)
				{
					if (obj is int)
					{
						int value = (int)obj;
						uiText.AddIntArgs(value);
					}
					else if (obj is float)
					{
						float num = (float)obj;
						if (!float.IsInfinity(num) && !float.IsNaN(num) && (double)num == Math.Truncate((double)num))
						{
							uiText.AddIntArgs((int)num);
						}
						else
						{
							uiText.AddFloatArgs(num);
						}
					}
					else
					{
						TableTextArgNew tableTextArgNew = obj as TableTextArgNew;
						if (tableTextArgNew != null)
						{
							uiText.AddFormatTableInfoNew(tableTextArgNew.TextKey);
						}
						else
						{
							IReadOnlyList<string> readOnlyList = obj as IReadOnlyList<string>;
							if (readOnlyList != null)
							{
								using (IEnumerator<string> enumerator2 = readOnlyList.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										string value2 = enumerator2.Current;
										uiText.AddStringArgs(value2);
									}
									continue;
								}
							}
							uiText.AddStringArgs((obj != null) ? obj.ToString() : null);
						}
					}
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159CF RID: 88527 RVA: 0x006452A4 File Offset: 0x006434A4
	[NullableContext(2)]
	public void SetLocalTextNew(UUIText uiText, [Nullable(1)] string textStringId, int[] args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (int value in args)
				{
					uiText.AddIntArgs(value);
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159D0 RID: 88528 RVA: 0x006452E0 File Offset: 0x006434E0
	[NullableContext(2)]
	public void SetLocalTextNew(UUIText uiText, [Nullable(1)] string textStringId, float[] args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (float value in args)
				{
					uiText.AddFloatArgs(value);
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159D1 RID: 88529 RVA: 0x0064531C File Offset: 0x0064351C
	[NullableContext(2)]
	public void SetLocalTextNew(UUIText uiText, [Nullable(1)] string textStringId, double[] args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (double num in args)
				{
					uiText.AddFloatArgs((float)num);
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159D2 RID: 88530 RVA: 0x00645358 File Offset: 0x00643558
	[NullableContext(2)]
	public void SetLocalTextNew(UUIText uiText, [Nullable(1)] string textStringId, long[] args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (long value in args)
				{
					uiText.AddInt64Args(value);
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159D3 RID: 88531 RVA: 0x00645394 File Offset: 0x00643594
	public void SetLocalTextNew([Nullable(2)] UUIText uiText, string textStringId, [Nullable(new byte[]
	{
		2,
		1
	})] string[] args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (string value in args)
				{
					uiText.AddStringArgs(value);
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159D4 RID: 88532 RVA: 0x006453D0 File Offset: 0x006435D0
	public void SetLocalTextNew([Nullable(2)] UUIText uiText, string textStringId, [Nullable(new byte[]
	{
		2,
		1
	})] TableTextArgNew[] args)
	{
		if (uiText != null)
		{
			uiText.Clear();
			if (args != null)
			{
				foreach (TableTextArgNew tableTextArgNew in args)
				{
					uiText.AddFormatTableInfoNew(tableTextArgNew.TextKey);
				}
			}
			uiText.ShowTextNew(textStringId);
		}
	}

	// Token: 0x060159D5 RID: 88533 RVA: 0x00645410 File Offset: 0x00643610
	[NullableContext(2)]
	public void TrySetLocalTextNew(UUIText uiText, string textStringId, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
		if (StringUtils.IsEmpty(textStringId))
		{
			if (uiText != null)
			{
				uiText.SetUIActive(false);
				return;
			}
		}
		else
		{
			if (uiText != null)
			{
				uiText.SetUIActive(true);
			}
			this.SetLocalTextNew(uiText, textStringId, args);
		}
	}

	// Token: 0x060159D6 RID: 88534 RVA: 0x00645438 File Offset: 0x00643638
	[NullableContext(2)]
	public void ReplaceWildCard(UUIText uiText)
	{
		if (uiText == null || !uiText.IsValid())
		{
			global::Log.Instance.Warn(ELogModule.LguiUtil, ELogAuthor.XXJ, "替换富文本时，UiText已经失效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!uiText.GetRichText())
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "替换富文本图标失败，因为此文本不是富文本";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uiText", uiText.GetText());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = uiText.GetText();
		string text2 = this.ConvertToPcKeyIconRichText(text);
		text2 = this.ConvertToGamepadKeyIconRichText(text2);
		text2 = this.ConvertToActionIconRichText(text2);
		text2 = this.ConvertToDataTableSkillIconRichText(text2);
		text2 = this.ConvertToSkillIconRichText(text2);
		text2 = this.ConvertToToExploreIconRichText(text2);
		text2 = this.ConvertToToPhantomIconRichText(text2);
		text2 = this.ConvertToToPlatformIconRichText(text2);
		uiText.SetText(text2, true);
	}

	// Token: 0x060159D7 RID: 88535 RVA: 0x00645500 File Offset: 0x00643700
	public string ConvertToPcKeyIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.pcKeyFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			text = this.ReplacePcKey(text, value, this.ParseWildCardToId(value, LguiUtil.pcKeyIdFormatRegex).Value);
		}
		return text;
	}

	// Token: 0x060159D8 RID: 88536 RVA: 0x0064558C File Offset: 0x0064378C
	public string ConvertToGamepadKeyIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.gamepadFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			text = this.ReplaceGamepadKey(text, value, this.ParseWildCardToId(value, LguiUtil.gamepadIdFormatRegex).Value);
		}
		return text;
	}

	// Token: 0x060159D9 RID: 88537 RVA: 0x00645618 File Offset: 0x00643818
	public string ConvertToActionIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.actionFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			int? value2 = this.ParseWildCardToId(value, LguiUtil.actionIdFormatRegex);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("{<");
			defaultInterpolatedStringHandler.AppendFormatted("ActionId=");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(value2);
			defaultInterpolatedStringHandler.AppendLiteral(">}");
			string replaceString = defaultInterpolatedStringHandler.ToStringAndClear();
			text = this.ReplaceActionKey(text, replaceString, value2.Value);
		}
		return text;
	}

	// Token: 0x060159DA RID: 88538 RVA: 0x006456E4 File Offset: 0x006438E4
	public string ConvertToDataTableSkillIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.dtSkillFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		bool flag = Info.Instance.IsInTouch();
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			int? num = this.ParseWildCardToId(value, LguiUtil.actionIdFormatRegex);
			if (!flag)
			{
				text = this.ReplaceActionKey(text, value, num.Value);
			}
		}
		return text;
	}

	// Token: 0x060159DB RID: 88539 RVA: 0x00645784 File Offset: 0x00643984
	public string ConvertToSkillIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.skillFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		bool flag = Info.Instance.IsInTouch();
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			int? num = this.ParseWildCardToId(value, LguiUtil.actionIdFormatRegex);
			int? num2 = this.ParseWildCardToId(value, LguiUtil.skillIdFormatRegex);
			if (flag)
			{
				text = this.ReplaceSkillIcon(text, value, num2.Value);
			}
			else
			{
				text = this.ReplaceActionKey(text, value, num.Value);
			}
		}
		return text;
	}

	// Token: 0x060159DC RID: 88540 RVA: 0x00645844 File Offset: 0x00643A44
	public string ConvertToToExploreIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.exploreFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		bool flag = Info.Instance.IsInTouch();
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			int? num = this.ParseWildCardToId(value, LguiUtil.actionIdFormatRegex);
			int? num2 = this.ParseWildCardToId(value, LguiUtil.exploreIdFormatRegex);
			if (flag)
			{
				text = this.ReplaceExploreIcon(text, value, num2.Value);
			}
			else
			{
				text = this.ReplaceActionKey(text, value, num.Value);
			}
		}
		return text;
	}

	// Token: 0x060159DD RID: 88541 RVA: 0x00645904 File Offset: 0x00643B04
	public string ConvertToToPhantomIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.phantomFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		bool flag = Info.Instance.IsInTouch();
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			int? num = this.ParseWildCardToId(value, LguiUtil.actionIdFormatRegex);
			int? num2 = this.ParseWildCardToId(value, LguiUtil.phantomIdFormatRegex);
			if (flag)
			{
				text = this.ReplacePhantomIcon(text, value, num2.Value);
			}
			else
			{
				text = this.ReplaceActionKey(text, value, num.Value);
			}
		}
		return text;
	}

	// Token: 0x060159DE RID: 88542 RVA: 0x006459C4 File Offset: 0x00643BC4
	public string ConvertToToPlatformIconRichText(string inString)
	{
		MatchCollection matchCollection = LguiUtil.iconFormatRegex.Matches(inString);
		if (matchCollection.Count == 0)
		{
			return inString;
		}
		string text = inString;
		foreach (object obj in matchCollection)
		{
			string value = ((Match)obj).Value;
			text = this.ReplacePlatformIcon(text, value, this.ParseWildCardToId(value, LguiUtil.iconIdFormatRegex).Value);
		}
		return text;
	}

	// Token: 0x060159DF RID: 88543 RVA: 0x00645A50 File Offset: 0x00643C50
	[return: Nullable(2)]
	private string ReplacePcKey(string inString, string replaceString, int pcKeyId)
	{
		PcKey? pcKeyConfigById = InputSettingsConfig.Instance.GetPcKeyConfigById(pcKeyId);
		if (pcKeyConfigById == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应Pc按键配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pcKeyId", pcKeyId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string pcKeyIconPathByCurrentPlatform = InputKeyUtils.GetPcKeyIconPathByCurrentPlatform(pcKeyConfigById.Value.KeyName);
		if (StringUtils.IsEmpty(pcKeyIconPathByCurrentPlatform))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "按键配置了空的图标路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("pcKeyId", pcKeyId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		string newValue = "<texture=" + pcKeyIconPathByCurrentPlatform + ">";
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E0 RID: 88544 RVA: 0x00645B0C File Offset: 0x00643D0C
	[return: Nullable(2)]
	private string ReplaceGamepadKey(string inString, string replaceString, int gamepadKeyId)
	{
		GamepadKey? gamepadKeyConfigById = InputSettingsConfig.Instance.GetGamepadKeyConfigById(gamepadKeyId);
		if (gamepadKeyConfigById == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应Gamepad按键配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gamepadKeyId", gamepadKeyId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string keyIconPath = gamepadKeyConfigById.Value.KeyIconPath;
		if (StringUtils.IsEmpty(keyIconPath))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "按键配置了空的图标路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("gamepadKeyId", gamepadKeyId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		string newValue = "<texture=" + keyIconPath + ">";
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E1 RID: 88545 RVA: 0x00645BC4 File Offset: 0x00643DC4
	[return: Nullable(2)]
	private string ReplaceSkillIcon(string inString, string replaceString, int skillId)
	{
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		if (skillConfigById == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string icon = skillConfigById.Value.Icon;
		string newValue = "<texture=" + icon + ">";
		if (StringUtils.IsEmpty(icon))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "技能配置了空的图标路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("skillId", skillId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E2 RID: 88546 RVA: 0x00645C7C File Offset: 0x00643E7C
	[return: Nullable(2)]
	private string ReplaceActionKey(string inString, string replaceString, int actionId)
	{
		InputActionBinding actionBindingByConfigId = InputSettingsManager.Instance.GetActionBindingByConfigId(actionId);
		if (actionBindingByConfigId == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应ActionBinding";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", actionId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string text = InputSettingsManager.Instance.CheckGetActionKeyIconPath(actionBindingByConfigId);
		if (StringUtils.IsEmpty(text))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "Action配置了空的图标路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("actionId", actionId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		string newValue = "<texture=" + text + ">";
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E3 RID: 88547 RVA: 0x00645D28 File Offset: 0x00643F28
	[return: Nullable(2)]
	private string ReplaceExploreIcon(string inString, string replaceString, int phantomSkillId)
	{
		ExploreTools? exploreDataBySkillId = RouletteModel.Instance.GetExploreDataBySkillId(phantomSkillId);
		if (exploreDataBySkillId == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应探索幻象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("phantomId", phantomSkillId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string battleViewIcon = exploreDataBySkillId.Value.BattleViewIcon;
		if (StringUtils.IsEmpty(battleViewIcon))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "探索幻象图标路径为空";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("phantomId", phantomSkillId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		string newValue = "<texture=" + battleViewIcon + ">";
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E4 RID: 88548 RVA: 0x00645DE0 File Offset: 0x00643FE0
	[return: Nullable(2)]
	private string ReplacePhantomIcon(string inString, string replaceString, int phantomId)
	{
		PhantomBattleInstance phantomInstanceByItemId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(phantomId);
		if (phantomInstanceByItemId == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应战斗幻象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("phantomId", phantomId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		PhantomSkill? phantomSkillInfoByLevel = phantomInstanceByItemId.GetPhantomSkillInfoByLevel();
		if (phantomSkillInfoByLevel == null)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "找不到对应战斗幻象技能";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("phantomId", phantomId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		string battleViewIcon = phantomSkillInfoByLevel.Value.BattleViewIcon;
		if (StringUtils.IsEmpty(battleViewIcon))
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.LguiUtil;
			ELogAuthor author3 = ELogAuthor.XXJ;
			string message3 = "战斗幻象图标路径为空";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("phantomId", phantomId);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return null;
		}
		string newValue = "<texture=" + battleViewIcon + ">";
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E5 RID: 88549 RVA: 0x00645ED4 File Offset: 0x006440D4
	[return: Nullable(2)]
	private string ReplacePlatformIcon(string inString, string replaceString, int iconId)
	{
		PlatformIcon? platformIconConfig = InputSettingsConfig.Instance.GetPlatformIconConfig(iconId);
		if (platformIconConfig == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "找不到对应多端平台图标配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("iconId", iconId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string text = platformIconConfig.Value.IconPath;
		if (Info.Instance.IsInTouch())
		{
			text = platformIconConfig.Value.MobileIconPath;
		}
		if (StringUtils.IsEmpty(text))
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.LguiUtil;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "多端图标路径为空";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("iconId", iconId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		string newValue = "<texture=" + text + ">";
		return inString.Replace(replaceString, newValue);
	}

	// Token: 0x060159E6 RID: 88550 RVA: 0x00645FA8 File Offset: 0x006441A8
	private int? ParseWildCardToId(string inString, Regex regexp)
	{
		Match match = regexp.Match(inString);
		if (!match.Success)
		{
			return null;
		}
		return new int?(int.Parse(match.Value.Split('=', StringSplitOptions.None)[1]));
	}

	// Token: 0x060159E7 RID: 88551 RVA: 0x00645FEC File Offset: 0x006441EC
	public string GetActorFullPath([Nullable(2)] AActor actor)
	{
		string empty = string.Empty;
		ULGUIBPLibrary.GetFullPathOfActor(GlobalData.World, actor, ref empty);
		return empty;
	}

	// Token: 0x060159E8 RID: 88552 RVA: 0x0064600E File Offset: 0x0064420E
	public string ScreenShot(string path, bool bAddFilenameSuffix)
	{
		return UBlueprintPathsLibrary.ProjectUserDir() + path;
	}

	// Token: 0x060159E9 RID: 88553 RVA: 0x0064601B File Offset: 0x0064421B
	public void ResetShot()
	{
	}

	// Token: 0x060159EA RID: 88554 RVA: 0x00646020 File Offset: 0x00644220
	public void ClearAttachChildren(UUIItem item)
	{
		for (int i = item.AttachChildren.Num() - 1; i >= 0; i--)
		{
			ULGUIBPLibrary.DeleteActor(item.AttachChildren.Get(i).GetOwner(), true);
		}
	}

	// Token: 0x060159EB RID: 88555 RVA: 0x0064605C File Offset: 0x0064425C
	public void LoadAndSetText(UUIText text, string content, string[] prefabs, Action<AActor[]> callback, string memoryTag = "js_undefined")
	{
		this.ClearAttachChildren(text);
		AActor[] callbackParameter = new AActor[prefabs.Length];
		UPrefabAsset[] prefabAssets = new UPrefabAsset[prefabs.Length];
		string realMemoryTag = this.GetRootActorMemoryTag(text, memoryTag);
		int loadedNum = 0;
		for (int i = 0; i < prefabs.Length; i++)
		{
			string path2 = prefabs[i];
			int currentIndex = i;
			ResourceSystem.Instance.LoadAsync<UPrefabAsset>(path2, delegate([Nullable(2)] UPrefabAsset asset, string path)
			{
				prefabAssets[currentIndex] = asset;
				int loadedNum = loadedNum;
				loadedNum++;
				if (loadedNum >= prefabs.Length)
				{
					if (!text.IsValid())
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.LguiUtil;
						ELogAuthor author = ELogAuthor.LZK;
						string message = "加载预制体回来后text节点已销毁";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("prefabs", string.Join(",", prefabs));
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					for (int j = 0; j < prefabAssets.Length; j++)
					{
						UPrefabAsset prefabAsset = prefabAssets[j];
						AActor aactor = ULGUIBPLibrary.LoadPrefabWithAsset(GlobalData.World, prefabAsset, text);
						LguiUtil.SetRootActorMemoryTag(aactor, realMemoryTag);
						UUIItem uuiitem = aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
						if (uuiitem != null)
						{
							uuiitem.SetPivot(FVector2D.ZeroVector);
							callbackParameter[j] = aactor;
						}
					}
					text.SetText(content, true);
					Action<AActor[]> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(callbackParameter);
				}
			}, 100, realMemoryTag);
		}
	}

	// Token: 0x060159EC RID: 88556 RVA: 0x00646134 File Offset: 0x00644334
	[NullableContext(2)]
	public void SetActorIsPermanent(AActor actor, bool isPermanent, bool hasChild)
	{
		if (actor == null)
		{
			global::Log.Instance.Warn(ELogModule.LguiUtil, ELogAuthor.XXJ, "无缝切换传入Actor异常,Actor为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!actor.IsValid())
		{
			global::Log.Instance.Warn(ELogModule.LguiUtil, ELogAuthor.XXJ, "无缝切换传入Actor异常,Actor IsValid", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKuroStaticLibrary.SetActorPermanent(actor, isPermanent, hasChild);
	}

	// Token: 0x060159ED RID: 88557 RVA: 0x00646194 File Offset: 0x00644394
	[return: Nullable(2)]
	public AUIBaseActor GetChildActorByHierarchyIndex(AUIBaseActor actor, int findHierarchyIndex = 0)
	{
		UUIItem uiitem = actor.GetUIItem();
		if (uiitem == null)
		{
			return null;
		}
		UUIItem attachUIChild = uiitem.GetAttachUIChild(findHierarchyIndex);
		return ((attachUIChild != null) ? attachUIChild.GetOwner() : null) as AUIBaseActor;
	}

	// Token: 0x060159EE RID: 88558 RVA: 0x006461C5 File Offset: 0x006443C5
	[NullableContext(2)]
	public ULGUIComponentsRegistry GetComponentsRegistry(AActor findActor)
	{
		return ((findActor != null) ? findActor.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) : null) as ULGUIComponentsRegistry;
	}

	// Token: 0x060159EF RID: 88559 RVA: 0x006461E4 File Offset: 0x006443E4
	[NullableContext(2)]
	[return: Nullable(1)]
	public string GetRootActorMemoryTag(UUIItem uiItem, string memoryTag = null)
	{
		if (memoryTag == null)
		{
			memoryTag = "js_undefined";
		}
		string text = memoryTag;
		if (ResourceSystem.Instance.IsMemoryTagOpen() && uiItem != null)
		{
			string text2 = ULGUIBPLibrary.GetRootActorMemoryTag(uiItem).ToString();
			if (!StringUtils.IsBlank(text2))
			{
				string[] array = text2.Split('.', StringSplitOptions.None);
				if (array.Length != 0)
				{
					string[] array2 = array;
					if (array2[array2.Length - 1] == memoryTag)
					{
						text = text2;
						goto IL_7D;
					}
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(text2);
				stringBuilder.Append('.');
				stringBuilder.Append(memoryTag);
				text = stringBuilder.ToString();
			}
		}
		IL_7D:
		return text.ToString();
	}

	// Token: 0x060159F0 RID: 88560 RVA: 0x00646274 File Offset: 0x00644474
	public static void SetRootActorMemoryTag([Nullable(2)] AActor actor, string memoryTag)
	{
		if (actor == null)
		{
			return;
		}
		if (ResourceSystem.Instance.IsMemoryTagOpen())
		{
			AUIBaseActor auibaseActor = actor as AUIBaseActor;
			if (auibaseActor != null)
			{
				FName? dynamicFName = FNameUtil.GetDynamicFName(memoryTag);
				ULGUIBPLibrary.SetRootActorMemoryTag(auibaseActor.GetUIItem(), dynamicFName.Value);
			}
		}
	}

	// Token: 0x060159F1 RID: 88561 RVA: 0x006462B4 File Offset: 0x006444B4
	public void ConvertPointerPositionToLguiCenterPosition(FVector vector, Vector2D outVector)
	{
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		if (canvasScaler == null)
		{
			return;
		}
		float width = UiLayer.Instance.UiRootItem.GetWidth();
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		outVector.Set((double)vector.X, (double)vector.Y);
		ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
		FVector2D fvector2D = outVector.ToUeVector2D(false);
		FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		outVector.FromUeVector2D(fvector2D2);
		outVector.X = MathCommon.Clamp(outVector.X, 0.0, (double)width);
		outVector.Y = MathCommon.Clamp(outVector.Y, 0.0, (double)height);
		outVector.X -= (double)(width / 2f);
		outVector.Y -= (double)(height / 2f);
	}

	// Token: 0x060159F2 RID: 88562 RVA: 0x0064638C File Offset: 0x0064458C
	public void ConvertPointerPositionToLguiCenterPosition(FVector2D vector, Vector2D outVector)
	{
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		if (canvasScaler == null)
		{
			return;
		}
		float width = UiLayer.Instance.UiRootItem.GetWidth();
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		outVector.Set((double)vector.X, (double)vector.Y);
		ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
		FVector2D fvector2D = outVector.ToUeVector2D(false);
		FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		outVector.FromUeVector2D(fvector2D2);
		outVector.X = MathCommon.Clamp(outVector.X, 0.0, (double)width);
		outVector.Y = MathCommon.Clamp(outVector.Y, 0.0, (double)height);
		outVector.X -= (double)(width / 2f);
		outVector.Y -= (double)(height / 2f);
	}

	// Token: 0x060159F3 RID: 88563 RVA: 0x00646464 File Offset: 0x00644664
	public FVector2D ConvertPointerPositionToLguiCenterPosition(FVector vector)
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		ULGUICanvasScaler canvasScaler = uiRootItem.GetCanvasScaler();
		if (canvasScaler == null)
		{
			return new FVector2D(float.NaN, float.NaN);
		}
		float width = uiRootItem.GetWidth();
		float height = uiRootItem.GetHeight();
		ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
		FVector2D fvector2D = new FVector2D(vector.X, vector.Y);
		FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		fvector2D2.X = MathCommon.Clamp(fvector2D2.X, 0f, width);
		fvector2D2.Y = MathCommon.Clamp(fvector2D2.Y, 0f, height);
		fvector2D2.X -= width / 2f;
		fvector2D2.Y -= height / 2f;
		return fvector2D2;
	}

	// Token: 0x060159F4 RID: 88564 RVA: 0x0064651C File Offset: 0x0064471C
	public void ConvertPointerPositionToLguiPosition(FVector vector, Vector2D outVector)
	{
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		if (canvasScaler == null)
		{
			return;
		}
		float width = UiLayer.Instance.UiRootItem.GetWidth();
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		outVector.Set((double)vector.X, (double)vector.Y);
		ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
		FVector2D fvector2D = outVector.ToUeVector2D(false);
		FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		outVector.FromUeVector2D(fvector2D2);
		outVector.X = MathCommon.Clamp(outVector.X, 0.0, (double)width);
		outVector.Y = MathCommon.Clamp(outVector.Y, 0.0, (double)height);
	}

	// Token: 0x060159F5 RID: 88565 RVA: 0x006465C8 File Offset: 0x006447C8
	public void ConvertPointerPositionToLguiPosition(FVector2D vector, Vector2D outVector)
	{
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		if (canvasScaler == null)
		{
			return;
		}
		float width = UiLayer.Instance.UiRootItem.GetWidth();
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		outVector.Set((double)vector.X, (double)vector.Y);
		ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
		FVector2D fvector2D = outVector.ToUeVector2D(false);
		FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		outVector.FromUeVector2D(fvector2D2);
		outVector.X = MathCommon.Clamp(outVector.X, 0.0, (double)width);
		outVector.Y = MathCommon.Clamp(outVector.Y, 0.0, (double)height);
	}

	// Token: 0x060159F6 RID: 88566 RVA: 0x00646673 File Offset: 0x00644873
	public void ConvertSceneActorPositionToLguiPosition(AActor actor, global::Vector outVector)
	{
		this.ConvertWorldPositionToLguiPosition(actor.D_K2_GetActorLocation(), outVector);
	}

	// Token: 0x060159F7 RID: 88567 RVA: 0x00646684 File Offset: 0x00644884
	public void ConvertWorldPositionToLguiPosition(FVectorDouble worldPosition, global::Vector outVector)
	{
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		if (canvasScaler == null)
		{
			return;
		}
		FVector2D fvector2D = default(FVector2D);
		if (!UGameplayStatics.D_ProjectWorldToScreen(Global.CharacterController, worldPosition, ref fvector2D, false))
		{
			return;
		}
		FVector2D fvector2D2 = canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		float width = UiLayer.Instance.UiRootItem.GetWidth();
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		outVector.Set((double)(fvector2D2.X - width / 2f), 0.0, (double)(fvector2D2.Y - height / 2f));
	}

	// Token: 0x060159F8 RID: 88568 RVA: 0x00646717 File Offset: 0x00644917
	public global::Vector GetAdaptiveTipsPosition(UUIItem clickItem, UUIItem tipsItem, float realWidth = 0f)
	{
		return this.GetAdaptiveTipsPositionByParam(clickItem, tipsItem, new AdaptiveTipsPositionParam
		{
			RealWidth = realWidth
		});
	}

	// Token: 0x060159F9 RID: 88569 RVA: 0x00646730 File Offset: 0x00644930
	public global::Vector GetAdaptiveTipsPositionByParam(UUIItem clickItem, UUIItem tipsItem, [Nullable(2)] AdaptiveTipsPositionParam param = null)
	{
		float num = (param != null) ? param.RealWidth : 0f;
		float num2 = (param != null) ? param.RealHeight : 0f;
		float num3 = (param != null) ? param.LeftOffset : 0f;
		float num4 = (param != null) ? param.TopOffset : 0f;
		float num5 = (param != null) ? param.RightOffset : 0f;
		float num6 = (param != null) ? param.BottomOffset : 0f;
		FVector uiworldPosition = clickItem.GetUIWorldPosition();
		FVector uiworldPosition2 = tipsItem.GetUIWorldPosition();
		float num7 = (num == 0f) ? tipsItem.Width : num;
		float num8 = (num2 == 0f) ? tipsItem.Height : num2;
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		float num9 = viewportSize.X / viewportScale;
		float num10 = viewportSize.Y / viewportScale;
		float num11 = num9 / 2f;
		float num12 = num10 / 2f;
		float num13 = uiworldPosition.X + clickItem.Width / 2f;
		float z = uiworldPosition.Z;
		bool flag = num13 + num7 < num11;
		bool flag2 = z - num8 > -num12 + 10f;
		float num14;
		if (flag)
		{
			num14 = num13 + num7 / 2f + num5;
		}
		else
		{
			num14 = uiworldPosition.X - clickItem.Width / 2f - num7 / 2f + num3;
		}
		float num15;
		if (flag2)
		{
			num15 = z + num4;
		}
		else
		{
			num15 = -num12 + num8 + num6;
		}
		return global::Vector.Create((double)num14, (double)uiworldPosition2.Y, (double)num15);
	}

	// Token: 0x060159FA RID: 88570 RVA: 0x006468C0 File Offset: 0x00644AC0
	public static float AdaptFieldOfViewByViewport(float fov, float aspectRatio)
	{
		Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
		float num = MathCommon.DegreeToRadian(fov);
		double num2 = viewportSize.X / viewportSize.Y;
		return MathCommon.RadianToDegree((float)(Math.Atan((double)aspectRatio / num2 * Math.Tan((double)(num / 2f))) * 2.0));
	}

	// Token: 0x060159FB RID: 88571 RVA: 0x00646914 File Offset: 0x00644B14
	public LTweenEase CoverEaseTypeToTweenEase(EEaseType easeType)
	{
		LTweenEase result;
		switch (easeType)
		{
		case EEaseType.Linear:
			result = LTweenEase.Linear;
			break;
		case EEaseType.Transient:
			result = LTweenEase.Linear;
			break;
		case EEaseType.InOutCubic:
			result = LTweenEase.InOutCubic;
			break;
		case EEaseType.OutSine:
			result = LTweenEase.OutSine;
			break;
		case EEaseType.OutQuart:
			result = LTweenEase.OutQuart;
			break;
		default:
			result = LTweenEase.Linear;
			break;
		}
		return result;
	}

	// Token: 0x170020CA RID: 8394
	// (get) Token: 0x060159FC RID: 88572 RVA: 0x00646955 File Offset: 0x00644B55
	public static LguiUtil Instance
	{
		get
		{
			if (LguiUtil._instance == null)
			{
				LguiUtil._instance = new LguiUtil();
				LguiUtil._instance.OnInit();
			}
			return LguiUtil._instance;
		}
	}

	// Token: 0x060159FD RID: 88573 RVA: 0x00646978 File Offset: 0x00644B78
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060159FE RID: 88574 RVA: 0x0064697A File Offset: 0x00644B7A
	public static void ResetStaticDefaultValue()
	{
		LguiUtil instance = LguiUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LguiUtil._instance = null;
	}

	// Token: 0x060159FF RID: 88575 RVA: 0x00646994 File Offset: 0x00644B94
	static LguiUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LguiUtil.CreateStaticDefaultValue), new Action(LguiUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0400B68E RID: 46734
	private const string PC_KEY_ID = "PcKeyId=";

	// Token: 0x0400B68F RID: 46735
	private const string GAMEPAD_KEY_ID = "GamepadKeyId=";

	// Token: 0x0400B690 RID: 46736
	private const string ACTION_ID_KEY = "ActionId=";

	// Token: 0x0400B691 RID: 46737
	private const string SKILL_ID_KEY = "SkillId=";

	// Token: 0x0400B692 RID: 46738
	private const string ROLE_ID_KEY = "RoleId=";

	// Token: 0x0400B693 RID: 46739
	private const string EXPLORE_ID_KEY = "ExploreId=";

	// Token: 0x0400B694 RID: 46740
	private const string PHANTOM_ID_KEY = "PhantomId=";

	// Token: 0x0400B695 RID: 46741
	private const string ICON_ID_KEY = "IconId=";

	// Token: 0x0400B696 RID: 46742
	private const string PC_KEY_ID_MATCH = "PcKeyId=[0-9]+";

	// Token: 0x0400B697 RID: 46743
	private const string GAMEPAD_KEY_ID_MATCH = "GamepadKeyId=[0-9]+";

	// Token: 0x0400B698 RID: 46744
	private const string ACTION_ID_MATCH = "ActionId=[0-9]+";

	// Token: 0x0400B699 RID: 46745
	private const string SKILL_ID_MATCH = "SkillId=[0-9]+";

	// Token: 0x0400B69A RID: 46746
	private const string ROLE_ID_MATCH = "RoleId=[0-9]+";

	// Token: 0x0400B69B RID: 46747
	private const string EXPLORE_ID_MATCH = "ExploreId=[0-9]+";

	// Token: 0x0400B69C RID: 46748
	private const string PHANTOM_ID_MATCH = "PhantomId=[0-9]+";

	// Token: 0x0400B69D RID: 46749
	private const string ICON_ID_MATCH = "IconId=[0-9]+";

	// Token: 0x0400B69E RID: 46750
	[StaticVariableRuleIgnore]
	private static Regex pcKeyFormatRegex = new Regex("{<PcKeyId=[0-9]+>}");

	// Token: 0x0400B69F RID: 46751
	[StaticVariableRuleIgnore]
	private static Regex gamepadFormatRegex = new Regex("{<GamepadKeyId=[0-9]+>}");

	// Token: 0x0400B6A0 RID: 46752
	[StaticVariableRuleIgnore]
	private static Regex actionFormatRegex = new Regex("{<ActionId=[0-9]+>}");

	// Token: 0x0400B6A1 RID: 46753
	[StaticVariableRuleIgnore]
	private static Regex skillFormatRegex = new Regex("{<ActionId=[0-9]+><SkillId=[0-9]+>}");

	// Token: 0x0400B6A2 RID: 46754
	[StaticVariableRuleIgnore]
	private static Regex dtSkillFormatRegex = new Regex("{<ActionId=[0-9]+><RoleId=[0-9]+><SkillId=[0-9]+>}");

	// Token: 0x0400B6A3 RID: 46755
	[StaticVariableRuleIgnore]
	private static Regex exploreFormatRegex = new Regex("{<ActionId=[0-9]+><ExploreId=[0-9]+>}");

	// Token: 0x0400B6A4 RID: 46756
	[StaticVariableRuleIgnore]
	private static Regex phantomFormatRegex = new Regex("{<ActionId=[0-9]+><PhantomId=[0-9]+>}");

	// Token: 0x0400B6A5 RID: 46757
	[StaticVariableRuleIgnore]
	private static Regex iconFormatRegex = new Regex("{<IconId=[0-9]+>}");

	// Token: 0x0400B6A6 RID: 46758
	[StaticVariableRuleIgnore]
	private static Regex pcKeyIdFormatRegex = new Regex("PcKeyId=[0-9]+");

	// Token: 0x0400B6A7 RID: 46759
	[StaticVariableRuleIgnore]
	private static Regex gamepadIdFormatRegex = new Regex("GamepadKeyId=[0-9]+");

	// Token: 0x0400B6A8 RID: 46760
	[StaticVariableRuleIgnore]
	private static Regex actionIdFormatRegex = new Regex("ActionId=[0-9]+");

	// Token: 0x0400B6A9 RID: 46761
	[StaticVariableRuleIgnore]
	private static Regex skillIdFormatRegex = new Regex("SkillId=[0-9]+");

	// Token: 0x0400B6AA RID: 46762
	[StaticVariableRuleIgnore]
	private static Regex exploreIdFormatRegex = new Regex("ExploreId=[0-9]+");

	// Token: 0x0400B6AB RID: 46763
	[StaticVariableRuleIgnore]
	private static Regex phantomIdFormatRegex = new Regex("PhantomId=[0-9]+");

	// Token: 0x0400B6AC RID: 46764
	[StaticVariableRuleIgnore]
	private static Regex iconIdFormatRegex = new Regex("IconId=[0-9]+");

	// Token: 0x0400B6AD RID: 46765
	[Nullable(2)]
	private static LguiUtil _instance;
}
