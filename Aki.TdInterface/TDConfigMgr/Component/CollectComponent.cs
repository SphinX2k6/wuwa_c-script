using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000042 RID: 66
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectComponent : IComponentBase
	{
		// Token: 0x0600023E RID: 574 RVA: 0x00019168 File Offset: 0x00017368
		private CollectComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CollectComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CollectComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CollectComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000191A0 File Offset: 0x000173A0
		public static CollectComponent Create([Nullable(2)] CollectComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CollectComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000191B3 File Offset: 0x000173B3
		public static CollectComponent CreateFromSetValue([Nullable(2)] CollectComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CollectComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000191C6 File Offset: 0x000173C6
		public new CollectComponent_SetValue ToSetValue()
		{
			return new CollectComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				IsDisableOneClickCollection = this.IsDisableOneClickCollection
			};
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000191F4 File Offset: 0x000173F4
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0001922E File Offset: 0x0001742E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CollectComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001923C File Offset: 0x0001743C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00019266 File Offset: 0x00017466
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00019274 File Offset: 0x00017474
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000192AE File Offset: 0x000174AE
		public virtual bool? IsDisableOneClickCollection
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableOneClickCollection;
				}
				CollectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableOneClickCollection;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableOneClickCollection = value;
			}
		}

		// Token: 0x04000171 RID: 369
		[Nullable(2)]
		protected new CollectComponent FbInstance;

		// Token: 0x04000172 RID: 370
		[Nullable(2)]
		protected new CollectComponent_SetValue PocoInterface;
	}
}
