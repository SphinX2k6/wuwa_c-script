using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A00 RID: 10752
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSpineAnimation : ActionParams
	{
		// Token: 0x0600ED4A RID: 60746 RVA: 0x00229AAF File Offset: 0x00227CAF
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

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x0600ED4B RID: 60747 RVA: 0x00229ACE File Offset: 0x00227CCE
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

		// Token: 0x040082A0 RID: 33440
		private ISetSpineAnimation Instance;

		// Token: 0x040082A1 RID: 33441
		[Nullable(2)]
		private IPlaySpineAnimation _ConfigCache;

		// Token: 0x040082A2 RID: 33442
		private bool _ConfigInited;
	}
}
