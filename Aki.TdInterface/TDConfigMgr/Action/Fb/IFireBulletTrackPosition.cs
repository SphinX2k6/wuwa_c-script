using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002975 RID: 10613
	public class IFireBulletTrackPosition : IFireBulletType
	{
		// Token: 0x0600EB7A RID: 60282 RVA: 0x0022B1DE File Offset: 0x002293DE
		public static IFireBulletTrackPosition Create(IFireBulletTrackPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletTrackPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x0600EB7B RID: 60283 RVA: 0x0022B1FD File Offset: 0x002293FD
		public override EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x0600EB7C RID: 60284 RVA: 0x0022B20A File Offset: 0x0022940A
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x0600EB7D RID: 60285 RVA: 0x0022B217 File Offset: 0x00229417
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this._LauncherInited)
				{
					return this._LauncherCache;
				}
				this._LauncherInited = true;
				this._LauncherCache = ActionReadHelper.ReadIFireBulletTrackPosition_Launcher(this.Instance);
				return this._LauncherCache;
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x0600EB7E RID: 60286 RVA: 0x0022B246 File Offset: 0x00229446
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x040081AD RID: 33197
		private IFireBulletTrackPosition Instance;

		// Token: 0x040081AE RID: 33198
		private ITargetEntityType _LauncherCache;

		// Token: 0x040081AF RID: 33199
		private bool _LauncherInited;
	}
}
