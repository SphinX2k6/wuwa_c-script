using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001969 RID: 6505
	public class IAssistCharacterStopMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x06008A53 RID: 35411 RVA: 0x00148E18 File Offset: 0x00147018
		private IAssistCharacterStopMoveToPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssistCharacterStopMoveToPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssistCharacterStopMoveToPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssistCharacterStopMoveToPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x00148E50 File Offset: 0x00147050
		public static IAssistCharacterStopMoveToPoint Create([Nullable(2)] IAssistCharacterStopMoveToPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterStopMoveToPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x00148E63 File Offset: 0x00147063
		public static IAssistCharacterStopMoveToPoint CreateFromSetValue([Nullable(2)] IAssistCharacterStopMoveToPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssistCharacterStopMoveToPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x00148E76 File Offset: 0x00147076
		public new IAssistCharacterStopMoveToPoint_SetValue ToSetValue()
		{
			return new IAssistCharacterStopMoveToPoint_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId
			};
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x06008A57 RID: 35415 RVA: 0x00148E95 File Offset: 0x00147095
		// (set) Token: 0x06008A58 RID: 35416 RVA: 0x00148EC0 File Offset: 0x001470C0
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

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x06008A59 RID: 35417 RVA: 0x00148ECE File Offset: 0x001470CE
		// (set) Token: 0x06008A5A RID: 35418 RVA: 0x00148EF9 File Offset: 0x001470F9
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

		// Token: 0x04005797 RID: 22423
		[Nullable(2)]
		protected new IAssistCharacterStopMoveToPoint FbInstance;

		// Token: 0x04005798 RID: 22424
		[Nullable(2)]
		protected new IAssistCharacterStopMoveToPoint_SetValue PocoInterface;
	}
}
