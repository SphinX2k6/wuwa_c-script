using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200198B RID: 6539
	public class IBattleStateMonsterLanding : ISetBattleTagType
	{
		// Token: 0x06008B15 RID: 35605 RVA: 0x0014A2D0 File Offset: 0x001484D0
		private IBattleStateMonsterLanding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleStateMonsterLanding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleStateMonsterLanding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleStateMonsterLanding_SetValue());
			}
			return result;
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x0014A308 File Offset: 0x00148508
		public static IBattleStateMonsterLanding Create([Nullable(2)] IBattleStateMonsterLanding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateMonsterLanding
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0014A31B File Offset: 0x0014851B
		public static IBattleStateMonsterLanding CreateFromSetValue([Nullable(2)] IBattleStateMonsterLanding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleStateMonsterLanding
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x0014A32E File Offset: 0x0014852E
		public new IBattleStateMonsterLanding_SetValue ToSetValue()
		{
			return new IBattleStateMonsterLanding_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x06008B19 RID: 35609 RVA: 0x0014A341 File Offset: 0x00148541
		// (set) Token: 0x06008B1A RID: 35610 RVA: 0x0014A36C File Offset: 0x0014856C
		public override ESetBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040057E7 RID: 22503
		[Nullable(2)]
		protected new IBattleStateMonsterLanding FbInstance;

		// Token: 0x040057E8 RID: 22504
		[Nullable(2)]
		protected new IBattleStateMonsterLanding_SetValue PocoInterface;
	}
}
