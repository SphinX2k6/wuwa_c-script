using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A63 RID: 6755
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletTrackPosition : IFireBulletType
	{
		// Token: 0x060090A0 RID: 37024 RVA: 0x00151108 File Offset: 0x0014F308
		private IFireBulletTrackPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBulletTrackPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBulletTrackPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBulletTrackPosition_SetValue());
			}
			return result;
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x00151140 File Offset: 0x0014F340
		public static IFireBulletTrackPosition Create([Nullable(2)] IFireBulletTrackPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletTrackPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090A2 RID: 37026 RVA: 0x00151153 File Offset: 0x0014F353
		public static IFireBulletTrackPosition CreateFromSetValue([Nullable(2)] IFireBulletTrackPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBulletTrackPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x00151166 File Offset: 0x0014F366
		public new IFireBulletTrackPosition_SetValue ToSetValue()
		{
			return new IFireBulletTrackPosition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				Launcher = this.Launcher,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x060090A4 RID: 37028 RVA: 0x0015119D File Offset: 0x0014F39D
		// (set) Token: 0x060090A5 RID: 37029 RVA: 0x001511C8 File Offset: 0x0014F3C8
		public override EFireBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFireBulletType.TrackTarget;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x001511D6 File Offset: 0x0014F3D6
		// (set) Token: 0x060090A7 RID: 37031 RVA: 0x00151202 File Offset: 0x0014F402
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x060090A8 RID: 37032 RVA: 0x00151210 File Offset: 0x0014F410
		// (set) Token: 0x060090A9 RID: 37033 RVA: 0x00151237 File Offset: 0x0014F437
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Launcher;
				}
				IFireBulletTrackPosition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Launcher;
			}
			set
			{
				this.GetOrCreatePoco().Launcher = value;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x060090AA RID: 37034 RVA: 0x00151245 File Offset: 0x0014F445
		// (set) Token: 0x060090AB RID: 37035 RVA: 0x00151270 File Offset: 0x0014F470
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x0400594E RID: 22862
		[Nullable(2)]
		protected new IFireBulletTrackPosition FbInstance;

		// Token: 0x0400594F RID: 22863
		[Nullable(2)]
		protected new IFireBulletTrackPosition_SetValue PocoInterface;
	}
}
