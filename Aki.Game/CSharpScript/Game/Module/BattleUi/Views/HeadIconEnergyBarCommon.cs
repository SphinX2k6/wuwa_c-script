using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D17 RID: 19735
	public class HeadIconEnergyBarCommon : HeadIconEnergyBarBase
	{
		// Token: 0x060317A8 RID: 202664 RVA: 0x00DD5600 File Offset: 0x00DD3800
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

		// Token: 0x060317A9 RID: 202665 RVA: 0x00DD56ED File Offset: 0x00DD38ED
		protected override void OnStart()
		{
			base.OnStart();
			base.InitTweenAnim(3);
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			this.LastPercent = this.PercentMachine.GetCurPercent();
			this.RefreshBarPercent(true);
		}

		// Token: 0x060317AA RID: 202666 RVA: 0x00DD5724 File Offset: 0x00DD3924
		protected override void OnTargetPercentChanged()
		{
			float targetPercent = this.PercentMachine.GetTargetPercent();
			if (targetPercent > this.LastPercent)
			{
				this.PlayAbsorbAni();
			}
			this.LastPercent = targetPercent;
		}

		// Token: 0x060317AB RID: 202667 RVA: 0x00DD5753 File Offset: 0x00DD3953
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x060317AC RID: 202668 RVA: 0x00DD575C File Offset: 0x00DD395C
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

		// Token: 0x060317AD RID: 202669 RVA: 0x00DD579C File Offset: 0x00DD399C
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

		// Token: 0x060317AE RID: 202670 RVA: 0x00DD57EA File Offset: 0x00DD39EA
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

		// Token: 0x0401A332 RID: 107314
		private float LastPercent;

		// Token: 0x0401A333 RID: 107315
		private float NextAbsorbAniTime;

		// Token: 0x0401A334 RID: 107316
		private bool IsFull;

		// Token: 0x0200A9D5 RID: 43477
		private enum EChildType
		{
			// Token: 0x04034799 RID: 214937
			BarItem,
			// Token: 0x0403479A RID: 214938
			BarSprite,
			// Token: 0x0403479B RID: 214939
			BarLightItem,
			// Token: 0x0403479C RID: 214940
			AniBurstIn,
			// Token: 0x0403479D RID: 214941
			AniBurstOut,
			// Token: 0x0403479E RID: 214942
			AniAbsorb
		}
	}
}
