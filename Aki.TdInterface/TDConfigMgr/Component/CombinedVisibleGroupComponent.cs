using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000046 RID: 70
	public class CombinedVisibleGroupComponent : IComponentBase
	{
		// Token: 0x06000258 RID: 600 RVA: 0x00019D50 File Offset: 0x00017F50
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

		// Token: 0x06000259 RID: 601 RVA: 0x00019D88 File Offset: 0x00017F88
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

		// Token: 0x0600025A RID: 602 RVA: 0x00019D9B File Offset: 0x00017F9B
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

		// Token: 0x0600025B RID: 603 RVA: 0x00019DB0 File Offset: 0x00017FB0
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00019E00 File Offset: 0x00018000
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00019E3A File Offset: 0x0001803A
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00019E48 File Offset: 0x00018048
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00019E72 File Offset: 0x00018072
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00019E80 File Offset: 0x00018080
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00019EA7 File Offset: 0x000180A7
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00019EB5 File Offset: 0x000180B5
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00019EE0 File Offset: 0x000180E0
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00019EEE File Offset: 0x000180EE
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00019F15 File Offset: 0x00018115
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

		// Token: 0x0400017F RID: 383
		[Nullable(2)]
		protected new CombinedVisibleGroupComponent FbInstance;

		// Token: 0x04000180 RID: 384
		[Nullable(2)]
		protected new CombinedVisibleGroupComponent_SetValue PocoInterface;
	}
}
