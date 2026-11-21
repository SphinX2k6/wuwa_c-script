using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1A RID: 3098
	public class IRangedRandom
	{
		// Token: 0x060046FF RID: 18175 RVA: 0x000B43EA File Offset: 0x000B25EA
		public static IRangedRandom Create(IRangedRandom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangedRandom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x000B4409 File Offset: 0x000B2609
		public virtual float Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x000B4416 File Offset: 0x000B2616
		public virtual float Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x040027CB RID: 10187
		private IRangedRandom Instance;
	}
}
