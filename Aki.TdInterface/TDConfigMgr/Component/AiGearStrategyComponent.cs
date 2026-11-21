using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200001B RID: 27
	public class AiGearStrategyComponent : IComponentBase
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00015620 File Offset: 0x00013820
		private AiGearStrategyComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AiGearStrategyComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AiGearStrategyComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AiGearStrategyComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00015658 File Offset: 0x00013858
		public static AiGearStrategyComponent Create([Nullable(2)] AiGearStrategyComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AiGearStrategyComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001566B File Offset: 0x0001386B
		public static AiGearStrategyComponent CreateFromSetValue([Nullable(2)] AiGearStrategyComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AiGearStrategyComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0001567E File Offset: 0x0001387E
		public new AiGearStrategyComponent_SetValue ToSetValue()
		{
			return new AiGearStrategyComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				StrategyType = this.StrategyType
			};
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000156AC File Offset: 0x000138AC
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000156E6 File Offset: 0x000138E6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AiGearStrategyComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000156F4 File Offset: 0x000138F4
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0001571E File Offset: 0x0001391E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0001572C File Offset: 0x0001392C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00015753 File Offset: 0x00013953
		public virtual IAiGearStrategy StrategyType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StrategyType;
				}
				AiGearStrategyComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StrategyType;
			}
			set
			{
				this.GetOrCreatePoco().StrategyType = value;
			}
		}

		// Token: 0x0400005F RID: 95
		[Nullable(2)]
		protected new AiGearStrategyComponent FbInstance;

		// Token: 0x04000060 RID: 96
		[Nullable(2)]
		protected new AiGearStrategyComponent_SetValue PocoInterface;
	}
}
