using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FEE RID: 8174
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefensePlayerOperationConstructTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600B3D2 RID: 46034 RVA: 0x001A2750 File Offset: 0x001A0950
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

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x001A2788 File Offset: 0x001A0988
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

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x001A279B File Offset: 0x001A099B
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

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x001A27AE File Offset: 0x001A09AE
		public new ITrapDefensePlayerOperationConstructTrap_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationConstructTrap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600B3D6 RID: 46038 RVA: 0x001A27C1 File Offset: 0x001A09C1
		// (set) Token: 0x0600B3D7 RID: 46039 RVA: 0x001A27EC File Offset: 0x001A09EC
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

		// Token: 0x04006C73 RID: 27763
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationConstructTrap FbInstance;

		// Token: 0x04006C74 RID: 27764
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationConstructTrap_SetValue PocoInterface;
	}
}
