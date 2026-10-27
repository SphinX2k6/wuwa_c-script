using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD5 RID: 4053
	[NullableContext(1)]
	[Nullable(0)]
	public class IKuroSimpleCombatKillMonsterSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005A54 RID: 23124 RVA: 0x000DB9B8 File Offset: 0x000D9BB8
		private IKuroSimpleCombatKillMonsterSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKuroSimpleCombatKillMonsterSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKuroSimpleCombatKillMonsterSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKuroSimpleCombatKillMonsterSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x000DB9F0 File Offset: 0x000D9BF0
		public static IKuroSimpleCombatKillMonsterSystemConfig Create([Nullable(2)] IKuroSimpleCombatKillMonsterSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKuroSimpleCombatKillMonsterSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x000DBA03 File Offset: 0x000D9C03
		public static IKuroSimpleCombatKillMonsterSystemConfig CreateFromSetValue([Nullable(2)] IKuroSimpleCombatKillMonsterSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKuroSimpleCombatKillMonsterSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x000DBA16 File Offset: 0x000D9C16
		public new IKuroSimpleCombatKillMonsterSystemConfig_SetValue ToSetValue()
		{
			return new IKuroSimpleCombatKillMonsterSystemConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x000DBA29 File Offset: 0x000D9C29
		// (set) Token: 0x06005A59 RID: 23129 RVA: 0x000DBA54 File Offset: 0x000D9C54
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003671 RID: 13937
		[Nullable(2)]
		protected new IKuroSimpleCombatKillMonsterSystemConfig FbInstance;

		// Token: 0x04003672 RID: 13938
		[Nullable(2)]
		protected new IKuroSimpleCombatKillMonsterSystemConfig_SetValue PocoInterface;
	}
}
