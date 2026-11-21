using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE6 RID: 3302
	public class IMonsterShowOnDeathConfig
	{
		// Token: 0x06004B60 RID: 19296 RVA: 0x000BD0D0 File Offset: 0x000BB2D0
		public static IMonsterShowOnDeathConfig Create(IMonsterShowOnDeathConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06004B61 RID: 19297 RVA: 0x000BD0EF File Offset: 0x000BB2EF
		public virtual EMonsterShowOnDeathType Type
		{
			get
			{
				return (EMonsterShowOnDeathType)this.Instance.Type;
			}
		}

		// Token: 0x04002A9B RID: 10907
		private IMonsterShowOnDeathConfig Instance;
	}
}
