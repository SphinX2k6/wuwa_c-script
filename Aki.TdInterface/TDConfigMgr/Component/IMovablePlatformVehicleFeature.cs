using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200059B RID: 1435
	public class IMovablePlatformVehicleFeature : IVehicleFeature
	{
		// Token: 0x06001D32 RID: 7474 RVA: 0x00053B38 File Offset: 0x00051D38
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

		// Token: 0x06001D33 RID: 7475 RVA: 0x00053B70 File Offset: 0x00051D70
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

		// Token: 0x06001D34 RID: 7476 RVA: 0x00053B83 File Offset: 0x00051D83
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

		// Token: 0x06001D35 RID: 7477 RVA: 0x00053B96 File Offset: 0x00051D96
		public new IMovablePlatformVehicleFeature_SetValue ToSetValue()
		{
			return new IMovablePlatformVehicleFeature_SetValue
			{
				Type = this.Type,
				PlayerAttachTags = this.PlayerAttachTags,
				SafePointId = this.SafePointId
			};
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00053BC1 File Offset: 0x00051DC1
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00053BEC File Offset: 0x00051DEC
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00053BFA File Offset: 0x00051DFA
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00053C21 File Offset: 0x00051E21
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

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00053C2F File Offset: 0x00051E2F
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00053C5A File Offset: 0x00051E5A
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

		// Token: 0x0400150A RID: 5386
		[Nullable(2)]
		protected new IMovablePlatformVehicleFeature FbInstance;

		// Token: 0x0400150B RID: 5387
		[Nullable(2)]
		protected new IMovablePlatformVehicleFeature_SetValue PocoInterface;
	}
}
