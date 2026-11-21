using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E0 RID: 480
	public class IAllRefreshContent : IRefreshContent
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00025598 File Offset: 0x00023798
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

		// Token: 0x0600075D RID: 1885 RVA: 0x000255D0 File Offset: 0x000237D0
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

		// Token: 0x0600075E RID: 1886 RVA: 0x000255E3 File Offset: 0x000237E3
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

		// Token: 0x0600075F RID: 1887 RVA: 0x000255F6 File Offset: 0x000237F6
		public new IAllRefreshContent_SetValue ToSetValue()
		{
			return new IAllRefreshContent_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				EdEnableSyncCamp = this.EdEnableSyncCamp
			};
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00025621 File Offset: 0x00023821
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0002564C File Offset: 0x0002384C
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002565A File Offset: 0x0002385A
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00025681 File Offset: 0x00023881
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00025690 File Offset: 0x00023890
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000256BA File Offset: 0x000238BA
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

		// Token: 0x040008DE RID: 2270
		[Nullable(2)]
		protected new IAllRefreshContent FbInstance;

		// Token: 0x040008DF RID: 2271
		[Nullable(2)]
		protected new IAllRefreshContent_SetValue PocoInterface;
	}
}
