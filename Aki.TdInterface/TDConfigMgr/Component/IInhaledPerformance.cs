using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B9 RID: 1209
	public class IInhaledPerformance
	{
		// Token: 0x06001839 RID: 6201 RVA: 0x00049664 File Offset: 0x00047864
		private IInhaledPerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhaledPerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhaledPerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhaledPerformance_SetValue());
			}
			return result;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0004969C File Offset: 0x0004789C
		public static IInhaledPerformance Create([Nullable(2)] IInhaledPerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x000496AF File Offset: 0x000478AF
		public static IInhaledPerformance CreateFromSetValue([Nullable(2)] IInhaledPerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhaledPerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x000496C2 File Offset: 0x000478C2
		public IInhaledPerformance_SetValue ToSetValue()
		{
			return new IInhaledPerformance_SetValue
			{
				InhaledTime = this.InhaledTime
			};
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x000496D5 File Offset: 0x000478D5
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x00049704 File Offset: 0x00047904
		public virtual float InhaledTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InhaledTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InhaledTime;
			}
			set
			{
				this.GetOrCreatePoco().InhaledTime = value;
			}
		}

		// Token: 0x04001256 RID: 4694
		[Nullable(2)]
		protected IInhaledPerformance FbInstance;

		// Token: 0x04001257 RID: 4695
		[Nullable(2)]
		protected IInhaledPerformance_SetValue PocoInterface;
	}
}
