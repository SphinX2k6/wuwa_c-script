using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026BD RID: 9917
	public class IClientTeleportConfig
	{
		// Token: 0x0600DDD5 RID: 56789 RVA: 0x0020EF5E File Offset: 0x0020D15E
		[NullableContext(1)]
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

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x0600DDD6 RID: 56790 RVA: 0x0020EF7D File Offset: 0x0020D17D
		public virtual EClientTeleportType Type
		{
			get
			{
				return (EClientTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x04007B29 RID: 31529
		private IClientTeleportConfig Instance;
	}
}
