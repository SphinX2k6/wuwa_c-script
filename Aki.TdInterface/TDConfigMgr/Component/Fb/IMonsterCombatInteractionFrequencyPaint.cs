using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF1 RID: 3313
	public class IMonsterCombatInteractionFrequencyPaint : IMonsterCombatInteractionConfig
	{
		// Token: 0x06004B82 RID: 19330 RVA: 0x000BD362 File Offset: 0x000BB562
		public static IMonsterCombatInteractionFrequencyPaint Create(IMonsterCombatInteractionFrequencyPaint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionFrequencyPaint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06004B83 RID: 19331 RVA: 0x000BD381 File Offset: 0x000BB581
		public override EMonsterCombatInteractionType Type
		{
			get
			{
				return (EMonsterCombatInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06004B84 RID: 19332 RVA: 0x000BD38E File Offset: 0x000BB58E
		public virtual int FrequencyPaintTableId
		{
			get
			{
				return this.Instance.FrequencyPaintTableId;
			}
		}

		// Token: 0x04002AAA RID: 10922
		private IMonsterCombatInteractionFrequencyPaint Instance;
	}
}
