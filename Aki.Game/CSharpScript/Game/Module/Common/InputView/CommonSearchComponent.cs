using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.InputView
{
	// Token: 0x02004B52 RID: 19282
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonSearchComponent : UiPanelBase
	{
		// Token: 0x060302FF RID: 197375 RVA: 0x00D6F7C3 File Offset: 0x00D6D9C3
		public CommonSearchComponent(UUIItem uiItem, Action<string> SearchFunction, Action ClearFunction)
		{
			this.SearchFunction = SearchFunction;
			this.ClearFunction = ClearFunction;
			this.IsDeleteState = false;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030300 RID: 197376 RVA: 0x00D6F7F0 File Offset: 0x00D6D9F0
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

		// Token: 0x06030301 RID: 197377 RVA: 0x00D6F8FD File Offset: 0x00D6DAFD
		private void ActiveInput(bool active)
		{
			if (active)
			{
				this.InputText.ActivateInputText();
			}
		}

		// Token: 0x06030302 RID: 197378 RVA: 0x00D6F910 File Offset: 0x00D6DB10
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

		// Token: 0x06030303 RID: 197379 RVA: 0x00D6F949 File Offset: 0x00D6DB49
		private void ClearClick()
		{
			this.ResetSearch(true);
		}

		// Token: 0x06030304 RID: 197380 RVA: 0x00D6F954 File Offset: 0x00D6DB54
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

		// Token: 0x06030305 RID: 197381 RVA: 0x00D6F9DC File Offset: 0x00D6DBDC
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

		// Token: 0x06030306 RID: 197382 RVA: 0x00D6FA30 File Offset: 0x00D6DC30
		protected override void OnBeforeDestroy()
		{
			this.InputText = null;
			this.SearchButton = null;
			this.ClearButton = null;
		}

		// Token: 0x06030307 RID: 197383 RVA: 0x00D6FA48 File Offset: 0x00D6DC48
		private void ChangeSearchButtonState(bool isShowSearch)
		{
			this.SearchButton.RootUIComp.Get().SetUIActive(isShowSearch);
			this.ClearButton.RootUIComp.Get().SetUIActive(!isShowSearch);
			this.IsDeleteState = !isShowSearch;
		}

		// Token: 0x06030308 RID: 197384 RVA: 0x00D6FA94 File Offset: 0x00D6DC94
		public void ResetSearch(bool isFire)
		{
			this.InputText.SetText("", isFire);
		}

		// Token: 0x040198EA RID: 104682
		[Nullable(2)]
		private UUITextInputComponent InputText;

		// Token: 0x040198EB RID: 104683
		[Nullable(2)]
		private UUIButtonComponent SearchButton;

		// Token: 0x040198EC RID: 104684
		[Nullable(2)]
		private UUIButtonComponent ClearButton;

		// Token: 0x040198ED RID: 104685
		private bool IsDeleteState;

		// Token: 0x040198EE RID: 104686
		private Action<string> SearchFunction;

		// Token: 0x040198EF RID: 104687
		private Action ClearFunction;

		// Token: 0x0200A78D RID: 42893
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04033C79 RID: 212089
			InputTextComp,
			// Token: 0x04033C7A RID: 212090
			SearchButton,
			// Token: 0x04033C7B RID: 212091
			ClearButton
		}
	}
}
