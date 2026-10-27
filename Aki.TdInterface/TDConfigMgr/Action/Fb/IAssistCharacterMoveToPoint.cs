using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002702 RID: 9986
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssistCharacterMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x0600DEE5 RID: 57061 RVA: 0x00210CC7 File Offset: 0x0020EEC7
		public static IAssistCharacterMoveToPoint Create(IAssistCharacterMoveToPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterMoveToPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x0600DEE6 RID: 57062 RVA: 0x00210CE6 File Offset: 0x0020EEE6
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x0600DEE7 RID: 57063 RVA: 0x00210CF3 File Offset: 0x0020EEF3
		public virtual int AssistCharacterId
		{
			get
			{
				return this.Instance.AssistCharacterId;
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x0600DEE8 RID: 57064 RVA: 0x00210D00 File Offset: 0x0020EF00
		public virtual IAssistCharacterMoveType MoveType
		{
			get
			{
				if (this._MoveTypeInited)
				{
					return this._MoveTypeCache;
				}
				this._MoveTypeInited = true;
				this._MoveTypeCache = ActionReadHelper.ReadIAssistCharacterMoveToPoint_MoveType(this.Instance);
				return this._MoveTypeCache;
			}
		}

		// Token: 0x04007BB4 RID: 31668
		private IAssistCharacterMoveToPoint Instance;

		// Token: 0x04007BB5 RID: 31669
		private IAssistCharacterMoveType _MoveTypeCache;

		// Token: 0x04007BB6 RID: 31670
		private bool _MoveTypeInited;
	}
}
