using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C94 RID: 3220
	public class IJigsawCompletedConfig
	{
		// Token: 0x060049A0 RID: 18848 RVA: 0x000B878D File Offset: 0x000B698D
		[NullableContext(1)]
		public static IJigsawCompletedConfig Create(IJigsawCompletedConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawCompletedConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x000B87AC File Offset: 0x000B69AC
		public virtual bool? IsSilentPiece
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSilentPiece);
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x060049A2 RID: 18850 RVA: 0x000B87E4 File Offset: 0x000B69E4
		public virtual bool? IsSilentFoundation
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSilentFoundation);
			}
		}

		// Token: 0x04002A01 RID: 10753
		private IJigsawCompletedConfig Instance;
	}
}
