using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001994 RID: 6548
	[NullableContext(1)]
	[Nullable(0)]
	public class IDetectBattleMonsterOnGround : IDetectBattleTagType
	{
		// Token: 0x06008C29 RID: 35881 RVA: 0x001490A0 File Offset: 0x001472A0
		private IDetectBattleMonsterOnGround_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDetectBattleMonsterOnGround 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDetectBattleMonsterOnGround_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDetectBattleMonsterOnGround_SetValue());
			}
			return result;
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x001490D8 File Offset: 0x001472D8
		public static IDetectBattleMonsterOnGround Create([Nullable(2)] IDetectBattleMonsterOnGround instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleMonsterOnGround
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x001490EB File Offset: 0x001472EB
		public static IDetectBattleMonsterOnGround CreateFromSetValue([Nullable(2)] IDetectBattleMonsterOnGround_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDetectBattleMonsterOnGround
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x001490FE File Offset: 0x001472FE
		public new IDetectBattleMonsterOnGround_SetValue ToSetValue()
		{
			return new IDetectBattleMonsterOnGround_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x06008C2D RID: 35885 RVA: 0x00149111 File Offset: 0x00147311
		// (set) Token: 0x06008C2E RID: 35886 RVA: 0x0014913C File Offset: 0x0014733C
		public override EDetectBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDetectBattleTagType.MonsterOnTheGround;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400574C RID: 22348
		[Nullable(2)]
		protected new IDetectBattleMonsterOnGround FbInstance;

		// Token: 0x0400574D RID: 22349
		[Nullable(2)]
		protected new IDetectBattleMonsterOnGround_SetValue PocoInterface;
	}
}
