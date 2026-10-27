using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D58 RID: 23896
	public class HonamiStoryMainQuestView : HonamiStoryViewBase
	{
		// Token: 0x0603CAA8 RID: 248488 RVA: 0x00E8FD04 File Offset: 0x00E8DF04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CAA9 RID: 248489 RVA: 0x00E8FE58 File Offset: 0x00E8E058
		protected override void OnInitData()
		{
			this.HpTextType = 2;
			this.InTweenType = 7;
			this.OutTweenType = 8;
			this.DangerPercentConfigId = "HonamiStoryMainQuestDangerLifeSupportPercent";
			this.ShowFunctionType = new EFunctionType?(EFunctionType.HonamiStoryMainQuestLifeSupport);
			this.HideFunctionType = new EFunctionType?(EFunctionType.HonamiStoryLifeSupport);
		}

		// Token: 0x0603CAAA RID: 248490 RVA: 0x00E8FEA5 File Offset: 0x00E8E0A5
		protected override void OnStart()
		{
			base.OnStart();
			base.GetSlider(5).SetValue(this.DangerPercent, true);
			base.GetSlider(6).SetValue(this.DangerPercent, true);
		}

		// Token: 0x0603CAAB RID: 248491 RVA: 0x00E8FED3 File Offset: 0x00E8E0D3
		protected override void OnRefreshAttribute(float percent, EHpStateType state)
		{
			base.GetSprite(0).SetFillAmount(percent);
			base.GetSprite(1).SetFillAmount(percent);
		}

		// Token: 0x0603CAAC RID: 248492 RVA: 0x00E8FEF0 File Offset: 0x00E8E0F0
		protected override void OnRefreshState(EHpStateType state)
		{
			bool flag = state == EHpStateType.Normal;
			base.GetItem(3).SetUIActive(flag);
			base.GetItem(4).SetUIActive(!flag);
			FColor color = FColor.FromHex(flag ? "#E3F1F5" : "#E5426A");
			base.GetSprite(0).SetColor(color);
			base.GetSprite(1).SetColor(color);
		}

		// Token: 0x0200C009 RID: 49161
		private enum EComponentType
		{
			// Token: 0x04039F27 RID: 237351
			BarLeft,
			// Token: 0x04039F28 RID: 237352
			BarRight,
			// Token: 0x04039F29 RID: 237353
			HpText,
			// Token: 0x04039F2A RID: 237354
			NormalItem,
			// Token: 0x04039F2B RID: 237355
			DangerItem,
			// Token: 0x04039F2C RID: 237356
			SliderLeft,
			// Token: 0x04039F2D RID: 237357
			SliderRight,
			// Token: 0x04039F2E RID: 237358
			InTween,
			// Token: 0x04039F2F RID: 237359
			OutTween
		}
	}
}
