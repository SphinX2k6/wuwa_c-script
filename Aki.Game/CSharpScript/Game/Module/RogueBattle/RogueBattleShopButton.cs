using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E9E RID: 20126
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleShopButton : UiPanelBase
	{
		// Token: 0x06033B9A RID: 211866 RVA: 0x00C1E02C File Offset: 0x00C1C22C
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

		// Token: 0x06033B9B RID: 211867 RVA: 0x00C1E0D5 File Offset: 0x00C1C2D5
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x06033B9C RID: 211868 RVA: 0x00C1E0DE File Offset: 0x00C1C2DE
		private void OnBtnClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06033B9D RID: 211869 RVA: 0x00C1E0F0 File Offset: 0x00C1C2F0
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06033B9E RID: 211870 RVA: 0x00C1E0F9 File Offset: 0x00C1C2F9
		public void SetText(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06033B9F RID: 211871 RVA: 0x00C1E110 File Offset: 0x00C1C310
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

		// Token: 0x06033BA0 RID: 211872 RVA: 0x00C1E154 File Offset: 0x00C1C354
		public void SetCostItem(int itemId)
		{
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x06033BA1 RID: 211873 RVA: 0x00C1E179 File Offset: 0x00C1C379
		public void SetInteractive(bool bActive)
		{
			base.GetButton(0).SetSelfInteractive(bActive);
		}

		// Token: 0x0401B79B RID: 112539
		[Nullable(2)]
		private Action ButtonFunction;
	}
}
