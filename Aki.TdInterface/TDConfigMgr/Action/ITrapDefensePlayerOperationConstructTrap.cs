using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002235 RID: 8757
	public class ITrapDefensePlayerOperationConstructTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600BEE8 RID: 48872 RVA: 0x001B8CBC File Offset: 0x001B6EBC
		private ITrapDefensePlayerOperationConstructTrap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefensePlayerOperationConstructTrap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefensePlayerOperationConstructTrap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefensePlayerOperationConstructTrap_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x001B8CF4 File Offset: 0x001B6EF4
		public static ITrapDefensePlayerOperationConstructTrap Create([Nullable(2)] ITrapDefensePlayerOperationConstructTrap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationConstructTrap
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x001B8D07 File Offset: 0x001B6F07
		public static ITrapDefensePlayerOperationConstructTrap CreateFromSetValue([Nullable(2)] ITrapDefensePlayerOperationConstructTrap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationConstructTrap
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x001B8D1A File Offset: 0x001B6F1A
		public new ITrapDefensePlayerOperationConstructTrap_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationConstructTrap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600BEEC RID: 48876 RVA: 0x001B8D2D File Offset: 0x001B6F2D
		// (set) Token: 0x0600BEED RID: 48877 RVA: 0x001B8D58 File Offset: 0x001B6F58
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007275 RID: 29301
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationConstructTrap FbInstance;

		// Token: 0x04007276 RID: 29302
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationConstructTrap_SetValue PocoInterface;
	}
}
