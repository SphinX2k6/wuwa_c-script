using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D1E RID: 11550
	public class SummonEntity : ActionParams
	{
		// Token: 0x0600FC8D RID: 64653 RVA: 0x00248543 File Offset: 0x00246743
		public static SummonEntity Create(ISummonEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SummonEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x0600FC8E RID: 64654 RVA: 0x00248562 File Offset: 0x00246762
		public virtual ISummonVehicle SummonEntityConfig
		{
			get
			{
				if (this._SummonEntityConfigInited)
				{
					return this._SummonEntityConfigCache;
				}
				this._SummonEntityConfigInited = true;
				this._SummonEntityConfigCache = ISummonVehicle.Create(this.Instance.SummonEntityConfig);
				return this._SummonEntityConfigCache;
			}
		}

		// Token: 0x040089E8 RID: 35304
		private ISummonEntity Instance;

		// Token: 0x040089E9 RID: 35305
		[Nullable(2)]
		private ISummonVehicle _SummonEntityConfigCache;

		// Token: 0x040089EA RID: 35306
		private bool _SummonEntityConfigInited;
	}
}
