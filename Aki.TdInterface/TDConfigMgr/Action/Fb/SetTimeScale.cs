using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002500 RID: 9472
	[NullableContext(1)]
	[Nullable(0)]
	public class SetTimeScale : ActionParams
	{
		// Token: 0x0600D36A RID: 54122 RVA: 0x001F5779 File Offset: 0x001F3979
		public static SetTimeScale Create(ISetTimeScale? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTimeScale
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600D36B RID: 54123 RVA: 0x001F5798 File Offset: 0x001F3998
		public virtual ISetGlobalTimeScale Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ISetGlobalTimeScale.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x040073E8 RID: 29672
		private ISetTimeScale Instance;

		// Token: 0x040073E9 RID: 29673
		[Nullable(2)]
		private ISetGlobalTimeScale _ConfigCache;

		// Token: 0x040073EA RID: 29674
		private bool _ConfigInited;
	}
}
