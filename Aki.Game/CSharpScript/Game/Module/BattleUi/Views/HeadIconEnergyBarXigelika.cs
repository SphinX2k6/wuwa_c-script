using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D1F RID: 19743
	public class HeadIconEnergyBarXigelika : HeadIconEnergyBarBase
	{
		// Token: 0x060317F7 RID: 202743 RVA: 0x00DD6B18 File Offset: 0x00DD4D18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060317F8 RID: 202744 RVA: 0x00DD6BA2 File Offset: 0x00DD4DA2
		protected override void OnStart()
		{
			base.OnStart();
			base.GetSprite(1).SetUIActive(true);
			this.RefreshBarPercent(true);
		}

		// Token: 0x060317F9 RID: 202745 RVA: 0x00DD6BBE File Offset: 0x00DD4DBE
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x060317FA RID: 202746 RVA: 0x00DD6BC8 File Offset: 0x00DD4DC8
		private void RefreshBarPercent(bool bForce = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool flag = curPercent <= 0.5f;
			float fillAmount = flag ? (curPercent * 2f) : ((curPercent - 0.5f) * 2f);
			base.GetSprite(2).SetUIActive(!flag);
			if (flag)
			{
				base.GetSprite(1).SetFillAmount(fillAmount);
				return;
			}
			base.GetSprite(1).SetFillAmount(1f);
			base.GetSprite(2).SetFillAmount(fillAmount);
		}

		// Token: 0x0200A9E2 RID: 43490
		private enum EChildType
		{
			// Token: 0x040347E1 RID: 215009
			PnlBar,
			// Token: 0x040347E2 RID: 215010
			SprBar1,
			// Token: 0x040347E3 RID: 215011
			SprBar2
		}
	}
}
