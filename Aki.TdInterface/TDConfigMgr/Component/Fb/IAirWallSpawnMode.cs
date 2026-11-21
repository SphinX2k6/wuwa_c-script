using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D45 RID: 3397
	public class IAirWallSpawnMode
	{
		// Token: 0x06004D5E RID: 19806 RVA: 0x000C139B File Offset: 0x000BF59B
		public static IAirWallSpawnMode Create(IAirWallSpawnMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallSpawnMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06004D5F RID: 19807 RVA: 0x000C13BA File Offset: 0x000BF5BA
		public virtual EAirWallSpawnMode Type
		{
			get
			{
				return (EAirWallSpawnMode)this.Instance.Type;
			}
		}

		// Token: 0x04002BEA RID: 11242
		private IAirWallSpawnMode Instance;
	}
}
