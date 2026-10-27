using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D39 RID: 23865
	public class HeadIconEnergyBarJiaBeiLiNa : HeadIconEnergyBarBase
	{
		// Token: 0x0603C875 RID: 247925 RVA: 0x00E858EC File Offset: 0x00E83AEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C876 RID: 247926 RVA: 0x00E85A1B File Offset: 0x00E83C1B
		protected override void OnStart()
		{
			base.OnStart();
			base.InitTweenAnim(6);
			base.InitTweenAnim(5);
			base.InitTweenAnim(7);
			this.LastPercent = this.PercentMachine.GetCurPercent();
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603C877 RID: 247927 RVA: 0x00E85A50 File Offset: 0x00E83C50
		protected override void OnTargetPercentChanged()
		{
			float targetPercent = this.PercentMachine.GetTargetPercent();
			if (targetPercent > this.LastPercent)
			{
				this.PlayAbsorbAni();
			}
			this.LastPercent = targetPercent;
		}

		// Token: 0x0603C878 RID: 247928 RVA: 0x00E85A7F File Offset: 0x00E83C7F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603C879 RID: 247929 RVA: 0x00E85A88 File Offset: 0x00E83C88
		private void RefreshBarPercent(bool bForce = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetFillAmount(curPercent);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetAnchorOffsetX(116f * (curPercent - 0.5f));
			}
			this.SetIsFull(curPercent >= 1f, bForce);
		}

		// Token: 0x0603C87A RID: 247930 RVA: 0x00E85AE8 File Offset: 0x00E83CE8
		private void PlayAbsorbAni()
		{
			if (!this.PlayIncreaseEffect)
			{
				return;
			}
			float num = (float)Time.Instance.NowSeconds;
			if (num <= this.NextAbsorbAniTime)
			{
				return;
			}
			this.NextAbsorbAniTime = num + this.Config.Value.EffectCd;
			base.PlayTweenAnim(7);
		}

		// Token: 0x0603C87B RID: 247931 RVA: 0x00E85B36 File Offset: 0x00E83D36
		private void SetIsFull(bool isFull, bool bForce = false)
		{
			if (this.IsFull == isFull && !bForce)
			{
				return;
			}
			this.IsFull = isFull;
			if (this.IsFull)
			{
				base.StopTweenAnim(5);
				base.PlayTweenAnim(6);
				return;
			}
			base.StopTweenAnim(6);
			base.PlayTweenAnim(5);
		}

		// Token: 0x0401F88D RID: 129165
		private float LastPercent;

		// Token: 0x0401F88E RID: 129166
		private float NextAbsorbAniTime;

		// Token: 0x0401F88F RID: 129167
		private bool IsFull;

		// Token: 0x0200BFD5 RID: 49109
		private enum EChildType
		{
			// Token: 0x04039DFD RID: 237053
			BarItem,
			// Token: 0x04039DFE RID: 237054
			BarSprite,
			// Token: 0x04039DFF RID: 237055
			BarLightItem,
			// Token: 0x04039E00 RID: 237056
			FullItem,
			// Token: 0x04039E01 RID: 237057
			FullBarSprite,
			// Token: 0x04039E02 RID: 237058
			AniBurstOut,
			// Token: 0x04039E03 RID: 237059
			AniBurstIn,
			// Token: 0x04039E04 RID: 237060
			AniAbsorb
		}
	}
}
