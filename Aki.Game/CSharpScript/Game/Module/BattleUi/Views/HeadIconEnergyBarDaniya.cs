using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D18 RID: 19736
	public class HeadIconEnergyBarDaniya : HeadIconEnergyBarBase
	{
		// Token: 0x060317B0 RID: 202672 RVA: 0x00DD5830 File Offset: 0x00DD3A30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060317B1 RID: 202673 RVA: 0x00DD59A4 File Offset: 0x00DD3BA4
		protected override void OnStart()
		{
			base.OnStart();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStyleChanged));
			BaseTagComponent tagComponent = this.TagComponent;
			bool tagExist = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"]);
			this.OnStyleChanged(0, tagExist);
		}

		// Token: 0x060317B2 RID: 202674 RVA: 0x00DD5A02 File Offset: 0x00DD3C02
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshBarPercent(true);
		}

		// Token: 0x060317B3 RID: 202675 RVA: 0x00DD5A11 File Offset: 0x00DD3C11
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x060317B4 RID: 202676 RVA: 0x00DD5A1A File Offset: 0x00DD3C1A
		private void OnStyleChanged(int tagId, bool tagExist)
		{
			this.CurState = (tagExist ? HeadIconEnergyBarDaniya.EState.StateA : HeadIconEnergyBarDaniya.EState.StateB);
			base.GetItem(0).SetUIActive(tagExist);
			base.GetItem(5).SetUIActive(!tagExist);
			this.RefreshBarPercent(true);
		}

		// Token: 0x060317B5 RID: 202677 RVA: 0x00DD5A50 File Offset: 0x00DD3C50
		private void RefreshBarPercent(bool bForce = false)
		{
			float num = this.ImmediateMode ? this.PercentMachine.GetTargetPercent() : this.PercentMachine.GetCurPercent();
			HeadIconEnergyBarDaniya.EChildType name = (this.CurState == HeadIconEnergyBarDaniya.EState.StateA) ? HeadIconEnergyBarDaniya.EChildType.BarNorA : HeadIconEnergyBarDaniya.EChildType.BarNorB;
			base.GetSprite((int)name).SetFillAmount(num);
			bool flag = num > 0.5f;
			if (this.LightVisible != flag || bForce)
			{
				this.LightVisible = flag;
				HeadIconEnergyBarDaniya.EChildType name2 = (this.CurState == HeadIconEnergyBarDaniya.EState.StateA) ? HeadIconEnergyBarDaniya.EChildType.PnlBurstA : HeadIconEnergyBarDaniya.EChildType.PnlBurstB;
				base.GetItem((int)name2).SetUIActive(flag);
			}
			if (flag)
			{
				HeadIconEnergyBarDaniya.EChildType name3 = (this.CurState == HeadIconEnergyBarDaniya.EState.StateA) ? HeadIconEnergyBarDaniya.EChildType.BarNorLightA : HeadIconEnergyBarDaniya.EChildType.BarNorLightB;
				base.GetSprite((int)name3).SetFillAmount(num);
			}
		}

		// Token: 0x0401A335 RID: 107317
		private const float SHOW_LIGHT_VALUE = 0.5f;

		// Token: 0x0401A336 RID: 107318
		private HeadIconEnergyBarDaniya.EState CurState;

		// Token: 0x0401A337 RID: 107319
		private readonly bool ImmediateMode = true;

		// Token: 0x0401A338 RID: 107320
		private bool LightVisible;

		// Token: 0x0200A9D6 RID: 43478
		private enum EState
		{
			// Token: 0x040347A0 RID: 214944
			StateA,
			// Token: 0x040347A1 RID: 214945
			StateB
		}

		// Token: 0x0200A9D7 RID: 43479
		private enum EChildType
		{
			// Token: 0x040347A3 RID: 214947
			PnBarA,
			// Token: 0x040347A4 RID: 214948
			PnlNorA,
			// Token: 0x040347A5 RID: 214949
			BarNorA,
			// Token: 0x040347A6 RID: 214950
			PnlBurstA,
			// Token: 0x040347A7 RID: 214951
			BarNorLightA,
			// Token: 0x040347A8 RID: 214952
			PnBarB,
			// Token: 0x040347A9 RID: 214953
			PnlNorB,
			// Token: 0x040347AA RID: 214954
			BarNorB,
			// Token: 0x040347AB RID: 214955
			PnlBurstB,
			// Token: 0x040347AC RID: 214956
			BarNorLightB
		}
	}
}
