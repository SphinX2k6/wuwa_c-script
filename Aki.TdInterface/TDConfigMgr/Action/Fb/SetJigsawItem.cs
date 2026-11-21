using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C55 RID: 11349
	public class SetJigsawItem : ActionParams
	{
		// Token: 0x0600F98D RID: 63885 RVA: 0x00243D9F File Offset: 0x00241F9F
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

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x0600F98E RID: 63886 RVA: 0x00243DBE File Offset: 0x00241FBE
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

		// Token: 0x04008863 RID: 34915
		private ISetJigsawItem Instance;

		// Token: 0x04008864 RID: 34916
		[Nullable(2)]
		private IMoveJigsawItem _ConfigCache;

		// Token: 0x04008865 RID: 34917
		private bool _ConfigInited;
	}
}
