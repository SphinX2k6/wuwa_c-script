using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000534 RID: 1332
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovablePlatformVehicleFeature : IVehicleFeature
	{
		// Token: 0x06001B36 RID: 6966 RVA: 0x0004ED7C File Offset: 0x0004CF7C
		private IMovablePlatformVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovablePlatformVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovablePlatformVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovablePlatformVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0004EDB4 File Offset: 0x0004CFB4
		public static IMovablePlatformVehicleFeature Create([Nullable(2)] IMovablePlatformVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovablePlatformVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0004EDC7 File Offset: 0x0004CFC7
		public static IMovablePlatformVehicleFeature CreateFromSetValue([Nullable(2)] IMovablePlatformVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovablePlatformVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0004EDDA File Offset: 0x0004CFDA
		public new IMovablePlatformVehicleFeature_SetValue ToSetValue()
		{
			return new IMovablePlatformVehicleFeature_SetValue
			{
				Type = this.Type,
				PlayerAttachTags = this.PlayerAttachTags,
				SafePointId = this.SafePointId
			};
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0004EE05 File Offset: 0x0004D005
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0004EE30 File Offset: 0x0004D030
		public override EVehicleFeatureFlag Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVehicleFeatureFlag)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0004EE3E File Offset: 0x0004D03E
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0004EE65 File Offset: 0x0004D065
		public virtual List<int> PlayerAttachTags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerAttachTags;
				}
				IMovablePlatformVehicleFeature_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0004EE73 File Offset: 0x0004D073
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0004EE9E File Offset: 0x0004D09E
		public virtual int SafePointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SafePointId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SafePointId;
			}
			set
			{
				this.GetOrCreatePoco().SafePointId = value;
			}
		}

		// Token: 0x040013A0 RID: 5024
		[Nullable(2)]
		protected new IMovablePlatformVehicleFeature FbInstance;

		// Token: 0x040013A1 RID: 5025
		[Nullable(2)]
		protected new IMovablePlatformVehicleFeature_SetValue PocoInterface;
	}
}
