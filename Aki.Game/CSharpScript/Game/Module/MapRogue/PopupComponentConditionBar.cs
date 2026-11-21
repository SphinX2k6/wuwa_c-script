using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045FC RID: 17916
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentConditionBar : UiPanelBase
	{
		// Token: 0x0602D0BB RID: 184507 RVA: 0x00C989E4 File Offset: 0x00C96BE4
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

		// Token: 0x0602D0BC RID: 184508 RVA: 0x00C98A61 File Offset: 0x00C96C61
		public void SetTextByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0602D0BD RID: 184509 RVA: 0x00C98A76 File Offset: 0x00C96C76
		public void SetTextByText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0602D0BE RID: 184510 RVA: 0x00C98A86 File Offset: 0x00C96C86
		public UUISprite GetIconSprite()
		{
			return base.GetSprite(0);
		}

		// Token: 0x0602D0BF RID: 184511 RVA: 0x00C98A8F File Offset: 0x00C96C8F
		public void SetSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x0602D0C0 RID: 184512 RVA: 0x00C98AA0 File Offset: 0x00C96CA0
		public void SetButtonVisible(bool bVisible)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x0602D0C1 RID: 184513 RVA: 0x00C98AC7 File Offset: 0x00C96CC7
		private void ButtonCallBackInternal()
		{
			Action buttonCallBack = this.ButtonCallBack;
			if (buttonCallBack == null)
			{
				return;
			}
			buttonCallBack();
		}

		// Token: 0x040182D2 RID: 99026
		[Nullable(2)]
		public Action ButtonCallBack;
	}
}
