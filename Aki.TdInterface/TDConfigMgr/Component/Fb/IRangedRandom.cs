using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4C RID: 2892
	public class IRangedRandom
	{
		// Token: 0x060042A6 RID: 17062 RVA: 0x000AA326 File Offset: 0x000A8526
		[NullableContext(1)]
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

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x000AA345 File Offset: 0x000A8545
		public virtual float Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x000AA352 File Offset: 0x000A8552
		public virtual float Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x04002583 RID: 9603
		private IRangedRandom Instance;
	}
}
