using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD1 RID: 11473
	public class PreloadAction : ActionParams
	{
		// Token: 0x0600FB75 RID: 64373 RVA: 0x00246BD9 File Offset: 0x00244DD9
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

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x0600FB76 RID: 64374 RVA: 0x00246BF8 File Offset: 0x00244DF8
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

		// Token: 0x04008963 RID: 35171
		private IPreloadAction Instance;

		// Token: 0x04008964 RID: 35172
		private IPreloadCharacterType _PreloadObjectTypeCache;

		// Token: 0x04008965 RID: 35173
		private bool _PreloadObjectTypeInited;
	}
}
