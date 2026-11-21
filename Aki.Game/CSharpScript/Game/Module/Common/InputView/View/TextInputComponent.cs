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
	// Token: 0x02004B5D RID: 19293
	[NullableContext(1)]
	[Nullable(0)]
	public class TextInputComponent : UiPanelBase
	{
		// Token: 0x0603036E RID: 197486 RVA: 0x00D7077C File Offset: 0x00D6E97C
		public TextInputComponent(UUIItem uiItem, ITextInputData inputData)
		{
			this.InputData = inputData;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603036F RID: 197487 RVA: 0x00D707AC File Offset: 0x00D6E9AC
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

		// Token: 0x06030370 RID: 197488 RVA: 0x00D708D8 File Offset: 0x00D6EAD8
		private void ActiveInputText(bool active)
		{
			if (active && this.TipsType == ETipsType.NoneText)
			{
				this.RefreshTips(ETipsType.Normal);
			}
		}

		// Token: 0x06030371 RID: 197489 RVA: 0x00D708F0 File Offset: 0x00D6EAF0
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

		// Token: 0x06030372 RID: 197490 RVA: 0x00D709B0 File Offset: 0x00D6EBB0
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

		// Token: 0x06030373 RID: 197491 RVA: 0x00D709DC File Offset: 0x00D6EBDC
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

		// Token: 0x06030374 RID: 197492 RVA: 0x00D70B17 File Offset: 0x00D6ED17
		private void UnBindTextChange()
		{
			this.InputText.OnTextChange.Unbind();
		}

		// Token: 0x06030375 RID: 197493 RVA: 0x00D70B29 File Offset: 0x00D6ED29
		private void OnTextChange(string inputText)
		{
			if (StringUtils.GetStringRealCount(inputText) <= this.MaxLimit)
			{
				this.RefreshTips(ETipsType.Normal);
				return;
			}
			this.RefreshTips(ETipsType.MsgTooLong);
		}

		// Token: 0x06030376 RID: 197494 RVA: 0x00D70B48 File Offset: 0x00D6ED48
		private void NormalHandle()
		{
			base.GetItem(0).SetUIActive(false);
			this.ConfirmButton.SetSelfInteractive(true);
			this.Timer = -1f;
		}

		// Token: 0x06030377 RID: 197495 RVA: 0x00D70B6E File Offset: 0x00D6ED6E
		private void NoneTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Entertext_Text", 0);
		}

		// Token: 0x06030378 RID: 197496 RVA: 0x00D70B7C File Offset: 0x00D6ED7C
		private void MsgTooLongHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textoverlength_Text", -1);
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x06030379 RID: 197497 RVA: 0x00D70B96 File Offset: 0x00D6ED96
		private void MsgTooShortHandle()
		{
			this.SetTipsAndTimer("CDKey_TooShort", 0);
			this.ConfirmButton.SetSelfInteractive(false);
		}

		// Token: 0x0603037A RID: 197498 RVA: 0x00D70BB0 File Offset: 0x00D6EDB0
		private void IllegalCharactersHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_Textillegality_Text", 0);
		}

		// Token: 0x0603037B RID: 197499 RVA: 0x00D70BBE File Offset: 0x00D6EDBE
		private void BlankTextHandle()
		{
			this.SetTipsAndTimer("PrefabTextItem_TextNull_Text", 0);
		}

		// Token: 0x0603037C RID: 197500 RVA: 0x00D70BCC File Offset: 0x00D6EDCC
		private void SetTipsAndTimer(string textId, int timer)
		{
			base.GetItem(0).SetUIActive(true);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
			this.Timer = (float)timer;
		}

		// Token: 0x0603037D RID: 197501 RVA: 0x00D70C07 File Offset: 0x00D6EE07
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

		// Token: 0x0603037E RID: 197502 RVA: 0x00D70C44 File Offset: 0x00D6EE44
		protected override void OnBeforeDestroy()
		{
			this.UnBindTextChange();
			TickSystem.Instance.Remove(this.TickId);
		}

		// Token: 0x0603037F RID: 197503 RVA: 0x00D70C5D File Offset: 0x00D6EE5D
		public void ClearText()
		{
			this.InputText.SetText("", false);
		}

		// Token: 0x06030380 RID: 197504 RVA: 0x00D70C70 File Offset: 0x00D6EE70
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

		// Token: 0x040198FD RID: 104701
		private ETipsType TipsType;

		// Token: 0x040198FE RID: 104702
		private float Timer = -1f;

		// Token: 0x040198FF RID: 104703
		private int TickId;

		// Token: 0x04019900 RID: 104704
		[Nullable(2)]
		private Dictionary<ETipsType, Action> TipsTypeFunc;

		// Token: 0x04019901 RID: 104705
		[Nullable(2)]
		private UUITextInputComponent InputText;

		// Token: 0x04019902 RID: 104706
		[Nullable(2)]
		private UUIButtonComponent ConfirmButton;

		// Token: 0x04019903 RID: 104707
		private readonly int MaxLimit = 12;

		// Token: 0x04019904 RID: 104708
		private readonly int MinLimit;

		// Token: 0x04019905 RID: 104709
		private bool IsLockConfirm;

		// Token: 0x04019906 RID: 104710
		private readonly ITextInputData InputData;

		// Token: 0x0200A793 RID: 42899
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04033C8D RID: 212109
			public const int TipsRootItem = 0;

			// Token: 0x04033C8E RID: 212110
			public const int Tips = 1;

			// Token: 0x04033C8F RID: 212111
			public const int InputText = 2;

			// Token: 0x04033C90 RID: 212112
			public const int DefaultText = 3;

			// Token: 0x04033C91 RID: 212113
			public const int ConfirmBtn = 4;
		}
	}
}
