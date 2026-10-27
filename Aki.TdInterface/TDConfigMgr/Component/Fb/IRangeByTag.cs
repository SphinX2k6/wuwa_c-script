using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A82 RID: 2690
	public class IRangeByTag
	{
		// Token: 0x06003DE1 RID: 15841 RVA: 0x0009E83E File Offset: 0x0009CA3E
		[NullableContext(1)]
		public static IRangeByTag Create(IRangeByTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeByTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0009E85D File Offset: 0x0009CA5D
		public virtual int Tag
		{
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x0009E86A File Offset: 0x0009CA6A
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x0009E878 File Offset: 0x0009CA78
		public virtual float? ExitRange
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ExitRange);
			}
		}

		// Token: 0x04002271 RID: 8817
		private IRangeByTag Instance;
	}
}
