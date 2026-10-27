using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001804 RID: 6148
	[NullableContext(1)]
	[Nullable(0)]
	public class IBattleStateMonsterSleep : ISetBattleTagType
	{
		// Token: 0x06008401 RID: 33793 RVA: 0x0013ACA4 File Offset: 0x00138EA4
		private IBattleStateMonsterSleep_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleStateMonsterSleep 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleStateMonsterSleep_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleStateMonsterSleep_SetValue());
			}
			return result;
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x0013ACDC File Offset: 0x00138EDC
		public static IBattleStateMonsterSleep Create([Nullable(2)] IBattleStateMonsterSleep instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateMonsterSleep
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x0013ACEF File Offset: 0x00138EEF
		public static IBattleStateMonsterSleep CreateFromSetValue([Nullable(2)] IBattleStateMonsterSleep_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleStateMonsterSleep
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x0013AD02 File Offset: 0x00138F02
		public new IBattleStateMonsterSleep_SetValue ToSetValue()
		{
			return new IBattleStateMonsterSleep_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x0013AD15 File Offset: 0x00138F15
		// (set) Token: 0x06008406 RID: 33798 RVA: 0x0013AD40 File Offset: 0x00138F40
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

		// Token: 0x040053A2 RID: 21410
		[Nullable(2)]
		protected new IBattleStateMonsterSleep FbInstance;

		// Token: 0x040053A3 RID: 21411
		[Nullable(2)]
		protected new IBattleStateMonsterSleep_SetValue PocoInterface;
	}
}
