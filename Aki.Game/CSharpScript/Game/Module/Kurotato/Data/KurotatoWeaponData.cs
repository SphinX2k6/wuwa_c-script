using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004779 RID: 18297
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoWeaponData
	{
		// Token: 0x0602DF20 RID: 188192 RVA: 0x00CDB2BB File Offset: 0x00CD94BB
		public KurotatoWeaponData(KurotatoWeapon config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x17005C92 RID: 23698
		// (get) Token: 0x0602DF21 RID: 188193 RVA: 0x00CDB2D1 File Offset: 0x00CD94D1
		// (set) Token: 0x0602DF22 RID: 188194 RVA: 0x00CDB2D9 File Offset: 0x00CD94D9
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

		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x0602DF23 RID: 188195 RVA: 0x00CDB2E2 File Offset: 0x00CD94E2
		public bool HasRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 2, this.Id, 0) == 0;
			}
		}

		// Token: 0x0602DF24 RID: 188196 RVA: 0x00CDB314 File Offset: 0x00CD9514
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

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x0602DF25 RID: 188197 RVA: 0x00CDB378 File Offset: 0x00CD9578
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17005C95 RID: 23701
		// (get) Token: 0x0602DF26 RID: 188198 RVA: 0x00CDB394 File Offset: 0x00CD9594
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17005C96 RID: 23702
		// (get) Token: 0x0602DF27 RID: 188199 RVA: 0x00CDB3B0 File Offset: 0x00CD95B0
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x0602DF28 RID: 188200 RVA: 0x00CDB3CC File Offset: 0x00CD95CC
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

		// Token: 0x17005C98 RID: 23704
		// (get) Token: 0x0602DF29 RID: 188201 RVA: 0x00CDB410 File Offset: 0x00CD9610
		public int ConditionId
		{
			get
			{
				return KurotatoConfig.Instance.GetWeaponGroupById(this.Config.GroupId).Value.UnlockConditionId;
			}
		}

		// Token: 0x17005C99 RID: 23705
		// (get) Token: 0x0602DF2A RID: 188202 RVA: 0x00CDB448 File Offset: 0x00CD9648
		public int Quality
		{
			get
			{
				return this.Config.Quality;
			}
		}

		// Token: 0x04018867 RID: 100455
		private readonly KurotatoWeapon Config;

		// Token: 0x04018868 RID: 100456
		private bool IsUnLockInternal;

		// Token: 0x04018869 RID: 100457
		private readonly int ActivityId;
	}
}
