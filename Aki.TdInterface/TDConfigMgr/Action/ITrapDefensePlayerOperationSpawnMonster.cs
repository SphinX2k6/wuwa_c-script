using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002239 RID: 8761
	public class ITrapDefensePlayerOperationSpawnMonster : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600BEF8 RID: 48888 RVA: 0x001B8E34 File Offset: 0x001B7034
		private ITrapDefensePlayerOperationSpawnMonster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefensePlayerOperationSpawnMonster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefensePlayerOperationSpawnMonster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefensePlayerOperationSpawnMonster_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x001B8E6C File Offset: 0x001B706C
		public static ITrapDefensePlayerOperationSpawnMonster Create([Nullable(2)] ITrapDefensePlayerOperationSpawnMonster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationSpawnMonster
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x001B8E7F File Offset: 0x001B707F
		public static ITrapDefensePlayerOperationSpawnMonster CreateFromSetValue([Nullable(2)] ITrapDefensePlayerOperationSpawnMonster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationSpawnMonster
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x001B8E92 File Offset: 0x001B7092
		public new ITrapDefensePlayerOperationSpawnMonster_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationSpawnMonster_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0600BEFC RID: 48892 RVA: 0x001B8EA5 File Offset: 0x001B70A5
		// (set) Token: 0x0600BEFD RID: 48893 RVA: 0x001B8ED0 File Offset: 0x001B70D0
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

		// Token: 0x0400727B RID: 29307
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationSpawnMonster FbInstance;

		// Token: 0x0400727C RID: 29308
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationSpawnMonster_SetValue PocoInterface;
	}
}
