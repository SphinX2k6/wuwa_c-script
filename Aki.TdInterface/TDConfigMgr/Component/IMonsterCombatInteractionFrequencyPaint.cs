using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000565 RID: 1381
	public class IMonsterCombatInteractionFrequencyPaint : IMonsterCombatInteractionConfig
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x000512F0 File Offset: 0x0004F4F0
		private IMonsterCombatInteractionFrequencyPaint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterCombatInteractionFrequencyPaint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterCombatInteractionFrequencyPaint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterCombatInteractionFrequencyPaint_SetValue());
			}
			return result;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00051328 File Offset: 0x0004F528
		public static IMonsterCombatInteractionFrequencyPaint Create([Nullable(2)] IMonsterCombatInteractionFrequencyPaint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionFrequencyPaint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0005133B File Offset: 0x0004F53B
		public static IMonsterCombatInteractionFrequencyPaint CreateFromSetValue([Nullable(2)] IMonsterCombatInteractionFrequencyPaint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterCombatInteractionFrequencyPaint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0005134E File Offset: 0x0004F54E
		public new IMonsterCombatInteractionFrequencyPaint_SetValue ToSetValue()
		{
			return new IMonsterCombatInteractionFrequencyPaint_SetValue
			{
				Type = this.Type,
				FrequencyPaintTableId = this.FrequencyPaintTableId
			};
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x0005136D File Offset: 0x0004F56D
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x00051398 File Offset: 0x0004F598
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

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000513A6 File Offset: 0x0004F5A6
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x000513D1 File Offset: 0x0004F5D1
		public virtual int FrequencyPaintTableId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FrequencyPaintTableId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FrequencyPaintTableId;
			}
			set
			{
				this.GetOrCreatePoco().FrequencyPaintTableId = value;
			}
		}

		// Token: 0x04001460 RID: 5216
		[Nullable(2)]
		protected new IMonsterCombatInteractionFrequencyPaint FbInstance;

		// Token: 0x04001461 RID: 5217
		[Nullable(2)]
		protected new IMonsterCombatInteractionFrequencyPaint_SetValue PocoInterface;
	}
}
