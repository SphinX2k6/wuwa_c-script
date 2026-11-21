using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A84 RID: 19076
	public class DreamLinkButton : UiPanelBase
	{
		// Token: 0x0602FBE9 RID: 195561 RVA: 0x00D52058 File Offset: 0x00D50258
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FBEA RID: 195562 RVA: 0x00D52124 File Offset: 0x00D50324
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => false);
			base.GetExtendToggle(0).OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnClickButton));
		}

		// Token: 0x0602FBEB RID: 195563 RVA: 0x00D5218B File Offset: 0x00D5038B
		public void SetRedDotState(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x0602FBEC RID: 195564 RVA: 0x00D5219A File Offset: 0x00D5039A
		public void SetFinishedState(bool isFinished)
		{
			base.GetItem(2).SetUIActive(isFinished);
		}

		// Token: 0x0602FBED RID: 195565 RVA: 0x00D521A9 File Offset: 0x00D503A9
		[NullableContext(1)]
		public void BindButtonFunction(Action func)
		{
			this.ButtonFunction = func;
		}

		// Token: 0x0602FBEE RID: 195566 RVA: 0x00D521B4 File Offset: 0x00D503B4
		public void SetToggleEnable(bool bEnable)
		{
			EToggleState state = bEnable ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
			base.GetItem(3).SetUIActive(!bEnable);
			UUISprite sprite = base.GetSprite(4);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = !bEnable;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602FBEF RID: 195567 RVA: 0x00D52209 File Offset: 0x00D50409
		private void OnClickButton(EToggleState _)
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x04019596 RID: 103830
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200A6F4 RID: 42740
		private class EButtonDefine
		{
			// Token: 0x04033978 RID: 211320
			public const int Toggle = 0;

			// Token: 0x04033979 RID: 211321
			public const int RedDot = 1;

			// Token: 0x0403397A RID: 211322
			public const int PanelDone = 2;

			// Token: 0x0403397B RID: 211323
			public const int PanelLock = 3;

			// Token: 0x0403397C RID: 211324
			public const int SpriteIcon = 4;
		}
	}
}
