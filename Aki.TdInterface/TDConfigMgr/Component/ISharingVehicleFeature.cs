using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000769 RID: 1897
	public class ISharingVehicleFeature : IVehicleFeature
	{
		// Token: 0x0600286E RID: 10350 RVA: 0x0006B954 File Offset: 0x00069B54
		private ISharingVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISharingVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISharingVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISharingVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0006B98C File Offset: 0x00069B8C
		public static ISharingVehicleFeature Create([Nullable(2)] ISharingVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISharingVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0006B99F File Offset: 0x00069B9F
		public static ISharingVehicleFeature CreateFromSetValue([Nullable(2)] ISharingVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISharingVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0006B9B2 File Offset: 0x00069BB2
		public new ISharingVehicleFeature_SetValue ToSetValue()
		{
			return new ISharingVehicleFeature_SetValue
			{
				Type = this.Type,
				AffectionDegreeSourceType = this.AffectionDegreeSourceType
			};
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x0006B9D1 File Offset: 0x00069BD1
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x0006B9FC File Offset: 0x00069BFC
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x0006BA0C File Offset: 0x00069C0C
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x0006BA46 File Offset: 0x00069C46
		public virtual EAffectionDegreeSourceType? AffectionDegreeSourceType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AffectionDegreeSourceType;
				}
				ISharingVehicleFeature_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AffectionDegreeSourceType;
			}
			set
			{
				this.GetOrCreatePoco().AffectionDegreeSourceType = value;
			}
		}

		// Token: 0x04001B7D RID: 7037
		[Nullable(2)]
		protected new ISharingVehicleFeature FbInstance;

		// Token: 0x04001B7E RID: 7038
		[Nullable(2)]
		protected new ISharingVehicleFeature_SetValue PocoInterface;
	}
}
