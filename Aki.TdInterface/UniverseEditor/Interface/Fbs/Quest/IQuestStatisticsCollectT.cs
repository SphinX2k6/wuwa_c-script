using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004491 RID: 17553
	public class IQuestStatisticsCollectT
	{
		// Token: 0x170079EA RID: 31210
		// (get) Token: 0x06019459 RID: 103513 RVA: 0x0039B511 File Offset: 0x00399711
		// (set) Token: 0x0601945A RID: 103514 RVA: 0x0039B519 File Offset: 0x00399719
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170079EB RID: 31211
		// (get) Token: 0x0601945B RID: 103515 RVA: 0x0039B522 File Offset: 0x00399722
		// (set) Token: 0x0601945C RID: 103516 RVA: 0x0039B52A File Offset: 0x0039972A
		public TVarRefUnion Var { get; set; }

		// Token: 0x170079EC RID: 31212
		// (get) Token: 0x0601945D RID: 103517 RVA: 0x0039B533 File Offset: 0x00399733
		// (set) Token: 0x0601945E RID: 103518 RVA: 0x0039B53B File Offset: 0x0039973B
		public IStaticEntitiyMatchT EntitiyMatch { get; set; }

		// Token: 0x170079ED RID: 31213
		// (get) Token: 0x0601945F RID: 103519 RVA: 0x0039B544 File Offset: 0x00399744
		// (set) Token: 0x06019460 RID: 103520 RVA: 0x0039B54C File Offset: 0x0039974C
		public bool IsGlobal { get; set; }

		// Token: 0x170079EE RID: 31214
		// (get) Token: 0x06019461 RID: 103521 RVA: 0x0039B555 File Offset: 0x00399755
		// (set) Token: 0x06019462 RID: 103522 RVA: 0x0039B55D File Offset: 0x0039975D
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x170079EF RID: 31215
		// (get) Token: 0x06019463 RID: 103523 RVA: 0x0039B566 File Offset: 0x00399766
		// (set) Token: 0x06019464 RID: 103524 RVA: 0x0039B56E File Offset: 0x0039976E
		public byte NullMask { get; set; }

		// Token: 0x06019465 RID: 103525 RVA: 0x0039B577 File Offset: 0x00399777
		public IQuestStatisticsCollectT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.EntitiyMatch = null;
			this.IsGlobal = false;
			this.OnlinePlayerConditionTargetOption = null;
			this.NullMask = 0;
		}
	}
}
