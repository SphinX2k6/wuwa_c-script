using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D23 RID: 11555
	public class GiantToggleModel : ActionParams
	{
		// Token: 0x0600FC9F RID: 64671 RVA: 0x002486BC File Offset: 0x002468BC
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

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x0600FCA0 RID: 64672 RVA: 0x002486DB File Offset: 0x002468DB
		public virtual bool IsEnabled
		{
			get
			{
				return this.Instance.IsEnabled;
			}
		}

		// Token: 0x040089F1 RID: 35313
		private IGiantToggleModel Instance;
	}
}
