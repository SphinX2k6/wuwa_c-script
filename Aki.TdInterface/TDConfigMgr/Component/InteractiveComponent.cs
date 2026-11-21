using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200060B RID: 1547
	public class InteractiveComponent : IComponentBase
	{
		// Token: 0x06002072 RID: 8306 RVA: 0x0005B22C File Offset: 0x0005942C
		private InteractiveComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InteractiveComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InteractiveComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InteractiveComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x0005B264 File Offset: 0x00059464
		public static InteractiveComponent Create([Nullable(2)] InteractiveComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InteractiveComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0005B277 File Offset: 0x00059477
		public static InteractiveComponent CreateFromSetValue([Nullable(2)] InteractiveComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InteractiveComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0005B28A File Offset: 0x0005948A
		public new InteractiveComponent_SetValue ToSetValue()
		{
			return new InteractiveComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Content = this.Content,
				Icon = this.Icon
			};
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0005B2C4 File Offset: 0x000594C4
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x0005B2FE File Offset: 0x000594FE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				InteractiveComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0005B30C File Offset: 0x0005950C
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x0005B336 File Offset: 0x00059536
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

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x0005B344 File Offset: 0x00059544
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x0005B36F File Offset: 0x0005956F
		public virtual string Content
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Content;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Content;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0005B37D File Offset: 0x0005957D
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x0005B3A8 File Offset: 0x000595A8
		public virtual string Icon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Icon;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Icon;
			}
			set
			{
				this.GetOrCreatePoco().Icon = value;
			}
		}

		// Token: 0x04001720 RID: 5920
		[Nullable(2)]
		protected new InteractiveComponent FbInstance;

		// Token: 0x04001721 RID: 5921
		[Nullable(2)]
		protected new InteractiveComponent_SetValue PocoInterface;
	}
}
