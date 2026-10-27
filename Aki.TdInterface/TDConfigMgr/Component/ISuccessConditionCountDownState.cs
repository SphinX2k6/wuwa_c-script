using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072F RID: 1839
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuccessConditionCountDownState : ITargetGearGroupSuccessContdion
	{
		// Token: 0x060027B3 RID: 10163 RVA: 0x000697D8 File Offset: 0x000679D8
		private ISuccessConditionCountDownState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISuccessConditionCountDownState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISuccessConditionCountDownState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISuccessConditionCountDownState_SetValue());
			}
			return result;
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00069810 File Offset: 0x00067A10
		public static ISuccessConditionCountDownState Create([Nullable(2)] ISuccessConditionCountDownState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuccessConditionCountDownState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00069823 File Offset: 0x00067A23
		public static ISuccessConditionCountDownState CreateFromSetValue([Nullable(2)] ISuccessConditionCountDownState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISuccessConditionCountDownState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00069836 File Offset: 0x00067A36
		public new ISuccessConditionCountDownState_SetValue ToSetValue()
		{
			return new ISuccessConditionCountDownState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x00069849 File Offset: 0x00067A49
		// (set) Token: 0x060027B8 RID: 10168 RVA: 0x00069874 File Offset: 0x00067A74
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

		// Token: 0x04001AC3 RID: 6851
		[Nullable(2)]
		protected new ISuccessConditionCountDownState FbInstance;

		// Token: 0x04001AC4 RID: 6852
		[Nullable(2)]
		protected new ISuccessConditionCountDownState_SetValue PocoInterface;
	}
}
