using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEB RID: 3307
	public class IMonsterNpcInteractionHook : IMonsterNpcInteractionConfig
	{
		// Token: 0x06004B70 RID: 19312 RVA: 0x000BD208 File Offset: 0x000BB408
		public static IMonsterNpcInteractionHook Create(IMonsterNpcInteractionHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x000BD227 File Offset: 0x000BB427
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA2 RID: 10914
		private IMonsterNpcInteractionHook Instance;
	}
}
