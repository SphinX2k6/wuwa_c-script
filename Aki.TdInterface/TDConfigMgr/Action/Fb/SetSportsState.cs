using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F5 RID: 10485
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSportsState : ActionParams
	{
		// Token: 0x0600E8E6 RID: 59622 RVA: 0x00222AA7 File Offset: 0x00220CA7
		public static SetSportsState Create(ISetSportsState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSportsState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x0600E8E7 RID: 59623 RVA: 0x00222AC6 File Offset: 0x00220CC6
		public virtual ISportConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadSetSportsState_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008091 RID: 32913
		private ISetSportsState Instance;

		// Token: 0x04008092 RID: 32914
		private ISportConfig _ConfigCache;

		// Token: 0x04008093 RID: 32915
		private bool _ConfigInited;
	}
}
