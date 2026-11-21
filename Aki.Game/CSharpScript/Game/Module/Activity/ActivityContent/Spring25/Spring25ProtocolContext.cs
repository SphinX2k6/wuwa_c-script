using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005017 RID: 20503
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25ProtocolContext : ActivityBaseData
	{
		// Token: 0x060334DD RID: 210141 RVA: 0x00E6283F File Offset: 0x00E60A3F
		public Spring25ProtocolContext(Spring25Model model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x060334DE RID: 210142 RVA: 0x00E62864 File Offset: 0x00E60A64
		public void Dispose()
		{
			this.CanInvite = false;
			this.TaskCacheInternal.Clear();
			this.InvitedRoleSetInternal.Clear();
		}

		// Token: 0x060334DF RID: 210143 RVA: 0x00E62884 File Offset: 0x00E60A84
		protected override void PhraseEx(ActivityData data)
		{
			SpringSignInfo springSignInfo = data.SpringSignInfo;
			if (springSignInfo != null)
			{
				this.ParseActivityInfo(springSignInfo);
				if (!UiManager.Instance.IsViewShow(EUiViewName.Spring25DialogueView) && !UiManager.Instance.IsViewShow(EUiViewName.Spring25EnvelopeView))
				{
					this.AttachedModel.ResetCurrentSignId();
				}
				EventSystem.Instance.Emit(EEventName.Spring25ActivityParseDone);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060334E0 RID: 210144 RVA: 0x00E628F5 File Offset: 0x00E60AF5
		public override bool GetExDataRedPointShowState()
		{
			return this.AttachedModel.HasRedDot;
		}

		// Token: 0x170063E5 RID: 25573
		// (get) Token: 0x060334E1 RID: 210145 RVA: 0x00E62902 File Offset: 0x00E60B02
		public int SignCountRemain
		{
			get
			{
				return (this.CanInvite > false) ? 1 : 0;
			}
		}

		// Token: 0x170063E6 RID: 25574
		// (get) Token: 0x060334E2 RID: 210146 RVA: 0x00E62910 File Offset: 0x00E60B10
		public int FinishTaskCount
		{
			get
			{
				int num = 0;
				using (Dictionary<int, ActivityTask>.ValueCollection.Enumerator enumerator = this.TaskCacheInternal.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Status > ActivityTaskState.ActivityTaskRunning)
						{
							num++;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x170063E7 RID: 25575
		// (get) Token: 0x060334E3 RID: 210147 RVA: 0x00E62970 File Offset: 0x00E60B70
		public int InvitedCount
		{
			get
			{
				return this.InvitedRoleSetInternal.Count;
			}
		}

		// Token: 0x170063E8 RID: 25576
		// (get) Token: 0x060334E4 RID: 210148 RVA: 0x00E6297D File Offset: 0x00E60B7D
		public Dictionary<int, ActivityTask> TaskCache
		{
			get
			{
				return this.TaskCacheInternal;
			}
		}

		// Token: 0x170063E9 RID: 25577
		// (get) Token: 0x060334E5 RID: 210149 RVA: 0x00E62985 File Offset: 0x00E60B85
		public HashSet<int> InvitedRoleSet
		{
			get
			{
				return this.InvitedRoleSetInternal;
			}
		}

		// Token: 0x170063EA RID: 25578
		// (get) Token: 0x060334E6 RID: 210150 RVA: 0x00E62990 File Offset: 0x00E60B90
		public bool HasAnyReward
		{
			get
			{
				using (Dictionary<int, ActivityTask>.ValueCollection.Enumerator enumerator = this.TaskCacheInternal.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Status == ActivityTaskState.ActivityTaskFinish)
						{
							return true;
						}
					}
				}
				return this.AttachedModel.IsAllInvited && !this.IsSkinRewarded;
			}
		}

		// Token: 0x170063EB RID: 25579
		// (get) Token: 0x060334E7 RID: 210151 RVA: 0x00E62A08 File Offset: 0x00E60C08
		public bool IsInviteAvailable
		{
			get
			{
				return this.CanInvite;
			}
		}

		// Token: 0x060334E8 RID: 210152 RVA: 0x00E62A10 File Offset: 0x00E60C10
		public int GetTaskCurrentByTaskId(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Current;
		}

		// Token: 0x060334E9 RID: 210153 RVA: 0x00E62A38 File Offset: 0x00E60C38
		public int GetTaskTargetByTaskId(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Target;
		}

		// Token: 0x060334EA RID: 210154 RVA: 0x00E62A60 File Offset: 0x00E60C60
		public ActivityTaskState GetTaskStateByTaskId(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return ActivityTaskState.ActivityTaskRunning;
			}
			return activityTask.Status;
		}

		// Token: 0x060334EB RID: 210155 RVA: 0x00E62A88 File Offset: 0x00E60C88
		public List<TItem> GetTaskRewardPreviewByTaskId(int id)
		{
			List<TItem> list = new List<TItem>();
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return list;
			}
			MapField<int, int> preItemMap = activityTask.PreItemMap;
			if (preItemMap == null)
			{
				return list;
			}
			foreach (KeyValuePair<int, int> keyValuePair in preItemMap)
			{
				InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0);
				TItem item = new TItem(itemData, keyValuePair.Value);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060334EC RID: 210156 RVA: 0x00E62B18 File Offset: 0x00E60D18
		public bool IsRoleInvitedById(int id)
		{
			return this.InvitedRoleSetInternal.Contains(id);
		}

		// Token: 0x060334ED RID: 210157 RVA: 0x00E62B28 File Offset: 0x00E60D28
		private void ParseActivityInfo(SpringSignInfo data)
		{
			this.CanInvite = data.CanInvite;
			this.TaskCacheInternal.Clear();
			foreach (ActivityTask activityTask in data.SpringSignActivityTasks)
			{
				this.TaskCacheInternal[activityTask.Id] = activityTask;
			}
			this.InvitedRoleSetInternal.Clear();
			foreach (int item in data.DrawRoles)
			{
				this.InvitedRoleSetInternal.Add(item);
			}
			this.IsSkinRewarded = data.SkinReward;
		}

		// Token: 0x060334EE RID: 210158 RVA: 0x00E62BF0 File Offset: 0x00E60DF0
		public void SyncTaskStateByTaskId(int id)
		{
			ActivityTask activityTask;
			if (this.TaskCache.TryGetValue(id, out activityTask))
			{
				ActivityTask activityTask2 = activityTask;
				int num = activityTask2.Current;
				activityTask2.Current = num + 1;
				activityTask.Status = ActivityTaskState.ActivityTaskTaken;
			}
		}

		// Token: 0x060334EF RID: 210159 RVA: 0x00E62C24 File Offset: 0x00E60E24
		public void SyncSkinReward()
		{
			this.IsSkinRewarded = true;
		}

		// Token: 0x0401B493 RID: 111763
		private readonly Spring25Model AttachedModel;

		// Token: 0x0401B494 RID: 111764
		public bool IsSkinRewarded;

		// Token: 0x0401B495 RID: 111765
		public bool CanInvite;

		// Token: 0x0401B496 RID: 111766
		private readonly Dictionary<int, ActivityTask> TaskCacheInternal = new Dictionary<int, ActivityTask>();

		// Token: 0x0401B497 RID: 111767
		private readonly HashSet<int> InvitedRoleSetInternal = new HashSet<int>();
	}
}
