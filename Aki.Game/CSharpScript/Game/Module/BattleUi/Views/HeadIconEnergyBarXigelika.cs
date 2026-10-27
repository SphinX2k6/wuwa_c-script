using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D3D RID: 23869
	public class HeadIconEnergyBarXigelika : HeadIconEnergyBarBase
	{
		// Token: 0x0603C89E RID: 247966 RVA: 0x00E86378 File Offset: 0x00E84578
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

		// Token: 0x0603C89F RID: 247967 RVA: 0x00E86402 File Offset: 0x00E84602
		protected override void OnStart()
		{
			base.OnStart();
			base.GetSprite(1).SetUIActive(true);
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603C8A0 RID: 247968 RVA: 0x00E8641E File Offset: 0x00E8461E
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603C8A1 RID: 247969 RVA: 0x00E86428 File Offset: 0x00E84628
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

		// Token: 0x0200BFDC RID: 49116
		private enum EChildType
		{
			// Token: 0x04039E1F RID: 237087
			PnlBar,
			// Token: 0x04039E20 RID: 237088
			SprBar1,
			// Token: 0x04039E21 RID: 237089
			SprBar2
		}
	}
}
