using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E67 RID: 15975
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleShopButton : UiPanelBase
	{
		// Token: 0x06028A05 RID: 166405 RVA: 0x00B67548 File Offset: 0x00B65748
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick))
			};
		}

		// Token: 0x06028A06 RID: 166406 RVA: 0x00B675F1 File Offset: 0x00B657F1
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x06028A07 RID: 166407 RVA: 0x00B675FA File Offset: 0x00B657FA
		private void OnBtnClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06028A08 RID: 166408 RVA: 0x00B6760C File Offset: 0x00B6580C
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06028A09 RID: 166409 RVA: 0x00B67615 File Offset: 0x00B65815
		public void SetText(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06028A0A RID: 166410 RVA: 0x00B6762C File Offset: 0x00B6582C
		public void SetCostText(string text, bool? useChangeColor = null)
		{
			UUIText text2 = base.GetText(4);
			text2.SetText(text, true);
			if (useChangeColor != null)
			{
				UUIItem uuiitem = text2;
				bool value = useChangeColor.Value;
				FColor? fcolor = new FColor?(text2.changeColor);
				uuiitem.SetChangeColor(value, fcolor);
			}
		}

		// Token: 0x06028A0B RID: 166411 RVA: 0x00B67670 File Offset: 0x00B65870
		public void SetCostItem(int itemId)
		{
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x06028A0C RID: 166412 RVA: 0x00B67695 File Offset: 0x00B65895
		public void SetInteractive(bool bActive)
		{
			base.GetButton(0).SetSelfInteractive(bActive);
		}

		// Token: 0x0401616E RID: 90478
		[Nullable(2)]
		private Action ButtonFunction;
	}
}
