using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020044D7 RID: 17623
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AreaLayout : GridProxyAbstract<MapTravelAreaData>
	{
		// Token: 0x0602D67E RID: 185982 RVA: 0x00A3F452 File Offset: 0x00A3D652
		public AreaLayout(ActivityMapTravelData ActivityBaseData)
		{
			this.ActivityBaseData = ActivityBaseData;
		}

		// Token: 0x0602D67F RID: 185983 RVA: 0x00A3F464 File Offset: 0x00A3D664
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

		// Token: 0x0602D680 RID: 185984 RVA: 0x00A3F594 File Offset: 0x00A3D794
		protected override UniTask OnBeforeStartAsync()
		{
			AreaLayout.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AreaLayout.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D681 RID: 185985 RVA: 0x00A3F5D7 File Offset: 0x00A3D7D7
		protected override void OnStart()
		{
			this.TaskLayout = new GenericLayout<TaskNormalItem, ActivityTaskData>(base.GetVerticalLayout(1), new Func<TaskNormalItem>(this.InitItem), null, false, true);
		}

		// Token: 0x0602D682 RID: 185986 RVA: 0x00A3F5FA File Offset: 0x00A3D7FA
		private TaskNormalItem InitItem()
		{
			TaskNormalItem taskNormalItem = new TaskNormalItem(this.ActivityBaseData);
			taskNormalItem.SetBtnClickCallback(delegate
			{
				GenericLayout<TaskNormalItem, ActivityTaskData> taskLayout = this.TaskLayout;
				List<int> list;
				if (taskLayout == null)
				{
					list = null;
				}
				else
				{
					list = taskLayout.GetDatas().ToList<ActivityTaskData>().FindAll((ActivityTaskData data) => data.Status == EActivityTaskState.FinishedAndUnclaimed).ConvertAll<int>((ActivityTaskData data) => data.Id);
				}
				List<int> list2 = list;
				if (list2 != null)
				{
					ActivityMapTravelController.Instance.RequestMultiMapTravelTaskReward(list2);
				}
			});
			return taskNormalItem;
		}

		// Token: 0x0602D683 RID: 185987 RVA: 0x00A3F61C File Offset: 0x00A3D81C
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

		// Token: 0x0602D684 RID: 185988 RVA: 0x00A3F7FC File Offset: 0x00A3D9FC
		public UniTask WaitRefreshDone()
		{
			AreaLayout.<WaitRefreshDone>d__14 <WaitRefreshDone>d__;
			<WaitRefreshDone>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRefreshDone>d__.<>4__this = this;
			<WaitRefreshDone>d__.<>1__state = -1;
			<WaitRefreshDone>d__.<>t__builder.Start<AreaLayout.<WaitRefreshDone>d__14>(ref <WaitRefreshDone>d__);
			return <WaitRefreshDone>d__.<>t__builder.Task;
		}

		// Token: 0x0602D685 RID: 185989 RVA: 0x00A3F840 File Offset: 0x00A3DA40
		private void TryUnlockArea(MapTravelAreaData data)
		{
			if (this.ActivityBaseData.GetAreaNewUnlockState(data.AreaId))
			{
				this.ActivityBaseData.SaveFirstCheckRedDotState(EMapTravelSaveFlag.AreaNewUnlock, data.AreaId);
				this.LevelSequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
			}
		}

		// Token: 0x0602D686 RID: 185990 RVA: 0x00A3F88E File Offset: 0x00A3DA8E
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

		// Token: 0x0401848A RID: 99466
		private ActivityMapTravelData ActivityBaseData;

		// Token: 0x0401848B RID: 99467
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TaskNormalItem, ActivityTaskData> TaskLayout;

		// Token: 0x0401848C RID: 99468
		[Nullable(2)]
		private TaskLockItem LockItem;

		// Token: 0x0401848D RID: 99469
		[Nullable(2)]
		private CustomPromise LoadingPromise;

		// Token: 0x0401848E RID: 99470
		private bool IsLoading;

		// Token: 0x0401848F RID: 99471
		private bool IsUnlock;

		// Token: 0x04018490 RID: 99472
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A724 RID: 42788
		[NullableContext(0)]
		private class ELayoutDefine
		{
			// Token: 0x040327A2 RID: 206754
			public const int Title = 0;

			// Token: 0x040327A3 RID: 206755
			public const int Layout = 1;

			// Token: 0x040327A4 RID: 206756
			public const int TaskItem = 2;

			// Token: 0x040327A5 RID: 206757
			public const int LockTaskItem = 3;

			// Token: 0x040327A6 RID: 206758
			public const int PanelTitle = 4;

			// Token: 0x040327A7 RID: 206759
			public const int LockItem = 5;

			// Token: 0x040327A8 RID: 206760
			public const int FinishedItem = 6;

			// Token: 0x040327A9 RID: 206761
			public const int TexIcon = 7;
		}
	}
}
