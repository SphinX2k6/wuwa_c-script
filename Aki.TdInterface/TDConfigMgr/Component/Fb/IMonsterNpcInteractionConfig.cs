using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C19 RID: 3097
	public class IMonsterNpcInteractionConfig
	{
		// Token: 0x06004707 RID: 18183 RVA: 0x000B2FD4 File Offset: 0x000B11D4
		[NullableContext(1)]
		public static IMonsterNpcInteractionConfig Create(IMonsterNpcInteractionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x000B2FF3 File Offset: 0x000B11F3
		public virtual EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002854 RID: 10324
		private IMonsterNpcInteractionConfig Instance;
	}
}
