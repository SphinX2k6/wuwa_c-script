using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBF RID: 3519
	public class IPasserbyNpcSpawnCenterPosBase
	{
		// Token: 0x06004FF2 RID: 20466 RVA: 0x000C6BCF File Offset: 0x000C4DCF
		public static IPasserbyNpcSpawnCenterPosBase Create(IPasserbyNpcSpawnCenterPosBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCenterPosBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x000C6BEE File Offset: 0x000C4DEE
		public virtual EPasserbyNpcSpawnCenterPosType Type
		{
			get
			{
				return (EPasserbyNpcSpawnCenterPosType)this.Instance.Type;
			}
		}

		// Token: 0x04002D8C RID: 11660
		private IPasserbyNpcSpawnCenterPosBase Instance;
	}
}
