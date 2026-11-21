using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006EB RID: 1771
	public class IRandomEntityRefreshContent : IRefreshContent
	{
		// Token: 0x0600258E RID: 9614 RVA: 0x00065CB0 File Offset: 0x00063EB0
		private IRandomEntityRefreshContent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomEntityRefreshContent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomEntityRefreshContent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomEntityRefreshContent_SetValue());
			}
			return result;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00065CE8 File Offset: 0x00063EE8
		public static IRandomEntityRefreshContent Create([Nullable(2)] IRandomEntityRefreshContent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomEntityRefreshContent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00065CFB File Offset: 0x00063EFB
		public static IRandomEntityRefreshContent CreateFromSetValue([Nullable(2)] IRandomEntityRefreshContent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomEntityRefreshContent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00065D0E File Offset: 0x00063F0E
		public new IRandomEntityRefreshContent_SetValue ToSetValue()
		{
			return new IRandomEntityRefreshContent_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				EdEnableSyncCamp = this.EdEnableSyncCamp
			};
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x00065D39 File Offset: 0x00063F39
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x00065D64 File Offset: 0x00063F64
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

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x00065D72 File Offset: 0x00063F72
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x00065D99 File Offset: 0x00063F99
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IRandomEntityRefreshContent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00065DA8 File Offset: 0x00063FA8
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x00065DD2 File Offset: 0x00063FD2
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

		// Token: 0x040019F2 RID: 6642
		[Nullable(2)]
		protected new IRandomEntityRefreshContent FbInstance;

		// Token: 0x040019F3 RID: 6643
		[Nullable(2)]
		protected new IRandomEntityRefreshContent_SetValue PocoInterface;
	}
}
