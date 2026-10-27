using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD9 RID: 3289
	public class IPasserbyNpcSpawnCountOverride
	{
		// Token: 0x06004B2C RID: 19244 RVA: 0x000BBE74 File Offset: 0x000BA074
		[NullableContext(1)]
		public static IPasserbyNpcSpawnCountOverride Create(IPasserbyNpcSpawnCountOverride? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCountOverride
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06004B2D RID: 19245 RVA: 0x000BBE94 File Offset: 0x000BA094
		public virtual int? PcSpawnCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PcSpawnCount);
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06004B2E RID: 19246 RVA: 0x000BBECC File Offset: 0x000BA0CC
		public virtual int? MobileSpawnCount
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MobileSpawnCount);
			}
		}

		// Token: 0x04002AFE RID: 11006
		private IPasserbyNpcSpawnCountOverride Instance;
	}
}
