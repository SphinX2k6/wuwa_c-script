using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036A RID: 874
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureConditionArbitraryState : ITargetGearGroupFailureCondition
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x0003AD10 File Offset: 0x00038F10
		private IFailureConditionArbitraryState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFailureConditionArbitraryState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFailureConditionArbitraryState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFailureConditionArbitraryState_SetValue());
			}
			return result;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0003AD48 File Offset: 0x00038F48
		public static IFailureConditionArbitraryState Create([Nullable(2)] IFailureConditionArbitraryState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionArbitraryState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0003AD5B File Offset: 0x00038F5B
		public static IFailureConditionArbitraryState CreateFromSetValue([Nullable(2)] IFailureConditionArbitraryState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFailureConditionArbitraryState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0003AD6E File Offset: 0x00038F6E
		public new IFailureConditionArbitraryState_SetValue ToSetValue()
		{
			return new IFailureConditionArbitraryState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0003AD8D File Offset: 0x00038F8D
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0003ADB8 File Offset: 0x00038FB8
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0003ADC6 File Offset: 0x00038FC6
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0003ADF1 File Offset: 0x00038FF1
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

		// Token: 0x04000E4D RID: 3661
		[Nullable(2)]
		protected new IFailureConditionArbitraryState FbInstance;

		// Token: 0x04000E4E RID: 3662
		[Nullable(2)]
		protected new IFailureConditionArbitraryState_SetValue PocoInterface;
	}
}
