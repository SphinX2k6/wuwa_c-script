using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000460 RID: 1120
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhaledPerformance
	{
		// Token: 0x0600169F RID: 5791 RVA: 0x0004591C File Offset: 0x00043B1C
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

		// Token: 0x060016A0 RID: 5792 RVA: 0x00045954 File Offset: 0x00043B54
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

		// Token: 0x060016A1 RID: 5793 RVA: 0x00045967 File Offset: 0x00043B67
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

		// Token: 0x060016A2 RID: 5794 RVA: 0x0004597A File Offset: 0x00043B7A
		public IInhaledPerformance_SetValue ToSetValue()
		{
			return new IInhaledPerformance_SetValue
			{
				InhaledTime = this.InhaledTime
			};
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0004598D File Offset: 0x00043B8D
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x000459BC File Offset: 0x00043BBC
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

		// Token: 0x04001134 RID: 4404
		[Nullable(2)]
		protected IInhaledPerformance FbInstance;

		// Token: 0x04001135 RID: 4405
		[Nullable(2)]
		protected IInhaledPerformance_SetValue PocoInterface;
	}
}
