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
	// Token: 0x02005B73 RID: 23411
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonInputViewBase : UiTickViewBase
	{
		// Token: 0x0603B3BD RID: 242621 RVA: 0x00E1F53B File Offset: 0x00E1D73B
		protected CommonInputViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3BE RID: 242622 RVA: 0x00E1F560 File Offset: 0x00E1D760
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

		// Token: 0x0603B3BF RID: 242623 RVA: 0x00E1F734 File Offset: 0x00E1D934
		private void ActiveInputText(bool active)
		{
			if (active && this.TipsType.GetValueOrDefault() == ETipsType.NoneText)
			{
				this.RefreshTips(ETipsType.Normal);
			}
		}

		// Token: 0x0603B3C0 RID: 242624 RVA: 0x00E1F74E File Offset: 0x00E1D94E
		private void CancelClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B3C1 RID: 242625 RVA: 0x00E1F757 File Offset: 0x00E1D957
		protected virtual bool ExtraConfirmCheck(int count, string text)
		{
			return true;
		}

		// Token: 0x0603B3C2 RID: 242626 RVA: 0x00E1F75C File Offset: 0x00E1D95C
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

		// Token: 0x0603B3C3 RID: 242627 RVA: 0x00E1F82C File Offset: 0x00E1DA2C
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

		// Token: 0x0603B3C4 RID: 242628 RVA: 0x00E1F86C File Offset: 0x00E1DA6C
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

		// Token: 0x0603B3C5 RID: 242629 RVA: 0x00E1F92D File Offset: 0x00E1DB2D
		private void NormalHandle()
		{
			this.SetTipsVisible(false);
			this.ConfirmButton.SetSelfInteractive(true);
			this.Timer = -1f;
		}

		// Token: 0x0603B3C6 RID: 242630 RVA: 0x00E1F94D File Offset: 0x00E1DB4D
		private void NoneTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Entertext_Text", 0, Array.Empty<string>());
		}

		// Token: 0x0603B3C7 RID: 242631 RVA: 0x00E1F960 File Offset: 0x00E1DB60
		private void MsgTooLongHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textoverlength_Text", -1, Array.Empty<string>());
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B3C8 RID: 242632 RVA: 0x00E1F97F File Offset: 0x00E1DB7F
		private void MsgTooShortHandle()
		{
			this.SetTipsAndTimer("CDKey_TooShort", 0, Array.Empty<string>());
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B3C9 RID: 242633 RVA: 0x00E1F99E File Offset: 0x00E1DB9E
		private void IllegalCharactersHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textillegality_Text", 0, Array.Empty<string>());
		}

		// Token: 0x0603B3CA RID: 242634 RVA: 0x00E1F9B1 File Offset: 0x00E1DBB1
		private void BlankTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_TextNull_Text", 0, Array.Empty<string>());
		}

		// Token: 0x0603B3CB RID: 242635 RVA: 0x00E1F9C4 File Offset: 0x00E1DBC4
		private void InValidCdKeyHandle()
		{
			this.SetTipsTextAndTimer(this.CdKeyErrorText, 0);
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B3CC RID: 242636 RVA: 0x00E1F9E0 File Offset: 0x00E1DBE0
		private void CdKeyInCdHandle()
		{
			string text = CdKeyInputController.GetCdKeyUseCd().ToString();
			this.SetTipsAndTimer("CDKey_CDtime", 0, new string[]
			{
				text
			});
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B3CD RID: 242637 RVA: 0x00E1FA20 File Offset: 0x00E1DC20
		private void SetTipsAndTimer(string textId, int timer, params string[] textParam)
		{
			this.SetTipsVisible(true);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, textId, textParam);
			this.Timer = (float)timer;
		}

		// Token: 0x0603B3CE RID: 242638 RVA: 0x00E1FA51 File Offset: 0x00E1DC51
		private void SetTipsTextAndTimer(string text, int timer)
		{
			this.SetTipsVisible(true);
			base.GetText(2).SetText(text, true);
			this.Timer = (float)timer;
		}

		// Token: 0x0603B3CF RID: 242639 RVA: 0x00E1FA70 File Offset: 0x00E1DC70
		protected void SetBottomTipsTextAndColor(string text, FColor color)
		{
			UUIText text2 = base.GetText(8);
			LguiUtil.Instance.SetLocalTextNew(text2, text, Array.Empty<object>());
			text2.SetColor(color);
		}

		// Token: 0x0603B3D0 RID: 242640 RVA: 0x00E1FA9D File Offset: 0x00E1DC9D
		protected void SetBottomTipsShowState(bool state)
		{
			base.GetText(8).SetUIActive(state);
		}

		// Token: 0x0603B3D1 RID: 242641 RVA: 0x00E1FAAC File Offset: 0x00E1DCAC
		protected override void OnBeforeShow()
		{
			this.InitSelfParam();
			this.RefreshTitle();
			this.RefreshTips(ETipsType.Normal);
			this.InitExtraParam();
		}

		// Token: 0x0603B3D2 RID: 242642 RVA: 0x00E1FAC8 File Offset: 0x00E1DCC8
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

		// Token: 0x0603B3D3 RID: 242643 RVA: 0x00E1FB44 File Offset: 0x00E1DD44
		private void OnClickClearBtn()
		{
			this.InputText.SetText("", true);
		}

		// Token: 0x0603B3D4 RID: 242644 RVA: 0x00E1FB58 File Offset: 0x00E1DD58
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

		// Token: 0x0603B3D5 RID: 242645 RVA: 0x00E1FBB8 File Offset: 0x00E1DDB8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.OnNameChange));
			EventSystem.Instance.Add(EEventName.OnSignChange, new Action(this.OnSignChange));
		}

		// Token: 0x0603B3D6 RID: 242646 RVA: 0x00E1FBF2 File Offset: 0x00E1DDF2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.OnNameChange));
			EventSystem.Instance.Remove(EEventName.OnSignChange, new Action(this.OnSignChange));
		}

		// Token: 0x0603B3D7 RID: 242647 RVA: 0x00E1FC2C File Offset: 0x00E1DE2C
		private void OnNameChange()
		{
			string textById = TextConfig.Instance.GetTextById("SetNameSuccess");
			ScrollingTipsController.Instance.ShowTipsByText(textById);
		}

		// Token: 0x0603B3D8 RID: 242648 RVA: 0x00E1FC54 File Offset: 0x00E1DE54
		private void OnSignChange()
		{
			string textById = TextConfig.Instance.GetTextById("SetSignSuccess");
			ScrollingTipsController.Instance.ShowTipsByText(textById);
		}

		// Token: 0x0603B3D9 RID: 242649 RVA: 0x00E1FC7C File Offset: 0x00E1DE7C
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

		// Token: 0x0603B3DA RID: 242650 RVA: 0x00E1FCAE File Offset: 0x00E1DEAE
		protected override void OnBeforeDestroy()
		{
			this.UnBindTextChange();
			this.FunctionButton = null;
			this.InputText = null;
			this.ConfirmButton = null;
		}

		// Token: 0x0603B3DB RID: 242651 RVA: 0x00E1FCCC File Offset: 0x00E1DECC
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

		// Token: 0x0603B3DC RID: 242652 RVA: 0x00E1FDF4 File Offset: 0x00E1DFF4
		protected void SetTipsVisible(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x0603B3DD RID: 242653 RVA: 0x00E1FE03 File Offset: 0x00E1E003
		protected virtual void InitExtraParam()
		{
		}

		// Token: 0x0603B3DE RID: 242654 RVA: 0x00E1FE05 File Offset: 0x00E1E005
		private void UnBindTextChange()
		{
			this.InputText.OnTextChange.Unbind();
		}

		// Token: 0x0603B3DF RID: 242655 RVA: 0x00E1FE17 File Offset: 0x00E1E017
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

		// Token: 0x0603B3E0 RID: 242656 RVA: 0x00E1FE4A File Offset: 0x00E1E04A
		private void RefreshTitle()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.InputData.TitleTextArgs.TextKey, this.InputData.TitleTextArgs.Params);
		}

		// Token: 0x0603B3E1 RID: 242657 RVA: 0x00E1FE80 File Offset: 0x00E1E080
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

		// Token: 0x0603B3E2 RID: 242658 RVA: 0x00E1FEC6 File Offset: 0x00E1E0C6
		protected virtual void RefreshDuplicateName(string inputText)
		{
		}

		// Token: 0x0603B3E3 RID: 242659
		protected abstract int GetMaxLimit();

		// Token: 0x0603B3E4 RID: 242660
		protected abstract bool IsAllowMultiLine();

		// Token: 0x0603B3E5 RID: 242661 RVA: 0x00E1FEC8 File Offset: 0x00E1E0C8
		protected virtual int GetMinLimit()
		{
			return 0;
		}

		// Token: 0x0401EE3F RID: 126527
		[Nullable(2)]
		protected ICommonInputViewData InputData;

		// Token: 0x0401EE40 RID: 126528
		private ETipsType? TipsType;

		// Token: 0x0401EE41 RID: 126529
		private float Timer = -1f;

		// Token: 0x0401EE42 RID: 126530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<ETipsType, Action> TipsTypeFunc;

		// Token: 0x0401EE43 RID: 126531
		[Nullable(2)]
		protected UUIButtonComponent ConfirmButton;

		// Token: 0x0401EE44 RID: 126532
		[Nullable(2)]
		protected UUITextInputComponent InputText;

		// Token: 0x0401EE45 RID: 126533
		[Nullable(2)]
		private ButtonAndSpriteItem FunctionButton;

		// Token: 0x0401EE46 RID: 126534
		protected string CdKeyErrorText = ConfigMultiTextLang.GetLocalTextNew("CDKey_Error", null);

		// Token: 0x0200BD84 RID: 48516
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x040392AE RID: 234158
			public const int Title = 0;

			// Token: 0x040392AF RID: 234159
			public const int TipsRootItem = 1;

			// Token: 0x040392B0 RID: 234160
			public const int Tips = 2;

			// Token: 0x040392B1 RID: 234161
			public const int CancelBtn = 3;

			// Token: 0x040392B2 RID: 234162
			public const int ConfirmBtn = 4;

			// Token: 0x040392B3 RID: 234163
			public const int InputText = 5;

			// Token: 0x040392B4 RID: 234164
			public const int DefaultText = 6;

			// Token: 0x040392B5 RID: 234165
			public const int ButtonFunction = 7;

			// Token: 0x040392B6 RID: 234166
			public const int BottomTipsText = 8;
		}
	}
}
