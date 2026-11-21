using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F57 RID: 16215
	public class BattleQuickHackLongPressItem : UiPanelBase
	{
		// Token: 0x060290D5 RID: 168149 RVA: 0x00B86B7C File Offset: 0x00B84D7C
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

		// Token: 0x060290D6 RID: 168150 RVA: 0x00B86CCD File Offset: 0x00B84ECD
		protected override void OnBeforeShow()
		{
			this.UpdateProgress();
		}

		// Token: 0x060290D7 RID: 168151 RVA: 0x00B86CD5 File Offset: 0x00B84ED5
		public void StartLongPress(float longPressTime)
		{
			this.CurrentPressTime = 0f;
			this.MaxLongPressTime = longPressTime;
			this.UpdateProgress();
		}

		// Token: 0x060290D8 RID: 168152 RVA: 0x00B86CEF File Offset: 0x00B84EEF
		public void StopLongPress()
		{
			this.CurrentPressTime = 0f;
			this.MaxLongPressTime = 0f;
			this.UpdateProgress();
		}

		// Token: 0x060290D9 RID: 168153 RVA: 0x00B86D0D File Offset: 0x00B84F0D
		public void Update(float delta)
		{
			if (this.MaxLongPressTime > 0f)
			{
				this.CurrentPressTime += delta;
				this.UpdateProgress();
			}
		}

		// Token: 0x060290DA RID: 168154 RVA: 0x00B86D30 File Offset: 0x00B84F30
		private void UpdateProgress()
		{
			float fillAmount = (this.MaxLongPressTime <= 0f) ? 0f : ((this.CurrentPressTime >= this.MaxLongPressTime) ? 1f : (this.CurrentPressTime / this.MaxLongPressTime));
			base.GetTexture(0).SetFillAmount(fillAmount);
		}

		// Token: 0x04016569 RID: 91497
		public float CurrentPressTime;

		// Token: 0x0401656A RID: 91498
		private float MaxLongPressTime;

		// Token: 0x02009AD2 RID: 39634
		private class EComponentType
		{
			// Token: 0x040303D7 RID: 197591
			public const int ProgressTextureA = 0;

			// Token: 0x040303D8 RID: 197592
			public const int FlagItemA = 1;

			// Token: 0x040303D9 RID: 197593
			public const int FlagItemB = 2;

			// Token: 0x040303DA RID: 197594
			public const int FlagNumB = 3;

			// Token: 0x040303DB RID: 197595
			public const int AniFlagSwitch = 4;

			// Token: 0x040303DC RID: 197596
			public const int BarItemA = 5;

			// Token: 0x040303DD RID: 197597
			public const int BarItemB = 6;

			// Token: 0x040303DE RID: 197598
			public const int ProgressTextureB = 7;

			// Token: 0x040303DF RID: 197599
			public const int FlagBg = 8;
		}
	}
}
