using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF8 RID: 7160
	public class IFireBulletTrackPosition : IFireBulletType
	{
		// Token: 0x0600980A RID: 38922 RVA: 0x00161034 File Offset: 0x0015F234
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

		// Token: 0x0600980B RID: 38923 RVA: 0x0016106C File Offset: 0x0015F26C
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

		// Token: 0x0600980C RID: 38924 RVA: 0x0016107F File Offset: 0x0015F27F
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

		// Token: 0x0600980D RID: 38925 RVA: 0x00161092 File Offset: 0x0015F292
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

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0600980E RID: 38926 RVA: 0x001610C9 File Offset: 0x0015F2C9
		// (set) Token: 0x0600980F RID: 38927 RVA: 0x001610F4 File Offset: 0x0015F2F4
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

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x06009810 RID: 38928 RVA: 0x00161102 File Offset: 0x0015F302
		// (set) Token: 0x06009811 RID: 38929 RVA: 0x0016112E File Offset: 0x0015F32E
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

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x06009812 RID: 38930 RVA: 0x0016113C File Offset: 0x0015F33C
		// (set) Token: 0x06009813 RID: 38931 RVA: 0x00161163 File Offset: 0x0015F363
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

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x00161171 File Offset: 0x0015F371
		// (set) Token: 0x06009815 RID: 38933 RVA: 0x0016119C File Offset: 0x0015F39C
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

		// Token: 0x04005DB3 RID: 23987
		[Nullable(2)]
		protected new IFireBulletTrackPosition FbInstance;

		// Token: 0x04005DB4 RID: 23988
		[Nullable(2)]
		protected new IFireBulletTrackPosition_SetValue PocoInterface;
	}
}
