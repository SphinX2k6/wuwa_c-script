using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCF RID: 3535
	public class IPasserbyNpcSpawnCountOverride
	{
		// Token: 0x0600502F RID: 20527 RVA: 0x000C71E0 File Offset: 0x000C53E0
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

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x000C7200 File Offset: 0x000C5400
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

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06005031 RID: 20529 RVA: 0x000C7238 File Offset: 0x000C5438
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

		// Token: 0x04002DAE RID: 11694
		private IPasserbyNpcSpawnCountOverride Instance;
	}
}
