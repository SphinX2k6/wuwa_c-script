using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299F RID: 10655
	public class IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600EC1F RID: 60447 RVA: 0x0022C347 File Offset: 0x0022A547
		public static IBattleStatePerceptionBehaviorType Create(IBattleStatePerceptionBehaviorType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStatePerceptionBehaviorType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x0600EC20 RID: 60448 RVA: 0x0022C366 File Offset: 0x0022A566
		public virtual EBattleStatePerceptionBehavior Type
		{
			get
			{
				return (EBattleStatePerceptionBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04008203 RID: 33283
		private IBattleStatePerceptionBehaviorType Instance;
	}
}
