using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BD RID: 445
	[NullableContext(1)]
	[Nullable(0)]
	public class IAllRefreshContent : IRefreshContent
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x00024294 File Offset: 0x00022494
		private IAllRefreshContent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAllRefreshContent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAllRefreshContent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAllRefreshContent_SetValue());
			}
			return result;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000242CC File Offset: 0x000224CC
		public static IAllRefreshContent Create([Nullable(2)] IAllRefreshContent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAllRefreshContent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000242DF File Offset: 0x000224DF
		public static IAllRefreshContent CreateFromSetValue([Nullable(2)] IAllRefreshContent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAllRefreshContent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000242F2 File Offset: 0x000224F2
		public new IAllRefreshContent_SetValue ToSetValue()
		{
			return new IAllRefreshContent_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				EdEnableSyncCamp = this.EdEnableSyncCamp
			};
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0002431D File Offset: 0x0002251D
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00024348 File Offset: 0x00022548
		public override ERefreshContent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshContent.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00024356 File Offset: 0x00022556
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0002437D File Offset: 0x0002257D
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IAllRefreshContent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0002438C File Offset: 0x0002258C
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x000243B6 File Offset: 0x000225B6
		public virtual bool? EdEnableSyncCamp
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdEnableSyncCamp;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdEnableSyncCamp = value;
			}
		}

		// Token: 0x0400086A RID: 2154
		[Nullable(2)]
		protected new IAllRefreshContent FbInstance;

		// Token: 0x0400086B RID: 2155
		[Nullable(2)]
		protected new IAllRefreshContent_SetValue PocoInterface;
	}
}
