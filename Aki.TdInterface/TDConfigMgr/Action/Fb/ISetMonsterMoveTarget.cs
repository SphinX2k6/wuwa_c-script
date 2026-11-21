using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AE RID: 10670
	public class ISetMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x0600EC5E RID: 60510 RVA: 0x0022CAF1 File Offset: 0x0022ACF1
		public static ISetMonsterMoveTarget Create(ISetMonsterMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMonsterMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x0600EC5F RID: 60511 RVA: 0x0022CB10 File Offset: 0x0022AD10
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x0600EC60 RID: 60512 RVA: 0x0022CB1D File Offset: 0x0022AD1D
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x0600EC61 RID: 60513 RVA: 0x0022CB2C File Offset: 0x0022AD2C
		public virtual EMoveEvent? MoveEvent
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EMoveEvent?((EMoveEvent)this.Instance.MoveEvent);
			}
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x0600EC62 RID: 60514 RVA: 0x0022CB64 File Offset: 0x0022AD64
		public virtual List<int> MonsterEntityIds
		{
			get
			{
				if (this._MonsterEntityIdsInited)
				{
					return this._MonsterEntityIdsCache;
				}
				this._MonsterEntityIdsInited = true;
				int monsterEntityIdsLength = this.Instance.MonsterEntityIdsLength;
				this._MonsterEntityIdsCache = new List<int>(monsterEntityIdsLength);
				for (int i = 0; i < monsterEntityIdsLength; i++)
				{
					this._MonsterEntityIdsCache.Add(this.Instance.MonsterEntityIds(i));
				}
				return this._MonsterEntityIdsCache;
			}
		}

		// Token: 0x04008222 RID: 33314
		private ISetMonsterMoveTarget Instance;

		// Token: 0x04008223 RID: 33315
		private List<int> _MonsterEntityIdsCache;

		// Token: 0x04008224 RID: 33316
		private bool _MonsterEntityIdsInited;
	}
}
