using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A1 RID: 10657
	public class IPerceptionNotifyGatherToPlayer : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600EC26 RID: 60454 RVA: 0x0022C3BC File Offset: 0x0022A5BC
		public static IPerceptionNotifyGatherToPlayer Create(IPerceptionNotifyGatherToPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x0600EC27 RID: 60455 RVA: 0x0022C3DB File Offset: 0x0022A5DB
		public override EBattleStatePerceptionBehavior Type
		{
			get
			{
				return (EBattleStatePerceptionBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04008205 RID: 33285
		private IPerceptionNotifyGatherToPlayer Instance;
	}
}
