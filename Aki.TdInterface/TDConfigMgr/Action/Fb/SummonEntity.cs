using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A31 RID: 10801
	[NullableContext(1)]
	[Nullable(0)]
	public class SummonEntity : ActionParams
	{
		// Token: 0x0600EDF5 RID: 60917 RVA: 0x0022AB8F File Offset: 0x00228D8F
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

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x0600EDF6 RID: 60918 RVA: 0x0022ABAE File Offset: 0x00228DAE
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

		// Token: 0x040082F5 RID: 33525
		private ISummonEntity Instance;

		// Token: 0x040082F6 RID: 33526
		[Nullable(2)]
		private ISummonVehicle _SummonEntityConfigCache;

		// Token: 0x040082F7 RID: 33527
		private bool _SummonEntityConfigInited;
	}
}
