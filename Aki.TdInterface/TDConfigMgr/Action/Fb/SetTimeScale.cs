using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A6 RID: 10150
	public class SetTimeScale : ActionParams
	{
		// Token: 0x0600E0C6 RID: 57542 RVA: 0x00211171 File Offset: 0x0020F371
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

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0600E0C7 RID: 57543 RVA: 0x00211190 File Offset: 0x0020F390
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

		// Token: 0x04007A3A RID: 31290
		private ISetTimeScale Instance;

		// Token: 0x04007A3B RID: 31291
		[Nullable(2)]
		private ISetGlobalTimeScale _ConfigCache;

		// Token: 0x04007A3C RID: 31292
		private bool _ConfigInited;
	}
}
