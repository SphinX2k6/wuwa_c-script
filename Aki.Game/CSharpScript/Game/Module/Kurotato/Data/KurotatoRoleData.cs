using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x020057A1 RID: 22433
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRoleData
	{
		// Token: 0x06038FF4 RID: 233460 RVA: 0x00D8C1A7 File Offset: 0x00D8A3A7
		public KurotatoRoleData(KurotatoCharacter config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x170088B6 RID: 34998
		// (get) Token: 0x06038FF5 RID: 233461 RVA: 0x00D8C1BD File Offset: 0x00D8A3BD
		// (set) Token: 0x06038FF6 RID: 233462 RVA: 0x00D8C1C5 File Offset: 0x00D8A3C5
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

		// Token: 0x170088B7 RID: 34999
		// (get) Token: 0x06038FF7 RID: 233463 RVA: 0x00D8C1CE File Offset: 0x00D8A3CE
		// (set) Token: 0x06038FF8 RID: 233464 RVA: 0x00D8C1D6 File Offset: 0x00D8A3D6
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

		// Token: 0x170088B8 RID: 35000
		// (get) Token: 0x06038FF9 RID: 233465 RVA: 0x00D8C1DF File Offset: 0x00D8A3DF
		// (set) Token: 0x06038FFA RID: 233466 RVA: 0x00D8C1E7 File Offset: 0x00D8A3E7
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

		// Token: 0x170088B9 RID: 35001
		// (get) Token: 0x06038FFB RID: 233467 RVA: 0x00D8C1F0 File Offset: 0x00D8A3F0
		public bool HasHistory
		{
			get
			{
				return this.HistoryWaveInternal != 0;
			}
		}

		// Token: 0x170088BA RID: 35002
		// (get) Token: 0x06038FFC RID: 233468 RVA: 0x00D8C1FB File Offset: 0x00D8A3FB
		public bool HasArchived
		{
			get
			{
				return this.ArchivedDataInternal != null;
			}
		}

		// Token: 0x170088BB RID: 35003
		// (get) Token: 0x06038FFD RID: 233469 RVA: 0x00D8C206 File Offset: 0x00D8A406
		// (set) Token: 0x06038FFE RID: 233470 RVA: 0x00D8C20E File Offset: 0x00D8A40E
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

		// Token: 0x170088BC RID: 35004
		// (get) Token: 0x06038FFF RID: 233471 RVA: 0x00D8C217 File Offset: 0x00D8A417
		public bool HasHandBookRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 1, this.Id, 0) == 0;
			}
		}

		// Token: 0x06039000 RID: 233472 RVA: 0x00D8C248 File Offset: 0x00D8A448
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

		// Token: 0x170088BD RID: 35005
		// (get) Token: 0x06039001 RID: 233473 RVA: 0x00D8C2AA File Offset: 0x00D8A4AA
		public bool HasRoleSelectRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 5, this.Id, 0) == 0;
			}
		}

		// Token: 0x06039002 RID: 233474 RVA: 0x00D8C2DA File Offset: 0x00D8A4DA
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

		// Token: 0x170088BE RID: 35006
		// (get) Token: 0x06039003 RID: 233475 RVA: 0x00D8C307 File Offset: 0x00D8A507
		public bool NeedPlayUnlockAnim
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 6, this.Id, 0) == 0;
			}
		}

		// Token: 0x06039004 RID: 233476 RVA: 0x00D8C337 File Offset: 0x00D8A537
		public void MarkUnlockAnimPlayed()
		{
			if (!this.NeedPlayUnlockAnim)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 6, this.Id, 0, 1);
		}

		// Token: 0x170088BF RID: 35007
		// (get) Token: 0x06039005 RID: 233477 RVA: 0x00D8C35C File Offset: 0x00D8A55C
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170088C0 RID: 35008
		// (get) Token: 0x06039006 RID: 233478 RVA: 0x00D8C378 File Offset: 0x00D8A578
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x170088C1 RID: 35009
		// (get) Token: 0x06039007 RID: 233479 RVA: 0x00D8C394 File Offset: 0x00D8A594
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x170088C2 RID: 35010
		// (get) Token: 0x06039008 RID: 233480 RVA: 0x00D8C3B0 File Offset: 0x00D8A5B0
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

		// Token: 0x170088C3 RID: 35011
		// (get) Token: 0x06039009 RID: 233481 RVA: 0x00D8C3F2 File Offset: 0x00D8A5F2
		public int RealRoleId
		{
			get
			{
				return KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(this.Id).GetDataId();
			}
		}

		// Token: 0x170088C4 RID: 35012
		// (get) Token: 0x0603900A RID: 233482 RVA: 0x00D8C409 File Offset: 0x00D8A609
		public int RealRoleSkinId
		{
			get
			{
				return KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(this.Id).GetRoleSkinId();
			}
		}

		// Token: 0x170088C5 RID: 35013
		// (get) Token: 0x0603900B RID: 233483 RVA: 0x00D8C420 File Offset: 0x00D8A620
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

		// Token: 0x170088C6 RID: 35014
		// (get) Token: 0x0603900C RID: 233484 RVA: 0x00D8C4A8 File Offset: 0x00D8A6A8
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

		// Token: 0x170088C7 RID: 35015
		// (get) Token: 0x0603900D RID: 233485 RVA: 0x00D8C4EC File Offset: 0x00D8A6EC
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockConditionId;
			}
		}

		// Token: 0x170088C8 RID: 35016
		// (get) Token: 0x0603900E RID: 233486 RVA: 0x00D8C508 File Offset: 0x00D8A708
		public int JumpLevelId
		{
			get
			{
				return this.Config.JumpLevelId;
			}
		}

		// Token: 0x170088C9 RID: 35017
		// (get) Token: 0x0603900F RID: 233487 RVA: 0x00D8C524 File Offset: 0x00D8A724
		public int SortId
		{
			get
			{
				return this.Config.SortId;
			}
		}

		// Token: 0x0401DDCA RID: 122314
		private readonly KurotatoCharacter Config;

		// Token: 0x0401DDCB RID: 122315
		private bool IsUnLockInternal;

		// Token: 0x0401DDCC RID: 122316
		private int HistoryWaveInternal;

		// Token: 0x0401DDCD RID: 122317
		private int HistoryKillNumInternal;

		// Token: 0x0401DDCE RID: 122318
		private readonly int ActivityId;

		// Token: 0x0401DDCF RID: 122319
		[Nullable(2)]
		private KurotatoInstInfo ArchivedDataInternal;

		// Token: 0x0401DDD0 RID: 122320
		[Nullable(2)]
		private List<int> InitItemIdsInternal;
	}
}
