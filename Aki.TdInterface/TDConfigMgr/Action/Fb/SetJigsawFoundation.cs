using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C58 RID: 11352
	public class SetJigsawFoundation : ActionParams
	{
		// Token: 0x0600F998 RID: 63896 RVA: 0x00243ED9 File Offset: 0x002420D9
		public static SetJigsawFoundation Create(ISetJigsawFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetJigsawFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x0600F999 RID: 63897 RVA: 0x00243EF8 File Offset: 0x002420F8
		public virtual ISetPieceState Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ISetPieceState.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x0400886A RID: 34922
		private ISetJigsawFoundation Instance;

		// Token: 0x0400886B RID: 34923
		[Nullable(2)]
		private ISetPieceState _ConfigCache;

		// Token: 0x0400886C RID: 34924
		private bool _ConfigInited;
	}
}
