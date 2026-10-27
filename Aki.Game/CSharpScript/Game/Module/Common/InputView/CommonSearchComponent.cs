using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.InputView
{
	// Token: 0x02005B72 RID: 23410
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonSearchComponent : UiPanelBase
	{
		// Token: 0x0603B3B2 RID: 242610 RVA: 0x00E1F24F File Offset: 0x00E1D44F
		public CommonSearchComponent(UUIItem uiItem, Action<string> SearchFunction, Action ClearFunction)
		{
			this.SearchFunction = SearchFunction;
			this.ClearFunction = ClearFunction;
			this.IsDeleteState = false;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B3B3 RID: 242611 RVA: 0x00E1F27C File Offset: 0x00E1D47C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITextInputComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<bool>(this.ActiveInput));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.SearchClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ClearClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B3B4 RID: 242612 RVA: 0x00E1F389 File Offset: 0x00E1D589
		private void ActiveInput(bool active)
		{
			if (active)
			{
				this.InputText.ActivateInputText();
			}
		}

		// Token: 0x0603B3B5 RID: 242613 RVA: 0x00E1F39C File Offset: 0x00E1D59C
		private void SearchClick()
		{
			string text = this.InputText.GetText();
			Action<string> searchFunction = this.SearchFunction;
			if (searchFunction != null)
			{
				searchFunction(text);
			}
			this.ChangeSearchButtonState(false);
			this.IsDeleteState = true;
		}

		// Token: 0x0603B3B6 RID: 242614 RVA: 0x00E1F3D5 File Offset: 0x00E1D5D5
		private void ClearClick()
		{
			this.ResetSearch(true);
		}

		// Token: 0x0603B3B7 RID: 242615 RVA: 0x00E1F3E0 File Offset: 0x00E1D5E0
		protected override void OnStart()
		{
			this.SearchButton = base.GetButton(1);
			this.ClearButton = base.GetButton(2);
			this.InputText = base.GetInputText(0);
			this.InputText.OnTextChange.Bind(new Action<string>(this.RefreshButton));
			this.InputText.OnTextSubmit.Bind(delegate(string _)
			{
				this.SearchClick();
			});
			this.ResetSearch(false);
			this.ChangeSearchButtonState(true);
			this.SearchButton.SetSelfInteractive(false);
		}

		// Token: 0x0603B3B8 RID: 242616 RVA: 0x00E1F468 File Offset: 0x00E1D668
		private void RefreshButton(string searchText)
		{
			if (!StringUtils.IsEmpty(searchText))
			{
				if (this.IsDeleteState)
				{
					this.ChangeSearchButtonState(true);
				}
				this.SearchButton.SetSelfInteractive(true);
				return;
			}
			this.ChangeSearchButtonState(true);
			this.SearchButton.SetSelfInteractive(false);
			Action clearFunction = this.ClearFunction;
			if (clearFunction == null)
			{
				return;
			}
			clearFunction();
		}

		// Token: 0x0603B3B9 RID: 242617 RVA: 0x00E1F4BC File Offset: 0x00E1D6BC
		protected override void OnBeforeDestroy()
		{
			this.InputText = null;
			this.SearchButton = null;
			this.ClearButton = null;
		}

		// Token: 0x0603B3BA RID: 242618 RVA: 0x00E1F4D4 File Offset: 0x00E1D6D4
		private void ChangeSearchButtonState(bool isShowSearch)
		{
			this.SearchButton.RootUIComp.Get().SetUIActive(isShowSearch);
			this.ClearButton.RootUIComp.Get().SetUIActive(!isShowSearch);
			this.IsDeleteState = !isShowSearch;
		}

		// Token: 0x0603B3BB RID: 242619 RVA: 0x00E1F520 File Offset: 0x00E1D720
		public void ResetSearch(bool isFire)
		{
			this.InputText.SetText("", isFire);
		}

		// Token: 0x0401EE39 RID: 126521
		[Nullable(2)]
		private UUITextInputComponent InputText;

		// Token: 0x0401EE3A RID: 126522
		[Nullable(2)]
		private UUIButtonComponent SearchButton;

		// Token: 0x0401EE3B RID: 126523
		[Nullable(2)]
		private UUIButtonComponent ClearButton;

		// Token: 0x0401EE3C RID: 126524
		private bool IsDeleteState;

		// Token: 0x0401EE3D RID: 126525
		private Action<string> SearchFunction;

		// Token: 0x0401EE3E RID: 126526
		private Action ClearFunction;

		// Token: 0x0200BD83 RID: 48515
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x040392AB RID: 234155
			InputTextComp,
			// Token: 0x040392AC RID: 234156
			SearchButton,
			// Token: 0x040392AD RID: 234157
			ClearButton
		}
	}
}
