using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA8 RID: 23208
	public class DreamLinkButton : UiPanelBase
	{
		// Token: 0x0603AC9D RID: 240797 RVA: 0x00E01AA4 File Offset: 0x00DFFCA4
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

		// Token: 0x0603AC9E RID: 240798 RVA: 0x00E01B70 File Offset: 0x00DFFD70
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => false);
			base.GetExtendToggle(0).OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnClickButton));
		}

		// Token: 0x0603AC9F RID: 240799 RVA: 0x00E01BD7 File Offset: 0x00DFFDD7
		public void SetRedDotState(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x0603ACA0 RID: 240800 RVA: 0x00E01BE6 File Offset: 0x00DFFDE6
		public void SetFinishedState(bool isFinished)
		{
			base.GetItem(2).SetUIActive(isFinished);
		}

		// Token: 0x0603ACA1 RID: 240801 RVA: 0x00E01BF5 File Offset: 0x00DFFDF5
		[NullableContext(1)]
		public void BindButtonFunction(Action func)
		{
			this.ButtonFunction = func;
		}

		// Token: 0x0603ACA2 RID: 240802 RVA: 0x00E01C00 File Offset: 0x00DFFE00
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

		// Token: 0x0603ACA3 RID: 240803 RVA: 0x00E01C55 File Offset: 0x00DFFE55
		private void OnClickButton(EToggleState _)
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x0401EAEF RID: 125679
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200BCEB RID: 48363
		private class EButtonDefine
		{
			// Token: 0x04038FAD RID: 233389
			public const int Toggle = 0;

			// Token: 0x04038FAE RID: 233390
			public const int RedDot = 1;

			// Token: 0x04038FAF RID: 233391
			public const int PanelDone = 2;

			// Token: 0x04038FB0 RID: 233392
			public const int PanelLock = 3;

			// Token: 0x04038FB1 RID: 233393
			public const int SpriteIcon = 4;
		}
	}
}
