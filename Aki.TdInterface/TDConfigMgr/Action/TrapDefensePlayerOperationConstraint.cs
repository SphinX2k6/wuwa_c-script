using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C1 RID: 9409
	public class TrapDefensePlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600CC8C RID: 52364 RVA: 0x001D218C File Offset: 0x001D038C
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

		// Token: 0x0600CC8D RID: 52365 RVA: 0x001D21C4 File Offset: 0x001D03C4
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

		// Token: 0x0600CC8E RID: 52366 RVA: 0x001D21D7 File Offset: 0x001D03D7
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

		// Token: 0x0600CC8F RID: 52367 RVA: 0x001D21EA File Offset: 0x001D03EA
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

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600CC90 RID: 52368 RVA: 0x001D2221 File Offset: 0x001D0421
		// (set) Token: 0x0600CC91 RID: 52369 RVA: 0x001D2248 File Offset: 0x001D0448
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

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600CC92 RID: 52370 RVA: 0x001D2256 File Offset: 0x001D0456
		// (set) Token: 0x0600CC93 RID: 52371 RVA: 0x001D2281 File Offset: 0x001D0481
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

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x001D228F File Offset: 0x001D048F
		// (set) Token: 0x0600CC95 RID: 52373 RVA: 0x001D22BA File Offset: 0x001D04BA
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

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600CC96 RID: 52374 RVA: 0x001D22C8 File Offset: 0x001D04C8
		// (set) Token: 0x0600CC97 RID: 52375 RVA: 0x001D22DF File Offset: 0x001D04DF
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

		// Token: 0x04007933 RID: 31027
		[Nullable(2)]
		protected new TrapDefensePlayerOperationConstraint FbInstance;

		// Token: 0x04007934 RID: 31028
		[Nullable(2)]
		protected TrapDefensePlayerOperationConstraint_SetValue PocoInterface;
	}
}
