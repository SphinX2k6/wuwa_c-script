using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02004F8E RID: 20366
	public class BattleQuickHackLongPressItem : UiPanelBase
	{
		// Token: 0x06034267 RID: 213607 RVA: 0x00C3D3D0 File Offset: 0x00C3B5D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034268 RID: 213608 RVA: 0x00C3D521 File Offset: 0x00C3B721
		protected override void OnBeforeShow()
		{
			this.UpdateProgress();
		}

		// Token: 0x06034269 RID: 213609 RVA: 0x00C3D529 File Offset: 0x00C3B729
		public void StartLongPress(float longPressTime)
		{
			this.CurrentPressTime = 0f;
			this.MaxLongPressTime = longPressTime;
			this.UpdateProgress();
		}

		// Token: 0x0603426A RID: 213610 RVA: 0x00C3D543 File Offset: 0x00C3B743
		public void StopLongPress()
		{
			this.CurrentPressTime = 0f;
			this.MaxLongPressTime = 0f;
			this.UpdateProgress();
		}

		// Token: 0x0603426B RID: 213611 RVA: 0x00C3D561 File Offset: 0x00C3B761
		public void Update(float delta)
		{
			if (this.MaxLongPressTime > 0f)
			{
				this.CurrentPressTime += delta;
				this.UpdateProgress();
			}
		}

		// Token: 0x0603426C RID: 213612 RVA: 0x00C3D584 File Offset: 0x00C3B784
		private void UpdateProgress()
		{
			float fillAmount = (this.MaxLongPressTime <= 0f) ? 0f : ((this.CurrentPressTime >= this.MaxLongPressTime) ? 1f : (this.CurrentPressTime / this.MaxLongPressTime));
			base.GetTexture(0).SetFillAmount(fillAmount);
		}

		// Token: 0x0401BB94 RID: 113556
		public float CurrentPressTime;

		// Token: 0x0401BB95 RID: 113557
		private float MaxLongPressTime;

		// Token: 0x0200B0A2 RID: 45218
		private class EComponentType
		{
			// Token: 0x040359AC RID: 219564
			public const int ProgressTextureA = 0;

			// Token: 0x040359AD RID: 219565
			public const int FlagItemA = 1;

			// Token: 0x040359AE RID: 219566
			public const int FlagItemB = 2;

			// Token: 0x040359AF RID: 219567
			public const int FlagNumB = 3;

			// Token: 0x040359B0 RID: 219568
			public const int AniFlagSwitch = 4;

			// Token: 0x040359B1 RID: 219569
			public const int BarItemA = 5;

			// Token: 0x040359B2 RID: 219570
			public const int BarItemB = 6;

			// Token: 0x040359B3 RID: 219571
			public const int ProgressTextureB = 7;

			// Token: 0x040359B4 RID: 219572
			public const int FlagBg = 8;
		}
	}
}
