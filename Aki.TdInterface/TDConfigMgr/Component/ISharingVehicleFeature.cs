using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C8 RID: 1736
	[NullableContext(1)]
	[Nullable(0)]
	public class ISharingVehicleFeature : IVehicleFeature
	{
		// Token: 0x0600254E RID: 9550 RVA: 0x000648E4 File Offset: 0x00062AE4
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

		// Token: 0x0600254F RID: 9551 RVA: 0x0006491C File Offset: 0x00062B1C
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

		// Token: 0x06002550 RID: 9552 RVA: 0x0006492F File Offset: 0x00062B2F
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

		// Token: 0x06002551 RID: 9553 RVA: 0x00064942 File Offset: 0x00062B42
		public new ISharingVehicleFeature_SetValue ToSetValue()
		{
			return new ISharingVehicleFeature_SetValue
			{
				Type = this.Type,
				AffectionDegreeSourceType = this.AffectionDegreeSourceType
			};
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x00064961 File Offset: 0x00062B61
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x0006498C File Offset: 0x00062B8C
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

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x0006499C File Offset: 0x00062B9C
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x000649D6 File Offset: 0x00062BD6
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

		// Token: 0x0400197E RID: 6526
		[Nullable(2)]
		protected new ISharingVehicleFeature FbInstance;

		// Token: 0x0400197F RID: 6527
		[Nullable(2)]
		protected new ISharingVehicleFeature_SetValue PocoInterface;
	}
}
