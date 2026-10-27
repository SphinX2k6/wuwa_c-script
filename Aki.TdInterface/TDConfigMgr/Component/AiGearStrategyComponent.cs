using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200001B RID: 27
	[NullableContext(1)]
	[Nullable(0)]
	public class AiGearStrategyComponent : IComponentBase
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00014D74 File Offset: 0x00012F74
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

		// Token: 0x0600008B RID: 139 RVA: 0x00014DAC File Offset: 0x00012FAC
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

		// Token: 0x0600008C RID: 140 RVA: 0x00014DBF File Offset: 0x00012FBF
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

		// Token: 0x0600008D RID: 141 RVA: 0x00014DD2 File Offset: 0x00012FD2
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
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00014E00 File Offset: 0x00013000
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00014E3A File Offset: 0x0001303A
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
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00014E48 File Offset: 0x00013048
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00014E72 File Offset: 0x00013072
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
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00014E80 File Offset: 0x00013080
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00014EA7 File Offset: 0x000130A7
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

		// Token: 0x0400005E RID: 94
		[Nullable(2)]
		protected new AiGearStrategyComponent FbInstance;

		// Token: 0x0400005F RID: 95
		[Nullable(2)]
		protected new AiGearStrategyComponent_SetValue PocoInterface;
	}
}
