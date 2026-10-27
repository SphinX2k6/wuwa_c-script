using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001572 RID: 5490
	[NullableContext(1)]
	[Nullable(0)]
	public class DrinksRollRoleRequirement : ActionParams
	{
		// Token: 0x06007BEB RID: 31723 RVA: 0x0012A3E4 File Offset: 0x001285E4
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

		// Token: 0x06007BEC RID: 31724 RVA: 0x0012A41C File Offset: 0x0012861C
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

		// Token: 0x06007BED RID: 31725 RVA: 0x0012A42F File Offset: 0x0012862F
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

		// Token: 0x06007BEE RID: 31726 RVA: 0x0012A442 File Offset: 0x00128642
		public DrinksRollRoleRequirement_SetValue ToSetValue()
		{
			return new DrinksRollRoleRequirement_SetValue
			{
				RoleId = this.RoleId,
				RequirementId = this.RequirementId
			};
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x0012A461 File Offset: 0x00128661
		// (set) Token: 0x06007BF0 RID: 31728 RVA: 0x0012A48C File Offset: 0x0012868C
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

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x06007BF1 RID: 31729 RVA: 0x0012A49C File Offset: 0x0012869C
		// (set) Token: 0x06007BF2 RID: 31730 RVA: 0x0012A4D6 File Offset: 0x001286D6
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

		// Token: 0x04004750 RID: 18256
		[Nullable(2)]
		protected new DrinksRollRoleRequirement FbInstance;

		// Token: 0x04004751 RID: 18257
		[Nullable(2)]
		protected DrinksRollRoleRequirement_SetValue PocoInterface;
	}
}
