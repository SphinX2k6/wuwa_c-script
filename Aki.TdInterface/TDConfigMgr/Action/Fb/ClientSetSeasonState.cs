using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B76 RID: 11126
	public class ClientSetSeasonState : ActionParams
	{
		// Token: 0x0600F471 RID: 62577 RVA: 0x0023A4D9 File Offset: 0x002386D9
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

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x0600F472 RID: 62578 RVA: 0x0023A4F8 File Offset: 0x002386F8
		public virtual int VolumeId
		{
			get
			{
				return this.Instance.VolumeId;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x0600F473 RID: 62579 RVA: 0x0023A505 File Offset: 0x00238705
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

		// Token: 0x0400860E RID: 34318
		private IClientSetSeasonState Instance;

		// Token: 0x0400860F RID: 34319
		private IClientSetSeasonStateConfig _ConfigCache;

		// Token: 0x04008610 RID: 34320
		private bool _ConfigInited;
	}
}
