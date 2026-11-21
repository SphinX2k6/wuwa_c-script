using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000362 RID: 866
	public class IEntityGroupFailureArbitraryState : IEntityGroupFailureCondition
	{
		// Token: 0x060010D2 RID: 4306 RVA: 0x0003A27C File Offset: 0x0003847C
		private IEntityGroupFailureArbitraryState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityGroupFailureArbitraryState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityGroupFailureArbitraryState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityGroupFailureArbitraryState_SetValue());
			}
			return result;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0003A2B4 File Offset: 0x000384B4
		public static IEntityGroupFailureArbitraryState Create([Nullable(2)] IEntityGroupFailureArbitraryState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureArbitraryState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0003A2C7 File Offset: 0x000384C7
		public static IEntityGroupFailureArbitraryState CreateFromSetValue([Nullable(2)] IEntityGroupFailureArbitraryState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityGroupFailureArbitraryState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003A2DA File Offset: 0x000384DA
		public new IEntityGroupFailureArbitraryState_SetValue ToSetValue()
		{
			return new IEntityGroupFailureArbitraryState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0003A2F9 File Offset: 0x000384F9
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x0003A324 File Offset: 0x00038524
		public override EEntityGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityGroupFailureCondition.SequentialState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0003A332 File Offset: 0x00038532
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x0003A35D File Offset: 0x0003855D
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

		// Token: 0x04000E46 RID: 3654
		[Nullable(2)]
		protected new IEntityGroupFailureArbitraryState FbInstance;

		// Token: 0x04000E47 RID: 3655
		[Nullable(2)]
		protected new IEntityGroupFailureArbitraryState_SetValue PocoInterface;
	}
}
