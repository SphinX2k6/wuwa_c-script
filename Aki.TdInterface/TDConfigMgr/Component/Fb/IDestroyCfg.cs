using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B44 RID: 2884
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroyCfg
	{
		// Token: 0x06004277 RID: 17015 RVA: 0x000A9F49 File Offset: 0x000A8149
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

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x000A9F68 File Offset: 0x000A8168
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

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x000A9F98 File Offset: 0x000A8198
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

		// Token: 0x04002571 RID: 9585
		private IDestroyCfg Instance;

		// Token: 0x04002572 RID: 9586
		private List<ITeleControlDestroyCondition> _ConditionsCache;

		// Token: 0x04002573 RID: 9587
		private bool _ConditionsInited;
	}
}
