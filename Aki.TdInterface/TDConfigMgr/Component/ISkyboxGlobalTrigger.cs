using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000775 RID: 1909
	public class ISkyboxGlobalTrigger : ISkyboxTrigger
	{
		// Token: 0x060028BE RID: 10430 RVA: 0x0006C370 File Offset: 0x0006A570
		private ISkyboxGlobalTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkyboxGlobalTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkyboxGlobalTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkyboxGlobalTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		public static ISkyboxGlobalTrigger Create([Nullable(2)] ISkyboxGlobalTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxGlobalTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0006C3BB File Offset: 0x0006A5BB
		public static ISkyboxGlobalTrigger CreateFromSetValue([Nullable(2)] ISkyboxGlobalTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkyboxGlobalTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0006C3CE File Offset: 0x0006A5CE
		public new ISkyboxGlobalTrigger_SetValue ToSetValue()
		{
			return new ISkyboxGlobalTrigger_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x0006C3E1 File Offset: 0x0006A5E1
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x0006C40C File Offset: 0x0006A60C
		public override ETriggerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETriggerMode.Distance;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BA5 RID: 7077
		[Nullable(2)]
		protected new ISkyboxGlobalTrigger FbInstance;

		// Token: 0x04001BA6 RID: 7078
		[Nullable(2)]
		protected new ISkyboxGlobalTrigger_SetValue PocoInterface;
	}
}
