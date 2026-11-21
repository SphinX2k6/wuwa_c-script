using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002221 RID: 8737
	public class ITraceTracingMaxStepRewardRuleItem
	{
		// Token: 0x0600BE7E RID: 48766 RVA: 0x001B80A4 File Offset: 0x001B62A4
		private ITraceTracingMaxStepRewardRuleItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITraceTracingMaxStepRewardRuleItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITraceTracingMaxStepRewardRuleItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITraceTracingMaxStepRewardRuleItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x001B80DC File Offset: 0x001B62DC
		public static ITraceTracingMaxStepRewardRuleItem Create([Nullable(2)] ITraceTracingMaxStepRewardRuleItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITraceTracingMaxStepRewardRuleItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE80 RID: 48768 RVA: 0x001B80EF File Offset: 0x001B62EF
		public static ITraceTracingMaxStepRewardRuleItem CreateFromSetValue([Nullable(2)] ITraceTracingMaxStepRewardRuleItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITraceTracingMaxStepRewardRuleItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x001B8102 File Offset: 0x001B6302
		public ITraceTracingMaxStepRewardRuleItem_SetValue ToSetValue()
		{
			return new ITraceTracingMaxStepRewardRuleItem_SetValue
			{
				RestartCount = this.RestartCount,
				AddStep = this.AddStep
			};
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600BE82 RID: 48770 RVA: 0x001B8121 File Offset: 0x001B6321
		// (set) Token: 0x0600BE83 RID: 48771 RVA: 0x001B814C File Offset: 0x001B634C
		public virtual int RestartCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RestartCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RestartCount;
			}
			set
			{
				this.GetOrCreatePoco().RestartCount = value;
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600BE84 RID: 48772 RVA: 0x001B815A File Offset: 0x001B635A
		// (set) Token: 0x0600BE85 RID: 48773 RVA: 0x001B8185 File Offset: 0x001B6385
		public virtual int AddStep
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddStep;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddStep;
			}
			set
			{
				this.GetOrCreatePoco().AddStep = value;
			}
		}

		// Token: 0x04007240 RID: 29248
		[Nullable(2)]
		protected ITraceTracingMaxStepRewardRuleItem FbInstance;

		// Token: 0x04007241 RID: 29249
		[Nullable(2)]
		protected ITraceTracingMaxStepRewardRuleItem_SetValue PocoInterface;
	}
}
