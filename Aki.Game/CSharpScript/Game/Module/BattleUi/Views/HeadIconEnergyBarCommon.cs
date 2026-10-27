using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D35 RID: 23861
	public class HeadIconEnergyBarCommon : HeadIconEnergyBarBase
	{
		// Token: 0x0603C84F RID: 247887 RVA: 0x00E84E60 File Offset: 0x00E83060
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C850 RID: 247888 RVA: 0x00E84F4D File Offset: 0x00E8314D
		protected override void OnStart()
		{
			base.OnStart();
			base.InitTweenAnim(3);
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			this.LastPercent = this.PercentMachine.GetCurPercent();
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603C851 RID: 247889 RVA: 0x00E84F84 File Offset: 0x00E83184
		protected override void OnTargetPercentChanged()
		{
			float targetPercent = this.PercentMachine.GetTargetPercent();
			if (targetPercent > this.LastPercent)
			{
				this.PlayAbsorbAni();
			}
			this.LastPercent = targetPercent;
		}

		// Token: 0x0603C852 RID: 247890 RVA: 0x00E84FB3 File Offset: 0x00E831B3
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603C853 RID: 247891 RVA: 0x00E84FBC File Offset: 0x00E831BC
		private void RefreshBarPercent(bool bForce = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetFillAmount(curPercent);
			}
			this.SetIsFull(curPercent >= 1f, bForce);
		}

		// Token: 0x0603C854 RID: 247892 RVA: 0x00E84FFC File Offset: 0x00E831FC
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
			base.PlayTweenAnim(5);
		}

		// Token: 0x0603C855 RID: 247893 RVA: 0x00E8504A File Offset: 0x00E8324A
		private void SetIsFull(bool isFull, bool bForce = false)
		{
			if (this.IsFull == isFull && !bForce)
			{
				return;
			}
			this.IsFull = isFull;
			if (this.IsFull)
			{
				base.StopTweenAnim(4);
				base.PlayTweenAnim(3);
				return;
			}
			base.StopTweenAnim(3);
			base.PlayTweenAnim(4);
		}

		// Token: 0x0401F879 RID: 129145
		private float LastPercent;

		// Token: 0x0401F87A RID: 129146
		private float NextAbsorbAniTime;

		// Token: 0x0401F87B RID: 129147
		private bool IsFull;

		// Token: 0x0200BFCF RID: 49103
		private enum EChildType
		{
			// Token: 0x04039DD7 RID: 237015
			BarItem,
			// Token: 0x04039DD8 RID: 237016
			BarSprite,
			// Token: 0x04039DD9 RID: 237017
			BarLightItem,
			// Token: 0x04039DDA RID: 237018
			AniBurstIn,
			// Token: 0x04039DDB RID: 237019
			AniBurstOut,
			// Token: 0x04039DDC RID: 237020
			AniAbsorb
		}
	}
}
