using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02003753 RID: 14163
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingCageTipListItem : WorldMapSecondaryTipListItem
	{
		// Token: 0x06024D4A RID: 150858 RVA: 0x00A68B78 File Offset: 0x00A66D78
		public override void Refresh(IWorldMapSecondaryTipItemParam data, bool isSelected, int gridIndex)
		{
			IWorldMapFishingCageSecondaryTipItemParam worldMapFishingCageSecondaryTipItemParam = (IWorldMapFishingCageSecondaryTipItemParam)data;
			if (worldMapFishingCageSecondaryTipItemParam.TipItemType == EFishingCageSecondaryTipItemType.NextHarvestTimeStamp)
			{
				this.RefreshToNextHarvestTimeLayout(worldMapFishingCageSecondaryTipItemParam);
				return;
			}
			if (worldMapFishingCageSecondaryTipItemParam.TipItemType == EFishingCageSecondaryTipItemType.Capacity)
			{
				this.RefreshToCapacityLayout(worldMapFishingCageSecondaryTipItemParam);
			}
		}

		// Token: 0x06024D4B RID: 150859 RVA: 0x00A68BAC File Offset: 0x00A66DAC
		protected override void OnBeforeHide()
		{
			this.StopTimer();
		}

		// Token: 0x06024D4C RID: 150860 RVA: 0x00A68BB4 File Offset: 0x00A66DB4
		private void RefreshToNextHarvestTimeLayout(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			int relativeId = data.RelativeId;
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText5", Array.Empty<string>());
			UUIText nameTxt = base.GetNameTxt();
			if (nameTxt != null)
			{
				nameTxt.SetText(multiText, true);
			}
			this.EndTime = (long)((double)FishingModel.Instance.GetShipCageNextHarvestTimeStamp(relativeId) * TimeUtil.Instance.Millisecond);
			this.UpdateNextHarvestTime(data);
			this.StartNewTimer(data);
		}

		// Token: 0x06024D4D RID: 150861 RVA: 0x00A68C1C File Offset: 0x00A66E1C
		private void RefreshToCapacityLayout(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			int relativeId = data.RelativeId;
			ValueTuple<int, int> shipCageCapacityInfoTuple = FishingModel.Instance.GetShipCageCapacityInfoTuple(relativeId);
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText1", Array.Empty<string>());
			string multiText2 = TextConfig.Instance.GetMultiText("Fishing_QTE_Count", new string[]
			{
				shipCageCapacityInfoTuple.Item1.ToString(),
				shipCageCapacityInfoTuple.Item2.ToString()
			});
			UUIText nameTxt = base.GetNameTxt();
			if (nameTxt != null)
			{
				nameTxt.SetText(multiText, true);
			}
			UUIText descTxt = base.GetDescTxt();
			if (descTxt == null)
			{
				return;
			}
			descTxt.SetText(multiText2, true);
		}

		// Token: 0x06024D4E RID: 150862 RVA: 0x00A68CAC File Offset: 0x00A66EAC
		private void StartNewTimer(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			this.StopTimer();
			int inverseMillisecond = TimeUtil.Instance.InverseMillisecond;
			this.TimerHandle = TimerSystem.RealTimeInstance.Forever(delegate(float _)
			{
				this.OnTimerTick(data);
			}, (float)inverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x06024D4F RID: 150863 RVA: 0x00A68D04 File Offset: 0x00A66F04
		private void OnTimerTick(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			this.UpdateNextHarvestTime(data);
		}

		// Token: 0x06024D50 RID: 150864 RVA: 0x00A68D10 File Offset: 0x00A66F10
		private void UpdateNextHarvestTime(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			int relativeId = data.RelativeId;
			ValueTuple<int, int> shipCageCapacityInfoTuple = FishingModel.Instance.GetShipCageCapacityInfoTuple(relativeId);
			if (shipCageCapacityInfoTuple.Item1 >= shipCageCapacityInfoTuple.Item2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetDescTxt(), "Fishing_MarkText6", Array.Empty<object>());
				return;
			}
			double remainTime = (double)this.EndTime - TimeUtil.Instance.GetServerTime();
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText6", Array.Empty<string>());
			string newText = TimeUtil.Instance.GetRemainTimeDataFormat4(remainTime).CountDownText ?? multiText;
			UUIText descTxt = base.GetDescTxt();
			if (descTxt == null)
			{
				return;
			}
			descTxt.SetText(newText, true);
		}

		// Token: 0x06024D51 RID: 150865 RVA: 0x00A68DB0 File Offset: 0x00A66FB0
		private void StopTimer()
		{
			if (this.TimerHandle != null && TimerSystem.RealTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x040146CC RID: 83660
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x040146CD RID: 83661
		private long EndTime;
	}
}
