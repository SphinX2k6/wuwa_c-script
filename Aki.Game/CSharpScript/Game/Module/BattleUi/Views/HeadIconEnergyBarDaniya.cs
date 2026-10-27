using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D36 RID: 23862
	public class HeadIconEnergyBarDaniya : HeadIconEnergyBarBase
	{
		// Token: 0x0603C857 RID: 247895 RVA: 0x00E85090 File Offset: 0x00E83290
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

		// Token: 0x0603C858 RID: 247896 RVA: 0x00E85204 File Offset: 0x00E83404
		protected override void OnStart()
		{
			base.OnStart();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStyleChanged));
			BaseTagComponent tagComponent = this.TagComponent;
			bool tagExist = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"]);
			this.OnStyleChanged(0, tagExist);
		}

		// Token: 0x0603C859 RID: 247897 RVA: 0x00E85262 File Offset: 0x00E83462
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603C85A RID: 247898 RVA: 0x00E85271 File Offset: 0x00E83471
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603C85B RID: 247899 RVA: 0x00E8527A File Offset: 0x00E8347A
		private void OnStyleChanged(int tagId, bool tagExist)
		{
			this.CurState = (tagExist ? HeadIconEnergyBarDaniya.EState.StateA : HeadIconEnergyBarDaniya.EState.StateB);
			base.GetItem(0).SetUIActive(tagExist);
			base.GetItem(5).SetUIActive(!tagExist);
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603C85C RID: 247900 RVA: 0x00E852B0 File Offset: 0x00E834B0
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

		// Token: 0x0401F87C RID: 129148
		private const float SHOW_LIGHT_VALUE = 0.5f;

		// Token: 0x0401F87D RID: 129149
		private HeadIconEnergyBarDaniya.EState CurState;

		// Token: 0x0401F87E RID: 129150
		private readonly bool ImmediateMode = true;

		// Token: 0x0401F87F RID: 129151
		private bool LightVisible;

		// Token: 0x0200BFD0 RID: 49104
		private enum EState
		{
			// Token: 0x04039DDE RID: 237022
			StateA,
			// Token: 0x04039DDF RID: 237023
			StateB
		}

		// Token: 0x0200BFD1 RID: 49105
		private enum EChildType
		{
			// Token: 0x04039DE1 RID: 237025
			PnBarA,
			// Token: 0x04039DE2 RID: 237026
			PnlNorA,
			// Token: 0x04039DE3 RID: 237027
			BarNorA,
			// Token: 0x04039DE4 RID: 237028
			PnlBurstA,
			// Token: 0x04039DE5 RID: 237029
			BarNorLightA,
			// Token: 0x04039DE6 RID: 237030
			PnBarB,
			// Token: 0x04039DE7 RID: 237031
			PnlNorB,
			// Token: 0x04039DE8 RID: 237032
			BarNorB,
			// Token: 0x04039DE9 RID: 237033
			PnlBurstB,
			// Token: 0x04039DEA RID: 237034
			BarNorLightB
		}
	}
}
