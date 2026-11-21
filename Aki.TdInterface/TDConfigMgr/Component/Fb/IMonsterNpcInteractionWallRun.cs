using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEA RID: 3306
	public class IMonsterNpcInteractionWallRun : IMonsterNpcInteractionConfig
	{
		// Token: 0x06004B6D RID: 19309 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		public static IMonsterNpcInteractionWallRun Create(IMonsterNpcInteractionWallRun? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionWallRun
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x000BD1F3 File Offset: 0x000BB3F3
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA1 RID: 10913
		private IMonsterNpcInteractionWallRun Instance;
	}
}
