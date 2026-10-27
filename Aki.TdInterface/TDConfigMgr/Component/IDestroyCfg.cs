using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B3 RID: 691
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroyCfg
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x000310CC File Offset: 0x0002F2CC
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

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00031104 File Offset: 0x0002F304
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

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00031117 File Offset: 0x0002F317
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

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003112A File Offset: 0x0002F32A
		public IDestroyCfg_SetValue ToSetValue()
		{
			return new IDestroyCfg_SetValue
			{
				Conditions = this.Conditions,
				StopPhysicAfterDestroyed = this.StopPhysicAfterDestroyed
			};
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00031149 File Offset: 0x0002F349
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00031170 File Offset: 0x0002F370
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

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00031180 File Offset: 0x0002F380
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x000311BA File Offset: 0x0002F3BA
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

		// Token: 0x04000BE5 RID: 3045
		[Nullable(2)]
		protected IDestroyCfg FbInstance;

		// Token: 0x04000BE6 RID: 3046
		[Nullable(2)]
		protected IDestroyCfg_SetValue PocoInterface;
	}
}
