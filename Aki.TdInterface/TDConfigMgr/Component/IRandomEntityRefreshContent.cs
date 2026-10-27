using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064E RID: 1614
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomEntityRefreshContent : IRefreshContent
	{
		// Token: 0x06002288 RID: 8840 RVA: 0x0005EF9C File Offset: 0x0005D19C
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

		// Token: 0x06002289 RID: 8841 RVA: 0x0005EFD4 File Offset: 0x0005D1D4
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

		// Token: 0x0600228A RID: 8842 RVA: 0x0005EFE7 File Offset: 0x0005D1E7
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

		// Token: 0x0600228B RID: 8843 RVA: 0x0005EFFA File Offset: 0x0005D1FA
		public new IRandomEntityRefreshContent_SetValue ToSetValue()
		{
			return new IRandomEntityRefreshContent_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				EdEnableSyncCamp = this.EdEnableSyncCamp
			};
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0005F025 File Offset: 0x0005D225
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x0005F050 File Offset: 0x0005D250
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x0005F05E File Offset: 0x0005D25E
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x0005F085 File Offset: 0x0005D285
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x0005F094 File Offset: 0x0005D294
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x0005F0BE File Offset: 0x0005D2BE
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

		// Token: 0x04001800 RID: 6144
		[Nullable(2)]
		protected new IRandomEntityRefreshContent FbInstance;

		// Token: 0x04001801 RID: 6145
		[Nullable(2)]
		protected new IRandomEntityRefreshContent_SetValue PocoInterface;
	}
}
