using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298F RID: 10639
	public class IPerformerAiMoveToPlayer : IPerformerAiMoveConfig
	{
		// Token: 0x0600EB91 RID: 60305 RVA: 0x0022735F File Offset: 0x0022555F
		[NullableContext(1)]
		public static IPerformerAiMoveToPlayer Create(IPerformerAiMoveToPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveToPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x0600EB92 RID: 60306 RVA: 0x0022737E File Offset: 0x0022557E
		public override EPerformerAiMoveToType Type
		{
			get
			{
				return (EPerformerAiMoveToType)this.Instance.Type;
			}
		}

		// Token: 0x040081BB RID: 33211
		private IPerformerAiMoveToPlayer Instance;
	}
}
