using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D5A RID: 23898
	public class HonamiStoryView : HonamiStoryViewBase
	{
		// Token: 0x0603CAB7 RID: 248503 RVA: 0x00E902A0 File Offset: 0x00E8E4A0
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

		// Token: 0x0603CAB8 RID: 248504 RVA: 0x00E903F1 File Offset: 0x00E8E5F1
		protected override void OnInitData()
		{
			this.HpTextType = 4;
			this.InTweenType = 7;
			this.OutTweenType = 8;
			this.DangerPercentConfigId = "HonamiStoryDangerLifeSupportPercent";
			this.ShowFunctionType = new EFunctionType?(EFunctionType.HonamiStoryLifeSupport);
		}

		// Token: 0x0603CAB9 RID: 248505 RVA: 0x00E90424 File Offset: 0x00E8E624
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

		// Token: 0x0603CABA RID: 248506 RVA: 0x00E90484 File Offset: 0x00E8E684
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

		// Token: 0x0200C00C RID: 49164
		private enum EComponentType
		{
			// Token: 0x04039F3A RID: 237370
			DangerBarLeft,
			// Token: 0x04039F3B RID: 237371
			NormalBarLeft,
			// Token: 0x04039F3C RID: 237372
			DangerBarRight,
			// Token: 0x04039F3D RID: 237373
			NormalBarRight,
			// Token: 0x04039F3E RID: 237374
			HpText,
			// Token: 0x04039F3F RID: 237375
			NormalItem,
			// Token: 0x04039F40 RID: 237376
			DangerItem,
			// Token: 0x04039F41 RID: 237377
			InTween,
			// Token: 0x04039F42 RID: 237378
			OutTween
		}
	}
}
