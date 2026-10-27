using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1B RID: 3099
	public class IMonsterNpcInteractionHook : IMonsterNpcInteractionConfig
	{
		// Token: 0x0600470D RID: 18189 RVA: 0x000B303C File Offset: 0x000B123C
		[NullableContext(1)]
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x000B305B File Offset: 0x000B125B
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002856 RID: 10326
		private IMonsterNpcInteractionHook Instance;
	}
}
