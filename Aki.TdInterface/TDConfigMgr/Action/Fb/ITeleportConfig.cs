using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B5 RID: 9909
	public class ITeleportConfig
	{
		// Token: 0x0600DDB4 RID: 56756 RVA: 0x0020EBDE File Offset: 0x0020CDDE
		[NullableContext(1)]
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

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x0020EBFD File Offset: 0x0020CDFD
		public virtual ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x04007B17 RID: 31511
		private ITeleportConfig Instance;
	}
}
