using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C8 RID: 10696
	public class IAssistCharacterMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x0600ECCD RID: 60621 RVA: 0x0022D62F File Offset: 0x0022B82F
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

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x0600ECCE RID: 60622 RVA: 0x0022D64E File Offset: 0x0022B84E
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x0600ECCF RID: 60623 RVA: 0x0022D65B File Offset: 0x0022B85B
		public virtual int AssistCharacterId
		{
			get
			{
				return this.Instance.AssistCharacterId;
			}
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x0600ECD0 RID: 60624 RVA: 0x0022D668 File Offset: 0x0022B868
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

		// Token: 0x04008258 RID: 33368
		private IAssistCharacterMoveToPoint Instance;

		// Token: 0x04008259 RID: 33369
		private IAssistCharacterMoveType _MoveTypeCache;

		// Token: 0x0400825A RID: 33370
		private bool _MoveTypeInited;
	}
}
