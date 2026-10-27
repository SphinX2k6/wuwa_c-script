using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014B2 RID: 5298
	[NullableContext(1)]
	[Nullable(0)]
	public class BvbPlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600789C RID: 30876 RVA: 0x0012119C File Offset: 0x0011F39C
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

		// Token: 0x0600789D RID: 30877 RVA: 0x001211D4 File Offset: 0x0011F3D4
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

		// Token: 0x0600789E RID: 30878 RVA: 0x001211E7 File Offset: 0x0011F3E7
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

		// Token: 0x0600789F RID: 30879 RVA: 0x001211FA File Offset: 0x0011F3FA
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

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x00121231 File Offset: 0x0011F431
		// (set) Token: 0x060078A1 RID: 30881 RVA: 0x00121258 File Offset: 0x0011F458
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

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00121268 File Offset: 0x0011F468
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x001212A2 File Offset: 0x0011F4A2
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

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x001212B0 File Offset: 0x0011F4B0
		// (set) Token: 0x060078A5 RID: 30885 RVA: 0x001212DB File Offset: 0x0011F4DB
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

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x001212E9 File Offset: 0x0011F4E9
		// (set) Token: 0x060078A7 RID: 30887 RVA: 0x00121300 File Offset: 0x0011F500
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

		// Token: 0x04004614 RID: 17940
		[Nullable(2)]
		protected new BvbPlayerOperationConstraint FbInstance;

		// Token: 0x04004615 RID: 17941
		[Nullable(2)]
		protected BvbPlayerOperationConstraint_SetValue PocoInterface;
	}
}
