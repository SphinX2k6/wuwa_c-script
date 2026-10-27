using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026DB RID: 9947
	public class IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600DE43 RID: 56899 RVA: 0x0020FB07 File Offset: 0x0020DD07
		[NullableContext(1)]
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

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x0020FB26 File Offset: 0x0020DD26
		public virtual EBattleStatePerceptionBehavior Type
		{
			get
			{
				return (EBattleStatePerceptionBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04007B63 RID: 31587
		private IBattleStatePerceptionBehaviorType Instance;
	}
}
