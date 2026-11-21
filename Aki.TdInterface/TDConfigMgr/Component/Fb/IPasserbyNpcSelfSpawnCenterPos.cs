using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC0 RID: 3520
	public class IPasserbyNpcSelfSpawnCenterPos : IPasserbyNpcSpawnCenterPosBase
	{
		// Token: 0x06004FF5 RID: 20469 RVA: 0x000C6C03 File Offset: 0x000C4E03
		public static IPasserbyNpcSelfSpawnCenterPos Create(IPasserbyNpcSelfSpawnCenterPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSelfSpawnCenterPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x000C6C22 File Offset: 0x000C4E22
		public override EPasserbyNpcSpawnCenterPosType Type
		{
			get
			{
				return (EPasserbyNpcSpawnCenterPosType)this.Instance.Type;
			}
		}

		// Token: 0x04002D8D RID: 11661
		private IPasserbyNpcSelfSpawnCenterPos Instance;
	}
}
