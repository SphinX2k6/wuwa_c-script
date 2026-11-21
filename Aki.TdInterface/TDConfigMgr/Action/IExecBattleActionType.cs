using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAF RID: 7087
	public class IExecBattleActionType
	{
		// Token: 0x06009695 RID: 38549 RVA: 0x0015E6E8 File Offset: 0x0015C8E8
		private IExecBattleActionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExecBattleActionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExecBattleActionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExecBattleActionType_SetValue());
			}
			return result;
		}

		// Token: 0x06009696 RID: 38550 RVA: 0x0015E720 File Offset: 0x0015C920
		public static IExecBattleActionType Create([Nullable(2)] IExecBattleActionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecBattleActionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009697 RID: 38551 RVA: 0x0015E733 File Offset: 0x0015C933
		public static IExecBattleActionType CreateFromSetValue([Nullable(2)] IExecBattleActionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExecBattleActionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x0015E746 File Offset: 0x0015C946
		public IExecBattleActionType_SetValue ToSetValue()
		{
			return new IExecBattleActionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x06009699 RID: 38553 RVA: 0x0015E759 File Offset: 0x0015C959
		// (set) Token: 0x0600969A RID: 38554 RVA: 0x0015E784 File Offset: 0x0015C984
		public virtual EExecBattleActionType Type
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

		// Token: 0x04005D05 RID: 23813
		[Nullable(2)]
		protected IExecBattleActionType FbInstance;

		// Token: 0x04005D06 RID: 23814
		[Nullable(2)]
		protected IExecBattleActionType_SetValue PocoInterface;
	}
}
