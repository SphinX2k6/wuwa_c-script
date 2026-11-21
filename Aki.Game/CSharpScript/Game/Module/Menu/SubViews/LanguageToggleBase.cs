using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004400 RID: 17408
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageToggleBase : UiPanelBase
	{
		// Token: 0x0602BFB1 RID: 180145 RVA: 0x00C59553 File Offset: 0x00C57753
		public void Initialize(UUIItem toggleItem, int index, bool isToggled)
		{
			this.Index = index;
			this.PreToggled = isToggled;
			base.CreateThenShowByActor(toggleItem.GetOwner(), null);
		}

		// Token: 0x0602BFB2 RID: 180146 RVA: 0x00C59570 File Offset: 0x00C57770
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.DoSelected))
			};
		}

		// Token: 0x0602BFB3 RID: 180147 RVA: 0x00C595ED File Offset: 0x00C577ED
		protected override void OnStart()
		{
			if (this.PreToggled)
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			this.MainText = base.GetText(1);
		}

		// Token: 0x0602BFB4 RID: 180148 RVA: 0x00C59615 File Offset: 0x00C57815
		protected override void OnBeforeDestroyImplement()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
			this.ProgressBuilder.Clear();
		}

		// Token: 0x0602BFB5 RID: 180149 RVA: 0x00C59634 File Offset: 0x00C57834
		private void DoSelected(EToggleState state)
		{
			Action<LanguageToggleBase, EToggleState> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack != null)
			{
				selectedCallBack(this, state);
			}
			this.OnSelected();
		}

		// Token: 0x0602BFB6 RID: 180150 RVA: 0x00C5964F File Offset: 0x00C5784F
		public void SetSelectedCallBack(Action<LanguageToggleBase, EToggleState> callBack)
		{
			this.SelectedCallBack = callBack;
		}

		// Token: 0x0602BFB7 RID: 180151 RVA: 0x00C59658 File Offset: 0x00C57858
		public void SetMainText(string textId)
		{
			this.MainText.ShowTextNew(textId);
		}

		// Token: 0x0602BFB8 RID: 180152 RVA: 0x00C59666 File Offset: 0x00C57866
		public string GetMainText()
		{
			return this.MainText.text;
		}

		// Token: 0x0602BFB9 RID: 180153 RVA: 0x00C59673 File Offset: 0x00C57873
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x0602BFBA RID: 180154 RVA: 0x00C5967B File Offset: 0x00C5787B
		public void UnSelect()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.OnUnSelected();
		}

		// Token: 0x0602BFBB RID: 180155 RVA: 0x00C59694 File Offset: 0x00C57894
		protected virtual void OnSelected()
		{
		}

		// Token: 0x0602BFBC RID: 180156 RVA: 0x00C59696 File Offset: 0x00C57896
		protected virtual void OnUnSelected()
		{
		}

		// Token: 0x04017B13 RID: 97043
		protected readonly StringBuilder ProgressBuilder = new StringBuilder();

		// Token: 0x04017B14 RID: 97044
		protected int Index;

		// Token: 0x04017B15 RID: 97045
		protected bool PreToggled;

		// Token: 0x04017B16 RID: 97046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<LanguageToggleBase, EToggleState> SelectedCallBack;

		// Token: 0x04017B17 RID: 97047
		[Nullable(2)]
		protected UUIText MainText;
	}
}
