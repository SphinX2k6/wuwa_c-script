using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BDB RID: 11227
	public class ModifyActorMaterialParamBySplineProgress : ActionParams
	{
		// Token: 0x0600F759 RID: 63321 RVA: 0x002400ED File Offset: 0x0023E2ED
		public static ModifyActorMaterialParamBySplineProgress Create(IModifyActorMaterialParamBySplineProgress? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifyActorMaterialParamBySplineProgress
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x0600F75A RID: 63322 RVA: 0x0024010C File Offset: 0x0023E30C
		public virtual IModifyActorMaterialParamBySplineProgressConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadModifyActorMaterialParamBySplineProgress_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x0400876F RID: 34671
		private IModifyActorMaterialParamBySplineProgress Instance;

		// Token: 0x04008770 RID: 34672
		private IModifyActorMaterialParamBySplineProgressConfig _ConfigCache;

		// Token: 0x04008771 RID: 34673
		private bool _ConfigInited;
	}
}
