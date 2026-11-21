using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D41 RID: 3393
	public class IAirWallSpawnStyle
	{
		// Token: 0x06004D4F RID: 19791 RVA: 0x000C127D File Offset: 0x000BF47D
		public static IAirWallSpawnStyle Create(IAirWallSpawnStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallSpawnStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x000C129C File Offset: 0x000BF49C
		public virtual EAirWallSpawnStyle Type
		{
			get
			{
				return (EAirWallSpawnStyle)this.Instance.Type;
			}
		}

		// Token: 0x04002BE4 RID: 11236
		private IAirWallSpawnStyle Instance;
	}
}
