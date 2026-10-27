using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1D RID: 6685
	[NullableContext(1)]
	[Nullable(0)]
	public class IExecClientBattleActionType
	{
		// Token: 0x06008F34 RID: 36660 RVA: 0x0014E8E4 File Offset: 0x0014CAE4
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

		// Token: 0x06008F35 RID: 36661 RVA: 0x0014E91C File Offset: 0x0014CB1C
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

		// Token: 0x06008F36 RID: 36662 RVA: 0x0014E92F File Offset: 0x0014CB2F
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

		// Token: 0x06008F37 RID: 36663 RVA: 0x0014E942 File Offset: 0x0014CB42
		public IExecClientBattleActionType_SetValue ToSetValue()
		{
			return new IExecClientBattleActionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x06008F38 RID: 36664 RVA: 0x0014E955 File Offset: 0x0014CB55
		// (set) Token: 0x06008F39 RID: 36665 RVA: 0x0014E980 File Offset: 0x0014CB80
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

		// Token: 0x040058A3 RID: 22691
		[Nullable(2)]
		protected IExecClientBattleActionType FbInstance;

		// Token: 0x040058A4 RID: 22692
		[Nullable(2)]
		protected IExecClientBattleActionType_SetValue PocoInterface;
	}
}
