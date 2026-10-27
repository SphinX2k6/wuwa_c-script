using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A6 RID: 10150
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSubScreenMode : ActionParams
	{
		// Token: 0x0600E1D4 RID: 57812 RVA: 0x00215CD1 File Offset: 0x00213ED1
		public static SetSubScreenMode Create(ISetSubScreenMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSubScreenMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x0600E1D5 RID: 57813 RVA: 0x00215CF0 File Offset: 0x00213EF0
		public virtual ISubScreenModeConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadSetSubScreenMode_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04007D3C RID: 32060
		private ISetSubScreenMode Instance;

		// Token: 0x04007D3D RID: 32061
		private ISubScreenModeConfig _ConfigCache;

		// Token: 0x04007D3E RID: 32062
		private bool _ConfigInited;
	}
}
