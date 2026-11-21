using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D23 RID: 3363
	public class IPatrolPositionRefreshConfig
	{
		// Token: 0x06004C89 RID: 19593 RVA: 0x000BF78C File Offset: 0x000BD98C
		public static IPatrolPositionRefreshConfig Create(IPatrolPositionRefreshConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06004C8A RID: 19594 RVA: 0x000BF7AB File Offset: 0x000BD9AB
		public virtual List<IPatrolPositionRefreshTrigger> TriggerConditions
		{
			get
			{
				if (this._TriggerConditionsInited)
				{
					return this._TriggerConditionsCache;
				}
				this._TriggerConditionsInited = true;
				this._TriggerConditionsCache = ComponentReadHelper.ReadIPatrolPositionRefreshConfig_TriggerConditions(this.Instance);
				return this._TriggerConditionsCache;
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06004C8B RID: 19595 RVA: 0x000BF7DA File Offset: 0x000BD9DA
		public virtual IPatrolPositionRefreshAtNearestSplinePointToPlayer Refresh
		{
			get
			{
				if (this._RefreshInited)
				{
					return this._RefreshCache;
				}
				this._RefreshInited = true;
				this._RefreshCache = IPatrolPositionRefreshAtNearestSplinePointToPlayer.Create(this.Instance.Refresh);
				return this._RefreshCache;
			}
		}

		// Token: 0x04002B5A RID: 11098
		private IPatrolPositionRefreshConfig Instance;

		// Token: 0x04002B5B RID: 11099
		private List<IPatrolPositionRefreshTrigger> _TriggerConditionsCache;

		// Token: 0x04002B5C RID: 11100
		private bool _TriggerConditionsInited;

		// Token: 0x04002B5D RID: 11101
		[Nullable(2)]
		private IPatrolPositionRefreshAtNearestSplinePointToPlayer _RefreshCache;

		// Token: 0x04002B5E RID: 11102
		private bool _RefreshInited;
	}
}
