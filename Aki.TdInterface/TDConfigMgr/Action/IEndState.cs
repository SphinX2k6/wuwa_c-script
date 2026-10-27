using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F8 RID: 6648
	[NullableContext(2)]
	[Nullable(0)]
	public class IEndState
	{
		// Token: 0x06008E71 RID: 36465 RVA: 0x0014D310 File Offset: 0x0014B510
		[NullableContext(1)]
		private IEndState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEndState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEndState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEndState_SetValue());
			}
			return result;
		}

		// Token: 0x06008E72 RID: 36466 RVA: 0x0014D348 File Offset: 0x0014B548
		[NullableContext(1)]
		public static IEndState Create([Nullable(2)] IEndState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEndState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E73 RID: 36467 RVA: 0x0014D35B File Offset: 0x0014B55B
		[NullableContext(1)]
		public static IEndState CreateFromSetValue([Nullable(2)] IEndState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEndState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E74 RID: 36468 RVA: 0x0014D36E File Offset: 0x0014B56E
		[NullableContext(1)]
		public IEndState_SetValue ToSetValue()
		{
			return new IEndState_SetValue
			{
				StayFlowMontageActors = this.StayFlowMontageActors
			};
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x06008E75 RID: 36469 RVA: 0x0014D381 File Offset: 0x0014B581
		// (set) Token: 0x06008E76 RID: 36470 RVA: 0x0014D3A8 File Offset: 0x0014B5A8
		public virtual List<int> StayFlowMontageActors
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StayFlowMontageActors;
				}
				IEndState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StayFlowMontageActors;
			}
			set
			{
				this.GetOrCreatePoco().StayFlowMontageActors = value;
			}
		}

		// Token: 0x0400584C RID: 22604
		protected IEndState FbInstance;

		// Token: 0x0400584D RID: 22605
		protected IEndState_SetValue PocoInterface;
	}
}
