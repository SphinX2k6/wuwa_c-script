using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A89 RID: 19081
	public class DreamLinkScoreRewardItem : UiPanelBase
	{
		// Token: 0x0602FC23 RID: 195619 RVA: 0x00D533B9 File Offset: 0x00D515B9
		[NullableContext(1)]
		public DreamLinkScoreRewardItem(DreamLinkData data)
		{
			this.Data = data;
			this.MaxEnergy = this.Data.MaxEnergy;
		}

		// Token: 0x0602FC24 RID: 195620 RVA: 0x00D533E0 File Offset: 0x00D515E0
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

		// Token: 0x0602FC25 RID: 195621 RVA: 0x00D534A7 File Offset: 0x00D516A7
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeCurrencyUpdate, new Action(this.OnDreamLinkRewardRefresh));
			this.RefreshPerformance();
		}

		// Token: 0x0602FC26 RID: 195622 RVA: 0x00D534CB File Offset: 0x00D516CB
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeCurrencyUpdate, new Action(this.OnDreamLinkRewardRefresh));
		}

		// Token: 0x0602FC27 RID: 195623 RVA: 0x00D534E9 File Offset: 0x00D516E9
		private void OnDreamLinkRewardRefresh()
		{
			this.RefreshPerformance();
		}

		// Token: 0x0602FC28 RID: 195624 RVA: 0x00D534F4 File Offset: 0x00D516F4
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

		// Token: 0x0602FC29 RID: 195625 RVA: 0x00D53576 File Offset: 0x00D51776
		private void OnClickedButton()
		{
			this.Data.SaveFirstCheckRedDotState(5, 0);
			UiManager.Instance.OpenView(EUiViewName.DreamLinkRewardViewEnergy, null, null);
		}

		// Token: 0x040195AC RID: 103852
		private int CurrentEnergy = -1;

		// Token: 0x040195AD RID: 103853
		private readonly int MaxEnergy;

		// Token: 0x040195AE RID: 103854
		[Nullable(1)]
		protected readonly DreamLinkData Data;

		// Token: 0x0200A702 RID: 42754
		private class EComponents
		{
			// Token: 0x040339AB RID: 211371
			public const int Button = 0;

			// Token: 0x040339AC RID: 211372
			public const int TxtScore = 1;

			// Token: 0x040339AD RID: 211373
			public const int RedDot = 2;
		}
	}
}
