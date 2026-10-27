using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002906 RID: 10502
	[NullableContext(1)]
	[Nullable(0)]
	public class ModifyActorMedia : ActionParams
	{
		// Token: 0x0600E927 RID: 59687 RVA: 0x00223125 File Offset: 0x00221325
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

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x0600E928 RID: 59688 RVA: 0x00223144 File Offset: 0x00221344
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

		// Token: 0x040080B6 RID: 32950
		private IModifyActorMedia Instance;

		// Token: 0x040080B7 RID: 32951
		[Nullable(2)]
		private IChangeMediaPlayDa _ConfigCache;

		// Token: 0x040080B8 RID: 32952
		private bool _ConfigInited;
	}
}
