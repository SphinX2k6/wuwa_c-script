using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002254 RID: 8788
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600C0C6 RID: 49350 RVA: 0x001BAA08 File Offset: 0x001B8C08
		private TrapDefensePlayerOperationConstraint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TrapDefensePlayerOperationConstraint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TrapDefensePlayerOperationConstraint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TrapDefensePlayerOperationConstraint_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x001BAA40 File Offset: 0x001B8C40
		public static TrapDefensePlayerOperationConstraint Create([Nullable(2)] TrapDefensePlayerOperationConstraint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TrapDefensePlayerOperationConstraint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0C8 RID: 49352 RVA: 0x001BAA53 File Offset: 0x001B8C53
		public static TrapDefensePlayerOperationConstraint CreateFromSetValue([Nullable(2)] TrapDefensePlayerOperationConstraint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TrapDefensePlayerOperationConstraint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x001BAA66 File Offset: 0x001B8C66
		public TrapDefensePlayerOperationConstraint_SetValue ToSetValue()
		{
			return new TrapDefensePlayerOperationConstraint_SetValue
			{
				DisableOperation = this.DisableOperation,
				IsConstrained = this.IsConstrained,
				TidPromptTxt = this.TidPromptTxt,
				EdTidPromptTxt = this.EdTidPromptTxt
			};
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600C0CA RID: 49354 RVA: 0x001BAA9D File Offset: 0x001B8C9D
		// (set) Token: 0x0600C0CB RID: 49355 RVA: 0x001BAAC4 File Offset: 0x001B8CC4
		public virtual ITrapDefensePlayerOperationType DisableOperation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableOperation;
				}
				TrapDefensePlayerOperationConstraint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableOperation;
			}
			set
			{
				this.GetOrCreatePoco().DisableOperation = value;
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600C0CC RID: 49356 RVA: 0x001BAAD2 File Offset: 0x001B8CD2
		// (set) Token: 0x0600C0CD RID: 49357 RVA: 0x001BAAFD File Offset: 0x001B8CFD
		public virtual bool IsConstrained
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsConstrained;
				}
				return this.PocoInterface != null && this.PocoInterface.IsConstrained;
			}
			set
			{
				this.GetOrCreatePoco().IsConstrained = value;
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600C0CE RID: 49358 RVA: 0x001BAB0B File Offset: 0x001B8D0B
		// (set) Token: 0x0600C0CF RID: 49359 RVA: 0x001BAB36 File Offset: 0x001B8D36
		public virtual string TidPromptTxt
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidPromptTxt;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidPromptTxt;
			}
			set
			{
				this.GetOrCreatePoco().TidPromptTxt = value;
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600C0D0 RID: 49360 RVA: 0x001BAB44 File Offset: 0x001B8D44
		// (set) Token: 0x0600C0D1 RID: 49361 RVA: 0x001BAB5B File Offset: 0x001B8D5B
		[Nullable(2)]
		public virtual string EdTidPromptTxt
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidPromptTxt;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidPromptTxt = value;
			}
		}

		// Token: 0x040072E6 RID: 29414
		[Nullable(2)]
		protected new TrapDefensePlayerOperationConstraint FbInstance;

		// Token: 0x040072E7 RID: 29415
		[Nullable(2)]
		protected TrapDefensePlayerOperationConstraint_SetValue PocoInterface;
	}
}
