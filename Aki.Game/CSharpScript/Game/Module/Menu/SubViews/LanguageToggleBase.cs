using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200541D RID: 21533
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageToggleBase : UiPanelBase
	{
		// Token: 0x06037068 RID: 225384 RVA: 0x00D0A133 File Offset: 0x00D08333
		public void Initialize(UUIItem toggleItem, int index, bool isToggled)
		{
			this.Index = index;
			this.PreToggled = isToggled;
			base.CreateThenShowByActor(toggleItem.GetOwner(), null);
		}

		// Token: 0x06037069 RID: 225385 RVA: 0x00D0A150 File Offset: 0x00D08350
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

		// Token: 0x0603706A RID: 225386 RVA: 0x00D0A1CD File Offset: 0x00D083CD
		protected override void OnStart()
		{
			if (this.PreToggled)
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			this.MainText = base.GetText(1);
		}

		// Token: 0x0603706B RID: 225387 RVA: 0x00D0A1F5 File Offset: 0x00D083F5
		protected override void OnBeforeDestroyImplement()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
			this.ProgressBuilder.Clear();
		}

		// Token: 0x0603706C RID: 225388 RVA: 0x00D0A214 File Offset: 0x00D08414
		private void DoSelected(EToggleState state)
		{
			Action<LanguageToggleBase, EToggleState> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack != null)
			{
				selectedCallBack(this, state);
			}
			this.OnSelected();
		}

		// Token: 0x0603706D RID: 225389 RVA: 0x00D0A22F File Offset: 0x00D0842F
		public void SetSelectedCallBack(Action<LanguageToggleBase, EToggleState> callBack)
		{
			this.SelectedCallBack = callBack;
		}

		// Token: 0x0603706E RID: 225390 RVA: 0x00D0A238 File Offset: 0x00D08438
		public void SetMainText(string textId)
		{
			this.MainText.ShowTextNew(textId);
		}

		// Token: 0x0603706F RID: 225391 RVA: 0x00D0A246 File Offset: 0x00D08446
		public string GetMainText()
		{
			return this.MainText.text;
		}

		// Token: 0x06037070 RID: 225392 RVA: 0x00D0A253 File Offset: 0x00D08453
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x06037071 RID: 225393 RVA: 0x00D0A25B File Offset: 0x00D0845B
		public void UnSelect()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.OnUnSelected();
		}

		// Token: 0x06037072 RID: 225394 RVA: 0x00D0A274 File Offset: 0x00D08474
		protected virtual void OnSelected()
		{
		}

		// Token: 0x06037073 RID: 225395 RVA: 0x00D0A276 File Offset: 0x00D08476
		protected virtual void OnUnSelected()
		{
		}

		// Token: 0x0401D07A RID: 118906
		protected readonly StringBuilder ProgressBuilder = new StringBuilder();

		// Token: 0x0401D07B RID: 118907
		protected int Index;

		// Token: 0x0401D07C RID: 118908
		protected bool PreToggled;

		// Token: 0x0401D07D RID: 118909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<LanguageToggleBase, EToggleState> SelectedCallBack;

		// Token: 0x0401D07E RID: 118910
		[Nullable(2)]
		protected UUIText MainText;
	}
}
