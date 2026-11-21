using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEC RID: 3308
	public class IMonsterNpcInteractionSwordRiding : IMonsterNpcInteractionConfig
	{
		// Token: 0x06004B73 RID: 19315 RVA: 0x000BD23C File Offset: 0x000BB43C
		public static IMonsterNpcInteractionSwordRiding Create(IMonsterNpcInteractionSwordRiding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionSwordRiding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x000BD25B File Offset: 0x000BB45B
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA3 RID: 10915
		private IMonsterNpcInteractionSwordRiding Instance;
	}
}
