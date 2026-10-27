using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF2 RID: 8178
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefensePlayerOperationSpawnMonster : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600B3E2 RID: 46050 RVA: 0x001A28C8 File Offset: 0x001A0AC8
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

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x001A2900 File Offset: 0x001A0B00
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

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x001A2913 File Offset: 0x001A0B13
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

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x001A2926 File Offset: 0x001A0B26
		public new ITrapDefensePlayerOperationSpawnMonster_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationSpawnMonster_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x001A2939 File Offset: 0x001A0B39
		// (set) Token: 0x0600B3E7 RID: 46055 RVA: 0x001A2964 File Offset: 0x001A0B64
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

		// Token: 0x04006C79 RID: 27769
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationSpawnMonster FbInstance;

		// Token: 0x04006C7A RID: 27770
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationSpawnMonster_SetValue PocoInterface;
	}
}
