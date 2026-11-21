using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B53 RID: 19283
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonInputViewBase : UiTickViewBase
	{
		// Token: 0x0603030A RID: 197386 RVA: 0x00D6FAAF File Offset: 0x00D6DCAF
		protected CommonInputViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603030B RID: 197387 RVA: 0x00D6FAD4 File Offset: 0x00D6DCD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITextInputComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<bool>(this.ActiveInputText));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.CancelClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603030C RID: 197388 RVA: 0x00D6FCA8 File Offset: 0x00D6DEA8
		private void ActiveInputText(bool active)
		{
			if (active && this.TipsType.GetValueOrDefault() == ETipsType.NoneText)
			{
				this.RefreshTips(ETipsType.Normal);
			}
		}

		// Token: 0x0603030D RID: 197389 RVA: 0x00D6FCC2 File Offset: 0x00D6DEC2
		private void CancelClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603030E RID: 197390 RVA: 0x00D6FCCB File Offset: 0x00D6DECB
		protected virtual bool ExtraConfirmCheck(int count, string text)
		{
			return true;
		}

		// Token: 0x0603030F RID: 197391 RVA: 0x00D6FCD0 File Offset: 0x00D6DED0
		private void ConfirmClick()
		{
			string text = this.InputText.GetText();
			int stringRealCount = StringUtils.GetStringRealCount(text);
			if (this.InputData.NeedCheckBlank != null && this.InputData.NeedCheckBlank.Value && text.Length > 0 && StringUtils.CheckIsOnlyBlank(text))
			{
				this.RefreshTips(ETipsType.Blank);
				return;
			}
			if (stringRealCount > this.GetMaxLimit())
			{
				this.RefreshTips(ETipsType.MsgTooLong);
				this.Timer = 0f;
				return;
			}
			if (stringRealCount == 0 && this.InputData.IsCheckNone)
			{
				this.RefreshTips(ETipsType.NoneText);
				this.Timer = 0f;
				return;
			}
			if (stringRealCount < this.GetMinLimit())
			{
				this.RefreshTips(ETipsType.MsgTooShort);
				this.Timer = 0f;
				return;
			}
			if (!this.ExtraConfirmCheck(stringRealCount, text))
			{
				return;
			}
			this.ExecuteInputConfirm(text);
		}

		// Token: 0x06030310 RID: 197392 RVA: 0x00D6FDA0 File Offset: 0x00D6DFA0
		protected virtual void ExecuteInputConfirm(string inputText)
		{
			CommonInputViewBase.<>c__DisplayClass14_0 CS$<>8__locals1 = new CommonInputViewBase.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.inputText = inputText;
			CS$<>8__locals1.<ExecuteInputConfirm>g__Temp|0().Forget(delegate(Exception exception)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.XXJ, "通用输入框执行出现未知错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, true);
		}

		// Token: 0x06030311 RID: 197393 RVA: 0x00D6FDE0 File Offset: 0x00D6DFE0
		protected override void OnBeforeCreate()
		{
			this.InputData = (this.OpenParam as ICommonInputViewData);
			Dictionary<ETipsType, Action> dictionary = new Dictionary<ETipsType, Action>();
			dictionary[ETipsType.Normal] = new Action(this.NormalHandle);
			dictionary[ETipsType.NoneText] = new Action(this.NoneTextHandle);
			dictionary[ETipsType.MsgTooLong] = new Action(this.MsgTooLongHandle);
			dictionary[ETipsType.MsgTooShort] = new Action(this.MsgTooShortHandle);
			dictionary[ETipsType.IllegalCharacters] = new Action(this.IllegalCharactersHandle);
			dictionary[ETipsType.Blank] = new Action(this.BlankTextHandle);
			dictionary[ETipsType.InValidCdKey] = new Action(this.InValidCdKeyHandle);
			dictionary[ETipsType.CdKeyInCd] = new Action(this.CdKeyInCdHandle);
			this.TipsTypeFunc = dictionary;
		}

		// Token: 0x06030312 RID: 197394 RVA: 0x00D6FEA1 File Offset: 0x00D6E0A1
		private void NormalHandle()
		{
			this.SetTipsVisible(false);
			this.ConfirmButton.SetSelfInteractive(true);
			this.Timer = -1f;
		}

		// Token: 0x06030313 RID: 197395 RVA: 0x00D6FEC1 File Offset: 0x00D6E0C1
		private void NoneTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Entertext_Text", 0, Array.Empty<string>());
		}

		// Token: 0x06030314 RID: 197396 RVA: 0x00D6FED4 File Offset: 0x00D6E0D4
		private void MsgTooLongHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textoverlength_Text", -1, Array.Empty<string>());
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x06030315 RID: 197397 RVA: 0x00D6FEF3 File Offset: 0x00D6E0F3
		private void MsgTooShortHandle()
		{
			this.SetTipsAndTimer("CDKey_TooShort", 0, Array.Empty<string>());
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x06030316 RID: 197398 RVA: 0x00D6FF12 File Offset: 0x00D6E112
		private void IllegalCharactersHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textillegality_Text", 0, Array.Empty<string>());
		}

		// Token: 0x06030317 RID: 197399 RVA: 0x00D6FF25 File Offset: 0x00D6E125
		private void BlankTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_TextNull_Text", 0, Array.Empty<string>());
		}

		// Token: 0x06030318 RID: 197400 RVA: 0x00D6FF38 File Offset: 0x00D6E138
		private void InValidCdKeyHandle()
		{
			this.SetTipsTextAndTimer(this.CdKeyErrorText, 0);
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x06030319 RID: 197401 RVA: 0x00D6FF54 File Offset: 0x00D6E154
		private void CdKeyInCdHandle()
		{
			string text = CdKeyInputController.GetCdKeyUseCd().ToString();
			this.SetTipsAndTimer("CDKey_CDtime", 0, new string[]
			{
				text
			});
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603031A RID: 197402 RVA: 0x00D6FF94 File Offset: 0x00D6E194
		private void SetTipsAndTimer(string textId, int timer, params string[] textParam)
		{
			this.SetTipsVisible(true);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, textId, textParam);
			this.Timer = (float)timer;
		}

		// Token: 0x0603031B RID: 197403 RVA: 0x00D6FFC5 File Offset: 0x00D6E1C5
		private void SetTipsTextAndTimer(string text, int timer)
		{
			this.SetTipsVisible(true);
			base.GetText(2).SetText(text, true);
			this.Timer = (float)timer;
		}

		// Token: 0x0603031C RID: 197404 RVA: 0x00D6FFE4 File Offset: 0x00D6E1E4
		protected void SetBottomTipsTextAndColor(string text, FColor color)
		{
			UUIText text2 = base.GetText(8);
			LguiUtil.Instance.SetLocalTextNew(text2, text, Array.Empty<object>());
			text2.SetColor(color);
		}

		// Token: 0x0603031D RID: 197405 RVA: 0x00D70011 File Offset: 0x00D6E211
		protected void SetBottomTipsShowState(bool state)
		{
			base.GetText(8).SetUIActive(state);
		}

		// Token: 0x0603031E RID: 197406 RVA: 0x00D70020 File Offset: 0x00D6E220
		protected override void OnBeforeShow()
		{
			this.InitSelfParam();
			this.RefreshTitle();
			this.RefreshTips(ETipsType.Normal);
			this.InitExtraParam();
		}

		// Token: 0x0603031F RID: 197407 RVA: 0x00D7003C File Offset: 0x00D6E23C
		protected void SetClearOrPaste()
		{
			if (this.FunctionButton == null)
			{
				return;
			}
			if (this.InputText.GetText() == "")
			{
				this.FunctionButton.RefreshSprite("SP_Paste");
				this.FunctionButton.BindCallback(new Action(this.OnClickPasteBtn));
				return;
			}
			this.FunctionButton.RefreshSprite("SP_Clear");
			this.FunctionButton.BindCallback(new Action(this.OnClickClearBtn));
		}

		// Token: 0x06030320 RID: 197408 RVA: 0x00D700B8 File Offset: 0x00D6E2B8
		private void OnClickClearBtn()
		{
			this.InputText.SetText("", true);
		}

		// Token: 0x06030321 RID: 197409 RVA: 0x00D700CC File Offset: 0x00D6E2CC
		private void OnClickPasteBtn()
		{
			if (Platform.Instance.IsCloudGame())
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					string empty2 = string.Empty;
					ULGUIBPLibrary.ClipBoardPaste(ref empty2);
					if (!string.IsNullOrEmpty(empty2))
					{
						this.InputText.SetText(empty2, true);
					}
				}, 200f, null, null, true, 1f);
				return;
			}
			string empty = string.Empty;
			ULGUIBPLibrary.ClipBoardPaste(ref empty);
			if (!string.IsNullOrEmpty(empty))
			{
				this.InputText.SetText(empty, true);
			}
		}

		// Token: 0x06030322 RID: 197410 RVA: 0x00D7012C File Offset: 0x00D6E32C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.OnNameChange));
			EventSystem.Instance.Add(EEventName.OnSignChange, new Action(this.OnSignChange));
		}

		// Token: 0x06030323 RID: 197411 RVA: 0x00D70166 File Offset: 0x00D6E366
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.OnNameChange));
			EventSystem.Instance.Remove(EEventName.OnSignChange, new Action(this.OnSignChange));
		}

		// Token: 0x06030324 RID: 197412 RVA: 0x00D701A0 File Offset: 0x00D6E3A0
		private void OnNameChange()
		{
			string textById = TextConfig.Instance.GetTextById("SetNameSuccess");
			ScrollingTipsController.Instance.ShowTipsByText(textById);
		}

		// Token: 0x06030325 RID: 197413 RVA: 0x00D701C8 File Offset: 0x00D6E3C8
		private void OnSignChange()
		{
			string textById = TextConfig.Instance.GetTextById("SetSignSuccess");
			ScrollingTipsController.Instance.ShowTipsByText(textById);
		}

		// Token: 0x06030326 RID: 197414 RVA: 0x00D701F0 File Offset: 0x00D6E3F0
		protected override void OnTick(float delta)
		{
			if (this.Timer == -1f)
			{
				return;
			}
			this.Timer += delta;
			if (this.Timer >= 2000f)
			{
				this.RefreshTips(ETipsType.Normal);
			}
		}

		// Token: 0x06030327 RID: 197415 RVA: 0x00D70222 File Offset: 0x00D6E422
		protected override void OnBeforeDestroy()
		{
			this.UnBindTextChange();
			this.FunctionButton = null;
			this.InputText = null;
			this.ConfirmButton = null;
		}

		// Token: 0x06030328 RID: 197416 RVA: 0x00D70240 File Offset: 0x00D6E440
		private void InitSelfParam()
		{
			bool flag = !Info.Instance.IsHomeConsolePlatform();
			if (flag)
			{
				this.FunctionButton = new ButtonAndSpriteItem(base.GetItem(7));
			}
			base.GetItem(7).SetUIActive(flag && this.InputData.NeedFunctionButton);
			this.ConfirmButton = base.GetButton(4);
			this.InputText = base.GetInputText(5);
			this.InputText.bAllowMultiLine = this.IsAllowMultiLine();
			this.InputText.OnTextChange.Bind(new Action<string>(this.OnTextChange));
			this.InputText.SetText(this.InputData.InputText, true);
			base.GetText(6).SetText(this.InputData.DefaultText, true);
			this.SetClearOrPaste();
			this.SetTipsVisible(false);
			string bottomTipsText = this.InputData.BottomTipsText;
			if (!string.IsNullOrEmpty(bottomTipsText))
			{
				this.SetBottomTipsShowState(true);
				base.GetText(8).SetText(bottomTipsText, true);
			}
			else
			{
				this.SetBottomTipsShowState(false);
			}
			string bottomTipsColor = this.InputData.BottomTipsColor;
			if (!string.IsNullOrEmpty(bottomTipsColor))
			{
				base.GetText(8).SetColor(FColor.FromHex(bottomTipsColor));
			}
		}

		// Token: 0x06030329 RID: 197417 RVA: 0x00D70368 File Offset: 0x00D6E568
		protected void SetTipsVisible(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x0603032A RID: 197418 RVA: 0x00D70377 File Offset: 0x00D6E577
		protected virtual void InitExtraParam()
		{
		}

		// Token: 0x0603032B RID: 197419 RVA: 0x00D70379 File Offset: 0x00D6E579
		private void UnBindTextChange()
		{
			this.InputText.OnTextChange.Unbind();
		}

		// Token: 0x0603032C RID: 197420 RVA: 0x00D7038B File Offset: 0x00D6E58B
		protected void OnTextChange(string inputText)
		{
			this.SetClearOrPaste();
			if (StringUtils.GetStringRealCount(inputText) <= this.GetMaxLimit())
			{
				this.RefreshTips(ETipsType.Normal);
				this.RefreshDuplicateName(inputText);
				return;
			}
			this.RefreshTips(ETipsType.MsgTooLong);
			this.RefreshDuplicateName(inputText);
		}

		// Token: 0x0603032D RID: 197421 RVA: 0x00D703BE File Offset: 0x00D6E5BE
		private void RefreshTitle()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.InputData.TitleTextArgs.TextKey, this.InputData.TitleTextArgs.Params);
		}

		// Token: 0x0603032E RID: 197422 RVA: 0x00D703F4 File Offset: 0x00D6E5F4
		protected virtual void RefreshTips(ETipsType type)
		{
			ETipsType? tipsType = this.TipsType;
			if (type == tipsType.GetValueOrDefault() & tipsType != null)
			{
				return;
			}
			this.TipsType = new ETipsType?(type);
			this.TipsTypeFunc[type]();
		}

		// Token: 0x0603032F RID: 197423 RVA: 0x00D7043A File Offset: 0x00D6E63A
		protected virtual void RefreshDuplicateName(string inputText)
		{
		}

		// Token: 0x06030330 RID: 197424
		protected abstract int GetMaxLimit();

		// Token: 0x06030331 RID: 197425
		protected abstract bool IsAllowMultiLine();

		// Token: 0x06030332 RID: 197426 RVA: 0x00D7043C File Offset: 0x00D6E63C
		protected virtual int GetMinLimit()
		{
			return 0;
		}

		// Token: 0x040198F0 RID: 104688
		[Nullable(2)]
		protected ICommonInputViewData InputData;

		// Token: 0x040198F1 RID: 104689
		private ETipsType? TipsType;

		// Token: 0x040198F2 RID: 104690
		private float Timer = -1f;

		// Token: 0x040198F3 RID: 104691
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<ETipsType, Action> TipsTypeFunc;

		// Token: 0x040198F4 RID: 104692
		[Nullable(2)]
		protected UUIButtonComponent ConfirmButton;

		// Token: 0x040198F5 RID: 104693
		[Nullable(2)]
		protected UUITextInputComponent InputText;

		// Token: 0x040198F6 RID: 104694
		[Nullable(2)]
		private ButtonAndSpriteItem FunctionButton;

		// Token: 0x040198F7 RID: 104695
		protected string CdKeyErrorText = ConfigMultiTextLang.GetLocalTextNew("CDKey_Error", null);

		// Token: 0x0200A78E RID: 42894
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04033C7C RID: 212092
			public const int Title = 0;

			// Token: 0x04033C7D RID: 212093
			public const int TipsRootItem = 1;

			// Token: 0x04033C7E RID: 212094
			public const int Tips = 2;

			// Token: 0x04033C7F RID: 212095
			public const int CancelBtn = 3;

			// Token: 0x04033C80 RID: 212096
			public const int ConfirmBtn = 4;

			// Token: 0x04033C81 RID: 212097
			public const int InputText = 5;

			// Token: 0x04033C82 RID: 212098
			public const int DefaultText = 6;

			// Token: 0x04033C83 RID: 212099
			public const int ButtonFunction = 7;

			// Token: 0x04033C84 RID: 212100
			public const int BottomTipsText = 8;
		}
	}
}
