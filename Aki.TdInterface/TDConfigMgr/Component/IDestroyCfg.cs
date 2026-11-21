using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002FA RID: 762
	public class IDestroyCfg
	{
		// Token: 0x06000E1F RID: 3615 RVA: 0x00034000 File Offset: 0x00032200
		private IDestroyCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroyCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroyCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroyCfg_SetValue());
			}
			return result;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00034038 File Offset: 0x00032238
		public static IDestroyCfg Create([Nullable(2)] IDestroyCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0003404B File Offset: 0x0003224B
		public static IDestroyCfg CreateFromSetValue([Nullable(2)] IDestroyCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroyCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0003405E File Offset: 0x0003225E
		public IDestroyCfg_SetValue ToSetValue()
		{
			return new IDestroyCfg_SetValue
			{
				Conditions = this.Conditions,
				StopPhysicAfterDestroyed = this.StopPhysicAfterDestroyed
			};
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0003407D File Offset: 0x0003227D
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000340A4 File Offset: 0x000322A4
		public virtual List<ITeleControlDestroyCondition> Conditions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Conditions;
				}
				IDestroyCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Conditions;
			}
			set
			{
				this.GetOrCreatePoco().Conditions = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000340B4 File Offset: 0x000322B4
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x000340EE File Offset: 0x000322EE
		public virtual bool? StopPhysicAfterDestroyed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopPhysicAfterDestroyed;
				}
				IDestroyCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopPhysicAfterDestroyed;
			}
			set
			{
				this.GetOrCreatePoco().StopPhysicAfterDestroyed = value;
			}
		}

		// Token: 0x04000CCF RID: 3279
		[Nullable(2)]
		protected IDestroyCfg FbInstance;

		// Token: 0x04000CD0 RID: 3280
		[Nullable(2)]
		protected IDestroyCfg_SetValue PocoInterface;
	}
}
