using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000777 RID: 1911
	public class ISkyboxTrigger
	{
		// Token: 0x060028C6 RID: 10438 RVA: 0x0006C42C File Offset: 0x0006A62C
		private ISkyboxTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkyboxTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkyboxTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkyboxTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0006C464 File Offset: 0x0006A664
		public static ISkyboxTrigger Create([Nullable(2)] ISkyboxTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0006C477 File Offset: 0x0006A677
		public static ISkyboxTrigger CreateFromSetValue([Nullable(2)] ISkyboxTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkyboxTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0006C48A File Offset: 0x0006A68A
		public ISkyboxTrigger_SetValue ToSetValue()
		{
			return new ISkyboxTrigger_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0006C49D File Offset: 0x0006A69D
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x0006C4C8 File Offset: 0x0006A6C8
		public virtual ETriggerMode Type
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

		// Token: 0x04001BA8 RID: 7080
		[Nullable(2)]
		protected ISkyboxTrigger FbInstance;

		// Token: 0x04001BA9 RID: 7081
		[Nullable(2)]
		protected ISkyboxTrigger_SetValue PocoInterface;
	}
}
