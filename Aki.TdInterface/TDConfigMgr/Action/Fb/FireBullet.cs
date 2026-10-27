using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B3 RID: 9907
	[NullableContext(1)]
	[Nullable(0)]
	public class FireBullet : ActionParams
	{
		// Token: 0x0600DDA9 RID: 56745 RVA: 0x0020EABB File Offset: 0x0020CCBB
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

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x0020EADA File Offset: 0x0020CCDA
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

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x0600DDAB RID: 56747 RVA: 0x0020EB0C File Offset: 0x0020CD0C
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

		// Token: 0x04007B13 RID: 31507
		private IFireBullet Instance;

		// Token: 0x04007B14 RID: 31508
		private IFireBulletType _TypeCache;

		// Token: 0x04007B15 RID: 31509
		private bool _TypeInited;
	}
}
