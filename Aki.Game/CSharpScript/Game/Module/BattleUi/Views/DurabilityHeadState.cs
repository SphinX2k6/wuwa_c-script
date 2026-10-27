using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D42 RID: 23874
	public class DurabilityHeadState : HeadStateViewBase
	{
		// Token: 0x0603C90D RID: 248077 RVA: 0x00E88AC0 File Offset: 0x00E86CC0
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

		// Token: 0x0603C90E RID: 248078 RVA: 0x00E88B4A File Offset: 0x00E86D4A
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_DestructionState_Prefab";
		}

		// Token: 0x0603C90F RID: 248079 RVA: 0x00E88B51 File Offset: 0x00E86D51
		[NullableContext(1)]
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			if (headStateData.OriginalHp != null)
			{
				this.CurrentBarPercent = headStateData.OriginalHp.Value / this.GetMaxHp();
			}
			this.RefreshDurability(true);
		}

		// Token: 0x0603C910 RID: 248080 RVA: 0x00E88B86 File Offset: 0x00E86D86
		protected override void OnStart()
		{
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
		}

		// Token: 0x0603C911 RID: 248081 RVA: 0x00E88B9F File Offset: 0x00E86D9F
		protected override void BindCallback()
		{
			base.BindCallback();
			this.HeadStateData.BindOnSceneItemDurabilityChange(new Action<int>(this.OnSceneItemDurabilityChange));
		}

		// Token: 0x0603C912 RID: 248082 RVA: 0x00E88BBE File Offset: 0x00E86DBE
		private void OnSceneItemDurabilityChange(int durability)
		{
			this.RefreshDurability(true);
		}

		// Token: 0x0603C913 RID: 248083 RVA: 0x00E88BC8 File Offset: 0x00E86DC8
		private void RefreshDurability(bool bPlayBarAnimation = false)
		{
			float hp = this.GetHp();
			float maxHp = this.GetMaxHp();
			float num = hp / maxHp;
			this.SetHpBarPercent(num);
			if (bPlayBarAnimation)
			{
				this.PlayBarAnimation(num);
			}
			else
			{
				this.StopBarLerpAnimation();
			}
			HeadStateData headStateData = this.HeadStateData;
			if (headStateData == null)
			{
				return;
			}
			headStateData.SetOriginalHp(hp);
		}

		// Token: 0x0603C914 RID: 248084 RVA: 0x00E88C11 File Offset: 0x00E86E11
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x0603C915 RID: 248085 RVA: 0x00E88C20 File Offset: 0x00E86E20
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603C916 RID: 248086 RVA: 0x00E88C29 File Offset: 0x00E86E29
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603C917 RID: 248087 RVA: 0x00E88C3E File Offset: 0x00E86E3E
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603C918 RID: 248088 RVA: 0x00E88C48 File Offset: 0x00E86E48
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

		// Token: 0x0603C919 RID: 248089 RVA: 0x00E88CAC File Offset: 0x00E86EAC
		protected override float GetMaxHp()
		{
			return this.HeadStateData.GetMaxDurable();
		}

		// Token: 0x0603C91A RID: 248090 RVA: 0x00E88CB9 File Offset: 0x00E86EB9
		protected override float GetHp()
		{
			return this.HeadStateData.GetDurable();
		}

		// Token: 0x0401F8BB RID: 129211
		private float HpParentWidth;

		// Token: 0x0200BFE5 RID: 49125
		private enum EChildComponentType
		{
			// Token: 0x04039E4F RID: 237135
			NormalHpBarSprite,
			// Token: 0x04039E50 RID: 237136
			BarBufferSprite,
			// Token: 0x04039E51 RID: 237137
			HpLight
		}
	}
}
