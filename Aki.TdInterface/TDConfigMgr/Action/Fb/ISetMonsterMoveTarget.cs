using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026EA RID: 9962
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x0600DE82 RID: 56962 RVA: 0x002102B1 File Offset: 0x0020E4B1
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

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0600DE83 RID: 56963 RVA: 0x002102D0 File Offset: 0x0020E4D0
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x0600DE84 RID: 56964 RVA: 0x002102DD File Offset: 0x0020E4DD
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x002102EC File Offset: 0x0020E4EC
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

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x0600DE86 RID: 56966 RVA: 0x00210324 File Offset: 0x0020E524
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

		// Token: 0x04007B82 RID: 31618
		private ISetMonsterMoveTarget Instance;

		// Token: 0x04007B83 RID: 31619
		private List<int> _MonsterEntityIdsCache;

		// Token: 0x04007B84 RID: 31620
		private bool _MonsterEntityIdsInited;
	}
}
