using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D76 RID: 3446
	public class IJigsawCompletedConfig
	{
		// Token: 0x06004E4E RID: 20046 RVA: 0x000C319D File Offset: 0x000C139D
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

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x000C31BC File Offset: 0x000C13BC
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

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x000C31F4 File Offset: 0x000C13F4
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

		// Token: 0x04002C7B RID: 11387
		private IJigsawCompletedConfig Instance;
	}
}
