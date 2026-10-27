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
	// Token: 0x02006099 RID: 24729
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25ProtocolContext : ActivityBaseData
	{
		// Token: 0x0603E819 RID: 256025 RVA: 0x00F1BA7B File Offset: 0x00F19C7B
		public Spring25ProtocolContext(Spring25Model model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x0603E81A RID: 256026 RVA: 0x00F1BAA0 File Offset: 0x00F19CA0
		public void Dispose()
		{
			this.CanInvite = false;
			this.TaskCacheInternal.Clear();
			this.InvitedRoleSetInternal.Clear();
		}

		// Token: 0x0603E81B RID: 256027 RVA: 0x00F1BAC0 File Offset: 0x00F19CC0
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

		// Token: 0x0603E81C RID: 256028 RVA: 0x00F1BB31 File Offset: 0x00F19D31
		public override bool GetExDataRedPointShowState()
		{
			return this.AttachedModel.HasRedDot;
		}

		// Token: 0x17009083 RID: 36995
		// (get) Token: 0x0603E81D RID: 256029 RVA: 0x00F1BB3E File Offset: 0x00F19D3E
		public int SignCountRemain
		{
			get
			{
				return (this.CanInvite > false) ? 1 : 0;
			}
		}

		// Token: 0x17009084 RID: 36996
		// (get) Token: 0x0603E81E RID: 256030 RVA: 0x00F1BB4C File Offset: 0x00F19D4C
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

		// Token: 0x17009085 RID: 36997
		// (get) Token: 0x0603E81F RID: 256031 RVA: 0x00F1BBAC File Offset: 0x00F19DAC
		public int InvitedCount
		{
			get
			{
				return this.InvitedRoleSetInternal.Count;
			}
		}

		// Token: 0x17009086 RID: 36998
		// (get) Token: 0x0603E820 RID: 256032 RVA: 0x00F1BBB9 File Offset: 0x00F19DB9
		public Dictionary<int, ActivityTask> TaskCache
		{
			get
			{
				return this.TaskCacheInternal;
			}
		}

		// Token: 0x17009087 RID: 36999
		// (get) Token: 0x0603E821 RID: 256033 RVA: 0x00F1BBC1 File Offset: 0x00F19DC1
		public HashSet<int> InvitedRoleSet
		{
			get
			{
				return this.InvitedRoleSetInternal;
			}
		}

		// Token: 0x17009088 RID: 37000
		// (get) Token: 0x0603E822 RID: 256034 RVA: 0x00F1BBCC File Offset: 0x00F19DCC
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

		// Token: 0x17009089 RID: 37001
		// (get) Token: 0x0603E823 RID: 256035 RVA: 0x00F1BC44 File Offset: 0x00F19E44
		public bool IsInviteAvailable
		{
			get
			{
				return this.CanInvite;
			}
		}

		// Token: 0x0603E824 RID: 256036 RVA: 0x00F1BC4C File Offset: 0x00F19E4C
		public int GetTaskCurrentByTaskId(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Current;
		}

		// Token: 0x0603E825 RID: 256037 RVA: 0x00F1BC74 File Offset: 0x00F19E74
		public int GetTaskTargetByTaskId(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Target;
		}

		// Token: 0x0603E826 RID: 256038 RVA: 0x00F1BC9C File Offset: 0x00F19E9C
		public ActivityTaskState GetTaskStateByTaskId(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskCacheInternal.TryGetValue(id, out activityTask))
			{
				return ActivityTaskState.ActivityTaskRunning;
			}
			return activityTask.Status;
		}

		// Token: 0x0603E827 RID: 256039 RVA: 0x00F1BCC4 File Offset: 0x00F19EC4
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

		// Token: 0x0603E828 RID: 256040 RVA: 0x00F1BD54 File Offset: 0x00F19F54
		public bool IsRoleInvitedById(int id)
		{
			return this.InvitedRoleSetInternal.Contains(id);
		}

		// Token: 0x0603E829 RID: 256041 RVA: 0x00F1BD64 File Offset: 0x00F19F64
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

		// Token: 0x0603E82A RID: 256042 RVA: 0x00F1BE2C File Offset: 0x00F1A02C
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

		// Token: 0x0603E82B RID: 256043 RVA: 0x00F1BE60 File Offset: 0x00F1A060
		public void SyncSkinReward()
		{
			this.IsSkinRewarded = true;
		}

		// Token: 0x04020B66 RID: 133990
		private readonly Spring25Model AttachedModel;

		// Token: 0x04020B67 RID: 133991
		public bool IsSkinRewarded;

		// Token: 0x04020B68 RID: 133992
		public bool CanInvite;

		// Token: 0x04020B69 RID: 133993
		private readonly Dictionary<int, ActivityTask> TaskCacheInternal = new Dictionary<int, ActivityTask>();

		// Token: 0x04020B6A RID: 133994
		private readonly HashSet<int> InvitedRoleSetInternal = new HashSet<int>();
	}
}
