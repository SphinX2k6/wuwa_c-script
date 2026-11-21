using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001300 RID: 4864
	public class ITrackRuleFindFirstNotMatchState : ITrackRuleTypeBase
	{
		// Token: 0x06006DA5 RID: 28069 RVA: 0x00105254 File Offset: 0x00103454
		private ITrackRuleFindFirstNotMatchState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackRuleFindFirstNotMatchState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackRuleFindFirstNotMatchState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackRuleFindFirstNotMatchState_SetValue());
			}
			return result;
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x0010528C File Offset: 0x0010348C
		public static ITrackRuleFindFirstNotMatchState Create([Nullable(2)] ITrackRuleFindFirstNotMatchState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleFindFirstNotMatchState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x0010529F File Offset: 0x0010349F
		public static ITrackRuleFindFirstNotMatchState CreateFromSetValue([Nullable(2)] ITrackRuleFindFirstNotMatchState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackRuleFindFirstNotMatchState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x001052B2 File Offset: 0x001034B2
		public new ITrackRuleFindFirstNotMatchState_SetValue ToSetValue()
		{
			return new ITrackRuleFindFirstNotMatchState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x001052D1 File Offset: 0x001034D1
		// (set) Token: 0x06006DAA RID: 28074 RVA: 0x001052FC File Offset: 0x001034FC
		public override ETrackRuleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackRuleType.FindLastMatchState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06006DAB RID: 28075 RVA: 0x0010530A File Offset: 0x0010350A
		// (set) Token: 0x06006DAC RID: 28076 RVA: 0x00105335 File Offset: 0x00103535
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04004180 RID: 16768
		[Nullable(2)]
		protected new ITrackRuleFindFirstNotMatchState FbInstance;

		// Token: 0x04004181 RID: 16769
		[Nullable(2)]
		protected new ITrackRuleFindFirstNotMatchState_SetValue PocoInterface;
	}
}
