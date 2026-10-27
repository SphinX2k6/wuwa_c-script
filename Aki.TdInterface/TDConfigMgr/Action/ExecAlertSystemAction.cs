using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001707 RID: 5895
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecAlertSystemAction : ActionParams
	{
		// Token: 0x06007CF7 RID: 31991 RVA: 0x0012C258 File Offset: 0x0012A458
		private ExecAlertSystemAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecAlertSystemAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecAlertSystemAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecAlertSystemAction_SetValue());
			}
			return result;
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x0012C290 File Offset: 0x0012A490
		public static ExecAlertSystemAction Create([Nullable(2)] ExecAlertSystemAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecAlertSystemAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x0012C2A3 File Offset: 0x0012A4A3
		public static ExecAlertSystemAction CreateFromSetValue([Nullable(2)] ExecAlertSystemAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecAlertSystemAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x0012C2B6 File Offset: 0x0012A4B6
		public ExecAlertSystemAction_SetValue ToSetValue()
		{
			return new ExecAlertSystemAction_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x06007CFB RID: 31995 RVA: 0x0012C2C9 File Offset: 0x0012A4C9
		// (set) Token: 0x06007CFC RID: 31996 RVA: 0x0012C2F0 File Offset: 0x0012A4F0
		public virtual IAlertSystemOption Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				ExecAlertSystemAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x04004FD6 RID: 20438
		[Nullable(2)]
		protected new ExecAlertSystemAction FbInstance;

		// Token: 0x04004FD7 RID: 20439
		[Nullable(2)]
		protected ExecAlertSystemAction_SetValue PocoInterface;
	}
}
