using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000563 RID: 1379
	public class IMonsterCombatInteractionConfig
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x00051234 File Offset: 0x0004F434
		private IMonsterCombatInteractionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterCombatInteractionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterCombatInteractionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterCombatInteractionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0005126C File Offset: 0x0004F46C
		public static IMonsterCombatInteractionConfig Create([Nullable(2)] IMonsterCombatInteractionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0005127F File Offset: 0x0004F47F
		public static IMonsterCombatInteractionConfig CreateFromSetValue([Nullable(2)] IMonsterCombatInteractionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00051292 File Offset: 0x0004F492
		public IMonsterCombatInteractionConfig_SetValue ToSetValue()
		{
			return new IMonsterCombatInteractionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000512A5 File Offset: 0x0004F4A5
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x000512D0 File Offset: 0x0004F4D0
		public virtual EMonsterCombatInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterCombatInteractionType.WaterBoxStagnation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400145D RID: 5213
		[Nullable(2)]
		protected IMonsterCombatInteractionConfig FbInstance;

		// Token: 0x0400145E RID: 5214
		[Nullable(2)]
		protected IMonsterCombatInteractionConfig_SetValue PocoInterface;
	}
}
