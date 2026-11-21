using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002771 RID: 10097
	public class ICsvActionContext : IActionContextType
	{
		// Token: 0x0600DFC4 RID: 57284 RVA: 0x0020F1D2 File Offset: 0x0020D3D2
		public static ICsvActionContext Create(ICsvActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICsvActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600DFC5 RID: 57285 RVA: 0x0020F1F1 File Offset: 0x0020D3F1
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x040079C1 RID: 31169
		private ICsvActionContext Instance;
	}
}
