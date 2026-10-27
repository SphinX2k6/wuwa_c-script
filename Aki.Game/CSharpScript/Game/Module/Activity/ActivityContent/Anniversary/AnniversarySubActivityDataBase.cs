using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200691F RID: 26911
	public abstract class AnniversarySubActivityDataBase
	{
		// Token: 0x06043199 RID: 274841 RVA: 0x0105A324 File Offset: 0x01058524
		public AnniversarySubActivityDataBase(int id)
		{
			this.Id = id;
			AnniversaryEntrance? anniversaryEntranceById = AnniversaryActivityConfig.Instance.GetAnniversaryEntranceById(id);
			if (anniversaryEntranceById != null)
			{
				this.ActivityId = anniversaryEntranceById.Value.ActivityId;
			}
		}

		// Token: 0x0604319A RID: 274842 RVA: 0x0105A368 File Offset: 0x01058568
		public EAnniversarySubId GetSubId()
		{
			return (EAnniversarySubId)this.Id;
		}

		// Token: 0x0604319B RID: 274843 RVA: 0x0105A370 File Offset: 0x01058570
		public int GetActivityId()
		{
			return this.ActivityId;
		}

		// Token: 0x0604319C RID: 274844 RVA: 0x0105A378 File Offset: 0x01058578
		[NullableContext(2)]
		public ActivityBaseData GetActivityData()
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId);
		}

		// Token: 0x0604319D RID: 274845 RVA: 0x0105A38A File Offset: 0x0105858A
		public void SetUnlockTime(long unlockTime)
		{
			this.UnlockTime = unlockTime;
		}

		// Token: 0x170097EB RID: 38891
		// (get) Token: 0x0604319E RID: 274846 RVA: 0x0105A393 File Offset: 0x01058593
		public long GetUnlockTime
		{
			get
			{
				return this.UnlockTime;
			}
		}

		// Token: 0x0604319F RID: 274847 RVA: 0x0105A39C File Offset: 0x0105859C
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

		// Token: 0x060431A0 RID: 274848 RVA: 0x0105A3CA File Offset: 0x010585CA
		public virtual void FirstClickOpenView()
		{
			ActivityController.Instance.OpenActivityById(this.ActivityId, EActivityViewOpenType.Other, null, null);
		}

		// Token: 0x060431A1 RID: 274849
		public abstract ValueTuple<int, int> GetCurrentProgress();

		// Token: 0x060431A2 RID: 274850 RVA: 0x0105A3E0 File Offset: 0x010585E0
		public bool NeedPlayUnlockSequence()
		{
			if (ActivityModel.Instance.GetActivityById(this.ActivityId) == null)
			{
				return false;
			}
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AnniversaryActivityFirstClick) as ServerStorageSet;
			return serverStorageSet == null || !serverStorageSet.Has(this.ActivityId);
		}

		// Token: 0x04022EEE RID: 143086
		protected int Id;

		// Token: 0x04022EEF RID: 143087
		protected int ActivityId;

		// Token: 0x04022EF0 RID: 143088
		protected long UnlockTime;
	}
}
