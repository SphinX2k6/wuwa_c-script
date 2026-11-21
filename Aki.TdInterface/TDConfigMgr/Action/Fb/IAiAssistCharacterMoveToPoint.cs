using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B3 RID: 10675
	public class IAiAssistCharacterMoveToPoint : IExecBattleActionType
	{
		// Token: 0x0600EC75 RID: 60533 RVA: 0x0022CE1C File Offset: 0x0022B01C
		public static IAiAssistCharacterMoveToPoint Create(IAiAssistCharacterMoveToPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAssistCharacterMoveToPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x0600EC76 RID: 60534 RVA: 0x0022CE3B File Offset: 0x0022B03B
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x0600EC77 RID: 60535 RVA: 0x0022CE48 File Offset: 0x0022B048
		public virtual int AssistCharacterId
		{
			get
			{
				return this.Instance.AssistCharacterId;
			}
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x0600EC78 RID: 60536 RVA: 0x0022CE55 File Offset: 0x0022B055
		public virtual IAssistCharacterMoveType MoveType
		{
			get
			{
				if (this._MoveTypeInited)
				{
					return this._MoveTypeCache;
				}
				this._MoveTypeInited = true;
				this._MoveTypeCache = ActionReadHelper.ReadIAiAssistCharacterMoveToPoint_MoveType(this.Instance);
				return this._MoveTypeCache;
			}
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x0600EC79 RID: 60537 RVA: 0x0022CE84 File Offset: 0x0022B084
		public virtual int Timeout
		{
			get
			{
				return this.Instance.Timeout;
			}
		}

		// Token: 0x0400822F RID: 33327
		private IAiAssistCharacterMoveToPoint Instance;

		// Token: 0x04008230 RID: 33328
		private IAssistCharacterMoveType _MoveTypeCache;

		// Token: 0x04008231 RID: 33329
		private bool _MoveTypeInited;
	}
}
