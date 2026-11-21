using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B86 RID: 2950
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateChangeConfig
	{
		// Token: 0x0600437D RID: 17277 RVA: 0x000AB2FE File Offset: 0x000A94FE
		[NullableContext(0)]
		public static IStateChangeConfig Create(IStateChangeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateChangeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x000AB31D File Offset: 0x000A951D
		public virtual string RefreshState
		{
			get
			{
				return this.Instance.RefreshState;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x000AB32A File Offset: 0x000A952A
		public virtual string SubDestroyState
		{
			get
			{
				return this.Instance.SubDestroyState;
			}
		}

		// Token: 0x04002547 RID: 9543
		private IStateChangeConfig Instance;
	}
}
