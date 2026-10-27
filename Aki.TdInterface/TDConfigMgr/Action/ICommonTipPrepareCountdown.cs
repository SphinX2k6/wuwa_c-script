using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001922 RID: 6434
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipPrepareCountdown : ICommonTipType
	{
		// Token: 0x060089F1 RID: 35313 RVA: 0x0014546C File Offset: 0x0014366C
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

		// Token: 0x060089F2 RID: 35314 RVA: 0x001454A4 File Offset: 0x001436A4
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

		// Token: 0x060089F3 RID: 35315 RVA: 0x001454B7 File Offset: 0x001436B7
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

		// Token: 0x060089F4 RID: 35316 RVA: 0x001454CA File Offset: 0x001436CA
		public new ICommonTipPrepareCountdown_SetValue ToSetValue()
		{
			return new ICommonTipPrepareCountdown_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x060089F5 RID: 35317 RVA: 0x001454DD File Offset: 0x001436DD
		// (set) Token: 0x060089F6 RID: 35318 RVA: 0x00145508 File Offset: 0x00143708
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

		// Token: 0x04005653 RID: 22099
		[Nullable(2)]
		protected new ICommonTipPrepareCountdown FbInstance;

		// Token: 0x04005654 RID: 22100
		[Nullable(2)]
		protected new ICommonTipPrepareCountdown_SetValue PocoInterface;
	}
}
