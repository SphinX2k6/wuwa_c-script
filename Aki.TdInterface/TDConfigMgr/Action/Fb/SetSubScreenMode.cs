using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A78 RID: 10872
	public class SetSubScreenMode : ActionParams
	{
		// Token: 0x0600EFF2 RID: 61426 RVA: 0x00232A65 File Offset: 0x00230C65
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

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x0600EFF3 RID: 61427 RVA: 0x00232A84 File Offset: 0x00230C84
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

		// Token: 0x040083F2 RID: 33778
		private ISetSubScreenMode Instance;

		// Token: 0x040083F3 RID: 33779
		private ISubScreenModeConfig _ConfigCache;

		// Token: 0x040083F4 RID: 33780
		private bool _ConfigInited;
	}
}
