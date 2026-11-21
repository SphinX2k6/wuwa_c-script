using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AF RID: 10671
	public class IExitMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x0600EC64 RID: 60516 RVA: 0x0022CBD0 File Offset: 0x0022ADD0
		public static IExitMonsterMoveTarget Create(IExitMonsterMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitMonsterMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x0600EC65 RID: 60517 RVA: 0x0022CBEF File Offset: 0x0022ADEF
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x0600EC66 RID: 60518 RVA: 0x0022CBFC File Offset: 0x0022ADFC
		public virtual List<int> TargetEntities
		{
			get
			{
				if (this._TargetEntitiesInited)
				{
					return this._TargetEntitiesCache;
				}
				this._TargetEntitiesInited = true;
				int targetEntitiesLength = this.Instance.TargetEntitiesLength;
				this._TargetEntitiesCache = new List<int>(targetEntitiesLength);
				for (int i = 0; i < targetEntitiesLength; i++)
				{
					this._TargetEntitiesCache.Add(this.Instance.TargetEntities(i));
				}
				return this._TargetEntitiesCache;
			}
		}

		// Token: 0x04008225 RID: 33317
		private IExitMonsterMoveTarget Instance;

		// Token: 0x04008226 RID: 33318
		private List<int> _TargetEntitiesCache;

		// Token: 0x04008227 RID: 33319
		private bool _TargetEntitiesInited;
	}
}
