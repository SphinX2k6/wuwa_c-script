using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7D RID: 10877
	public class ToggleDragActorPlay : ActionParams
	{
		// Token: 0x0600F010 RID: 61456 RVA: 0x00232D53 File Offset: 0x00230F53
		public static ToggleDragActorPlay Create(IToggleDragActorPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleDragActorPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x0600F011 RID: 61457 RVA: 0x00232D72 File Offset: 0x00230F72
		public virtual IToggleDragActorPlayType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadToggleDragActorPlay_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x040083FF RID: 33791
		private IToggleDragActorPlay Instance;

		// Token: 0x04008400 RID: 33792
		private IToggleDragActorPlayType _ConfigCache;

		// Token: 0x04008401 RID: 33793
		private bool _ConfigInited;
	}
}
