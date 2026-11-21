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
	// Token: 0x020055B4 RID: 21940
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFeiXuePreheatData : ActivityBaseData
	{
		// Token: 0x06036632 RID: 222770 RVA: 0x00F2F688 File Offset: 0x00F2D888
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

		// Token: 0x06036633 RID: 222771 RVA: 0x00F2F6B4 File Offset: 0x00F2D8B4
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

		// Token: 0x06036634 RID: 222772 RVA: 0x00F2F72C File Offset: 0x00F2D92C
		public void UpdateFeiXuePreheatInfo(FeiXuePreheatInfo info)
		{
			this.InfoMap[info.Id] = info;
			FeiXuePreheatTaskData feiXuePreheatTaskData;
			if (this.FeiXuePreheatTaskDataMap.TryGetValue(info.Id, out feiXuePreheatTaskData))
			{
				feiXuePreheatTaskData.UpdateTaskData(info);
			}
		}

		// Token: 0x06036635 RID: 222773 RVA: 0x00F2F767 File Offset: 0x00F2D967
		protected override bool GetExDataFinishShowState()
		{
			return base.IsUnLock() && this.IsAllTaskFinish();
		}

		// Token: 0x06036636 RID: 222774 RVA: 0x00F2F779 File Offset: 0x00F2D979
		public override bool GetExDataRedPointShowState()
		{
			return this.IsExistClaimableTask() || this.IsFirstDoingTaskIsUnClick();
		}

		// Token: 0x06036637 RID: 222775 RVA: 0x00F2F78B File Offset: 0x00F2D98B
		public List<FeiXuePreheatTaskData> GetTaskDataList()
		{
			return new List<FeiXuePreheatTaskData>(this.FeiXuePreheatTaskDataMap.Values);
		}

		// Token: 0x06036638 RID: 222776 RVA: 0x00F2F79D File Offset: 0x00F2D99D
		public List<FeiXuePreheatTaskData> GetTaskDataSortList()
		{
			List<FeiXuePreheatTaskData> list = new List<FeiXuePreheatTaskData>(this.FeiXuePreheatTaskDataMap.Values);
			list.Sort((FeiXuePreheatTaskData a, FeiXuePreheatTaskData b) => this.Priority(a) - this.Priority(b));
			return list;
		}

		// Token: 0x06036639 RID: 222777 RVA: 0x00F2F7C4 File Offset: 0x00F2D9C4
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

		// Token: 0x0603663A RID: 222778 RVA: 0x00F2F7F2 File Offset: 0x00F2D9F2
		public int GetTotalTaskNum()
		{
			return this.InfoMap.Count;
		}

		// Token: 0x0603663B RID: 222779 RVA: 0x00F2F800 File Offset: 0x00F2DA00
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

		// Token: 0x0603663C RID: 222780 RVA: 0x00F2F860 File Offset: 0x00F2DA60
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

		// Token: 0x0603663D RID: 222781 RVA: 0x00F2F8C0 File Offset: 0x00F2DAC0
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

		// Token: 0x0603663E RID: 222782 RVA: 0x00F2F920 File Offset: 0x00F2DB20
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

		// Token: 0x0603663F RID: 222783 RVA: 0x00F2F968 File Offset: 0x00F2DB68
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

		// Token: 0x06036640 RID: 222784 RVA: 0x00F2F9AC File Offset: 0x00F2DBAC
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

		// Token: 0x06036641 RID: 222785 RVA: 0x00F2FA00 File Offset: 0x00F2DC00
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

		// Token: 0x06036642 RID: 222786 RVA: 0x00F2FA54 File Offset: 0x00F2DC54
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

		// Token: 0x06036643 RID: 222787 RVA: 0x00F2FAB4 File Offset: 0x00F2DCB4
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

		// Token: 0x06036644 RID: 222788 RVA: 0x00F2FB14 File Offset: 0x00F2DD14
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

		// Token: 0x06036645 RID: 222789 RVA: 0x00F2FB80 File Offset: 0x00F2DD80
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

		// Token: 0x06036646 RID: 222790 RVA: 0x00F2FBA0 File Offset: 0x00F2DDA0
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

		// Token: 0x06036647 RID: 222791 RVA: 0x00F2FC10 File Offset: 0x00F2DE10
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

		// Token: 0x06036648 RID: 222792 RVA: 0x00F2FC98 File Offset: 0x00F2DE98
		public FeiXuePreheatTaskData GetLastTaskData()
		{
			List<FeiXuePreheatInfo> list = new List<FeiXuePreheatInfo>(this.InfoMap.Values);
			return new FeiXuePreheatTaskData(list[list.Count - 1]);
		}

		// Token: 0x06036649 RID: 222793 RVA: 0x00F2FCBC File Offset: 0x00F2DEBC
		public bool GetHasPlayFinishAnimation(int questIndex)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, questIndex, 0) == 1;
		}

		// Token: 0x0603664A RID: 222794 RVA: 0x00F2FCD6 File Offset: 0x00F2DED6
		public void SetHasPlayFinishAnimation(int questIndex)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 100, questIndex, 0, 1);
		}

		// Token: 0x0603664B RID: 222795 RVA: 0x00F2FCED File Offset: 0x00F2DEED
		public bool GetHasPlaySearchInAnimation(int questIndex)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 101, questIndex, 0) == 1;
		}

		// Token: 0x0603664C RID: 222796 RVA: 0x00F2FD07 File Offset: 0x00F2DF07
		public void SetHasPlaySearchInAnimation(int questIndex)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 101, questIndex, 0, 1);
		}

		// Token: 0x0603664D RID: 222797 RVA: 0x00F2FD1E File Offset: 0x00F2DF1E
		public bool GetHasPlayAllDoneAnimation()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 102, 0, 0) == 1;
		}

		// Token: 0x0603664E RID: 222798 RVA: 0x00F2FD38 File Offset: 0x00F2DF38
		public void SetHasPlayAllDoneAnimation()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 102, 0, 0, 1);
		}

		// Token: 0x0401CB2A RID: 117546
		private readonly Dictionary<int, FeiXuePreheatInfo> InfoMap = new Dictionary<int, FeiXuePreheatInfo>();

		// Token: 0x0401CB2B RID: 117547
		private readonly Dictionary<int, FeiXuePreheatTaskData> FeiXuePreheatTaskDataMap = new Dictionary<int, FeiXuePreheatTaskData>();
	}
}
