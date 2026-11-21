using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D4 RID: 2004
	public class ISuccessConditionSameSpecificState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x06002AE7 RID: 10983 RVA: 0x00070AF8 File Offset: 0x0006ECF8
		private ISuccessConditionSameSpecificState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISuccessConditionSameSpecificState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISuccessConditionSameSpecificState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISuccessConditionSameSpecificState_SetValue());
			}
			return result;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00070B30 File Offset: 0x0006ED30
		public static ISuccessConditionSameSpecificState Create([Nullable(2)] ISuccessConditionSameSpecificState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionSameSpecificState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00070B43 File Offset: 0x0006ED43
		public static ISuccessConditionSameSpecificState CreateFromSetValue([Nullable(2)] ISuccessConditionSameSpecificState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISuccessConditionSameSpecificState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00070B56 File Offset: 0x0006ED56
		public new ISuccessConditionSameSpecificState_SetValue ToSetValue()
		{
			return new ISuccessConditionSameSpecificState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x00070B75 File Offset: 0x0006ED75
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x00070BA0 File Offset: 0x0006EDA0
		public override ETargetGearGroupSuccessCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x00070BAE File Offset: 0x0006EDAE
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x00070BD9 File Offset: 0x0006EDD9
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

		// Token: 0x04001CCE RID: 7374
		[Nullable(2)]
		protected new ISuccessConditionSameSpecificState FbInstance;

		// Token: 0x04001CCF RID: 7375
		[Nullable(2)]
		protected new ISuccessConditionSameSpecificState_SetValue PocoInterface;
	}
}
