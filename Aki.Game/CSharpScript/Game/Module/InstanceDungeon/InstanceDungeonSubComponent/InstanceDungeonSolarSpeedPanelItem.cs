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
	// Token: 0x02004883 RID: 18563
	public class InstanceDungeonSolarSpeedPanelItem : UiPanelBase
	{
		// Token: 0x0602EAEB RID: 191211 RVA: 0x00D07A40 File Offset: 0x00D05C40
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

		// Token: 0x0602EAEC RID: 191212 RVA: 0x00D07B28 File Offset: 0x00D05D28
		protected override void OnStart()
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), "BossRushCollectReward", Array.Empty<object>());
			if (this.ItemDataHandle != null && this.ItemDataHandle.HaveRefresh)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x0602EAED RID: 191213 RVA: 0x00D07B60 File Offset: 0x00D05D60
		protected override UniTask OnBeforeStartAsync()
		{
			EventSystem.Instance.Add(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
			return UniTask.CompletedTask;
		}

		// Token: 0x0602EAEE RID: 191214 RVA: 0x00D07B83 File Offset: 0x00D05D83
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.SolarSpeedRewarded, new Action(this.HandleSolarSpeedRewarded));
		}

		// Token: 0x0602EAEF RID: 191215 RVA: 0x00D07BA4 File Offset: 0x00D05DA4
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

		// Token: 0x0602EAF0 RID: 191216 RVA: 0x00D07C21 File Offset: 0x00D05E21
		private void OnClickBtnScoreReward()
		{
			ActivitySolarSpeedController.Instance.HandleOnClickRewardInActivitySubView();
		}

		// Token: 0x0602EAF1 RID: 191217 RVA: 0x00D07C2D File Offset: 0x00D05E2D
		private void HandleSolarSpeedRewarded()
		{
			this.RefreshItem();
		}

		// Token: 0x04018D15 RID: 101653
		[Nullable(2)]
		private IInstanceDungeonSolarSpeedPanelItem ItemDataHandle;

		// Token: 0x0200A52B RID: 42283
		private enum EChildType
		{
			// Token: 0x04033235 RID: 209461
			BtnScoreReward,
			// Token: 0x04033236 RID: 209462
			TxtTitle,
			// Token: 0x04033237 RID: 209463
			ScoreRedDot,
			// Token: 0x04033238 RID: 209464
			TxtProgress
		}
	}
}
