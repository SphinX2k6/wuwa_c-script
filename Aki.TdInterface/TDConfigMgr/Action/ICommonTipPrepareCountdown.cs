using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AAB RID: 6827
	public class ICommonTipPrepareCountdown : ICommonTipType
	{
		// Token: 0x0600911D RID: 37149 RVA: 0x00154DAC File Offset: 0x00152FAC
		private ICommonTipPrepareCountdown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipPrepareCountdown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipPrepareCountdown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipPrepareCountdown_SetValue());
			}
			return result;
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x00154DE4 File Offset: 0x00152FE4
		public static ICommonTipPrepareCountdown Create([Nullable(2)] ICommonTipPrepareCountdown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipPrepareCountdown
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x00154DF7 File Offset: 0x00152FF7
		public static ICommonTipPrepareCountdown CreateFromSetValue([Nullable(2)] ICommonTipPrepareCountdown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipPrepareCountdown
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009120 RID: 37152 RVA: 0x00154E0A File Offset: 0x0015300A
		public new ICommonTipPrepareCountdown_SetValue ToSetValue()
		{
			return new ICommonTipPrepareCountdown_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x06009121 RID: 37153 RVA: 0x00154E1D File Offset: 0x0015301D
		// (set) Token: 0x06009122 RID: 37154 RVA: 0x00154E48 File Offset: 0x00153048
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AA3 RID: 23203
		[Nullable(2)]
		protected new ICommonTipPrepareCountdown FbInstance;

		// Token: 0x04005AA4 RID: 23204
		[Nullable(2)]
		protected new ICommonTipPrepareCountdown_SetValue PocoInterface;
	}
}
