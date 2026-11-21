using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001989 RID: 6537
	public class IBattleStateFinalMonsterLanding : ISetBattleTagType
	{
		// Token: 0x06008B0D RID: 35597 RVA: 0x0014A214 File Offset: 0x00148414
		private IBattleStateFinalMonsterLanding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleStateFinalMonsterLanding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleStateFinalMonsterLanding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleStateFinalMonsterLanding_SetValue());
			}
			return result;
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x0014A24C File Offset: 0x0014844C
		public static IBattleStateFinalMonsterLanding Create([Nullable(2)] IBattleStateFinalMonsterLanding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateFinalMonsterLanding
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x0014A25F File Offset: 0x0014845F
		public static IBattleStateFinalMonsterLanding CreateFromSetValue([Nullable(2)] IBattleStateFinalMonsterLanding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleStateFinalMonsterLanding
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x0014A272 File Offset: 0x00148472
		public new IBattleStateFinalMonsterLanding_SetValue ToSetValue()
		{
			return new IBattleStateFinalMonsterLanding_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x06008B11 RID: 35601 RVA: 0x0014A285 File Offset: 0x00148485
		// (set) Token: 0x06008B12 RID: 35602 RVA: 0x0014A2B0 File Offset: 0x001484B0
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

		// Token: 0x040057E4 RID: 22500
		[Nullable(2)]
		protected new IBattleStateFinalMonsterLanding FbInstance;

		// Token: 0x040057E5 RID: 22501
		[Nullable(2)]
		protected new IBattleStateFinalMonsterLanding_SetValue PocoInterface;
	}
}
