using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x02002F64 RID: 12132
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AreaLayout : GridProxyAbstract<MapTravelAreaData>
	{
		// Token: 0x0601CBBC RID: 117692 RVA: 0x008C50B2 File Offset: 0x008C32B2
		public AreaLayout(ActivityMapTravelData ActivityBaseData)
		{
			this.ActivityBaseData = ActivityBaseData;
		}

		// Token: 0x0601CBBD RID: 117693 RVA: 0x008C50C4 File Offset: 0x008C32C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601CBBE RID: 117694 RVA: 0x008C51F4 File Offset: 0x008C33F4
		protected override UniTask OnBeforeStartAsync()
		{
			AreaLayout.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AreaLayout.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBBF RID: 117695 RVA: 0x008C5237 File Offset: 0x008C3437
		protected override void OnStart()
		{
			this.TaskLayout = new GenericLayout<TaskNormalItem, ActivityTaskData>(base.GetVerticalLayout(1), new Func<TaskNormalItem>(this.InitItem), null, false, true);
		}

		// Token: 0x0601CBC0 RID: 117696 RVA: 0x008C525A File Offset: 0x008C345A
		private TaskNormalItem InitItem()
		{
			TaskNormalItem taskNormalItem = new TaskNormalItem(this.ActivityBaseData);
			taskNormalItem.SetBtnClickCallback(delegate
			{
				List<int> list;
				if (this.TaskLayout != null)
				{
					list = new List<ActivityTaskData>(this.TaskLayout.GetDatas()).FindAll((ActivityTaskData data) => data.Status == EActivityTaskState.FinishedAndUnclaimed).ConvertAll<int>((ActivityTaskData data) => data.Id);
				}
				else
				{
					list = null;
				}
				List<int> list2 = list;
				if (list2 != null)
				{
					ActivityMapTravelController.Instance.RequestMultiMapTravelTaskReward(list2);
				}
			});
			return taskNormalItem;
		}

		// Token: 0x0601CBC1 RID: 117697 RVA: 0x008C527C File Offset: 0x008C347C
		public override void Refresh(MapTravelAreaData data, bool isSelected, int gridIndex)
		{
			this.IsLoading = true;
			this.IsUnlock = data.IsUnlock;
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(data.AreaId);
			TravelTaskArea? areaConfig = ActivityMapTravelConfig.Instance.GetAreaConfig(data.AreaId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), areaInfo.Value.Title, Array.Empty<object>());
			bool uiactive = true;
			foreach (int key in data.TravelTaskIdSet)
			{
				if (this.ActivityBaseData.AreaTaskMap[key].Status != EActivityTaskState.FinishedAndClaimed)
				{
					uiactive = false;
					break;
				}
			}
			UUIItem text = base.GetText(0);
			bool bUseChangeColor = !data.IsUnlock;
			FColor? fcolor = new FColor?(base.GetText(0).changeColor);
			text.SetChangeColor(bUseChangeColor, fcolor);
			UUIItem texture = base.GetTexture(7);
			bool bUseChangeColor2 = !data.IsUnlock;
			fcolor = new FColor?(base.GetTexture(7).changeColor);
			texture.SetChangeColor(bUseChangeColor2, fcolor);
			base.GetItem(5).SetUIActive(!data.IsUnlock);
			base.GetItem(6).SetUIActive(uiactive);
			List<ActivityTaskData> data2 = new List<ActivityTaskData>();
			this.LockItem.SetActive(!data.IsUnlock);
			if (data.IsUnlock)
			{
				this.TryUnlockArea(data);
				data2 = this.ActivityBaseData.GetAreaTaskDataList(data.AreaId);
			}
			else
			{
				MapTravelLockAreaData mapTravelLockAreaData = new MapTravelLockAreaData(data.AreaId);
				mapTravelLockAreaData.ConditionGroupId = areaConfig.Value.UnLockCondition;
				mapTravelLockAreaData.JumpId = areaConfig.Value.UnlockAccessId;
				this.LockItem.Refresh(mapTravelLockAreaData);
			}
			this.TaskLayout.RefreshByData(data2, delegate
			{
				this.IsLoading = false;
				this.TaskLayout.BindLateUpdate(delegate(float _)
				{
					this.TaskLayout.UnBindLateUpdate();
					CustomPromise loadingPromise = this.LoadingPromise;
					if (loadingPromise == null)
					{
						return;
					}
					loadingPromise.SetResult();
				});
			}, false);
		}

		// Token: 0x0601CBC2 RID: 117698 RVA: 0x008C545C File Offset: 0x008C365C
		public UniTask WaitRefreshDone()
		{
			AreaLayout.<WaitRefreshDone>d__14 <WaitRefreshDone>d__;
			<WaitRefreshDone>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRefreshDone>d__.<>4__this = this;
			<WaitRefreshDone>d__.<>1__state = -1;
			<WaitRefreshDone>d__.<>t__builder.Start<AreaLayout.<WaitRefreshDone>d__14>(ref <WaitRefreshDone>d__);
			return <WaitRefreshDone>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x008C54A0 File Offset: 0x008C36A0
		private void TryUnlockArea(MapTravelAreaData data)
		{
			if (this.ActivityBaseData.GetAreaNewUnlockState(data.AreaId))
			{
				this.ActivityBaseData.SaveFirstCheckRedDotState(EMapTravelSaveFlag.AreaNewUnlock, data.AreaId);
				this.LevelSequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
			}
		}

		// Token: 0x0601CBC4 RID: 117700 RVA: 0x008C54EE File Offset: 0x008C36EE
		[NullableContext(2)]
		public UUIItem GetFirstItem()
		{
			if (this.IsUnlock)
			{
				return this.TaskLayout.GetItemByIndex(0);
			}
			TaskLockItem lockItem = this.LockItem;
			if (lockItem == null)
			{
				return null;
			}
			return lockItem.GetRootItem();
		}

		// Token: 0x0400F232 RID: 62002
		private ActivityMapTravelData ActivityBaseData;

		// Token: 0x0400F233 RID: 62003
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TaskNormalItem, ActivityTaskData> TaskLayout;

		// Token: 0x0400F234 RID: 62004
		[Nullable(2)]
		private TaskLockItem LockItem;

		// Token: 0x0400F235 RID: 62005
		[Nullable(2)]
		private CustomPromise LoadingPromise;

		// Token: 0x0400F236 RID: 62006
		private bool IsLoading;

		// Token: 0x0400F237 RID: 62007
		private bool IsUnlock;

		// Token: 0x0400F238 RID: 62008
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02008BFA RID: 35834
		[NullableContext(0)]
		private class ELayoutDefine
		{
			// Token: 0x0402C570 RID: 181616
			public const int Title = 0;

			// Token: 0x0402C571 RID: 181617
			public const int Layout = 1;

			// Token: 0x0402C572 RID: 181618
			public const int TaskItem = 2;

			// Token: 0x0402C573 RID: 181619
			public const int LockTaskItem = 3;

			// Token: 0x0402C574 RID: 181620
			public const int PanelTitle = 4;

			// Token: 0x0402C575 RID: 181621
			public const int LockItem = 5;

			// Token: 0x0402C576 RID: 181622
			public const int FinishedItem = 6;

			// Token: 0x0402C577 RID: 181623
			public const int TexIcon = 7;
		}
	}
}
