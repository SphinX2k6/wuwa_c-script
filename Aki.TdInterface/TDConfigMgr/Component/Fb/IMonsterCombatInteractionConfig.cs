using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEF RID: 3311
	public class IMonsterCombatInteractionConfig
	{
		// Token: 0x06004B7C RID: 19324 RVA: 0x000BD2FA File Offset: 0x000BB4FA
		public static IMonsterCombatInteractionConfig Create(IMonsterCombatInteractionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06004B7D RID: 19325 RVA: 0x000BD319 File Offset: 0x000BB519
		public virtual EMonsterCombatInteractionType Type
		{
			get
			{
				return (EMonsterCombatInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002AA8 RID: 10920
		private IMonsterCombatInteractionConfig Instance;
	}
}
