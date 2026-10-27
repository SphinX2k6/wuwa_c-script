using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002903 RID: 10499
	[NullableContext(1)]
	[Nullable(0)]
	public class ModifyActorMaterialParamBySplineProgress : ActionParams
	{
		// Token: 0x0600E91C RID: 59676 RVA: 0x00222FEE File Offset: 0x002211EE
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

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x0600E91D RID: 59677 RVA: 0x0022300D File Offset: 0x0022120D
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

		// Token: 0x040080AF RID: 32943
		private IModifyActorMaterialParamBySplineProgress Instance;

		// Token: 0x040080B0 RID: 32944
		private IModifyActorMaterialParamBySplineProgressConfig _ConfigCache;

		// Token: 0x040080B1 RID: 32945
		private bool _ConfigInited;
	}
}
