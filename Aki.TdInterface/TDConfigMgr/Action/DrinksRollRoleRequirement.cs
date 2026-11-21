using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016D0 RID: 5840
	public class DrinksRollRoleRequirement : ActionParams
	{
		// Token: 0x060082C9 RID: 33481 RVA: 0x00139490 File Offset: 0x00137690
		private DrinksRollRoleRequirement_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DrinksRollRoleRequirement 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DrinksRollRoleRequirement_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DrinksRollRoleRequirement_SetValue());
			}
			return result;
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x001394C8 File Offset: 0x001376C8
		public static DrinksRollRoleRequirement Create([Nullable(2)] DrinksRollRoleRequirement instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DrinksRollRoleRequirement
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x001394DB File Offset: 0x001376DB
		public static DrinksRollRoleRequirement CreateFromSetValue([Nullable(2)] DrinksRollRoleRequirement_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DrinksRollRoleRequirement
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x001394EE File Offset: 0x001376EE
		public DrinksRollRoleRequirement_SetValue ToSetValue()
		{
			return new DrinksRollRoleRequirement_SetValue
			{
				RoleId = this.RoleId,
				RequirementId = this.RequirementId
			};
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x060082CD RID: 33485 RVA: 0x0013950D File Offset: 0x0013770D
		// (set) Token: 0x060082CE RID: 33486 RVA: 0x00139538 File Offset: 0x00137738
		public virtual int RoleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RoleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RoleId;
			}
			set
			{
				this.GetOrCreatePoco().RoleId = value;
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x060082CF RID: 33487 RVA: 0x00139548 File Offset: 0x00137748
		// (set) Token: 0x060082D0 RID: 33488 RVA: 0x00139582 File Offset: 0x00137782
		public virtual int? RequirementId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RequirementId;
				}
				DrinksRollRoleRequirement_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RequirementId;
			}
			set
			{
				this.GetOrCreatePoco().RequirementId = value;
			}
		}

		// Token: 0x04004AF0 RID: 19184
		[Nullable(2)]
		protected new DrinksRollRoleRequirement FbInstance;

		// Token: 0x04004AF1 RID: 19185
		[Nullable(2)]
		protected DrinksRollRoleRequirement_SetValue PocoInterface;
	}
}
