using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AAD RID: 23213
	public class DreamLinkScoreRewardItem : UiPanelBase
	{
		// Token: 0x0603ACD7 RID: 240855 RVA: 0x00E02DF1 File Offset: 0x00E00FF1
		[NullableContext(1)]
		public DreamLinkScoreRewardItem(DreamLinkData data)
		{
			this.Data = data;
			this.MaxEnergy = this.Data.MaxEnergy;
		}

		// Token: 0x0603ACD8 RID: 240856 RVA: 0x00E02E18 File Offset: 0x00E01018
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ACD9 RID: 240857 RVA: 0x00E02EDF File Offset: 0x00E010DF
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeCurrencyUpdate, new Action(this.OnDreamLinkRewardRefresh));
			this.RefreshPerformance();
		}

		// Token: 0x0603ACDA RID: 240858 RVA: 0x00E02F03 File Offset: 0x00E01103
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeCurrencyUpdate, new Action(this.OnDreamLinkRewardRefresh));
		}

		// Token: 0x0603ACDB RID: 240859 RVA: 0x00E02F21 File Offset: 0x00E01121
		private void OnDreamLinkRewardRefresh()
		{
			this.RefreshPerformance();
		}

		// Token: 0x0603ACDC RID: 240860 RVA: 0x00E02F2C File Offset: 0x00E0112C
		public void RefreshPerformance()
		{
			int energyItemCount = this.Data.GetEnergyItemCount();
			if (this.CurrentEnergy != energyItemCount)
			{
				this.CurrentEnergy = energyItemCount;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DreamLink_Reward_Ins_Progress", new <>z__ReadOnlyArray<object>(new object[]
				{
					this.CurrentEnergy,
					this.MaxEnergy
				}));
			}
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.Data.CheckHasEnergyReward());
		}

		// Token: 0x0603ACDD RID: 240861 RVA: 0x00E02FAE File Offset: 0x00E011AE
		private void OnClickedButton()
		{
			this.Data.SaveFirstCheckRedDotState(5, 0);
			UiManager.Instance.OpenView(EUiViewName.DreamLinkRewardViewEnergy, null, null);
		}

		// Token: 0x0401EB05 RID: 125701
		private int CurrentEnergy = -1;

		// Token: 0x0401EB06 RID: 125702
		private readonly int MaxEnergy;

		// Token: 0x0401EB07 RID: 125703
		[Nullable(1)]
		protected readonly DreamLinkData Data;

		// Token: 0x0200BCFA RID: 48378
		private class EComponents
		{
			// Token: 0x04038FE1 RID: 233441
			public const int Button = 0;

			// Token: 0x04038FE2 RID: 233442
			public const int TxtScore = 1;

			// Token: 0x04038FE3 RID: 233443
			public const int RedDot = 2;
		}
	}
}
