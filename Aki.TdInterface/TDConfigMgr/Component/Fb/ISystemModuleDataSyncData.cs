using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD1 RID: 3537
	public class ISystemModuleDataSyncData
	{
		// Token: 0x06005046 RID: 20550 RVA: 0x000C667F File Offset: 0x000C487F
		[NullableContext(1)]
		public static ISystemModuleDataSyncData Create(ISystemModuleDataSyncData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemModuleDataSyncData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06005047 RID: 20551 RVA: 0x000C669E File Offset: 0x000C489E
		public virtual ESyncDataSystemType Type
		{
			get
			{
				return (ESyncDataSystemType)this.Instance.Type;
			}
		}

		// Token: 0x04002E12 RID: 11794
		private ISystemModuleDataSyncData Instance;
	}
}
