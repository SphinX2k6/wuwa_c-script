using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001802 RID: 6146
	[NullableContext(1)]
	[Nullable(0)]
	public class IBattleStateMonsterLanding : ISetBattleTagType
	{
		// Token: 0x060083F9 RID: 33785 RVA: 0x0013ABE8 File Offset: 0x00138DE8
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

		// Token: 0x060083FA RID: 33786 RVA: 0x0013AC20 File Offset: 0x00138E20
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

		// Token: 0x060083FB RID: 33787 RVA: 0x0013AC33 File Offset: 0x00138E33
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

		// Token: 0x060083FC RID: 33788 RVA: 0x0013AC46 File Offset: 0x00138E46
		public new IBattleStateMonsterLanding_SetValue ToSetValue()
		{
			return new IBattleStateMonsterLanding_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x060083FD RID: 33789 RVA: 0x0013AC59 File Offset: 0x00138E59
		// (set) Token: 0x060083FE RID: 33790 RVA: 0x0013AC84 File Offset: 0x00138E84
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

		// Token: 0x0400539F RID: 21407
		[Nullable(2)]
		protected new IBattleStateMonsterLanding FbInstance;

		// Token: 0x040053A0 RID: 21408
		[Nullable(2)]
		protected new IBattleStateMonsterLanding_SetValue PocoInterface;
	}
}
