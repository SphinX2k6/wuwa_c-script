using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002976 RID: 10614
	public class FireBullet : ActionParams
	{
		// Token: 0x0600EB80 RID: 60288 RVA: 0x0022B25B File Offset: 0x0022945B
		public static FireBullet Create(IFireBullet? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FireBullet
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x0600EB81 RID: 60289 RVA: 0x0022B27A File Offset: 0x0022947A
		public virtual IFireBulletType Type
		{
			get
			{
				if (this._TypeInited)
				{
					return this._TypeCache;
				}
				this._TypeInited = true;
				this._TypeCache = ActionReadHelper.ReadFireBullet_Type(this.Instance);
				return this._TypeCache;
			}
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x0600EB82 RID: 60290 RVA: 0x0022B2AC File Offset: 0x002294AC
		public virtual EBulletLauncher? Launcher
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EBulletLauncher?((EBulletLauncher)this.Instance.Launcher);
			}
		}

		// Token: 0x040081B0 RID: 33200
		private IFireBullet Instance;

		// Token: 0x040081B1 RID: 33201
		private IFireBulletType _TypeCache;

		// Token: 0x040081B2 RID: 33202
		private bool _TypeInited;
	}
}
