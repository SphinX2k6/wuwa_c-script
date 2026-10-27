using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAE RID: 3502
	public class IRandomPoolConfig
	{
		// Token: 0x06004F8C RID: 20364 RVA: 0x000C4F86 File Offset: 0x000C3186
		[NullableContext(1)]
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

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x000C4FA5 File Offset: 0x000C31A5
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x000C4FB2 File Offset: 0x000C31B2
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x04002DA3 RID: 11683
		private IRandomPoolConfig Instance;
	}
}
