using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C1 RID: 9921
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientSetPlayerPos : ActionParams
	{
		// Token: 0x0600DDE7 RID: 56807 RVA: 0x0020F113 File Offset: 0x0020D313
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

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x0600DDE8 RID: 56808 RVA: 0x0020F132 File Offset: 0x0020D332
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

		// Token: 0x04007B35 RID: 31541
		private IClientSetPlayerPos Instance;

		// Token: 0x04007B36 RID: 31542
		private IClientTeleportConfig _TelePortConfigCache;

		// Token: 0x04007B37 RID: 31543
		private bool _TelePortConfigInited;
	}
}
