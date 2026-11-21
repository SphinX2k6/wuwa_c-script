using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E0B RID: 11787
	public class IClientExecEntityPrefabOption
	{
		// Token: 0x06010025 RID: 65573 RVA: 0x0024DE9A File Offset: 0x0024C09A
		public static IClientExecEntityPrefabOption Create(IClientExecEntityPrefabOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientExecEntityPrefabOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x06010026 RID: 65574 RVA: 0x0024DEB9 File Offset: 0x0024C0B9
		public virtual EClientExecEntityPrefabOption Type
		{
			get
			{
				return (EClientExecEntityPrefabOption)this.Instance.Type;
			}
		}

		// Token: 0x04008BCB RID: 35787
		private IClientExecEntityPrefabOption Instance;
	}
}
