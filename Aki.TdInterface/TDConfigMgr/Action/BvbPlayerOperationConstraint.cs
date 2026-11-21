using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200160B RID: 5643
	public class BvbPlayerOperationConstraint : ActionParams
	{
		// Token: 0x06007F69 RID: 32617 RVA: 0x0012FDE8 File Offset: 0x0012DFE8
		private BvbPlayerOperationConstraint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BvbPlayerOperationConstraint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BvbPlayerOperationConstraint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BvbPlayerOperationConstraint_SetValue());
			}
			return result;
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x0012FE20 File Offset: 0x0012E020
		public static BvbPlayerOperationConstraint Create([Nullable(2)] BvbPlayerOperationConstraint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbPlayerOperationConstraint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x0012FE33 File Offset: 0x0012E033
		public static BvbPlayerOperationConstraint CreateFromSetValue([Nullable(2)] BvbPlayerOperationConstraint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BvbPlayerOperationConstraint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x0012FE46 File Offset: 0x0012E046
		public BvbPlayerOperationConstraint_SetValue ToSetValue()
		{
			return new BvbPlayerOperationConstraint_SetValue
			{
				EnableOperation = this.EnableOperation,
				IsTheLast = this.IsTheLast,
				TidPromptTxt = this.TidPromptTxt,
				EdTidPromptTxt = this.EdTidPromptTxt
			};
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x0012FE7D File Offset: 0x0012E07D
		// (set) Token: 0x06007F6E RID: 32622 RVA: 0x0012FEA4 File Offset: 0x0012E0A4
		public virtual IBvbPlayerOperationType EnableOperation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableOperation;
				}
				BvbPlayerOperationConstraint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableOperation;
			}
			set
			{
				this.GetOrCreatePoco().EnableOperation = value;
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x0012FEB4 File Offset: 0x0012E0B4
		// (set) Token: 0x06007F70 RID: 32624 RVA: 0x0012FEEE File Offset: 0x0012E0EE
		public virtual bool? IsTheLast
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsTheLast;
				}
				BvbPlayerOperationConstraint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsTheLast;
			}
			set
			{
				this.GetOrCreatePoco().IsTheLast = value;
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x0012FEFC File Offset: 0x0012E0FC
		// (set) Token: 0x06007F72 RID: 32626 RVA: 0x0012FF27 File Offset: 0x0012E127
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

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x06007F73 RID: 32627 RVA: 0x0012FF35 File Offset: 0x0012E135
		// (set) Token: 0x06007F74 RID: 32628 RVA: 0x0012FF4C File Offset: 0x0012E14C
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

		// Token: 0x040049AF RID: 18863
		[Nullable(2)]
		protected new BvbPlayerOperationConstraint FbInstance;

		// Token: 0x040049B0 RID: 18864
		[Nullable(2)]
		protected BvbPlayerOperationConstraint_SetValue PocoInterface;
	}
}
