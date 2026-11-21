using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200198D RID: 6541
	public class IBattleStateMonsterSleep : ISetBattleTagType
	{
		// Token: 0x06008B1D RID: 35613 RVA: 0x0014A38C File Offset: 0x0014858C
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

		// Token: 0x06008B1E RID: 35614 RVA: 0x0014A3C4 File Offset: 0x001485C4
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

		// Token: 0x06008B1F RID: 35615 RVA: 0x0014A3D7 File Offset: 0x001485D7
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

		// Token: 0x06008B20 RID: 35616 RVA: 0x0014A3EA File Offset: 0x001485EA
		public new IBattleStateMonsterSleep_SetValue ToSetValue()
		{
			return new IBattleStateMonsterSleep_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x0014A3FD File Offset: 0x001485FD
		// (set) Token: 0x06008B22 RID: 35618 RVA: 0x0014A428 File Offset: 0x00148628
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

		// Token: 0x040057EA RID: 22506
		[Nullable(2)]
		protected new IBattleStateMonsterSleep FbInstance;

		// Token: 0x040057EB RID: 22507
		[Nullable(2)]
		protected new IBattleStateMonsterSleep_SetValue PocoInterface;
	}
}
