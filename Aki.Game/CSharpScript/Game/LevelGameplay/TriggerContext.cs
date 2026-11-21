using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AFA RID: 23290
	public class TriggerContext : GeneralContext
	{
		// Token: 0x06039480 RID: 234624 RVA: 0x0100A0F5 File Offset: 0x010082F5
		public TriggerContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Trigger);
		}

		// Token: 0x06039481 RID: 234625 RVA: 0x0100A124 File Offset: 0x01008324
		[NullableContext(1)]
		public static TriggerContext Create(int triggerEntityId = 0, int otherEntityId = 0, GameCtxType? subType = null, ETriggerEventType? tiggerType = null, bool? isClientTrigger = null)
		{
			TriggerContext triggerContext = GeneralContext.GetObj(EGeneralContextType.Trigger, subType, () => new TriggerContext()) as TriggerContext;
			triggerContext.TriggerEntityId = new int?(triggerEntityId);
			triggerContext.OtherEntityId = new int?(otherEntityId);
			triggerContext.TriggerType = tiggerType.GetValueOrDefault();
			triggerContext.IsClientTrigger = isClientTrigger.GetValueOrDefault();
			return triggerContext;
		}

		// Token: 0x0401E294 RID: 123540
		public int? TriggerEntityId = new int?(0);

		// Token: 0x0401E295 RID: 123541
		public int? OtherEntityId = new int?(0);

		// Token: 0x0401E296 RID: 123542
		public ETriggerEventType TriggerType;

		// Token: 0x0401E297 RID: 123543
		public bool IsClientTrigger;
	}
}
