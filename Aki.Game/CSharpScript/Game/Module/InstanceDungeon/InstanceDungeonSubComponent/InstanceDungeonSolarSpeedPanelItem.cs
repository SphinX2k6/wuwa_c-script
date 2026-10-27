using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058AB RID: 22699
	public class InstanceDungeonSolarSpeedPanelItem : UiPanelBase
	{
		// Token: 0x06039BC8 RID: 236488 RVA: 0x00DB8B28 File Offset: 0x00DB6D28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnScoreReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039BC9 RID: 236489 RVA: 0x00DB8C10 File Offset: 0x00DB6E10
		protected override void OnStart()
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), "BossRushCollectReward", Array.Empty<object>());
			if (this.ItemDataHandle != null && this.ItemDataHandle.HaveRefresh)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x06039BCA RID: 236490 RVA: 0x00DB8C48 File Offset: 0x00DB6E48
		protected override UniTask OnBeforeStartAsync()
		{
			EventSystem.Instance.Add(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			return UniTask.CompletedTask;
		}

		// Token: 0x06039BCB RID: 236491 RVA: 0x00DB8C6B File Offset: 0x00DB6E6B
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
		}

		// Token: 0x06039BCC RID: 236492 RVA: 0x00DB8C8C File Offset: 0x00DB6E8C
		public void RefreshItem()
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new IInstanceDungeonSolarSpeedPanelItem
				{
					HaveRefresh = true
				};
				return;
			}
			SolarSpeedModel instance = SolarSpeedModel.Instance;
			base.GetItem(2).SetUIActive(instance.HasRewardRedDot);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), "parkour_award_2_1", new <>z__ReadOnlyArray<object>(new object[]
			{
				instance.CurrentCompletedCount,
				instance.TotalRewardCount
			}));
		}

		// Token: 0x06039BCD RID: 236493 RVA: 0x00DB8D09 File Offset: 0x00DB6F09
		private void OnClickBtnScoreReward()
		{
			ActivitySolarSpeedController.Instance.HandleOnClickRewardInActivitySubView();
		}

		// Token: 0x06039BCE RID: 236494 RVA: 0x00DB8D15 File Offset: 0x00DB6F15
		private void HandleSolarSpeedRewarded()
		{
			this.RefreshItem();
		}

		// Token: 0x0401E278 RID: 123512
		[Nullable(2)]
		private IInstanceDungeonSolarSpeedPanelItem ItemDataHandle;

		// Token: 0x0200BB12 RID: 47890
		private enum EChildType
		{
			// Token: 0x04038834 RID: 231476
			BtnScoreReward,
			// Token: 0x04038835 RID: 231477
			TxtTitle,
			// Token: 0x04038836 RID: 231478
			ScoreRedDot,
			// Token: 0x04038837 RID: 231479
			TxtProgress
		}
	}
}
