using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002703 RID: 9987
	public class IAssistCharacterStopMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x0600DEEA RID: 57066 RVA: 0x00210D37 File Offset: 0x0020EF37
		[NullableContext(1)]
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

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x00210D56 File Offset: 0x0020EF56
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x0600DEEC RID: 57068 RVA: 0x00210D63 File Offset: 0x0020EF63
		public virtual int AssistCharacterId
		{
			get
			{
				return this.Instance.AssistCharacterId;
			}
		}

		// Token: 0x04007BB7 RID: 31671
		private IAssistCharacterStopMoveToPoint Instance;
	}
}
