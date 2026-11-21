using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002978 RID: 10616
	public class ITeleportConfig
	{
		// Token: 0x0600EB8B RID: 60299 RVA: 0x0022B37E File Offset: 0x0022957E
		public static ITeleportConfig Create(ITeleportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x0600EB8C RID: 60300 RVA: 0x0022B39D File Offset: 0x0022959D
		public virtual ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x040081B4 RID: 33204
		private ITeleportConfig Instance;
	}
}
