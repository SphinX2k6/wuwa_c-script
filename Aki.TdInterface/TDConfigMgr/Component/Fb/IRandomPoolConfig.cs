using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EAA RID: 3754
	public class IRandomPoolConfig
	{
		// Token: 0x060054B1 RID: 21681 RVA: 0x000D07D6 File Offset: 0x000CE9D6
		public static IRandomPoolConfig Create(IRandomPoolConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPoolConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x000D07F5 File Offset: 0x000CE9F5
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x060054B3 RID: 21683 RVA: 0x000D0802 File Offset: 0x000CEA02
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x04003069 RID: 12393
		private IRandomPoolConfig Instance;
	}
}
