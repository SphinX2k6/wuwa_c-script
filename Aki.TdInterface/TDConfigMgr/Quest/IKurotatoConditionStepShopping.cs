using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE3 RID: 4067
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepShopping : IKurotatoConditionStepBase
	{
		// Token: 0x06005A8C RID: 23180 RVA: 0x000DBEDC File Offset: 0x000DA0DC
		private IKurotatoConditionStepShopping_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepShopping 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepShopping_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepShopping_SetValue());
			}
			return result;
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x000DBF14 File Offset: 0x000DA114
		public static IKurotatoConditionStepShopping Create([Nullable(2)] IKurotatoConditionStepShopping instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepShopping
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x000DBF27 File Offset: 0x000DA127
		public static IKurotatoConditionStepShopping CreateFromSetValue([Nullable(2)] IKurotatoConditionStepShopping_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepShopping
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x000DBF3A File Offset: 0x000DA13A
		public new IKurotatoConditionStepShopping_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepShopping_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x000DBF4D File Offset: 0x000DA14D
		// (set) Token: 0x06005A91 RID: 23185 RVA: 0x000DBF78 File Offset: 0x000DA178
		public override EKurotatoConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003686 RID: 13958
		[Nullable(2)]
		protected new IKurotatoConditionStepShopping FbInstance;

		// Token: 0x04003687 RID: 13959
		[Nullable(2)]
		protected new IKurotatoConditionStepShopping_SetValue PocoInterface;
	}
}
