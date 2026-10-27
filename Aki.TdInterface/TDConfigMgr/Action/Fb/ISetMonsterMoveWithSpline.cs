using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026ED RID: 9965
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x0600DE90 RID: 56976 RVA: 0x00210469 File Offset: 0x0020E669
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

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x00210488 File Offset: 0x0020E688
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x0600DE92 RID: 56978 RVA: 0x00210498 File Offset: 0x0020E698
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

		// Token: 0x04007B89 RID: 31625
		private ISetMonsterMoveWithSpline Instance;

		// Token: 0x04007B8A RID: 31626
		private List<IMonsterMoveSplineConfig> _MoveSplineConfigsCache;

		// Token: 0x04007B8B RID: 31627
		private bool _MoveSplineConfigsInited;
	}
}
