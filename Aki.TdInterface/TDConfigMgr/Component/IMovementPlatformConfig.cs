using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000538 RID: 1336
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementPlatformConfig
	{
		// Token: 0x06001B4C RID: 6988 RVA: 0x0004F09C File Offset: 0x0004D29C
		[NullableContext(1)]
		private IMovementPlatformConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovementPlatformConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovementPlatformConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovementPlatformConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
		[NullableContext(1)]
		public static IMovementPlatformConfig Create([Nullable(2)] IMovementPlatformConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPlatformConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0004F0E7 File Offset: 0x0004D2E7
		[NullableContext(1)]
		public static IMovementPlatformConfig CreateFromSetValue([Nullable(2)] IMovementPlatformConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovementPlatformConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0004F0FA File Offset: 0x0004D2FA
		[NullableContext(1)]
		public IMovementPlatformConfig_SetValue ToSetValue()
		{
			return new IMovementPlatformConfig_SetValue
			{
				PlayerAttachTags = this.PlayerAttachTags,
				SafePointId = this.SafePointId
			};
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0004F119 File Offset: 0x0004D319
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0004F140 File Offset: 0x0004D340
		public virtual List<int> PlayerAttachTags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerAttachTags;
				}
				IMovementPlatformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerAttachTags;
			}
			set
			{
				this.GetOrCreatePoco().PlayerAttachTags = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0004F150 File Offset: 0x0004D350
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0004F18A File Offset: 0x0004D38A
		public virtual int? SafePointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SafePointId;
				}
				IMovementPlatformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SafePointId;
			}
			set
			{
				this.GetOrCreatePoco().SafePointId = value;
			}
		}

		// Token: 0x040013AD RID: 5037
		protected IMovementPlatformConfig FbInstance;

		// Token: 0x040013AE RID: 5038
		protected IMovementPlatformConfig_SetValue PocoInterface;
	}
}
