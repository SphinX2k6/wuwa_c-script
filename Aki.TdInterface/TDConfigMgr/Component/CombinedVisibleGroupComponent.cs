using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000046 RID: 70
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinedVisibleGroupComponent : IComponentBase
	{
		// Token: 0x06000254 RID: 596 RVA: 0x000193DC File Offset: 0x000175DC
		private CombinedVisibleGroupComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CombinedVisibleGroupComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CombinedVisibleGroupComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CombinedVisibleGroupComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00019414 File Offset: 0x00017614
		public static CombinedVisibleGroupComponent Create([Nullable(2)] CombinedVisibleGroupComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CombinedVisibleGroupComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00019427 File Offset: 0x00017627
		public static CombinedVisibleGroupComponent CreateFromSetValue([Nullable(2)] CombinedVisibleGroupComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CombinedVisibleGroupComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001943C File Offset: 0x0001763C
		public new CombinedVisibleGroupComponent_SetValue ToSetValue()
		{
			return new CombinedVisibleGroupComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AreaIds = this.AreaIds,
				IncludeSubArea = this.IncludeSubArea,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001948C File Offset: 0x0001768C
		// (set) Token: 0x06000259 RID: 601 RVA: 0x000194C6 File Offset: 0x000176C6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CombinedVisibleGroupComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000194D4 File Offset: 0x000176D4
		// (set) Token: 0x0600025B RID: 603 RVA: 0x000194FE File Offset: 0x000176FE
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001950C File Offset: 0x0001770C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00019533 File Offset: 0x00017733
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				CombinedVisibleGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00019541 File Offset: 0x00017741
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0001956C File Offset: 0x0001776C
		public virtual bool IncludeSubArea
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IncludeSubArea;
				}
				return this.PocoInterface != null && this.PocoInterface.IncludeSubArea;
			}
			set
			{
				this.GetOrCreatePoco().IncludeSubArea = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001957A File Offset: 0x0001777A
		// (set) Token: 0x06000261 RID: 609 RVA: 0x000195A1 File Offset: 0x000177A1
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				CombinedVisibleGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x0400017A RID: 378
		[Nullable(2)]
		protected new CombinedVisibleGroupComponent FbInstance;

		// Token: 0x0400017B RID: 379
		[Nullable(2)]
		protected new CombinedVisibleGroupComponent_SetValue PocoInterface;
	}
}
