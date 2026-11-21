using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE2 RID: 11234
	public class ModifyActorMedia : ActionParams
	{
		// Token: 0x0600F778 RID: 63352 RVA: 0x00240445 File Offset: 0x0023E645
		public static ModifyActorMedia Create(IModifyActorMedia? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifyActorMedia
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x0600F779 RID: 63353 RVA: 0x00240464 File Offset: 0x0023E664
		public virtual IChangeMediaPlayDa Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IChangeMediaPlayDa.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008784 RID: 34692
		private IModifyActorMedia Instance;

		// Token: 0x04008785 RID: 34693
		[Nullable(2)]
		private IChangeMediaPlayDa _ConfigCache;

		// Token: 0x04008786 RID: 34694
		private bool _ConfigInited;
	}
}
