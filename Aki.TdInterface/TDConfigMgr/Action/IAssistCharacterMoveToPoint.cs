using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195F RID: 6495
	public class IAssistCharacterMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x06008A1F RID: 35359 RVA: 0x00148898 File Offset: 0x00146A98
		private IAssistCharacterMoveToPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssistCharacterMoveToPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssistCharacterMoveToPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssistCharacterMoveToPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x001488D0 File Offset: 0x00146AD0
		public static IAssistCharacterMoveToPoint Create([Nullable(2)] IAssistCharacterMoveToPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterMoveToPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x001488E3 File Offset: 0x00146AE3
		public static IAssistCharacterMoveToPoint CreateFromSetValue([Nullable(2)] IAssistCharacterMoveToPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssistCharacterMoveToPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x001488F6 File Offset: 0x00146AF6
		public new IAssistCharacterMoveToPoint_SetValue ToSetValue()
		{
			return new IAssistCharacterMoveToPoint_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId,
				MoveType = this.MoveType
			};
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x00148921 File Offset: 0x00146B21
		// (set) Token: 0x06008A24 RID: 35364 RVA: 0x0014894C File Offset: 0x00146B4C
		public override EExecClientBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x0014895A File Offset: 0x00146B5A
		// (set) Token: 0x06008A26 RID: 35366 RVA: 0x00148985 File Offset: 0x00146B85
		public virtual int AssistCharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AssistCharacterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AssistCharacterId;
			}
			set
			{
				this.GetOrCreatePoco().AssistCharacterId = value;
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x06008A27 RID: 35367 RVA: 0x00148993 File Offset: 0x00146B93
		// (set) Token: 0x06008A28 RID: 35368 RVA: 0x001489BA File Offset: 0x00146BBA
		public virtual IAssistCharacterMoveType MoveType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveType;
				}
				IAssistCharacterMoveToPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveType;
			}
			set
			{
				this.GetOrCreatePoco().MoveType = value;
			}
		}

		// Token: 0x04005780 RID: 22400
		[Nullable(2)]
		protected new IAssistCharacterMoveToPoint FbInstance;

		// Token: 0x04005781 RID: 22401
		[Nullable(2)]
		protected new IAssistCharacterMoveToPoint_SetValue PocoInterface;
	}
}
