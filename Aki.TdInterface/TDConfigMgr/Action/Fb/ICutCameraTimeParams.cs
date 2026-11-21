using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B8D RID: 11149
	public class ICutCameraTimeParams
	{
		// Token: 0x0600F596 RID: 62870 RVA: 0x0023CB3E File Offset: 0x0023AD3E
		public static ICutCameraTimeParams Create(ICutCameraTimeParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICutCameraTimeParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x0600F597 RID: 62871 RVA: 0x0023CB5D File Offset: 0x0023AD5D
		public virtual float CutStayTime
		{
			get
			{
				return this.Instance.CutStayTime;
			}
		}

		// Token: 0x040086A3 RID: 34467
		private ICutCameraTimeParams Instance;
	}
}
