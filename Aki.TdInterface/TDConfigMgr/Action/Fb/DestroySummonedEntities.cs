using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D21 RID: 11553
	public class DestroySummonedEntities : ActionParams
	{
		// Token: 0x0600FC98 RID: 64664 RVA: 0x00248620 File Offset: 0x00246820
		public static DestroySummonedEntities Create(IDestroySummonedEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroySummonedEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x0600FC99 RID: 64665 RVA: 0x0024863F File Offset: 0x0024683F
		public virtual IDestroySummonedVehicle DestroyEntitiesConfig
		{
			get
			{
				if (this._DestroyEntitiesConfigInited)
				{
					return this._DestroyEntitiesConfigCache;
				}
				this._DestroyEntitiesConfigInited = true;
				this._DestroyEntitiesConfigCache = IDestroySummonedVehicle.Create(this.Instance.DestroyEntitiesConfig);
				return this._DestroyEntitiesConfigCache;
			}
		}

		// Token: 0x040089ED RID: 35309
		private IDestroySummonedEntities Instance;

		// Token: 0x040089EE RID: 35310
		[Nullable(2)]
		private IDestroySummonedVehicle _DestroyEntitiesConfigCache;

		// Token: 0x040089EF RID: 35311
		private bool _DestroyEntitiesConfigInited;
	}
}
