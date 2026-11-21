using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001101 RID: 4353
	public class IKuroSimpleCombatKillMonsterSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006034 RID: 24628 RVA: 0x000E85F8 File Offset: 0x000E67F8
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

		// Token: 0x06006035 RID: 24629 RVA: 0x000E8630 File Offset: 0x000E6830
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

		// Token: 0x06006036 RID: 24630 RVA: 0x000E8643 File Offset: 0x000E6843
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

		// Token: 0x06006037 RID: 24631 RVA: 0x000E8656 File Offset: 0x000E6856
		public new IKuroSimpleCombatKillMonsterSystemConfig_SetValue ToSetValue()
		{
			return new IKuroSimpleCombatKillMonsterSystemConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06006038 RID: 24632 RVA: 0x000E8669 File Offset: 0x000E6869
		// (set) Token: 0x06006039 RID: 24633 RVA: 0x000E8694 File Offset: 0x000E6894
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

		// Token: 0x040039A9 RID: 14761
		[Nullable(2)]
		protected new IKuroSimpleCombatKillMonsterSystemConfig FbInstance;

		// Token: 0x040039AA RID: 14762
		[Nullable(2)]
		protected new IKuroSimpleCombatKillMonsterSystemConfig_SetValue PocoInterface;
	}
}
