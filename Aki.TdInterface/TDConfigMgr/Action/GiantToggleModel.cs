using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001738 RID: 5944
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantToggleModel : ActionParams
	{
		// Token: 0x06007DCD RID: 32205 RVA: 0x0012D990 File Offset: 0x0012BB90
		private GiantToggleModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GiantToggleModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GiantToggleModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GiantToggleModel_SetValue());
			}
			return result;
		}

		// Token: 0x06007DCE RID: 32206 RVA: 0x0012D9C8 File Offset: 0x0012BBC8
		public static GiantToggleModel Create([Nullable(2)] GiantToggleModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GiantToggleModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x0012D9DB File Offset: 0x0012BBDB
		public static GiantToggleModel CreateFromSetValue([Nullable(2)] GiantToggleModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GiantToggleModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x0012D9EE File Offset: 0x0012BBEE
		public GiantToggleModel_SetValue ToSetValue()
		{
			return new GiantToggleModel_SetValue
			{
				IsEnabled = this.IsEnabled
			};
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x06007DD1 RID: 32209 RVA: 0x0012DA01 File Offset: 0x0012BC01
		// (set) Token: 0x06007DD2 RID: 32210 RVA: 0x0012DA2C File Offset: 0x0012BC2C
		public virtual bool IsEnabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnabled;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnabled;
			}
			set
			{
				this.GetOrCreatePoco().IsEnabled = value;
			}
		}

		// Token: 0x0400503B RID: 20539
		[Nullable(2)]
		protected new GiantToggleModel FbInstance;

		// Token: 0x0400503C RID: 20540
		[Nullable(2)]
		protected GiantToggleModel_SetValue PocoInterface;
	}
}
