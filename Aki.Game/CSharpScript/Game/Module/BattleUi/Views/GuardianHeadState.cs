using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D45 RID: 23877
	public class GuardianHeadState : HeadStateViewBase
	{
		// Token: 0x0603C960 RID: 248160 RVA: 0x00E8A0F8 File Offset: 0x00E882F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C961 RID: 248161 RVA: 0x00E8A182 File Offset: 0x00E88382
		[NullableContext(1)]
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshHp(false);
			this.RefreshHpColor();
		}

		// Token: 0x0603C962 RID: 248162 RVA: 0x00E8A198 File Offset: 0x00E88398
		protected override void OnStart()
		{
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
		}

		// Token: 0x0603C963 RID: 248163 RVA: 0x00E8A1B1 File Offset: 0x00E883B1
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_GuardianState_Prefab";
		}

		// Token: 0x0603C964 RID: 248164 RVA: 0x00E8A1B8 File Offset: 0x00E883B8
		protected override void OnHealthChanged()
		{
			this.RefreshHp(true);
		}

		// Token: 0x0603C965 RID: 248165 RVA: 0x00E8A1C4 File Offset: 0x00E883C4
		public void RefreshHp(bool bPlayBarAnimation = false)
		{
			ValueTuple<float, float> hpAndMaxHp = base.GetHpAndMaxHp();
			float item = hpAndMaxHp.Item1;
			float item2 = hpAndMaxHp.Item2;
			float num = item / item2;
			this.SetHpBarPercent(num);
			if (bPlayBarAnimation)
			{
				this.PlayBarAnimation(num);
				return;
			}
			this.StopBarLerpAnimation();
		}

		// Token: 0x0603C966 RID: 248166 RVA: 0x00E8A200 File Offset: 0x00E88400
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x0603C967 RID: 248167 RVA: 0x00E8A20F File Offset: 0x00E8840F
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603C968 RID: 248168 RVA: 0x00E8A218 File Offset: 0x00E88418
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603C969 RID: 248169 RVA: 0x00E8A22D File Offset: 0x00E8842D
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603C96A RID: 248170 RVA: 0x00E8A238 File Offset: 0x00E88438
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount(percent);
			if (!sprite.IsUIActiveSelf())
			{
				sprite.SetUIActive(true);
			}
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft(this.HpParentWidth * this.CurrentBarPercent - 2f);
			sprite2.SetStretchRight(this.HpParentWidth * (1f - percent) - 2f);
		}

		// Token: 0x0603C96B RID: 248171 RVA: 0x00E8A29C File Offset: 0x00E8849C
		private void RefreshHpColor()
		{
			string hpColor = base.GetHpColor();
			if (string.IsNullOrEmpty(hpColor))
			{
				return;
			}
			FColor color = FColor.FromHex(hpColor);
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(color);
		}

		// Token: 0x0603C96C RID: 248172 RVA: 0x00E8A2D2 File Offset: 0x00E884D2
		protected override void RefreshOnCampChanged()
		{
			this.RefreshHpColor();
		}

		// Token: 0x0401F8DC RID: 129244
		private float HpParentWidth;

		// Token: 0x0200BFE8 RID: 49128
		private enum EChildComponentType
		{
			// Token: 0x04039E78 RID: 237176
			HpBarSprite,
			// Token: 0x04039E79 RID: 237177
			BarBufferSprite,
			// Token: 0x04039E7A RID: 237178
			HpLight
		}
	}
}
