using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200613A RID: 24890
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelTipsItem : UiPanelBase
	{
		// Token: 0x0603EEC6 RID: 257734 RVA: 0x00F32C74 File Offset: 0x00F30E74
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EEC7 RID: 257735 RVA: 0x00F32D64 File Offset: 0x00F30F64
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLevelTipsItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLevelTipsItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EEC8 RID: 257736 RVA: 0x00F32DA8 File Offset: 0x00F30FA8
		protected override void OnStart()
		{
			this.LineLayout = new GenericLayout<RoverlikeRogueLevelLineItem, IRoverlikeRogueLevelLineData>(base.GetHorizontalLayout(1), new Func<RoverlikeRogueLevelLineItem>(this.CreateLevelLineItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			base.GetItem(5).SetUIActive(false);
			base.GetText(4).SetUIActive(true);
		}

		// Token: 0x0603EEC9 RID: 257737 RVA: 0x00F32E00 File Offset: 0x00F31000
		private RoverlikeRogueLevelLineItem CreateLevelLineItem()
		{
			return new RoverlikeRogueLevelLineItem();
		}

		// Token: 0x0603EECA RID: 257738 RVA: 0x00F32E08 File Offset: 0x00F31008
		public void Refresh(RoverlikeInstanceData instanceData, bool combinationText, [Nullable(2)] Action callback = null)
		{
			List<IRoverlikeRogueLevelLineData> dataList = this.BuildLevelLineDataList(instanceData);
			this.RefreshTips(instanceData, combinationText);
			this.RefreshLines(dataList, callback);
		}

		// Token: 0x0603EECB RID: 257739 RVA: 0x00F32E2D File Offset: 0x00F3102D
		public void PlayCurrentLevelSequence(string sequenceName)
		{
			RoverlikeRogueLevelLineItem levelLineItem = this.GetLevelLineItem(this.CurrentLevelIndex);
			if (levelLineItem == null)
			{
				return;
			}
			levelLineItem.PlayCurrentNodeSequence(sequenceName);
		}

		// Token: 0x0603EECC RID: 257740 RVA: 0x00F32E46 File Offset: 0x00F31046
		public void SetEffectPanelVisible(bool bVisible)
		{
			base.GetItem(5).SetUIActive(bVisible);
		}

		// Token: 0x0603EECD RID: 257741 RVA: 0x00F32E58 File Offset: 0x00F31058
		private void RefreshTips(RoverlikeInstanceData instanceData, bool combinationText)
		{
			RoverRogueRoomType? roomTypeConfig = RoverlikeConfig.Instance.GetRoomTypeConfig(instanceData.CurRoomTypeId);
			string text = (roomTypeConfig != null) ? (ConfigMultiTextLang.GetLocalTextNew(roomTypeConfig.Value.Name, null) ?? "") : "";
			IReadOnlyList<RoverRogueRoad> roadByRoadType = RoverlikeConfig.Instance.GetRoadByRoadType(instanceData.RoadTypeId);
			int count = roadByRoadType.Count;
			int num = instanceData.CurLayer - 1;
			ValueTuple<int, int> currentFloorRange = this.GetCurrentFloorRange(instanceData, num, count);
			int item = currentFloorRange.Item1;
			int item2 = currentFloorRange.Item2;
			int num2 = num - item + 1;
			int num3 = item2 - item;
			int currentFloorNumber = this.GetCurrentFloorNumber(instanceData, num);
			if (combinationText)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoverRogue_ProcessingFloor", new <>z__ReadOnlyArray<object>(new object[]
				{
					num2,
					num3,
					currentFloorNumber,
					text
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoverRogue_RoomTypeTitle", new <>z__ReadOnlyArray<object>(new object[]
				{
					currentFloorNumber,
					text
				}));
			}
			int? num4 = (num >= 0 && num < roadByRoadType.Count) ? new int?(roadByRoadType[num].LayerType) : null;
			if (num4.GetValueOrDefault() == 2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoverRogue_RoomProcessTitleLittleBoss", Array.Empty<object>());
				return;
			}
			if (num4.GetValueOrDefault() == 3)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoverRogue_RoomProcessTitleBigBoss", Array.Empty<object>());
			}
		}

		// Token: 0x0603EECE RID: 257742 RVA: 0x00F32FF0 File Offset: 0x00F311F0
		private void RefreshLines(List<IRoverlikeRogueLevelLineData> dataList, [Nullable(2)] Action callback = null)
		{
			if (dataList.Count == 0)
			{
				this.CurrentLevelIndex = -1;
				if (callback != null)
				{
					callback();
				}
				return;
			}
			int num = dataList.Count - 1;
			this.CurrentLevelIndex = dataList.FindIndex((IRoverlikeRogueLevelLineData data) => data.IsCurrent);
			GenericLayout<RoverlikeRogueLevelLineItem, IRoverlikeRogueLevelLineData> lineLayout = this.LineLayout;
			if (lineLayout != null)
			{
				lineLayout.RefreshByData(dataList.GetRange(0, num), callback, false);
			}
			RoverlikeRogueLevelLineItem lastNode = this.LastNode;
			if (lastNode != null)
			{
				lastNode.Refresh(dataList[num], false, num);
			}
			RoverlikeRogueLevelLineItem lastNode2 = this.LastNode;
			if (lastNode2 == null)
			{
				return;
			}
			lastNode2.SetActive(true);
		}

		// Token: 0x0603EECF RID: 257743 RVA: 0x00F33090 File Offset: 0x00F31290
		[NullableContext(2)]
		private RoverlikeRogueLevelLineItem GetLevelLineItem(int index)
		{
			if (index < 0)
			{
				return null;
			}
			GenericLayout<RoverlikeRogueLevelLineItem, IRoverlikeRogueLevelLineData> lineLayout = this.LineLayout;
			IReadOnlyList<IRoverlikeRogueLevelLineData> readOnlyList = (lineLayout != null) ? lineLayout.GetDatas() : null;
			if (readOnlyList == null || index >= readOnlyList.Count)
			{
				return this.LastNode;
			}
			GenericLayout<RoverlikeRogueLevelLineItem, IRoverlikeRogueLevelLineData> lineLayout2 = this.LineLayout;
			if (lineLayout2 == null)
			{
				return null;
			}
			return lineLayout2.GetLayoutItemByIndex(index);
		}

		// Token: 0x0603EED0 RID: 257744 RVA: 0x00F330DC File Offset: 0x00F312DC
		private List<IRoverlikeRogueLevelLineData> BuildLevelLineDataList(RoverlikeInstanceData instanceData)
		{
			List<IRoverlikeRogueLevelLineData> list = new List<IRoverlikeRogueLevelLineData>();
			IReadOnlyList<RoverRogueRoad> roadByRoadType = RoverlikeConfig.Instance.GetRoadByRoadType(instanceData.RoadTypeId);
			int count = roadByRoadType.Count;
			if (roadByRoadType.Count == 0 || count == 0)
			{
				return list;
			}
			int num = instanceData.CurLayer - 1;
			ValueTuple<int, int> currentFloorRange = this.GetCurrentFloorRange(instanceData, num, count);
			int item = currentFloorRange.Item1;
			int item2 = currentFloorRange.Item2;
			for (int i = item; i < item2; i++)
			{
				if (i < roadByRoadType.Count)
				{
					RoverRogueRoad roverRogueRoad = roadByRoadType[i];
					RoverlikeRogueLevelLineData item3 = new RoverlikeRogueLevelLineData
					{
						LayerType = (ERoverlikeRoadLayerType)roverRogueRoad.LayerType,
						IsCurrent = (i == num),
						IsPassed = (i < num),
						ShowCurrent = this.ShowCurrentNode
					};
					list.Add(item3);
				}
			}
			return list;
		}

		// Token: 0x0603EED1 RID: 257745 RVA: 0x00F3319C File Offset: 0x00F3139C
		[NullableContext(0)]
		private ValueTuple<int, int> GetCurrentFloorRange([Nullable(1)] RoverlikeInstanceData instanceData, int curIndex, int total)
		{
			List<int> roadLayerIndexList = instanceData.RoadLayerIndexList;
			for (int i = roadLayerIndexList.Count - 1; i >= 0; i--)
			{
				if (curIndex >= roadLayerIndexList[i])
				{
					int item = roadLayerIndexList[i];
					int item2 = (i + 1 < roadLayerIndexList.Count) ? roadLayerIndexList[i + 1] : total;
					return new ValueTuple<int, int>(item, item2);
				}
			}
			return new ValueTuple<int, int>(0, total);
		}

		// Token: 0x0603EED2 RID: 257746 RVA: 0x00F331FC File Offset: 0x00F313FC
		private int GetCurrentFloorNumber(RoverlikeInstanceData instanceData, int curIndex)
		{
			List<int> roadLayerIndexList = instanceData.RoadLayerIndexList;
			for (int i = roadLayerIndexList.Count - 1; i >= 0; i--)
			{
				if (curIndex >= roadLayerIndexList[i])
				{
					return i + 1;
				}
			}
			return 1;
		}

		// Token: 0x04020D91 RID: 134545
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeRogueLevelLineItem, IRoverlikeRogueLevelLineData> LineLayout;

		// Token: 0x04020D92 RID: 134546
		[Nullable(2)]
		private RoverlikeRogueLevelLineItem LastNode;

		// Token: 0x04020D93 RID: 134547
		private int CurrentLevelIndex = -1;

		// Token: 0x04020D94 RID: 134548
		public bool ShowCurrentNode = true;

		// Token: 0x0200C394 RID: 50068
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B052 RID: 241746
			public const int TxtTips = 0;

			// Token: 0x0403B053 RID: 241747
			public const int LineLayout = 1;

			// Token: 0x0403B054 RID: 241748
			public const int ItemLevelLine = 2;

			// Token: 0x0403B055 RID: 241749
			public const int ItemLastLine = 3;

			// Token: 0x0403B056 RID: 241750
			public const int TxtLevelProgress = 4;

			// Token: 0x0403B057 RID: 241751
			public const int PanelEffect = 5;
		}
	}
}
