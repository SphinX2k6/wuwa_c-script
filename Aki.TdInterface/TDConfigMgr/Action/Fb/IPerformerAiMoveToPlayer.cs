using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C76 RID: 11382
	public class IPerformerAiMoveToPlayer : IPerformerAiMoveConfig
	{
		// Token: 0x0600FA0F RID: 64015 RVA: 0x00244AEB File Offset: 0x00242CEB
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

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x0600FA10 RID: 64016 RVA: 0x00244B0A File Offset: 0x00242D0A
		public override EPerformerAiMoveToType Type
		{
			get
			{
				return (EPerformerAiMoveToType)this.Instance.Type;
			}
		}

		// Token: 0x040088A0 RID: 34976
		private IPerformerAiMoveToPlayer Instance;
	}
}
