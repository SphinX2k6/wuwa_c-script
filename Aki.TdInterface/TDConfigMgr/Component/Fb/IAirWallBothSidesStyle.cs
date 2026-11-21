using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D44 RID: 3396
	public class IAirWallBothSidesStyle : IAirWallSpawnStyle
	{
		// Token: 0x06004D5A RID: 19802 RVA: 0x000C135A File Offset: 0x000BF55A
		public static IAirWallBothSidesStyle Create(IAirWallBothSidesStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallBothSidesStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06004D5B RID: 19803 RVA: 0x000C1379 File Offset: 0x000BF579
		public override EAirWallSpawnStyle Type
		{
			get
			{
				return (EAirWallSpawnStyle)this.Instance.Type;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x000C1386 File Offset: 0x000BF586
		public virtual float GapWidth
		{
			get
			{
				return this.Instance.GapWidth;
			}
		}

		// Token: 0x04002BE9 RID: 11241
		private IAirWallBothSidesStyle Instance;
	}
}
