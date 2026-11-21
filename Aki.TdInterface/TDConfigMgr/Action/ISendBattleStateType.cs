using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200202F RID: 8239
	public class ISendBattleStateType
	{
		// Token: 0x0600AEE5 RID: 44773 RVA: 0x0018A2C0 File Offset: 0x001884C0
		private ISendBattleStateType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendBattleStateType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendBattleStateType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendBattleStateType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x0018A2F8 File Offset: 0x001884F8
		public static ISendBattleStateType Create([Nullable(2)] ISendBattleStateType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleStateType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x0018A30B File Offset: 0x0018850B
		public static ISendBattleStateType CreateFromSetValue([Nullable(2)] ISendBattleStateType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendBattleStateType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x0018A31E File Offset: 0x0018851E
		public ISendBattleStateType_SetValue ToSetValue()
		{
			return new ISendBattleStateType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600AEE9 RID: 44777 RVA: 0x0018A331 File Offset: 0x00188531
		// (set) Token: 0x0600AEEA RID: 44778 RVA: 0x0018A35C File Offset: 0x0018855C
		public virtual ESetBattleStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006833 RID: 26675
		[Nullable(2)]
		protected ISendBattleStateType FbInstance;

		// Token: 0x04006834 RID: 26676
		[Nullable(2)]
		protected ISendBattleStateType_SetValue PocoInterface;
	}
}
