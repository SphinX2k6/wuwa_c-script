using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A0 RID: 10656
	public class IPerceptionNotifyGatherToEntity : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600EC22 RID: 60450 RVA: 0x0022C37B File Offset: 0x0022A57B
		public static IPerceptionNotifyGatherToEntity Create(IPerceptionNotifyGatherToEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x0600EC23 RID: 60451 RVA: 0x0022C39A File Offset: 0x0022A59A
		public override EBattleStatePerceptionBehavior Type
		{
			get
			{
				return (EBattleStatePerceptionBehavior)this.Instance.Type;
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x0600EC24 RID: 60452 RVA: 0x0022C3A7 File Offset: 0x0022A5A7
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008204 RID: 33284
		private IPerceptionNotifyGatherToEntity Instance;
	}
}
