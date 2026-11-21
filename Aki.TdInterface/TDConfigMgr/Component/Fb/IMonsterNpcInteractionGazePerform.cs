using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CED RID: 3309
	public class IMonsterNpcInteractionGazePerform : IMonsterNpcInteractionConfig
	{
		// Token: 0x06004B76 RID: 19318 RVA: 0x000BD270 File Offset: 0x000BB470
		public static IMonsterNpcInteractionGazePerform Create(IMonsterNpcInteractionGazePerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionGazePerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06004B77 RID: 19319 RVA: 0x000BD28F File Offset: 0x000BB48F
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA4 RID: 10916
		private IMonsterNpcInteractionGazePerform Instance;
	}
}
