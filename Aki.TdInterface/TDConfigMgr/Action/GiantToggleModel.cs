using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B7 RID: 6327
	public class GiantToggleModel : ActionParams
	{
		// Token: 0x060084B5 RID: 33973 RVA: 0x0013CB38 File Offset: 0x0013AD38
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

		// Token: 0x060084B6 RID: 33974 RVA: 0x0013CB70 File Offset: 0x0013AD70
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

		// Token: 0x060084B7 RID: 33975 RVA: 0x0013CB83 File Offset: 0x0013AD83
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

		// Token: 0x060084B8 RID: 33976 RVA: 0x0013CB96 File Offset: 0x0013AD96
		public GiantToggleModel_SetValue ToSetValue()
		{
			return new GiantToggleModel_SetValue
			{
				IsEnabled = this.IsEnabled
			};
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x0013CBA9 File Offset: 0x0013ADA9
		// (set) Token: 0x060084BA RID: 33978 RVA: 0x0013CBD4 File Offset: 0x0013ADD4
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

		// Token: 0x0400546E RID: 21614
		[Nullable(2)]
		protected new GiantToggleModel FbInstance;

		// Token: 0x0400546F RID: 21615
		[Nullable(2)]
		protected GiantToggleModel_SetValue PocoInterface;
	}
}
