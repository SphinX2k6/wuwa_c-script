using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B7D RID: 23421
	[NullableContext(1)]
	[Nullable(0)]
	public class TextInputComponent : UiPanelBase
	{
		// Token: 0x0603B421 RID: 242721 RVA: 0x00E20208 File Offset: 0x00E1E408
		public TextInputComponent(UUIItem uiItem, ITextInputData inputData)
		{
			this.InputData = inputData;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B422 RID: 242722 RVA: 0x00E20238 File Offset: 0x00E1E438
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITextInputComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<bool>(this.ActiveInputText));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B423 RID: 242723 RVA: 0x00E20364 File Offset: 0x00E1E564
		private void ActiveInputText(bool active)
		{
			if (active && this.TipsType == ETipsType.NoneText)
			{
				this.RefreshTips(ETipsType.Normal);
			}
		}

		// Token: 0x0603B424 RID: 242724 RVA: 0x00E2037C File Offset: 0x00E1E57C
		private void ConfirmClick()
		{
			if (this.IsLockConfirm)
			{
				Log.Instance.Info(ELogModule.UiCommon, ELogAuthor.XXJ, "通用输入框锁住确认点击", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			string text = this.InputText.GetText();
			int stringRealCount = StringUtils.GetStringRealCount(text);
			if (stringRealCount > this.MaxLimit)
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
			if (stringRealCount < this.MinLimit)
			{
				this.RefreshTips(ETipsType.MsgTooShort);
				this.Timer = 0f;
				return;
			}
			this.IsLockConfirm = true;
			this.<ConfirmClick>g__Temp|14_0(text).Forget(delegate(Exception exception)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.XXJ, "通用输入框执行出现未知错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.IsLockConfirm = false;
			}, true);
		}

		// Token: 0x0603B425 RID: 242725 RVA: 0x00E2043C File Offset: 0x00E1E63C
		private void RefreshTips(ETipsType type)
		{
			if (type == this.TipsType)
			{
				return;
			}
			this.TipsType = type;
			Action action = this.TipsTypeFunc[type];
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x0603B426 RID: 242726 RVA: 0x00E20468 File Offset: 0x00E1E668
		protected override void OnStart()
		{
			Dictionary<ETipsType, Action> dictionary = new Dictionary<ETipsType, Action>();
			dictionary[ETipsType.Normal] = new Action(this.NormalHandle);
			dictionary[ETipsType.NoneText] = new Action(this.NoneTextHandle);
			dictionary[ETipsType.MsgTooLong] = new Action(this.MsgTooLongHandle);
			dictionary[ETipsType.MsgTooShort] = new Action(this.MsgTooShortHandle);
			dictionary[ETipsType.IllegalCharacters] = new Action(this.IllegalCharactersHandle);
			dictionary[ETipsType.Blank] = new Action(this.BlankTextHandle);
			dictionary[ETipsType.InValidCdKey] = null;
			dictionary[ETipsType.CdKeyInCd] = null;
			this.TipsTypeFunc = dictionary;
			this.ConfirmButton = base.GetButton(4);
			this.InputText = base.GetInputText(2);
			this.InputText.OnTextChange.Bind(new Action<string>(this.OnTextChange));
			this.InputText.SetText(this.InputData.InputText, true);
			if (!string.IsNullOrEmpty(this.InputData.DefaultText))
			{
				base.GetText(3).SetText(this.InputData.DefaultText, true);
			}
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "TextInputComponent", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x0603B427 RID: 242727 RVA: 0x00E205A3 File Offset: 0x00E1E7A3
		private void UnBindTextChange()
		{
			this.InputText.OnTextChange.Unbind();
		}

		// Token: 0x0603B428 RID: 242728 RVA: 0x00E205B5 File Offset: 0x00E1E7B5
		private void OnTextChange(string inputText)
		{
			if (StringUtils.GetStringRealCount(inputText) <= this.MaxLimit)
			{
				this.RefreshTips(ETipsType.Normal);
				return;
			}
			this.RefreshTips(ETipsType.MsgTooLong);
		}

		// Token: 0x0603B429 RID: 242729 RVA: 0x00E205D4 File Offset: 0x00E1E7D4
		private void NormalHandle()
		{
			base.GetItem(0).SetUIActive(false);
			this.ConfirmButton.SetSelfInteractive(true);
			this.Timer = -1f;
		}

		// Token: 0x0603B42A RID: 242730 RVA: 0x00E205FA File Offset: 0x00E1E7FA
		private void NoneTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Entertext_Text", 0);
		}

		// Token: 0x0603B42B RID: 242731 RVA: 0x00E20608 File Offset: 0x00E1E808
		private void MsgTooLongHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textoverlength_Text", -1);
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B42C RID: 242732 RVA: 0x00E20622 File Offset: 0x00E1E822
		private void MsgTooShortHandle()
		{
			this.SetTipsAndTimer("CDKey_TooShort", 0);
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B42D RID: 242733 RVA: 0x00E2063C File Offset: 0x00E1E83C
		private void IllegalCharactersHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textillegality_Text", 0);
		}

		// Token: 0x0603B42E RID: 242734 RVA: 0x00E2064A File Offset: 0x00E1E84A
		private void BlankTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_TextNull_Text", 0);
		}

		// Token: 0x0603B42F RID: 242735 RVA: 0x00E20658 File Offset: 0x00E1E858
		private void SetTipsAndTimer(string textId, int timer)
		{
			base.GetItem(0).SetUIActive(true);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
			this.Timer = (float)timer;
		}

		// Token: 0x0603B430 RID: 242736 RVA: 0x00E20693 File Offset: 0x00E1E893
		private void Tick(float delta)
		{
			if (Math.Abs(this.Timer - -1f) < 0.001f)
			{
				return;
			}
			this.Timer += delta;
			if (this.Timer >= 2000f)
			{
				this.RefreshTips(ETipsType.Normal);
			}
		}

		// Token: 0x0603B431 RID: 242737 RVA: 0x00E206D0 File Offset: 0x00E1E8D0
		protected override void OnBeforeDestroy()
		{
			this.UnBindTextChange();
			TickSystem.Instance.Remove(this.TickId);
		}

		// Token: 0x0603B432 RID: 242738 RVA: 0x00E206E9 File Offset: 0x00E1E8E9
		public void ClearText()
		{
			this.InputText.SetText("", false);
		}

		// Token: 0x0603B433 RID: 242739 RVA: 0x00E206FC File Offset: 0x00E1E8FC
		[CompilerGenerated]
		private UniTask <ConfirmClick>g__Temp|14_0(string argInputText)
		{
			TextInputComponent.<<ConfirmClick>g__Temp|14_0>d <<ConfirmClick>g__Temp|14_0>d;
			<<ConfirmClick>g__Temp|14_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<ConfirmClick>g__Temp|14_0>d.<>4__this = this;
			<<ConfirmClick>g__Temp|14_0>d.argInputText = argInputText;
			<<ConfirmClick>g__Temp|14_0>d.<>1__state = -1;
			<<ConfirmClick>g__Temp|14_0>d.<>t__builder.Start<TextInputComponent.<<ConfirmClick>g__Temp|14_0>d>(ref <<ConfirmClick>g__Temp|14_0>d);
			return <<ConfirmClick>g__Temp|14_0>d.<>t__builder.Task;
		}

		// Token: 0x0401EE4C RID: 126540
		private ETipsType TipsType;

		// Token: 0x0401EE4D RID: 126541
		private float Timer = -1f;

		// Token: 0x0401EE4E RID: 126542
		private int TickId;

		// Token: 0x0401EE4F RID: 126543
		[Nullable(2)]
		private Dictionary<ETipsType, Action> TipsTypeFunc;

		// Token: 0x0401EE50 RID: 126544
		[Nullable(2)]
		private UUITextInputComponent InputText;

		// Token: 0x0401EE51 RID: 126545
		[Nullable(2)]
		private UUIButtonComponent ConfirmButton;

		// Token: 0x0401EE52 RID: 126546
		private readonly int MaxLimit = 12;

		// Token: 0x0401EE53 RID: 126547
		private readonly int MinLimit;

		// Token: 0x0401EE54 RID: 126548
		private bool IsLockConfirm;

		// Token: 0x0401EE55 RID: 126549
		private readonly ITextInputData InputData;

		// Token: 0x0200BD89 RID: 48521
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x040392BF RID: 234175
			public const int TipsRootItem = 0;

			// Token: 0x040392C0 RID: 234176
			public const int Tips = 1;

			// Token: 0x040392C1 RID: 234177
			public const int InputText = 2;

			// Token: 0x040392C2 RID: 234178
			public const int DefaultText = 3;

			// Token: 0x040392C3 RID: 234179
			public const int ConfirmBtn = 4;
		}
	}
}
