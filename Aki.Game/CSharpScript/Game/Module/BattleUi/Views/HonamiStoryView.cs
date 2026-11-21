using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D3C RID: 19772
	public class HonamiStoryView : HonamiStoryViewBase
	{
		// Token: 0x06031A10 RID: 203280 RVA: 0x00DE0A54 File Offset: 0x00DDEC54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031A11 RID: 203281 RVA: 0x00DE0BA5 File Offset: 0x00DDEDA5
		protected override void OnInitData()
		{
			this.HpTextType = 4;
			this.InTweenType = 7;
			this.OutTweenType = 8;
			this.DangerPercentConfigId = "HonamiStoryDangerLifeSupportPercent";
			this.ShowFunctionType = new EFunctionType?(EFunctionType.HonamiStoryLifeSupport);
		}

		// Token: 0x06031A12 RID: 203282 RVA: 0x00DE0BD8 File Offset: 0x00DDEDD8
		protected override void OnRefreshAttribute(float percent, EHpStateType state)
		{
			if (state == EHpStateType.Normal)
			{
				float fillAmount = (percent - this.DangerPercent) / this.NormalPercent;
				base.GetSprite(1).SetFillAmount(fillAmount);
				base.GetSprite(3).SetFillAmount(fillAmount);
				return;
			}
			float fillAmount2 = percent / this.DangerPercent;
			base.GetSprite(0).SetFillAmount(fillAmount2);
			base.GetSprite(2).SetFillAmount(fillAmount2);
		}

		// Token: 0x06031A13 RID: 203283 RVA: 0x00DE0C38 File Offset: 0x00DDEE38
		protected override void OnRefreshState(EHpStateType state)
		{
			bool flag = state == EHpStateType.Normal;
			base.GetItem(5).SetUIActive(flag);
			base.GetItem(6).SetUIActive(!flag);
			if (flag)
			{
				UUISprite sprite = base.GetSprite(0);
				UUISprite sprite2 = base.GetSprite(2);
				sprite.SetFillAmount(1f);
				sprite2.SetFillAmount(1f);
				FColor color = FColor.FromHex("#E3F1F5");
				sprite.SetColor(color);
				sprite2.SetColor(color);
				return;
			}
			base.GetSprite(1).SetFillAmount(0f);
			base.GetSprite(3).SetFillAmount(0f);
			FColor color2 = FColor.FromHex("#E5426A");
			base.GetSprite(0).SetColor(color2);
			base.GetSprite(2).SetColor(color2);
		}

		// Token: 0x0200AA12 RID: 43538
		private enum EComponentType
		{
			// Token: 0x040348FC RID: 215292
			DangerBarLeft,
			// Token: 0x040348FD RID: 215293
			NormalBarLeft,
			// Token: 0x040348FE RID: 215294
			DangerBarRight,
			// Token: 0x040348FF RID: 215295
			NormalBarRight,
			// Token: 0x04034900 RID: 215296
			HpText,
			// Token: 0x04034901 RID: 215297
			NormalItem,
			// Token: 0x04034902 RID: 215298
			DangerItem,
			// Token: 0x04034903 RID: 215299
			InTween,
			// Token: 0x04034904 RID: 215300
			OutTween
		}
	}
}
