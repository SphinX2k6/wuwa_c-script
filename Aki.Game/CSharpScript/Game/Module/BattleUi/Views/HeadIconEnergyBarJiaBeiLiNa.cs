using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D1B RID: 19739
	public class HeadIconEnergyBarJiaBeiLiNa : HeadIconEnergyBarBase
	{
		// Token: 0x060317CE RID: 202702 RVA: 0x00DD608C File Offset: 0x00DD428C
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

		// Token: 0x060317CF RID: 202703 RVA: 0x00DD61BB File Offset: 0x00DD43BB
		protected override void OnStart()
		{
			base.OnStart();
			base.InitTweenAnim(6);
			base.InitTweenAnim(5);
			base.InitTweenAnim(7);
			this.LastPercent = this.PercentMachine.GetCurPercent();
			this.RefreshBarPercent(true);
		}

		// Token: 0x060317D0 RID: 202704 RVA: 0x00DD61F0 File Offset: 0x00DD43F0
		protected override void OnTargetPercentChanged()
		{
			float targetPercent = this.PercentMachine.GetTargetPercent();
			if (targetPercent > this.LastPercent)
			{
				this.PlayAbsorbAni();
			}
			this.LastPercent = targetPercent;
		}

		// Token: 0x060317D1 RID: 202705 RVA: 0x00DD621F File Offset: 0x00DD441F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x060317D2 RID: 202706 RVA: 0x00DD6228 File Offset: 0x00DD4428
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

		// Token: 0x060317D3 RID: 202707 RVA: 0x00DD6288 File Offset: 0x00DD4488
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

		// Token: 0x060317D4 RID: 202708 RVA: 0x00DD62D6 File Offset: 0x00DD44D6
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

		// Token: 0x0401A346 RID: 107334
		private float LastPercent;

		// Token: 0x0401A347 RID: 107335
		private float NextAbsorbAniTime;

		// Token: 0x0401A348 RID: 107336
		private bool IsFull;

		// Token: 0x0200A9DB RID: 43483
		private enum EChildType
		{
			// Token: 0x040347BF RID: 214975
			BarItem,
			// Token: 0x040347C0 RID: 214976
			BarSprite,
			// Token: 0x040347C1 RID: 214977
			BarLightItem,
			// Token: 0x040347C2 RID: 214978
			FullItem,
			// Token: 0x040347C3 RID: 214979
			FullBarSprite,
			// Token: 0x040347C4 RID: 214980
			AniBurstOut,
			// Token: 0x040347C5 RID: 214981
			AniBurstIn,
			// Token: 0x040347C6 RID: 214982
			AniAbsorb
		}
	}
}
