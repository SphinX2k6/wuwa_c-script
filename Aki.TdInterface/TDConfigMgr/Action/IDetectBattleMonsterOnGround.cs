using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B1B RID: 6939
	public class IDetectBattleMonsterOnGround : IDetectBattleTagType
	{
		// Token: 0x0600934D RID: 37709 RVA: 0x001588B0 File Offset: 0x00156AB0
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

		// Token: 0x0600934E RID: 37710 RVA: 0x001588E8 File Offset: 0x00156AE8
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

		// Token: 0x0600934F RID: 37711 RVA: 0x001588FB File Offset: 0x00156AFB
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

		// Token: 0x06009350 RID: 37712 RVA: 0x0015890E File Offset: 0x00156B0E
		public new IDetectBattleMonsterOnGround_SetValue ToSetValue()
		{
			return new IDetectBattleMonsterOnGround_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x00158921 File Offset: 0x00156B21
		// (set) Token: 0x06009352 RID: 37714 RVA: 0x0015894C File Offset: 0x00156B4C
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

		// Token: 0x04005B95 RID: 23445
		[Nullable(2)]
		protected new IDetectBattleMonsterOnGround FbInstance;

		// Token: 0x04005B96 RID: 23446
		[Nullable(2)]
		protected new IDetectBattleMonsterOnGround_SetValue PocoInterface;
	}
}
