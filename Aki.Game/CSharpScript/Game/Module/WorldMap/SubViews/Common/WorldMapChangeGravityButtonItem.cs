using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02004834 RID: 18484
	public class WorldMapChangeGravityButtonItem : UiPanelBase
	{
		// Token: 0x0603060F RID: 198159 RVA: 0x00B3B3F4 File Offset: 0x00B395F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISpriteTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030610 RID: 198160 RVA: 0x00B3B4DC File Offset: 0x00B396DC
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06030611 RID: 198161 RVA: 0x00B3B4EE File Offset: 0x00B396EE
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x06030612 RID: 198162 RVA: 0x00B3B502 File Offset: 0x00B39702
		[NullableContext(1)]
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06030613 RID: 198163 RVA: 0x00B3B50C File Offset: 0x00B3970C
		[NullableContext(1)]
		public void SetSprite(string path)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetUIActive(false);
			this.SetSpriteByPath(path, sprite, false, null, delegate(bool success)
			{
				this.GetUiSpriteTransition(3).SetAllTransitionSprite(sprite.GetSprite());
				sprite.SetUIActive(success);
			});
		}

		// Token: 0x0401A03A RID: 106554
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200AB10 RID: 43792
		public static class EButtonItemDefine
		{
			// Token: 0x04033FD9 RID: 212953
			public const int Button = 0;

			// Token: 0x04033FDA RID: 212954
			public const int Sprite = 1;

			// Token: 0x04033FDB RID: 212955
			public const int Text = 2;

			// Token: 0x04033FDC RID: 212956
			public const int SpriteTransition = 3;
		}
	}
}
