using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A9 RID: 8617
	public class ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600BBF0 RID: 48112 RVA: 0x001B3784 File Offset: 0x001B1984
		private ITalkOptionConditionSystemConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionConditionSystemConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionConditionSystemConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionConditionSystemConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x001B37BC File Offset: 0x001B19BC
		public static ITalkOptionConditionSystemConfigBase Create([Nullable(2)] ITalkOptionConditionSystemConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionConditionSystemConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBF2 RID: 48114 RVA: 0x001B37CF File Offset: 0x001B19CF
		public static ITalkOptionConditionSystemConfigBase CreateFromSetValue([Nullable(2)] ITalkOptionConditionSystemConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionConditionSystemConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBF3 RID: 48115 RVA: 0x001B37E2 File Offset: 0x001B19E2
		public ITalkOptionConditionSystemConfigBase_SetValue ToSetValue()
		{
			return new ITalkOptionConditionSystemConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x001B37F5 File Offset: 0x001B19F5
		// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x001B3820 File Offset: 0x001B1A20
		public virtual ETalkOptionConditionSystem Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionConditionSystem.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007111 RID: 28945
		[Nullable(2)]
		protected ITalkOptionConditionSystemConfigBase FbInstance;

		// Token: 0x04007112 RID: 28946
		[Nullable(2)]
		protected ITalkOptionConditionSystemConfigBase_SetValue PocoInterface;
	}
}
