using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x020057A2 RID: 22434
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoWeaponData
	{
		// Token: 0x06039010 RID: 233488 RVA: 0x00D8C53F File Offset: 0x00D8A73F
		public KurotatoWeaponData(KurotatoWeapon config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x170088CA RID: 35018
		// (get) Token: 0x06039011 RID: 233489 RVA: 0x00D8C555 File Offset: 0x00D8A755
		// (set) Token: 0x06039012 RID: 233490 RVA: 0x00D8C55D File Offset: 0x00D8A75D
		public bool IsUnLock
		{
			get
			{
				return this.IsUnLockInternal;
			}
			set
			{
				this.IsUnLockInternal = value;
			}
		}

		// Token: 0x170088CB RID: 35019
		// (get) Token: 0x06039013 RID: 233491 RVA: 0x00D8C566 File Offset: 0x00D8A766
		public bool HasRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 2, this.Id, 0) == 0;
			}
		}

		// Token: 0x06039014 RID: 233492 RVA: 0x00D8C598 File Offset: 0x00D8A798
		public void ReadRedDot(bool emitEvent = true)
		{
			if (!this.IsUnLock)
			{
				return;
			}
			if (!this.HasRedDot)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 2, this.Id, 0, 1);
			if (!emitEvent)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoWeaponAndPropRedDot);
		}

		// Token: 0x170088CC RID: 35020
		// (get) Token: 0x06039015 RID: 233493 RVA: 0x00D8C5FC File Offset: 0x00D8A7FC
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170088CD RID: 35021
		// (get) Token: 0x06039016 RID: 233494 RVA: 0x00D8C618 File Offset: 0x00D8A818
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x170088CE RID: 35022
		// (get) Token: 0x06039017 RID: 233495 RVA: 0x00D8C634 File Offset: 0x00D8A834
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x170088CF RID: 35023
		// (get) Token: 0x06039018 RID: 233496 RVA: 0x00D8C650 File Offset: 0x00D8A850
		public string[] DescParam
		{
			get
			{
				int descParamsLength = this.Config.DescParamsLength;
				string[] array = new string[descParamsLength];
				for (int i = 0; i < descParamsLength; i++)
				{
					array[i] = this.Config.DescParams(i);
				}
				return array;
			}
		}

		// Token: 0x170088D0 RID: 35024
		// (get) Token: 0x06039019 RID: 233497 RVA: 0x00D8C694 File Offset: 0x00D8A894
		public int ConditionId
		{
			get
			{
				return KurotatoConfig.Instance.GetWeaponGroupById(this.Config.GroupId).Value.UnlockConditionId;
			}
		}

		// Token: 0x170088D1 RID: 35025
		// (get) Token: 0x0603901A RID: 233498 RVA: 0x00D8C6CC File Offset: 0x00D8A8CC
		public int Quality
		{
			get
			{
				return this.Config.Quality;
			}
		}

		// Token: 0x0401DDD1 RID: 122321
		private readonly KurotatoWeapon Config;

		// Token: 0x0401DDD2 RID: 122322
		private bool IsUnLockInternal;

		// Token: 0x0401DDD3 RID: 122323
		private readonly int ActivityId;
	}
}
