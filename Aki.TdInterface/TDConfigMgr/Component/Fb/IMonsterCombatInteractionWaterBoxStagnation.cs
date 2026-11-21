using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF0 RID: 3312
	public class IMonsterCombatInteractionWaterBoxStagnation : IMonsterCombatInteractionConfig
	{
		// Token: 0x06004B7F RID: 19327 RVA: 0x000BD32E File Offset: 0x000BB52E
		public static IMonsterCombatInteractionWaterBoxStagnation Create(IMonsterCombatInteractionWaterBoxStagnation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionWaterBoxStagnation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x000BD34D File Offset: 0x000BB54D
		public override EMonsterCombatInteractionType Type
		{
			get
			{
				return (EMonsterCombatInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA9 RID: 10921
		private IMonsterCombatInteractionWaterBoxStagnation Instance;
	}
}
