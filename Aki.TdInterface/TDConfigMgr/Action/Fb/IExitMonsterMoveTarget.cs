using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026EB RID: 9963
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x0600DE88 RID: 56968 RVA: 0x00210390 File Offset: 0x0020E590
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

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x0600DE89 RID: 56969 RVA: 0x002103AF File Offset: 0x0020E5AF
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x002103BC File Offset: 0x0020E5BC
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

		// Token: 0x04007B85 RID: 31621
		private IExitMonsterMoveTarget Instance;

		// Token: 0x04007B86 RID: 31622
		private List<int> _TargetEntitiesCache;

		// Token: 0x04007B87 RID: 31623
		private bool _TargetEntitiesInited;
	}
}
