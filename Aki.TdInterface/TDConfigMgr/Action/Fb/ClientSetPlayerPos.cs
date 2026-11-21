using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002985 RID: 10629
	public class ClientSetPlayerPos : ActionParams
	{
		// Token: 0x0600EBC3 RID: 60355 RVA: 0x0022B953 File Offset: 0x00229B53
		public static ClientSetPlayerPos Create(IClientSetPlayerPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientSetPlayerPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x0600EBC4 RID: 60356 RVA: 0x0022B972 File Offset: 0x00229B72
		public virtual IClientTeleportConfig TelePortConfig
		{
			get
			{
				if (this._TelePortConfigInited)
				{
					return this._TelePortConfigCache;
				}
				this._TelePortConfigInited = true;
				this._TelePortConfigCache = ActionReadHelper.ReadClientSetPlayerPos_TelePortConfig(this.Instance);
				return this._TelePortConfigCache;
			}
		}

		// Token: 0x040081D5 RID: 33237
		private IClientSetPlayerPos Instance;

		// Token: 0x040081D6 RID: 33238
		private IClientTeleportConfig _TelePortConfigCache;

		// Token: 0x040081D7 RID: 33239
		private bool _TelePortConfigInited;
	}
}
