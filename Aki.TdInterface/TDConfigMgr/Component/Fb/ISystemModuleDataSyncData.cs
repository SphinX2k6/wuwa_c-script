using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ECD RID: 3789
	public class ISystemModuleDataSyncData
	{
		// Token: 0x0600556B RID: 21867 RVA: 0x000D1ECF File Offset: 0x000D00CF
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

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x0600556C RID: 21868 RVA: 0x000D1EEE File Offset: 0x000D00EE
		public virtual ESyncDataSystemType Type
		{
			get
			{
				return (ESyncDataSystemType)this.Instance.Type;
			}
		}

		// Token: 0x040030D8 RID: 12504
		private ISystemModuleDataSyncData Instance;
	}
}
