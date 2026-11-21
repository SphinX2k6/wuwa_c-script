using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CED RID: 11501
	public class SetSpineAnimation : ActionParams
	{
		// Token: 0x0600FBE1 RID: 64481 RVA: 0x00247433 File Offset: 0x00245633
		public static SetSpineAnimation Create(ISetSpineAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSpineAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x0600FBE2 RID: 64482 RVA: 0x00247452 File Offset: 0x00245652
		public virtual IPlaySpineAnimation Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IPlaySpineAnimation.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008991 RID: 35217
		private ISetSpineAnimation Instance;

		// Token: 0x04008992 RID: 35218
		[Nullable(2)]
		private IPlaySpineAnimation _ConfigCache;

		// Token: 0x04008993 RID: 35219
		private bool _ConfigInited;
	}
}
