using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C9 RID: 10697
	public class IAssistCharacterStopMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x0600ECD2 RID: 60626 RVA: 0x0022D69F File Offset: 0x0022B89F
		public static IAssistCharacterStopMoveToPoint Create(IAssistCharacterStopMoveToPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterStopMoveToPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x0600ECD3 RID: 60627 RVA: 0x0022D6BE File Offset: 0x0022B8BE
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x0600ECD4 RID: 60628 RVA: 0x0022D6CB File Offset: 0x0022B8CB
		public virtual int AssistCharacterId
		{
			get
			{
				return this.Instance.AssistCharacterId;
			}
		}

		// Token: 0x0400825B RID: 33371
		private IAssistCharacterStopMoveToPoint Instance;
	}
}
