using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000733 RID: 1843
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuccessConditionSameSpecificState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x00069950 File Offset: 0x00067B50
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

		// Token: 0x060027C4 RID: 10180 RVA: 0x00069988 File Offset: 0x00067B88
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

		// Token: 0x060027C5 RID: 10181 RVA: 0x0006999B File Offset: 0x00067B9B
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

		// Token: 0x060027C6 RID: 10182 RVA: 0x000699AE File Offset: 0x00067BAE
		public new ISuccessConditionSameSpecificState_SetValue ToSetValue()
		{
			return new ISuccessConditionSameSpecificState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x000699CD File Offset: 0x00067BCD
		// (set) Token: 0x060027C8 RID: 10184 RVA: 0x000699F8 File Offset: 0x00067BF8
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

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x00069A06 File Offset: 0x00067C06
		// (set) Token: 0x060027CA RID: 10186 RVA: 0x00069A31 File Offset: 0x00067C31
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

		// Token: 0x04001AC9 RID: 6857
		[Nullable(2)]
		protected new ISuccessConditionSameSpecificState FbInstance;

		// Token: 0x04001ACA RID: 6858
		[Nullable(2)]
		protected new ISuccessConditionSameSpecificState_SetValue PocoInterface;
	}
}
