using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D42 RID: 3394
	public class IAirWallCover
	{
		// Token: 0x06004D52 RID: 19794 RVA: 0x000C12B1 File Offset: 0x000BF4B1
		public static IAirWallCover Create(IAirWallCover? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallCover
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06004D53 RID: 19795 RVA: 0x000C12D0 File Offset: 0x000BF4D0
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x04002BE5 RID: 11237
		private IAirWallCover Instance;
	}
}
