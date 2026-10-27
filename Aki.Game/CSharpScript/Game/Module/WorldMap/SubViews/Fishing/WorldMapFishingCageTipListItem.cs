using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02004822 RID: 18466
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingCageTipListItem : WorldMapSecondaryTipListItem
	{
		// Token: 0x0603057A RID: 198010 RVA: 0x00B38AAC File Offset: 0x00B36CAC
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

		// Token: 0x0603057B RID: 198011 RVA: 0x00B38AE0 File Offset: 0x00B36CE0
		protected override void OnBeforeHide()
		{
			this.StopTimer();
		}

		// Token: 0x0603057C RID: 198012 RVA: 0x00B38AE8 File Offset: 0x00B36CE8
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

		// Token: 0x0603057D RID: 198013 RVA: 0x00B38B50 File Offset: 0x00B36D50
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

		// Token: 0x0603057E RID: 198014 RVA: 0x00B38BE0 File Offset: 0x00B36DE0
		private void StartNewTimer(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			this.StopTimer();
			int inverseMillisecond = TimeUtil.Instance.InverseMillisecond;
			this.TimerHandle = TimerSystem.RealTimeInstance.Forever(delegate(float _)
			{
				this.OnTimerTick(data);
			}, (float)inverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0603057F RID: 198015 RVA: 0x00B38C38 File Offset: 0x00B36E38
		private void OnTimerTick(IWorldMapFishingCageSecondaryTipItemParam data)
		{
			this.UpdateNextHarvestTime(data);
		}

		// Token: 0x06030580 RID: 198016 RVA: 0x00B38C44 File Offset: 0x00B36E44
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

		// Token: 0x06030581 RID: 198017 RVA: 0x00B38CE4 File Offset: 0x00B36EE4
		private void StopTimer()
		{
			if (this.TimerHandle != null && TimerSystem.RealTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0401A018 RID: 106520
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401A019 RID: 106521
		private long EndTime;
	}
}
