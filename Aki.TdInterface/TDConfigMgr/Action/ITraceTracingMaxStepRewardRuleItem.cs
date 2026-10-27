using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FDA RID: 8154
	[NullableContext(1)]
	[Nullable(0)]
	public class ITraceTracingMaxStepRewardRuleItem
	{
		// Token: 0x0600B368 RID: 45928 RVA: 0x001A1B38 File Offset: 0x0019FD38
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

		// Token: 0x0600B369 RID: 45929 RVA: 0x001A1B70 File Offset: 0x0019FD70
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

		// Token: 0x0600B36A RID: 45930 RVA: 0x001A1B83 File Offset: 0x0019FD83
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

		// Token: 0x0600B36B RID: 45931 RVA: 0x001A1B96 File Offset: 0x0019FD96
		public ITraceTracingMaxStepRewardRuleItem_SetValue ToSetValue()
		{
			return new ITraceTracingMaxStepRewardRuleItem_SetValue
			{
				RestartCount = this.RestartCount,
				AddStep = this.AddStep
			};
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600B36C RID: 45932 RVA: 0x001A1BB5 File Offset: 0x0019FDB5
		// (set) Token: 0x0600B36D RID: 45933 RVA: 0x001A1BE0 File Offset: 0x0019FDE0
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

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600B36E RID: 45934 RVA: 0x001A1BEE File Offset: 0x0019FDEE
		// (set) Token: 0x0600B36F RID: 45935 RVA: 0x001A1C19 File Offset: 0x0019FE19
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

		// Token: 0x04006C3E RID: 27710
		[Nullable(2)]
		protected ITraceTracingMaxStepRewardRuleItem FbInstance;

		// Token: 0x04006C3F RID: 27711
		[Nullable(2)]
		protected ITraceTracingMaxStepRewardRuleItem_SetValue PocoInterface;
	}
}
