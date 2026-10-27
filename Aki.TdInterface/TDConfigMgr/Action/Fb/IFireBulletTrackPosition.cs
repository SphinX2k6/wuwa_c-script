using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B2 RID: 9906
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletTrackPosition : IFireBulletType
	{
		// Token: 0x0600DDA3 RID: 56739 RVA: 0x0020EA3E File Offset: 0x0020CC3E
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

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x0600DDA4 RID: 56740 RVA: 0x0020EA5D File Offset: 0x0020CC5D
		public override EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x0600DDA5 RID: 56741 RVA: 0x0020EA6A File Offset: 0x0020CC6A
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x0600DDA6 RID: 56742 RVA: 0x0020EA77 File Offset: 0x0020CC77
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

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x0600DDA7 RID: 56743 RVA: 0x0020EAA6 File Offset: 0x0020CCA6
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x04007B10 RID: 31504
		private IFireBulletTrackPosition Instance;

		// Token: 0x04007B11 RID: 31505
		private ITargetEntityType _LauncherCache;

		// Token: 0x04007B12 RID: 31506
		private bool _LauncherInited;
	}
}
