using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F8 RID: 10488
	[NullableContext(1)]
	[Nullable(0)]
	public class SetExploreState : ActionParams
	{
		// Token: 0x0600E8F0 RID: 59632 RVA: 0x00222B72 File Offset: 0x00220D72
		public static SetExploreState Create(ISetExploreState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetExploreState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x0600E8F1 RID: 59633 RVA: 0x00222B91 File Offset: 0x00220D91
		public virtual ITeleControlConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ITeleControlConfig.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008096 RID: 32918
		private ISetExploreState Instance;

		// Token: 0x04008097 RID: 32919
		[Nullable(2)]
		private ITeleControlConfig _ConfigCache;

		// Token: 0x04008098 RID: 32920
		private bool _ConfigInited;
	}
}
