using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002970 RID: 10608
	[NullableContext(1)]
	[Nullable(0)]
	public class SetJigsawItem : ActionParams
	{
		// Token: 0x0600EB17 RID: 60183 RVA: 0x002266E7 File Offset: 0x002248E7
		public static SetJigsawItem Create(ISetJigsawItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetJigsawItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x0600EB18 RID: 60184 RVA: 0x00226706 File Offset: 0x00224906
		public virtual IMoveJigsawItem Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IMoveJigsawItem.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008182 RID: 33154
		private ISetJigsawItem Instance;

		// Token: 0x04008183 RID: 33155
		[Nullable(2)]
		private IMoveJigsawItem _ConfigCache;

		// Token: 0x04008184 RID: 33156
		private bool _ConfigInited;
	}
}
