using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000910 RID: 2320
	public class RefreshSingleComponent : IComponentBase
	{
		// Token: 0x06003309 RID: 13065 RVA: 0x000828DC File Offset: 0x00080ADC
		private RefreshSingleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RefreshSingleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RefreshSingleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RefreshSingleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00082914 File Offset: 0x00080B14
		public static RefreshSingleComponent Create([Nullable(2)] RefreshSingleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshSingleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00082927 File Offset: 0x00080B27
		public static RefreshSingleComponent CreateFromSetValue([Nullable(2)] RefreshSingleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RefreshSingleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x0008293C File Offset: 0x00080B3C
		public new RefreshSingleComponent_SetValue ToSetValue()
		{
			return new RefreshSingleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RefreshInterval = this.RefreshInterval,
				DelayRefresh = this.DelayRefresh,
				TemplateGuid = this.TemplateGuid
			};
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x0008298C File Offset: 0x00080B8C
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x000829C6 File Offset: 0x00080BC6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RefreshSingleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x000829D4 File Offset: 0x00080BD4
		// (set) Token: 0x06003310 RID: 13072 RVA: 0x000829FE File Offset: 0x00080BFE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x00082A0C File Offset: 0x00080C0C
		// (set) Token: 0x06003312 RID: 13074 RVA: 0x00082A37 File Offset: 0x00080C37
		public virtual int RefreshInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RefreshInterval;
			}
			set
			{
				this.GetOrCreatePoco().RefreshInterval = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00082A45 File Offset: 0x00080C45
		// (set) Token: 0x06003314 RID: 13076 RVA: 0x00082A70 File Offset: 0x00080C70
		public virtual bool DelayRefresh
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayRefresh;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayRefresh;
			}
			set
			{
				this.GetOrCreatePoco().DelayRefresh = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x00082A7E File Offset: 0x00080C7E
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x00082AA9 File Offset: 0x00080CA9
		public virtual string TemplateGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateGuid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TemplateGuid;
			}
			set
			{
				this.GetOrCreatePoco().TemplateGuid = value;
			}
		}

		// Token: 0x04002194 RID: 8596
		[Nullable(2)]
		protected new RefreshSingleComponent FbInstance;

		// Token: 0x04002195 RID: 8597
		[Nullable(2)]
		protected new RefreshSingleComponent_SetValue PocoInterface;
	}
}
