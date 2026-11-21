using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200194F RID: 6479
	public class IAiAssistCharacterStopMoveToPoint : IExecBattleActionType
	{
		// Token: 0x060089C7 RID: 35271 RVA: 0x00147ED4 File Offset: 0x001460D4
		private IAiAssistCharacterStopMoveToPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAiAssistCharacterStopMoveToPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAiAssistCharacterStopMoveToPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAiAssistCharacterStopMoveToPoint_SetValue());
			}
			return result;
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x00147F0C File Offset: 0x0014610C
		public static IAiAssistCharacterStopMoveToPoint Create([Nullable(2)] IAiAssistCharacterStopMoveToPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAssistCharacterStopMoveToPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x00147F1F File Offset: 0x0014611F
		public static IAiAssistCharacterStopMoveToPoint CreateFromSetValue([Nullable(2)] IAiAssistCharacterStopMoveToPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAiAssistCharacterStopMoveToPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x00147F32 File Offset: 0x00146132
		public new IAiAssistCharacterStopMoveToPoint_SetValue ToSetValue()
		{
			return new IAiAssistCharacterStopMoveToPoint_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId
			};
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x00147F51 File Offset: 0x00146151
		// (set) Token: 0x060089CC RID: 35276 RVA: 0x00147F7C File Offset: 0x0014617C
		public override EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x060089CD RID: 35277 RVA: 0x00147F8A File Offset: 0x0014618A
		// (set) Token: 0x060089CE RID: 35278 RVA: 0x00147FB5 File Offset: 0x001461B5
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

		// Token: 0x0400575A RID: 22362
		[Nullable(2)]
		protected new IAiAssistCharacterStopMoveToPoint FbInstance;

		// Token: 0x0400575B RID: 22363
		[Nullable(2)]
		protected new IAiAssistCharacterStopMoveToPoint_SetValue PocoInterface;
	}
}
