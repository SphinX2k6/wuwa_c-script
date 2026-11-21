using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B2 RID: 10674
	public class IExitMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x0600EC71 RID: 60529 RVA: 0x0022CD81 File Offset: 0x0022AF81
		public static IExitMonsterMoveWithSpline Create(IExitMonsterMoveWithSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitMonsterMoveWithSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x0600EC72 RID: 60530 RVA: 0x0022CDA0 File Offset: 0x0022AFA0
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x0022CDB0 File Offset: 0x0022AFB0
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

		// Token: 0x0400822C RID: 33324
		private IExitMonsterMoveWithSpline Instance;

		// Token: 0x0400822D RID: 33325
		private List<int> _TargetEntitiesCache;

		// Token: 0x0400822E RID: 33326
		private bool _TargetEntitiesInited;
	}
}
