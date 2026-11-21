using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004778 RID: 18296
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRoleData
	{
		// Token: 0x0602DF04 RID: 188164 RVA: 0x00CDAF23 File Offset: 0x00CD9123
		public KurotatoRoleData(KurotatoCharacter config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x0602DF05 RID: 188165 RVA: 0x00CDAF39 File Offset: 0x00CD9139
		// (set) Token: 0x0602DF06 RID: 188166 RVA: 0x00CDAF41 File Offset: 0x00CD9141
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

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x0602DF07 RID: 188167 RVA: 0x00CDAF4A File Offset: 0x00CD914A
		// (set) Token: 0x0602DF08 RID: 188168 RVA: 0x00CDAF52 File Offset: 0x00CD9152
		public int HistoryWave
		{
			get
			{
				return this.HistoryWaveInternal;
			}
			set
			{
				this.HistoryWaveInternal = value;
			}
		}

		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x0602DF09 RID: 188169 RVA: 0x00CDAF5B File Offset: 0x00CD915B
		// (set) Token: 0x0602DF0A RID: 188170 RVA: 0x00CDAF63 File Offset: 0x00CD9163
		public int HistoryKillNum
		{
			get
			{
				return this.HistoryKillNumInternal;
			}
			set
			{
				this.HistoryKillNumInternal = value;
			}
		}

		// Token: 0x17005C81 RID: 23681
		// (get) Token: 0x0602DF0B RID: 188171 RVA: 0x00CDAF6C File Offset: 0x00CD916C
		public bool HasHistory
		{
			get
			{
				return this.HistoryWaveInternal != 0;
			}
		}

		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x0602DF0C RID: 188172 RVA: 0x00CDAF77 File Offset: 0x00CD9177
		public bool HasArchived
		{
			get
			{
				return this.ArchivedDataInternal != null;
			}
		}

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x0602DF0D RID: 188173 RVA: 0x00CDAF82 File Offset: 0x00CD9182
		// (set) Token: 0x0602DF0E RID: 188174 RVA: 0x00CDAF8A File Offset: 0x00CD918A
		[Nullable(2)]
		public KurotatoInstInfo ArchivedData
		{
			[NullableContext(2)]
			get
			{
				return this.ArchivedDataInternal;
			}
			[NullableContext(2)]
			set
			{
				this.ArchivedDataInternal = value;
			}
		}

		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x0602DF0F RID: 188175 RVA: 0x00CDAF93 File Offset: 0x00CD9193
		public bool HasHandBookRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 1, this.Id, 0) == 0;
			}
		}

		// Token: 0x0602DF10 RID: 188176 RVA: 0x00CDAFC4 File Offset: 0x00CD91C4
		public void ReadHandBookRedDot(bool emitEvent = true)
		{
			if (!this.IsUnLock)
			{
				return;
			}
			if (!this.HasHandBookRedDot)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 1, this.Id, 0, 1);
			if (!emitEvent)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoRoleRedDot);
		}

		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x0602DF11 RID: 188177 RVA: 0x00CDB026 File Offset: 0x00CD9226
		public bool HasRoleSelectRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 5, this.Id, 0) == 0;
			}
		}

		// Token: 0x0602DF12 RID: 188178 RVA: 0x00CDB056 File Offset: 0x00CD9256
		public void ReadRoleSelectRedDot()
		{
			if (!this.IsUnLock)
			{
				return;
			}
			if (!this.HasRoleSelectRedDot)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 5, this.Id, 0, 1);
		}

		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x0602DF13 RID: 188179 RVA: 0x00CDB083 File Offset: 0x00CD9283
		public bool NeedPlayUnlockAnim
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 6, this.Id, 0) == 0;
			}
		}

		// Token: 0x0602DF14 RID: 188180 RVA: 0x00CDB0B3 File Offset: 0x00CD92B3
		public void MarkUnlockAnimPlayed()
		{
			if (!this.NeedPlayUnlockAnim)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 6, this.Id, 0, 1);
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x0602DF15 RID: 188181 RVA: 0x00CDB0D8 File Offset: 0x00CD92D8
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17005C88 RID: 23688
		// (get) Token: 0x0602DF16 RID: 188182 RVA: 0x00CDB0F4 File Offset: 0x00CD92F4
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17005C89 RID: 23689
		// (get) Token: 0x0602DF17 RID: 188183 RVA: 0x00CDB110 File Offset: 0x00CD9310
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x0602DF18 RID: 188184 RVA: 0x00CDB12C File Offset: 0x00CD932C
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

		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x0602DF19 RID: 188185 RVA: 0x00CDB16E File Offset: 0x00CD936E
		public int RealRoleId
		{
			get
			{
				return KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(this.Id).GetDataId();
			}
		}

		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x0602DF1A RID: 188186 RVA: 0x00CDB185 File Offset: 0x00CD9385
		public int RealRoleSkinId
		{
			get
			{
				return KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(this.Id).GetRoleSkinId();
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x0602DF1B RID: 188187 RVA: 0x00CDB19C File Offset: 0x00CD939C
		public List<int> InitItemIds
		{
			get
			{
				if (this.InitItemIdsInternal == null)
				{
					this.InitItemIdsInternal = new List<int>();
					int initItemIdsLength = this.Config.InitItemIdsLength;
					for (int i = 0; i < initItemIdsLength; i++)
					{
						int num = this.Config.InitItemIds(i);
						KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(num);
						if (itemConfigByItemId != null && itemConfigByItemId.Value.Type == 2)
						{
							this.InitItemIdsInternal.Add(num);
						}
					}
				}
				return this.InitItemIdsInternal;
			}
		}

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x0602DF1C RID: 188188 RVA: 0x00CDB224 File Offset: 0x00CD9424
		public List<int> InitWeaponIds
		{
			get
			{
				List<int> list = new List<int>();
				int initWeaponIdsLength = this.Config.InitWeaponIdsLength;
				for (int i = 0; i < initWeaponIdsLength; i++)
				{
					list.Add(this.Config.InitWeaponIds(i));
				}
				return list;
			}
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x0602DF1D RID: 188189 RVA: 0x00CDB268 File Offset: 0x00CD9468
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockConditionId;
			}
		}

		// Token: 0x17005C90 RID: 23696
		// (get) Token: 0x0602DF1E RID: 188190 RVA: 0x00CDB284 File Offset: 0x00CD9484
		public int JumpLevelId
		{
			get
			{
				return this.Config.JumpLevelId;
			}
		}

		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x0602DF1F RID: 188191 RVA: 0x00CDB2A0 File Offset: 0x00CD94A0
		public int SortId
		{
			get
			{
				return this.Config.SortId;
			}
		}

		// Token: 0x04018860 RID: 100448
		private readonly KurotatoCharacter Config;

		// Token: 0x04018861 RID: 100449
		private bool IsUnLockInternal;

		// Token: 0x04018862 RID: 100450
		private int HistoryWaveInternal;

		// Token: 0x04018863 RID: 100451
		private int HistoryKillNumInternal;

		// Token: 0x04018864 RID: 100452
		private readonly int ActivityId;

		// Token: 0x04018865 RID: 100453
		[Nullable(2)]
		private KurotatoInstInfo ArchivedDataInternal;

		// Token: 0x04018866 RID: 100454
		[Nullable(2)]
		private List<int> InitItemIdsInternal;
	}
}
