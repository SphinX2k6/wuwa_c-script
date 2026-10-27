using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE1 RID: 4065
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoConditionStepSaveRole : IKurotatoConditionStepBase
	{
		// Token: 0x06005A84 RID: 23172 RVA: 0x000DBE20 File Offset: 0x000DA020
		private IKurotatoConditionStepSaveRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepSaveRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepSaveRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepSaveRole_SetValue());
			}
			return result;
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x000DBE58 File Offset: 0x000DA058
		public static IKurotatoConditionStepSaveRole Create([Nullable(2)] IKurotatoConditionStepSaveRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepSaveRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x000DBE6B File Offset: 0x000DA06B
		public static IKurotatoConditionStepSaveRole CreateFromSetValue([Nullable(2)] IKurotatoConditionStepSaveRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepSaveRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x000DBE7E File Offset: 0x000DA07E
		public new IKurotatoConditionStepSaveRole_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepSaveRole_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06005A88 RID: 23176 RVA: 0x000DBE91 File Offset: 0x000DA091
		// (set) Token: 0x06005A89 RID: 23177 RVA: 0x000DBEBC File Offset: 0x000DA0BC
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

		// Token: 0x04003683 RID: 13955
		[Nullable(2)]
		protected new IKurotatoConditionStepSaveRole FbInstance;

		// Token: 0x04003684 RID: 13956
		[Nullable(2)]
		protected new IKurotatoConditionStepSaveRole_SetValue PocoInterface;
	}
}
