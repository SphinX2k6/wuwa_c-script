using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026DD RID: 9949
	public class IPerceptionNotifyGatherToPlayer : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600DE4A RID: 56906 RVA: 0x0020FB7C File Offset: 0x0020DD7C
		[NullableContext(1)]
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

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x0020FB9B File Offset: 0x0020DD9B
		public override EBattleStatePerceptionBehavior Type
		{
			get
			{
				return (EBattleStatePerceptionBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04007B65 RID: 31589
		private IPerceptionNotifyGatherToPlayer Instance;
	}
}
