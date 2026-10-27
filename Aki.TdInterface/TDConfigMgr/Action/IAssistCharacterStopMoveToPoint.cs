using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E0 RID: 6112
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssistCharacterStopMoveToPoint : IExecClientBattleActionType
	{
		// Token: 0x06008337 RID: 33591 RVA: 0x00139730 File Offset: 0x00137930
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

		// Token: 0x06008338 RID: 33592 RVA: 0x00139768 File Offset: 0x00137968
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

		// Token: 0x06008339 RID: 33593 RVA: 0x0013977B File Offset: 0x0013797B
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

		// Token: 0x0600833A RID: 33594 RVA: 0x0013978E File Offset: 0x0013798E
		public new IAssistCharacterStopMoveToPoint_SetValue ToSetValue()
		{
			return new IAssistCharacterStopMoveToPoint_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId
			};
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600833B RID: 33595 RVA: 0x001397AD File Offset: 0x001379AD
		// (set) Token: 0x0600833C RID: 33596 RVA: 0x001397D8 File Offset: 0x001379D8
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

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600833D RID: 33597 RVA: 0x001397E6 File Offset: 0x001379E6
		// (set) Token: 0x0600833E RID: 33598 RVA: 0x00139811 File Offset: 0x00137A11
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

		// Token: 0x0400534F RID: 21327
		[Nullable(2)]
		protected new IAssistCharacterStopMoveToPoint FbInstance;

		// Token: 0x04005350 RID: 21328
		[Nullable(2)]
		protected new IAssistCharacterStopMoveToPoint_SetValue PocoInterface;
	}
}
