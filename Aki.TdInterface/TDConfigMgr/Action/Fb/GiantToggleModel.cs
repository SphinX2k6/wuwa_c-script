using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A36 RID: 10806
	public class GiantToggleModel : ActionParams
	{
		// Token: 0x0600EE07 RID: 60935 RVA: 0x0022AD08 File Offset: 0x00228F08
		[NullableContext(1)]
		public static GiantToggleModel Create(IGiantToggleModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GiantToggleModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0022AD27 File Offset: 0x00228F27
		public virtual bool IsEnabled
		{
			get
			{
				return this.Instance.IsEnabled;
			}
		}

		// Token: 0x040082FE RID: 33534
		private IGiantToggleModel Instance;
	}
}
