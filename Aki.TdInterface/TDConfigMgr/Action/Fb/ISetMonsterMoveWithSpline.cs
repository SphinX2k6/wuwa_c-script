using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B1 RID: 10673
	public class ISetMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x0600EC6D RID: 60525 RVA: 0x0022CCE2 File Offset: 0x0022AEE2
		public static ISetMonsterMoveWithSpline Create(ISetMonsterMoveWithSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMonsterMoveWithSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x0600EC6E RID: 60526 RVA: 0x0022CD01 File Offset: 0x0022AF01
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x0600EC6F RID: 60527 RVA: 0x0022CD10 File Offset: 0x0022AF10
		public virtual List<IMonsterMoveSplineConfig> MoveSplineConfigs
		{
			get
			{
				if (this._MoveSplineConfigsInited)
				{
					return this._MoveSplineConfigsCache;
				}
				this._MoveSplineConfigsInited = true;
				int moveSplineConfigsLength = this.Instance.MoveSplineConfigsLength;
				this._MoveSplineConfigsCache = new List<IMonsterMoveSplineConfig>(moveSplineConfigsLength);
				for (int i = 0; i < moveSplineConfigsLength; i++)
				{
					this._MoveSplineConfigsCache.Add(IMonsterMoveSplineConfig.Create(this.Instance.MoveSplineConfigs(i)));
				}
				return this._MoveSplineConfigsCache;
			}
		}

		// Token: 0x04008229 RID: 33321
		private ISetMonsterMoveWithSpline Instance;

		// Token: 0x0400822A RID: 33322
		private List<IMonsterMoveSplineConfig> _MoveSplineConfigsCache;

		// Token: 0x0400822B RID: 33323
		private bool _MoveSplineConfigsInited;
	}
}
