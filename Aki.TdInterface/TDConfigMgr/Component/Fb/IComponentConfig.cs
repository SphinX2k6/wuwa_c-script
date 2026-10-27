using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A52 RID: 2642
	[NullableContext(1)]
	[Nullable(0)]
	public class IComponentConfig
	{
		// Token: 0x06003CDA RID: 15578 RVA: 0x0009C91E File Offset: 0x0009AB1E
		public static IComponentConfig Create(IComponentConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x0009C940 File Offset: 0x0009AB40
		public virtual List<EAction> BaseActions
		{
			get
			{
				if (this._BaseActionsInited)
				{
					return this._BaseActionsCache;
				}
				this._BaseActionsInited = true;
				int baseActionsLength = this.Instance.BaseActionsLength;
				this._BaseActionsCache = new List<EAction>(baseActionsLength);
				for (int i = 0; i < baseActionsLength; i++)
				{
					this._BaseActionsCache.Add((EAction)this.Instance.BaseActions(i));
				}
				return this._BaseActionsCache;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x0009C9A4 File Offset: 0x0009ABA4
		public virtual string ActionsByComponent
		{
			get
			{
				return this.Instance.ActionsByComponent;
			}
		}

		// Token: 0x040021ED RID: 8685
		private IComponentConfig Instance;

		// Token: 0x040021EE RID: 8686
		private List<EAction> _BaseActionsCache;

		// Token: 0x040021EF RID: 8687
		private bool _BaseActionsInited;
	}
}
