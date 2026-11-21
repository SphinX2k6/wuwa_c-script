using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E1D RID: 11805
	public class ILiveInteractDanmakuTriggerBattleEvent : ILiveInteractDanmakuTrigger
	{
		// Token: 0x06010069 RID: 65641 RVA: 0x0024E416 File Offset: 0x0024C616
		public static ILiveInteractDanmakuTriggerBattleEvent Create(ILiveInteractDanmakuTriggerBattleEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerBattleEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050DD RID: 20701
		// (get) Token: 0x0601006A RID: 65642 RVA: 0x0024E435 File Offset: 0x0024C635
		public override ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				return (ELiveInteractDanmakuTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x170050DE RID: 20702
		// (get) Token: 0x0601006B RID: 65643 RVA: 0x0024E442 File Offset: 0x0024C642
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x0601006C RID: 65644 RVA: 0x0024E44F File Offset: 0x0024C64F
		public virtual int BattleEventId
		{
			get
			{
				return this.Instance.BattleEventId;
			}
		}

		// Token: 0x04008BE5 RID: 35813
		private ILiveInteractDanmakuTriggerBattleEvent Instance;
	}
}
