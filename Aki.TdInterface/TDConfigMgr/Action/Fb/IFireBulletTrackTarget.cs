using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002973 RID: 10611
	public class IFireBulletTrackTarget : IFireBulletType
	{
		// Token: 0x0600EB6E RID: 60270 RVA: 0x0022B096 File Offset: 0x00229296
		public static IFireBulletTrackTarget Create(IFireBulletTrackTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletTrackTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x0600EB6F RID: 60271 RVA: 0x0022B0B5 File Offset: 0x002292B5
		public override EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x0600EB70 RID: 60272 RVA: 0x0022B0C2 File Offset: 0x002292C2
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x0600EB71 RID: 60273 RVA: 0x0022B0CF File Offset: 0x002292CF
		public virtual ITargetEntityType Launcher
		{
			get
			{
				if (this._LauncherInited)
				{
					return this._LauncherCache;
				}
				this._LauncherInited = true;
				this._LauncherCache = ActionReadHelper.ReadIFireBulletTrackTarget_Launcher(this.Instance);
				return this._LauncherCache;
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x0600EB72 RID: 60274 RVA: 0x0022B0FE File Offset: 0x002292FE
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIFireBulletTrackTarget_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x0600EB73 RID: 60275 RVA: 0x0022B130 File Offset: 0x00229330
		public virtual bool? WaitDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.WaitDestroy);
			}
		}

		// Token: 0x040081A5 RID: 33189
		private IFireBulletTrackTarget Instance;

		// Token: 0x040081A6 RID: 33190
		private ITargetEntityType _LauncherCache;

		// Token: 0x040081A7 RID: 33191
		private bool _LauncherInited;

		// Token: 0x040081A8 RID: 33192
		private ITargetEntityType _TargetCache;

		// Token: 0x040081A9 RID: 33193
		private bool _TargetInited;
	}
}
