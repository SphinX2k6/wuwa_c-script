using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B4 RID: 10676
	public class IAiAssistCharacterStopMoveToPoint : IExecBattleActionType
	{
		// Token: 0x0600EC7B RID: 60539 RVA: 0x0022CE99 File Offset: 0x0022B099
		public static IAiAssistCharacterStopMoveToPoint Create(IAiAssistCharacterStopMoveToPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAssistCharacterStopMoveToPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x0600EC7C RID: 60540 RVA: 0x0022CEB8 File Offset: 0x0022B0B8
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x0600EC7D RID: 60541 RVA: 0x0022CEC5 File Offset: 0x0022B0C5
		public virtual int AssistCharacterId
		{
			get
			{
				return this.Instance.AssistCharacterId;
			}
		}

		// Token: 0x04008232 RID: 33330
		private IAiAssistCharacterStopMoveToPoint Instance;
	}
}
