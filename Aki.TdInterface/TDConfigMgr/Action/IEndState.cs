using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B8B RID: 7051
	public class IEndState
	{
		// Token: 0x060095D3 RID: 38355 RVA: 0x0015D180 File Offset: 0x0015B380
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

		// Token: 0x060095D4 RID: 38356 RVA: 0x0015D1B8 File Offset: 0x0015B3B8
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

		// Token: 0x060095D5 RID: 38357 RVA: 0x0015D1CB File Offset: 0x0015B3CB
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

		// Token: 0x060095D6 RID: 38358 RVA: 0x0015D1DE File Offset: 0x0015B3DE
		public IEndState_SetValue ToSetValue()
		{
			return new IEndState_SetValue
			{
				StayFlowMontageActors = this.StayFlowMontageActors
			};
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x060095D7 RID: 38359 RVA: 0x0015D1F1 File Offset: 0x0015B3F1
		// (set) Token: 0x060095D8 RID: 38360 RVA: 0x0015D218 File Offset: 0x0015B418
		[Nullable(2)]
		public virtual List<int> StayFlowMontageActors
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().StayFlowMontageActors = value;
			}
		}

		// Token: 0x04005CAE RID: 23726
		[Nullable(2)]
		protected IEndState FbInstance;

		// Token: 0x04005CAF RID: 23727
		[Nullable(2)]
		protected IEndState_SetValue PocoInterface;
	}
}
