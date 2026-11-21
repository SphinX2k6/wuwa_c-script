using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200586F RID: 22639
	public abstract class AnniversarySubActivityDataBase
	{
		// Token: 0x06037CF1 RID: 228593 RVA: 0x00F9B950 File Offset: 0x00F99B50
		public AnniversarySubActivityDataBase(int id)
		{
			this.Id = id;
			AnniversaryEntrance? anniversaryEntranceById = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceById(id);
			if (anniversaryEntranceById != null)
			{
				this.ActivityId = anniversaryEntranceById.Value.ActivityId;
			}
		}

		// Token: 0x06037CF2 RID: 228594 RVA: 0x00F9B994 File Offset: 0x00F99B94
		public EAnniversarySubId GetSubId()
		{
			return (EAnniversarySubId)this.Id;
		}

		// Token: 0x06037CF3 RID: 228595 RVA: 0x00F9B99C File Offset: 0x00F99B9C
		public int GetActivityId()
		{
			return this.ActivityId;
		}

		// Token: 0x06037CF4 RID: 228596 RVA: 0x00F9B9A4 File Offset: 0x00F99BA4
		[NullableContext(2)]
		public ActivityBaseData GetActivityData()
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId);
		}

		// Token: 0x06037CF5 RID: 228597 RVA: 0x00F9B9B6 File Offset: 0x00F99BB6
		public void SetUnlockTime(long unlockTime)
		{
			this.UnlockTime = unlockTime;
		}

		// Token: 0x17006B2B RID: 27435
		// (get) Token: 0x06037CF6 RID: 228598 RVA: 0x00F9B9BF File Offset: 0x00F99BBF
		public long GetUnlockTime
		{
			get
			{
				return this.UnlockTime;
			}
		}

		// Token: 0x06037CF7 RID: 228599 RVA: 0x00F9B9C8 File Offset: 0x00F99BC8
		public EAnniversaryActivityState GetCurrentState()
		{
			ActivityBaseData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return EAnniversaryActivityState.Lock;
			}
			if (activityData.CheckIfClose())
			{
				return EAnniversaryActivityState.Close;
			}
			if (activityData.FinishShowState)
			{
				return EAnniversaryActivityState.Finish;
			}
			return EAnniversaryActivityState.Unlock;
		}

		// Token: 0x06037CF8 RID: 228600 RVA: 0x00F9B9F6 File Offset: 0x00F99BF6
		public virtual void FirstClickOpenView()
		{
			ActivityController.Instance.OpenActivityById(this.ActivityId, EActivityViewOpenType.Other, null, null);
		}

		// Token: 0x06037CF9 RID: 228601
		public abstract ValueTuple<int, int> GetCurrentProgress();

		// Token: 0x06037CFA RID: 228602 RVA: 0x00F9BA0C File Offset: 0x00F99C0C
		public bool NeedPlayUnlockSequence()
		{
			if (ActivityModel.Instance.GetActivityById(this.ActivityId) == null)
			{
				return false;
			}
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AnniversaryActivityFirstClick) as ServerStorageSet;
			return serverStorageSet == null || !serverStorageSet.Has(this.ActivityId);
		}

		// Token: 0x0401D74A RID: 120650
		protected int Id;

		// Token: 0x0401D74B RID: 120651
		protected int ActivityId;

		// Token: 0x0401D74C RID: 120652
		protected long UnlockTime;
	}
}
