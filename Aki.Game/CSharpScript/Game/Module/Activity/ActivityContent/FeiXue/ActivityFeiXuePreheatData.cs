using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x02006636 RID: 26166
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFeiXuePreheatData : ActivityBaseData
	{
		// Token: 0x0604196D RID: 268653 RVA: 0x00FE85D0 File Offset: 0x00FE67D0
		protected override void PhraseEx(ActivityData data)
		{
			FeiXuePreheatActivityInfo feiXuePreheatActivityInfo = data.FeiXuePreheatActivityInfo;
			RepeatedField<FeiXuePreheatInfo> repeatedField = (feiXuePreheatActivityInfo != null) ? feiXuePreheatActivityInfo.FeiXuePreheatInfos : null;
			if (repeatedField == null)
			{
				return;
			}
			this.InitFeiXuePreheatData(repeatedField);
		}

		// Token: 0x0604196E RID: 268654 RVA: 0x00FE85FC File Offset: 0x00FE67FC
		public void InitFeiXuePreheatData(IReadOnlyList<FeiXuePreheatInfo> feiXuePreheatData)
		{
			this.InfoMap.Clear();
			foreach (FeiXuePreheatInfo feiXuePreheatInfo in feiXuePreheatData)
			{
				this.InfoMap[feiXuePreheatInfo.Id] = feiXuePreheatInfo;
				FeiXuePreheatTaskData value = new FeiXuePreheatTaskData(feiXuePreheatInfo);
				this.FeiXuePreheatTaskDataMap[feiXuePreheatInfo.Id] = value;
			}
		}

		// Token: 0x0604196F RID: 268655 RVA: 0x00FE8674 File Offset: 0x00FE6874
		public void UpdateFeiXuePreheatInfo(FeiXuePreheatInfo info)
		{
			this.InfoMap[info.Id] = info;
			FeiXuePreheatTaskData feiXuePreheatTaskData;
			if (this.FeiXuePreheatTaskDataMap.TryGetValue(info.Id, out feiXuePreheatTaskData))
			{
				feiXuePreheatTaskData.UpdateTaskData(info);
			}
		}

		// Token: 0x06041970 RID: 268656 RVA: 0x00FE86AF File Offset: 0x00FE68AF
		protected override bool GetExDataFinishShowState()
		{
			return base.IsUnLock() && this.IsAllTaskFinish();
		}

		// Token: 0x06041971 RID: 268657 RVA: 0x00FE86C1 File Offset: 0x00FE68C1
		public override bool GetExDataRedPointShowState()
		{
			return this.IsExistClaimableTask() || this.IsFirstDoingTaskIsUnClick();
		}

		// Token: 0x06041972 RID: 268658 RVA: 0x00FE86D3 File Offset: 0x00FE68D3
		public List<FeiXuePreheatTaskData> GetTaskDataList()
		{
			return new List<FeiXuePreheatTaskData>(this.FeiXuePreheatTaskDataMap.Values);
		}

		// Token: 0x06041973 RID: 268659 RVA: 0x00FE86E5 File Offset: 0x00FE68E5
		public List<FeiXuePreheatTaskData> GetTaskDataSortList()
		{
			List<FeiXuePreheatTaskData> list = new List<FeiXuePreheatTaskData>(this.FeiXuePreheatTaskDataMap.Values);
			list.Sort((FeiXuePreheatTaskData a, FeiXuePreheatTaskData b) => this.Priority(a) - this.Priority(b));
			return list;
		}

		// Token: 0x06041974 RID: 268660 RVA: 0x00FE870C File Offset: 0x00FE690C
		private int Priority(FeiXuePreheatTaskData task)
		{
			int result = 3;
			if (task.IsUnclaimed)
			{
				return 0;
			}
			if (task.IsDoing)
			{
				return 1;
			}
			if (task.IsLock)
			{
				return 2;
			}
			return result;
		}

		// Token: 0x06041975 RID: 268661 RVA: 0x00FE873A File Offset: 0x00FE693A
		public int GetTotalTaskNum()
		{
			return this.InfoMap.Count;
		}

		// Token: 0x06041976 RID: 268662 RVA: 0x00FE8748 File Offset: 0x00FE6948
		public int GetClaimableOrFinishedTaskNum()
		{
			int num = 0;
			using (Dictionary<int, FeiXuePreheatInfo>.ValueCollection.Enumerator enumerator = this.InfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State >= 2)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06041977 RID: 268663 RVA: 0x00FE87A8 File Offset: 0x00FE69A8
		public int GetFinishedTaskNum()
		{
			int num = 0;
			using (Dictionary<int, FeiXuePreheatInfo>.ValueCollection.Enumerator enumerator = this.InfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == 3)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06041978 RID: 268664 RVA: 0x00FE8808 File Offset: 0x00FE6A08
		public bool IsExistClaimableTask()
		{
			using (Dictionary<int, FeiXuePreheatInfo>.ValueCollection.Enumerator enumerator = this.InfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == 2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06041979 RID: 268665 RVA: 0x00FE8868 File Offset: 0x00FE6A68
		public int GetFirstDoingTaskIndex()
		{
			List<FeiXuePreheatInfo> list = new List<FeiXuePreheatInfo>(this.InfoMap.Values);
			for (int i = 0; i < this.InfoMap.Count; i++)
			{
				if (list[i].State == 1)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0604197A RID: 268666 RVA: 0x00FE88B0 File Offset: 0x00FE6AB0
		public int GetLastFinishedTaskIndex()
		{
			List<FeiXuePreheatInfo> list = new List<FeiXuePreheatInfo>(this.InfoMap.Values);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i].State == 2)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0604197B RID: 268667 RVA: 0x00FE88F4 File Offset: 0x00FE6AF4
		public bool IsFirstDoingTaskIsUnClick()
		{
			int firstDoingTaskIndex = this.GetFirstDoingTaskIndex();
			if (firstDoingTaskIndex == -1)
			{
				return false;
			}
			ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FeiXuePreheatSubViewRedDot) as ServerStorageMap;
			if (!serverStorageMap.Has(firstDoingTaskIndex))
			{
				serverStorageMap.Set(firstDoingTaskIndex, 1);
				return true;
			}
			return serverStorageMap.Get(firstDoingTaskIndex).GetValueOrDefault() == 1;
		}

		// Token: 0x0604197C RID: 268668 RVA: 0x00FE8948 File Offset: 0x00FE6B48
		public void CancelFirstDoingTaskRedDot()
		{
			int firstDoingTaskIndex = this.GetFirstDoingTaskIndex();
			if (firstDoingTaskIndex == -1)
			{
				return;
			}
			ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FeiXuePreheatSubViewRedDot) as ServerStorageMap;
			if (serverStorageMap.Has(firstDoingTaskIndex))
			{
				serverStorageMap.Set(firstDoingTaskIndex, 0);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0604197D RID: 268669 RVA: 0x00FE899C File Offset: 0x00FE6B9C
		public bool IsAllTaskClaimable()
		{
			using (Dictionary<int, FeiXuePreheatInfo>.ValueCollection.Enumerator enumerator = this.InfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State < 2)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0604197E RID: 268670 RVA: 0x00FE89FC File Offset: 0x00FE6BFC
		public bool IsAllTaskFinish()
		{
			using (Dictionary<int, FeiXuePreheatInfo>.ValueCollection.Enumerator enumerator = this.InfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State != 3)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0604197F RID: 268671 RVA: 0x00FE8A5C File Offset: 0x00FE6C5C
		public bool IsAllTaskDone()
		{
			foreach (FeiXuePreheatInfo feiXuePreheatInfo in this.InfoMap.Values)
			{
				if (feiXuePreheatInfo.State != 2 && feiXuePreheatInfo.State != 3)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06041980 RID: 268672 RVA: 0x00FE8AC8 File Offset: 0x00FE6CC8
		[NullableContext(2)]
		public FeiXuePreheatInfo GetTaskData(int id)
		{
			FeiXuePreheatInfo result;
			if (this.InfoMap.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06041981 RID: 268673 RVA: 0x00FE8AE8 File Offset: 0x00FE6CE8
		public List<int> GetClaimableTaskIdList()
		{
			List<int> list = new List<int>();
			foreach (FeiXuePreheatInfo feiXuePreheatInfo in this.InfoMap.Values)
			{
				if (feiXuePreheatInfo.State == 2)
				{
					list.Add(feiXuePreheatInfo.Id);
				}
			}
			return list;
		}

		// Token: 0x06041982 RID: 268674 RVA: 0x00FE8B58 File Offset: 0x00FE6D58
		public FeiXuePreheatTaskData GetBtnGoShowTaskData()
		{
			FeiXuePreheatTaskData feiXuePreheatTaskData = null;
			FeiXuePreheatTaskData feiXuePreheatTaskData2 = null;
			bool flag = false;
			foreach (FeiXuePreheatInfo feiXuePreheatInfo in this.InfoMap.Values)
			{
				if (feiXuePreheatInfo.State == 1)
				{
					feiXuePreheatTaskData2 = new FeiXuePreheatTaskData(feiXuePreheatInfo);
				}
				if (!flag && feiXuePreheatInfo.State == 0)
				{
					feiXuePreheatTaskData = new FeiXuePreheatTaskData(feiXuePreheatInfo);
					flag = true;
				}
			}
			return feiXuePreheatTaskData2 ?? feiXuePreheatTaskData;
		}

		// Token: 0x06041983 RID: 268675 RVA: 0x00FE8BE0 File Offset: 0x00FE6DE0
		public FeiXuePreheatTaskData GetLastTaskData()
		{
			List<FeiXuePreheatInfo> list = new List<FeiXuePreheatInfo>(this.InfoMap.Values);
			return new FeiXuePreheatTaskData(list[list.Count - 1]);
		}

		// Token: 0x06041984 RID: 268676 RVA: 0x00FE8C04 File Offset: 0x00FE6E04
		public bool GetHasPlayFinishAnimation(int questIndex)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, questIndex, 0) == 1;
		}

		// Token: 0x06041985 RID: 268677 RVA: 0x00FE8C1E File Offset: 0x00FE6E1E
		public void SetHasPlayFinishAnimation(int questIndex)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 100, questIndex, 0, 1);
		}

		// Token: 0x06041986 RID: 268678 RVA: 0x00FE8C35 File Offset: 0x00FE6E35
		public bool GetHasPlaySearchInAnimation(int questIndex)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 101, questIndex, 0) == 1;
		}

		// Token: 0x06041987 RID: 268679 RVA: 0x00FE8C4F File Offset: 0x00FE6E4F
		public void SetHasPlaySearchInAnimation(int questIndex)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 101, questIndex, 0, 1);
		}

		// Token: 0x06041988 RID: 268680 RVA: 0x00FE8C66 File Offset: 0x00FE6E66
		public bool GetHasPlayAllDoneAnimation()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 102, 0, 0) == 1;
		}

		// Token: 0x06041989 RID: 268681 RVA: 0x00FE8C80 File Offset: 0x00FE6E80
		public void SetHasPlayAllDoneAnimation()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 102, 0, 0, 1);
		}

		// Token: 0x040221F9 RID: 139769
		private readonly Dictionary<int, FeiXuePreheatInfo> InfoMap = new Dictionary<int, FeiXuePreheatInfo>();

		// Token: 0x040221FA RID: 139770
		private readonly Dictionary<int, FeiXuePreheatTaskData> FeiXuePreheatTaskDataMap = new Dictionary<int, FeiXuePreheatTaskData>();
	}
}
