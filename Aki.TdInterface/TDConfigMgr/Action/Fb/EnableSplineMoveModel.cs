using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D5 RID: 10453
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableSplineMoveModel : ActionParams
	{
		// Token: 0x0600E823 RID: 59427 RVA: 0x0022122D File Offset: 0x0021F42D
		public static EnableSplineMoveModel Create(IEnableSplineMoveModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSplineMoveModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x0600E824 RID: 59428 RVA: 0x0022124C File Offset: 0x0021F44C
		public virtual ISplineMoveConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadEnableSplineMoveModel_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008051 RID: 32849
		private IEnableSplineMoveModel Instance;

		// Token: 0x04008052 RID: 32850
		private ISplineMoveConfig _ConfigCache;

		// Token: 0x04008053 RID: 32851
		private bool _ConfigInited;
	}
}
