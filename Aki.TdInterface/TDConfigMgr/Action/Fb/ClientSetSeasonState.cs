using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A1 RID: 10401
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientSetSeasonState : ActionParams
	{
		// Token: 0x0600E642 RID: 58946 RVA: 0x0021D559 File Offset: 0x0021B759
		public static ClientSetSeasonState Create(IClientSetSeasonState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientSetSeasonState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x0600E643 RID: 58947 RVA: 0x0021D578 File Offset: 0x0021B778
		public virtual int VolumeId
		{
			get
			{
				return this.Instance.VolumeId;
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x0600E644 RID: 58948 RVA: 0x0021D585 File Offset: 0x0021B785
		public virtual IClientSetSeasonStateConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadClientSetSeasonState_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04007F4F RID: 32591
		private IClientSetSeasonState Instance;

		// Token: 0x04007F50 RID: 32592
		private IClientSetSeasonStateConfig _ConfigCache;

		// Token: 0x04007F51 RID: 32593
		private bool _ConfigInited;
	}
}
