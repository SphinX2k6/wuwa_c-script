using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C12 RID: 3090
	public class IDestroyCfg
	{
		// Token: 0x060046D0 RID: 18128 RVA: 0x000B400D File Offset: 0x000B220D
		public static IDestroyCfg Create(IDestroyCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x000B402C File Offset: 0x000B222C
		public virtual List<ITeleControlDestroyCondition> Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				this._ConditionsCache = ComponentReadHelper.ReadIDestroyCfg_Conditions(this.Instance);
				return this._ConditionsCache;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x000B405C File Offset: 0x000B225C
		public virtual bool? StopPhysicAfterDestroyed
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.StopPhysicAfterDestroyed);
			}
		}

		// Token: 0x040027B9 RID: 10169
		private IDestroyCfg Instance;

		// Token: 0x040027BA RID: 10170
		private List<ITeleControlDestroyCondition> _ConditionsCache;

		// Token: 0x040027BB RID: 10171
		private bool _ConditionsInited;
	}
}
