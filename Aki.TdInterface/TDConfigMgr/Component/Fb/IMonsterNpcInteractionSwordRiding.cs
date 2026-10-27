using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1C RID: 3100
	public class IMonsterNpcInteractionSwordRiding : IMonsterNpcInteractionConfig
	{
		// Token: 0x06004710 RID: 18192 RVA: 0x000B3070 File Offset: 0x000B1270
		[NullableContext(1)]
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

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x000B308F File Offset: 0x000B128F
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002857 RID: 10327
		private IMonsterNpcInteractionSwordRiding Instance;
	}
}
