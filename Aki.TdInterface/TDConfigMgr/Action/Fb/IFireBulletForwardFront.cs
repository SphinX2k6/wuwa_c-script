using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002974 RID: 10612
	public class IFireBulletForwardFront : IFireBulletType
	{
		// Token: 0x0600EB75 RID: 60277 RVA: 0x0022B16E File Offset: 0x0022936E
		public static IFireBulletForwardFront Create(IFireBulletForwardFront? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletForwardFront
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x0600EB76 RID: 60278 RVA: 0x0022B18D File Offset: 0x0022938D
		public override EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x0600EB77 RID: 60279 RVA: 0x0022B19A File Offset: 0x0022939A
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x0600EB78 RID: 60280 RVA: 0x0022B1A7 File Offset: 0x002293A7
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this._LauncherInited)
				{
					return this._LauncherCache;
				}
				this._LauncherInited = true;
				this._LauncherCache = ActionReadHelper.ReadIFireBulletForwardFront_Launcher(this.Instance);
				return this._LauncherCache;
			}
		}

		// Token: 0x040081AA RID: 33194
		private IFireBulletForwardFront Instance;

		// Token: 0x040081AB RID: 33195
		private ITargetEntityType _LauncherCache;

		// Token: 0x040081AC RID: 33196
		private bool _LauncherInited;
	}
}
