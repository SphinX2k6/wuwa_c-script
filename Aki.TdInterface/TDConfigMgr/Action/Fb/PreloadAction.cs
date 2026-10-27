using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E4 RID: 10724
	[NullableContext(1)]
	[Nullable(0)]
	public class PreloadAction : ActionParams
	{
		// Token: 0x0600ECDE RID: 60638 RVA: 0x00229255 File Offset: 0x00227455
		public static PreloadAction Create(IPreloadAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PreloadAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x0600ECDF RID: 60639 RVA: 0x00229274 File Offset: 0x00227474
		public virtual IPreloadCharacterType PreloadObjectType
		{
			get
			{
				if (this._PreloadObjectTypeInited)
				{
					return this._PreloadObjectTypeCache;
				}
				this._PreloadObjectTypeInited = true;
				this._PreloadObjectTypeCache = ActionReadHelper.ReadPreloadAction_PreloadObjectType(this.Instance);
				return this._PreloadObjectTypeCache;
			}
		}

		// Token: 0x04008272 RID: 33394
		private IPreloadAction Instance;

		// Token: 0x04008273 RID: 33395
		private IPreloadCharacterType _PreloadObjectTypeCache;

		// Token: 0x04008274 RID: 33396
		private bool _PreloadObjectTypeInited;
	}
}
