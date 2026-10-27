using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086D RID: 2157
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshSingleComponent : IComponentBase
	{
		// Token: 0x06002FCD RID: 12237 RVA: 0x0007B3F4 File Offset: 0x000795F4
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

		// Token: 0x06002FCE RID: 12238 RVA: 0x0007B42C File Offset: 0x0007962C
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

		// Token: 0x06002FCF RID: 12239 RVA: 0x0007B43F File Offset: 0x0007963F
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

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0007B454 File Offset: 0x00079654
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

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x0007B4A4 File Offset: 0x000796A4
		// (set) Token: 0x06002FD2 RID: 12242 RVA: 0x0007B4DE File Offset: 0x000796DE
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

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x0007B4EC File Offset: 0x000796EC
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x0007B516 File Offset: 0x00079716
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x0007B524 File Offset: 0x00079724
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x0007B54F File Offset: 0x0007974F
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

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x0007B55D File Offset: 0x0007975D
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x0007B588 File Offset: 0x00079788
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x0007B596 File Offset: 0x00079796
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x0007B5C1 File Offset: 0x000797C1
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

		// Token: 0x04001F82 RID: 8066
		[Nullable(2)]
		protected new RefreshSingleComponent FbInstance;

		// Token: 0x04001F83 RID: 8067
		[Nullable(2)]
		protected new RefreshSingleComponent_SetValue PocoInterface;
	}
}
