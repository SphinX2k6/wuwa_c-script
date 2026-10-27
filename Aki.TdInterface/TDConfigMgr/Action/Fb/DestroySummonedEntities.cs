using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A34 RID: 10804
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroySummonedEntities : ActionParams
	{
		// Token: 0x0600EE00 RID: 60928 RVA: 0x0022AC6C File Offset: 0x00228E6C
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

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0022AC8B File Offset: 0x00228E8B
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

		// Token: 0x040082FA RID: 33530
		private IDestroySummonedEntities Instance;

		// Token: 0x040082FB RID: 33531
		[Nullable(2)]
		private IDestroySummonedVehicle _DestroyEntitiesConfigCache;

		// Token: 0x040082FC RID: 33532
		private bool _DestroyEntitiesConfigInited;
	}
}
