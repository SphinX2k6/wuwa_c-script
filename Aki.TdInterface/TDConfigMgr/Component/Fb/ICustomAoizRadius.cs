using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AA2 RID: 2722
	public class ICustomAoizRadius
	{
		// Token: 0x06003EB1 RID: 16049 RVA: 0x000A062D File Offset: 0x0009E82D
		[NullableContext(1)]
		public static ICustomAoizRadius Create(ICustomAoizRadius? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAoizRadius
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x000A064C File Offset: 0x0009E84C
		public virtual int? Up
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Up);
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x000A0684 File Offset: 0x0009E884
		public virtual int? Down
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Down);
			}
		}

		// Token: 0x040022D3 RID: 8915
		private ICustomAoizRadius Instance;
	}
}
