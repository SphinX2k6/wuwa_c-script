using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001884 RID: 6276
	public class ExecAlertSystemAction : ActionParams
	{
		// Token: 0x060083D5 RID: 33749 RVA: 0x0013B304 File Offset: 0x00139504
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

		// Token: 0x060083D6 RID: 33750 RVA: 0x0013B33C File Offset: 0x0013953C
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

		// Token: 0x060083D7 RID: 33751 RVA: 0x0013B34F File Offset: 0x0013954F
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

		// Token: 0x060083D8 RID: 33752 RVA: 0x0013B362 File Offset: 0x00139562
		public ExecAlertSystemAction_SetValue ToSetValue()
		{
			return new ExecAlertSystemAction_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x060083D9 RID: 33753 RVA: 0x0013B375 File Offset: 0x00139575
		// (set) Token: 0x060083DA RID: 33754 RVA: 0x0013B39C File Offset: 0x0013959C
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

		// Token: 0x04005405 RID: 21509
		[Nullable(2)]
		protected new ExecAlertSystemAction FbInstance;

		// Token: 0x04005406 RID: 21510
		[Nullable(2)]
		protected ExecAlertSystemAction_SetValue PocoInterface;
	}
}
