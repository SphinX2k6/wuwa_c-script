using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000567 RID: 1383
	public class IMonsterCombatInteractionWaterBoxStagnation : IMonsterCombatInteractionConfig
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x000513F0 File Offset: 0x0004F5F0
		private IMonsterCombatInteractionWaterBoxStagnation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterCombatInteractionWaterBoxStagnation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterCombatInteractionWaterBoxStagnation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterCombatInteractionWaterBoxStagnation_SetValue());
			}
			return result;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00051428 File Offset: 0x0004F628
		public static IMonsterCombatInteractionWaterBoxStagnation Create([Nullable(2)] IMonsterCombatInteractionWaterBoxStagnation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionWaterBoxStagnation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0005143B File Offset: 0x0004F63B
		public static IMonsterCombatInteractionWaterBoxStagnation CreateFromSetValue([Nullable(2)] IMonsterCombatInteractionWaterBoxStagnation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionWaterBoxStagnation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0005144E File Offset: 0x0004F64E
		public new IMonsterCombatInteractionWaterBoxStagnation_SetValue ToSetValue()
		{
			return new IMonsterCombatInteractionWaterBoxStagnation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x00051461 File Offset: 0x0004F661
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0005148C File Offset: 0x0004F68C
		public override EMonsterCombatInteractionType Type
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

		// Token: 0x04001464 RID: 5220
		[Nullable(2)]
		protected new IMonsterCombatInteractionWaterBoxStagnation FbInstance;

		// Token: 0x04001465 RID: 5221
		[Nullable(2)]
		protected new IMonsterCombatInteractionWaterBoxStagnation_SetValue PocoInterface;
	}
}
