using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002047 RID: 8263
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleTeam : ITargetVehicle
	{
		// Token: 0x0600B596 RID: 46486 RVA: 0x001A58E8 File Offset: 0x001A3AE8
		private IVehicleTeam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleTeam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleTeam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleTeam_SetValue());
			}
			return result;
		}

		// Token: 0x0600B597 RID: 46487 RVA: 0x001A5920 File Offset: 0x001A3B20
		public static IVehicleTeam Create([Nullable(2)] IVehicleTeam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleTeam
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x001A5933 File Offset: 0x001A3B33
		public static IVehicleTeam CreateFromSetValue([Nullable(2)] IVehicleTeam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleTeam
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x001A5946 File Offset: 0x001A3B46
		public new IVehicleTeam_SetValue ToSetValue()
		{
			return new IVehicleTeam_SetValue
			{
				Type = this.Type,
				TeamId = this.TeamId
			};
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600B59A RID: 46490 RVA: 0x001A5965 File Offset: 0x001A3B65
		// (set) Token: 0x0600B59B RID: 46491 RVA: 0x001A5990 File Offset: 0x001A3B90
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600B59C RID: 46492 RVA: 0x001A599E File Offset: 0x001A3B9E
		// (set) Token: 0x0600B59D RID: 46493 RVA: 0x001A59C9 File Offset: 0x001A3BC9
		public virtual int TeamId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeamId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TeamId;
			}
			set
			{
				this.GetOrCreatePoco().TeamId = value;
			}
		}

		// Token: 0x04006D3C RID: 27964
		[Nullable(2)]
		protected new IVehicleTeam FbInstance;

		// Token: 0x04006D3D RID: 27965
		[Nullable(2)]
		protected new IVehicleTeam_SetValue PocoInterface;
	}
}
