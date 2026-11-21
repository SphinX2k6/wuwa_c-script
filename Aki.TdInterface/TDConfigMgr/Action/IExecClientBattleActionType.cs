using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB2 RID: 7090
	public class IExecClientBattleActionType
	{
		// Token: 0x0600969E RID: 38558 RVA: 0x0015E810 File Offset: 0x0015CA10
		private IExecClientBattleActionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExecClientBattleActionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExecClientBattleActionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExecClientBattleActionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x0015E848 File Offset: 0x0015CA48
		public static IExecClientBattleActionType Create([Nullable(2)] IExecClientBattleActionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecClientBattleActionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0015E85B File Offset: 0x0015CA5B
		public static IExecClientBattleActionType CreateFromSetValue([Nullable(2)] IExecClientBattleActionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExecClientBattleActionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x0015E86E File Offset: 0x0015CA6E
		public IExecClientBattleActionType_SetValue ToSetValue()
		{
			return new IExecClientBattleActionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x060096A2 RID: 38562 RVA: 0x0015E881 File Offset: 0x0015CA81
		// (set) Token: 0x060096A3 RID: 38563 RVA: 0x0015E8AC File Offset: 0x0015CAAC
		public virtual EExecClientBattleActionType Type
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

		// Token: 0x04005D08 RID: 23816
		[Nullable(2)]
		protected IExecClientBattleActionType FbInstance;

		// Token: 0x04005D09 RID: 23817
		[Nullable(2)]
		protected IExecClientBattleActionType_SetValue PocoInterface;
	}
}
