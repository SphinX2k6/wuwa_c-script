using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B1 RID: 9905
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletForwardFront : IFireBulletType
	{
		// Token: 0x0600DD9E RID: 56734 RVA: 0x0020E9CE File Offset: 0x0020CBCE
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

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x0600DD9F RID: 56735 RVA: 0x0020E9ED File Offset: 0x0020CBED
		public override EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x0600DDA0 RID: 56736 RVA: 0x0020E9FA File Offset: 0x0020CBFA
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x0600DDA1 RID: 56737 RVA: 0x0020EA07 File Offset: 0x0020CC07
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

		// Token: 0x04007B0D RID: 31501
		private IFireBulletForwardFront Instance;

		// Token: 0x04007B0E RID: 31502
		private ITargetEntityType _LauncherCache;

		// Token: 0x04007B0F RID: 31503
		private bool _LauncherInited;
	}
}
