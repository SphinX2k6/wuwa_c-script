using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A65 RID: 6757
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletTrackTarget : IFireBulletType
	{
		// Token: 0x060090AE RID: 37038 RVA: 0x00151290 File Offset: 0x0014F490
		private IFireBulletTrackTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBulletTrackTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBulletTrackTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBulletTrackTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060090AF RID: 37039 RVA: 0x001512C8 File Offset: 0x0014F4C8
		public static IFireBulletTrackTarget Create([Nullable(2)] IFireBulletTrackTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletTrackTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x001512DB File Offset: 0x0014F4DB
		public static IFireBulletTrackTarget CreateFromSetValue([Nullable(2)] IFireBulletTrackTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBulletTrackTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x001512F0 File Offset: 0x0014F4F0
		public new IFireBulletTrackTarget_SetValue ToSetValue()
		{
			return new IFireBulletTrackTarget_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				Launcher = this.Launcher,
				Target = this.Target,
				WaitDestroy = this.WaitDestroy
			};
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x0015133E File Offset: 0x0014F53E
		// (set) Token: 0x060090B3 RID: 37043 RVA: 0x00151369 File Offset: 0x0014F569
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

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x060090B4 RID: 37044 RVA: 0x00151377 File Offset: 0x0014F577
		// (set) Token: 0x060090B5 RID: 37045 RVA: 0x001513A3 File Offset: 0x0014F5A3
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

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x001513B1 File Offset: 0x0014F5B1
		// (set) Token: 0x060090B7 RID: 37047 RVA: 0x001513D8 File Offset: 0x0014F5D8
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Launcher;
				}
				IFireBulletTrackTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x060090B8 RID: 37048 RVA: 0x001513E6 File Offset: 0x0014F5E6
		// (set) Token: 0x060090B9 RID: 37049 RVA: 0x0015140D File Offset: 0x0014F60D
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IFireBulletTrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x0015141C File Offset: 0x0014F61C
		// (set) Token: 0x060090BB RID: 37051 RVA: 0x00151456 File Offset: 0x0014F656
		public virtual bool? WaitDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitDestroy;
				}
				IFireBulletTrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WaitDestroy;
			}
			set
			{
				this.GetOrCreatePoco().WaitDestroy = value;
			}
		}

		// Token: 0x04005954 RID: 22868
		[Nullable(2)]
		protected new IFireBulletTrackTarget FbInstance;

		// Token: 0x04005955 RID: 22869
		[Nullable(2)]
		protected new IFireBulletTrackTarget_SetValue PocoInterface;
	}
}
