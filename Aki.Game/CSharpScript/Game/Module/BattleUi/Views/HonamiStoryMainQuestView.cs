using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D3A RID: 19770
	public class HonamiStoryMainQuestView : HonamiStoryViewBase
	{
		// Token: 0x06031A01 RID: 203265 RVA: 0x00DE04B8 File Offset: 0x00DDE6B8
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

		// Token: 0x06031A02 RID: 203266 RVA: 0x00DE060C File Offset: 0x00DDE80C
		protected override void OnInitData()
		{
			this.HpTextType = 2;
			this.InTweenType = 7;
			this.OutTweenType = 8;
			this.DangerPercentConfigId = "HonamiStoryMainQuestDangerLifeSupportPercent";
			this.ShowFunctionType = new EFunctionType?(EFunctionType.HonamiStoryMainQuestLifeSupport);
			this.HideFunctionType = new EFunctionType?(EFunctionType.HonamiStoryLifeSupport);
		}

		// Token: 0x06031A03 RID: 203267 RVA: 0x00DE0659 File Offset: 0x00DDE859
		protected override void OnStart()
		{
			base.OnStart();
			base.GetSlider(5).SetValue(this.DangerPercent, true);
			base.GetSlider(6).SetValue(this.DangerPercent, true);
		}

		// Token: 0x06031A04 RID: 203268 RVA: 0x00DE0687 File Offset: 0x00DDE887
		protected override void OnRefreshAttribute(float percent, EHpStateType state)
		{
			base.GetSprite(0).SetFillAmount(percent);
			base.GetSprite(1).SetFillAmount(percent);
		}

		// Token: 0x06031A05 RID: 203269 RVA: 0x00DE06A4 File Offset: 0x00DDE8A4
		protected override void OnRefreshState(EHpStateType state)
		{
			bool flag = state == EHpStateType.Normal;
			base.GetItem(3).SetUIActive(flag);
			base.GetItem(4).SetUIActive(!flag);
			FColor color = FColor.FromHex(flag ? "#E3F1F5" : "#E5426A");
			base.GetSprite(0).SetColor(color);
			base.GetSprite(1).SetColor(color);
		}

		// Token: 0x0200AA0F RID: 43535
		private enum EComponentType
		{
			// Token: 0x040348E9 RID: 215273
			BarLeft,
			// Token: 0x040348EA RID: 215274
			BarRight,
			// Token: 0x040348EB RID: 215275
			HpText,
			// Token: 0x040348EC RID: 215276
			NormalItem,
			// Token: 0x040348ED RID: 215277
			DangerItem,
			// Token: 0x040348EE RID: 215278
			SliderLeft,
			// Token: 0x040348EF RID: 215279
			SliderRight,
			// Token: 0x040348F0 RID: 215280
			InTween,
			// Token: 0x040348F1 RID: 215281
			OutTween
		}
	}
}
