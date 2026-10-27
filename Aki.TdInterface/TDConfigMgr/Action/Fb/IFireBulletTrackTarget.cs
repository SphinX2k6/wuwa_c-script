using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B0 RID: 9904
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletTrackTarget : IFireBulletType
	{
		// Token: 0x0600DD97 RID: 56727 RVA: 0x0020E8F6 File Offset: 0x0020CAF6
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

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x0600DD98 RID: 56728 RVA: 0x0020E915 File Offset: 0x0020CB15
		public override EFireBulletType Type
		{
			get
			{
				return (EFireBulletType)this.Instance.Type;
			}
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x0600DD99 RID: 56729 RVA: 0x0020E922 File Offset: 0x0020CB22
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x0600DD9A RID: 56730 RVA: 0x0020E92F File Offset: 0x0020CB2F
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

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x0600DD9B RID: 56731 RVA: 0x0020E95E File Offset: 0x0020CB5E
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

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x0600DD9C RID: 56732 RVA: 0x0020E990 File Offset: 0x0020CB90
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

		// Token: 0x04007B08 RID: 31496
		private IFireBulletTrackTarget Instance;

		// Token: 0x04007B09 RID: 31497
		private ITargetEntityType _LauncherCache;

		// Token: 0x04007B0A RID: 31498
		private bool _LauncherInited;

		// Token: 0x04007B0B RID: 31499
		private ITargetEntityType _TargetCache;

		// Token: 0x04007B0C RID: 31500
		private bool _TargetInited;
	}
}
