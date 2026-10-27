using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026EE RID: 9966
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x0600DE94 RID: 56980 RVA: 0x00210509 File Offset: 0x0020E709
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

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x0600DE95 RID: 56981 RVA: 0x00210528 File Offset: 0x0020E728
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x0600DE96 RID: 56982 RVA: 0x00210538 File Offset: 0x0020E738
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

		// Token: 0x04007B8C RID: 31628
		private IExitMonsterMoveWithSpline Instance;

		// Token: 0x04007B8D RID: 31629
		private List<int> _TargetEntitiesCache;

		// Token: 0x04007B8E RID: 31630
		private bool _TargetEntitiesInited;
	}
}
