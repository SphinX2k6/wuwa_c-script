using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D27 RID: 19751
	public class GuardianHeadState : HeadStateViewBase
	{
		// Token: 0x060318B9 RID: 202937 RVA: 0x00DDA8A8 File Offset: 0x00DD8AA8
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

		// Token: 0x060318BA RID: 202938 RVA: 0x00DDA932 File Offset: 0x00DD8B32
		[NullableContext(1)]
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshHp(false);
			this.RefreshHpColor();
		}

		// Token: 0x060318BB RID: 202939 RVA: 0x00DDA948 File Offset: 0x00DD8B48
		protected override void OnStart()
		{
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
		}

		// Token: 0x060318BC RID: 202940 RVA: 0x00DDA961 File Offset: 0x00DD8B61
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_GuardianState_Prefab";
		}

		// Token: 0x060318BD RID: 202941 RVA: 0x00DDA968 File Offset: 0x00DD8B68
		protected override void OnHealthChanged()
		{
			this.RefreshHp(true);
		}

		// Token: 0x060318BE RID: 202942 RVA: 0x00DDA974 File Offset: 0x00DD8B74
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

		// Token: 0x060318BF RID: 202943 RVA: 0x00DDA9B0 File Offset: 0x00DD8BB0
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x060318C0 RID: 202944 RVA: 0x00DDA9BF File Offset: 0x00DD8BBF
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x060318C1 RID: 202945 RVA: 0x00DDA9C8 File Offset: 0x00DD8BC8
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x060318C2 RID: 202946 RVA: 0x00DDA9DD File Offset: 0x00DD8BDD
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x060318C3 RID: 202947 RVA: 0x00DDA9E8 File Offset: 0x00DD8BE8
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

		// Token: 0x060318C4 RID: 202948 RVA: 0x00DDAA4C File Offset: 0x00DD8C4C
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

		// Token: 0x060318C5 RID: 202949 RVA: 0x00DDAA82 File Offset: 0x00DD8C82
		protected override void RefreshOnCampChanged()
		{
			this.RefreshHpColor();
		}

		// Token: 0x0401A395 RID: 107413
		private float HpParentWidth;

		// Token: 0x0200A9EE RID: 43502
		private enum EChildComponentType
		{
			// Token: 0x0403483A RID: 215098
			HpBarSprite,
			// Token: 0x0403483B RID: 215099
			BarBufferSprite,
			// Token: 0x0403483C RID: 215100
			HpLight
		}
	}
}
