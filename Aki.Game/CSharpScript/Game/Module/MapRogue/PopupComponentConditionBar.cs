using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005626 RID: 22054
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentConditionBar : UiPanelBase
	{
		// Token: 0x060381BD RID: 229821 RVA: 0x00D4AC9C File Offset: 0x00D48E9C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.ButtonCallBackInternal))
			};
		}

		// Token: 0x060381BE RID: 229822 RVA: 0x00D4AD19 File Offset: 0x00D48F19
		public void SetTextByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x060381BF RID: 229823 RVA: 0x00D4AD2E File Offset: 0x00D48F2E
		public void SetTextByText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x060381C0 RID: 229824 RVA: 0x00D4AD3E File Offset: 0x00D48F3E
		public UUISprite GetIconSprite()
		{
			return base.GetSprite(0);
		}

		// Token: 0x060381C1 RID: 229825 RVA: 0x00D4AD47 File Offset: 0x00D48F47
		public void SetSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x060381C2 RID: 229826 RVA: 0x00D4AD58 File Offset: 0x00D48F58
		public void SetButtonVisible(bool bVisible)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x060381C3 RID: 229827 RVA: 0x00D4AD7F File Offset: 0x00D48F7F
		private void ButtonCallBackInternal()
		{
			Action buttonCallBack = this.ButtonCallBack;
			if (buttonCallBack == null)
			{
				return;
			}
			buttonCallBack();
		}

		// Token: 0x0401D847 RID: 120903
		[Nullable(2)]
		public Action ButtonCallBack;
	}
}
