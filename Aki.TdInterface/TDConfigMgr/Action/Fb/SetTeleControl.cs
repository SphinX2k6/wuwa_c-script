using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B2 RID: 10674
	[NullableContext(1)]
	[Nullable(0)]
	public class SetTeleControl : ActionParams
	{
		// Token: 0x0600EC22 RID: 60450 RVA: 0x00227F70 File Offset: 0x00226170
		public static SetTeleControl Create(ISetTeleControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTeleControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0600EC23 RID: 60451 RVA: 0x00227F8F File Offset: 0x0022618F
		public virtual ISetTeleControlConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadSetTeleControl_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008204 RID: 33284
		private ISetTeleControl Instance;

		// Token: 0x04008205 RID: 33285
		private ISetTeleControlConfig _ConfigCache;

		// Token: 0x04008206 RID: 33286
		private bool _ConfigInited;
	}
}
