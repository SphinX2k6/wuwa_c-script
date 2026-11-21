using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D24 RID: 19748
	public class DurabilityHeadState : HeadStateViewBase
	{
		// Token: 0x06031866 RID: 202854 RVA: 0x00DD9268 File Offset: 0x00DD7468
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

		// Token: 0x06031867 RID: 202855 RVA: 0x00DD92F2 File Offset: 0x00DD74F2
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_DestructionState_Prefab";
		}

		// Token: 0x06031868 RID: 202856 RVA: 0x00DD92F9 File Offset: 0x00DD74F9
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

		// Token: 0x06031869 RID: 202857 RVA: 0x00DD932E File Offset: 0x00DD752E
		protected override void OnStart()
		{
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
		}

		// Token: 0x0603186A RID: 202858 RVA: 0x00DD9347 File Offset: 0x00DD7547
		protected override void BindCallback()
		{
			base.BindCallback();
			this.HeadStateData.BindOnSceneItemDurabilityChange(new Action<int>(this.OnSceneItemDurabilityChange));
		}

		// Token: 0x0603186B RID: 202859 RVA: 0x00DD9366 File Offset: 0x00DD7566
		private void OnSceneItemDurabilityChange(int durability)
		{
			this.RefreshDurability(true);
		}

		// Token: 0x0603186C RID: 202860 RVA: 0x00DD9370 File Offset: 0x00DD7570
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

		// Token: 0x0603186D RID: 202861 RVA: 0x00DD93B9 File Offset: 0x00DD75B9
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x0603186E RID: 202862 RVA: 0x00DD93C8 File Offset: 0x00DD75C8
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603186F RID: 202863 RVA: 0x00DD93D1 File Offset: 0x00DD75D1
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x06031870 RID: 202864 RVA: 0x00DD93E6 File Offset: 0x00DD75E6
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x06031871 RID: 202865 RVA: 0x00DD93F0 File Offset: 0x00DD75F0
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

		// Token: 0x06031872 RID: 202866 RVA: 0x00DD9454 File Offset: 0x00DD7654
		protected override float GetMaxHp()
		{
			return this.HeadStateData.GetMaxDurable();
		}

		// Token: 0x06031873 RID: 202867 RVA: 0x00DD9461 File Offset: 0x00DD7661
		protected override float GetHp()
		{
			return this.HeadStateData.GetDurable();
		}

		// Token: 0x0401A374 RID: 107380
		private float HpParentWidth;

		// Token: 0x0200A9EB RID: 43499
		private enum EChildComponentType
		{
			// Token: 0x04034811 RID: 215057
			NormalHpBarSprite,
			// Token: 0x04034812 RID: 215058
			BarBufferSprite,
			// Token: 0x04034813 RID: 215059
			HpLight
		}
	}
}
