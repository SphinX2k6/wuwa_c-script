using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D8 RID: 6104
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssistCharacterMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x0600830D RID: 33549 RVA: 0x001392B0 File Offset: 0x001374B0
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

		// Token: 0x0600830E RID: 33550 RVA: 0x001392E8 File Offset: 0x001374E8
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

		// Token: 0x0600830F RID: 33551 RVA: 0x001392FB File Offset: 0x001374FB
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

		// Token: 0x06008310 RID: 33552 RVA: 0x0013930E File Offset: 0x0013750E
		public new IAssistCharacterMoveToPoint_SetValue ToSetValue()
		{
			return new IAssistCharacterMoveToPoint_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId,
				MoveType = this.MoveType
			};
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x06008311 RID: 33553 RVA: 0x00139339 File Offset: 0x00137539
		// (set) Token: 0x06008312 RID: 33554 RVA: 0x00139364 File Offset: 0x00137564
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

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x06008313 RID: 33555 RVA: 0x00139372 File Offset: 0x00137572
		// (set) Token: 0x06008314 RID: 33556 RVA: 0x0013939D File Offset: 0x0013759D
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

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06008315 RID: 33557 RVA: 0x001393AB File Offset: 0x001375AB
		// (set) Token: 0x06008316 RID: 33558 RVA: 0x001393D2 File Offset: 0x001375D2
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

		// Token: 0x0400533C RID: 21308
		[Nullable(2)]
		protected new IAssistCharacterMoveToPoint FbInstance;

		// Token: 0x0400533D RID: 21309
		[Nullable(2)]
		protected new IAssistCharacterMoveToPoint_SetValue PocoInterface;
	}
}
