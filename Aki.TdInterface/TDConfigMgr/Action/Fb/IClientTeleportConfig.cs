using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002981 RID: 10625
	public class IClientTeleportConfig
	{
		// Token: 0x0600EBB1 RID: 60337 RVA: 0x0022B79E File Offset: 0x0022999E
		public static IClientTeleportConfig Create(IClientTeleportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientTeleportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x0600EBB2 RID: 60338 RVA: 0x0022B7BD File Offset: 0x002299BD
		public virtual EClientTeleportType Type
		{
			get
			{
				return (EClientTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x040081C9 RID: 33225
		private IClientTeleportConfig Instance;
	}
}
