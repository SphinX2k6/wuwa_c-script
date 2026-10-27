using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200699E RID: 27038
	public class TriggerContext : GeneralContext
	{
		// Token: 0x06043448 RID: 275528 RVA: 0x01065E8D File Offset: 0x0106408D
		public TriggerContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Trigger);
		}

		// Token: 0x06043449 RID: 275529 RVA: 0x01065EBC File Offset: 0x010640BC
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

		// Token: 0x040230AA RID: 143530
		public int? TriggerEntityId = new int?(0);

		// Token: 0x040230AB RID: 143531
		public int? OtherEntityId = new int?(0);

		// Token: 0x040230AC RID: 143532
		public ETriggerEventType TriggerType;

		// Token: 0x040230AD RID: 143533
		public bool IsClientTrigger;
	}
}
