using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002977 RID: 10615
	public class FireBulletEffect : ActionParams
	{
		// Token: 0x0600EB84 RID: 60292 RVA: 0x0022B2EA File Offset: 0x002294EA
		public static FireBulletEffect Create(IFireBulletEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FireBulletEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x0600EB85 RID: 60293 RVA: 0x0022B309 File Offset: 0x00229509
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x0600EB86 RID: 60294 RVA: 0x0022B316 File Offset: 0x00229516
		public virtual int X
		{
			get
			{
				return this.Instance.X;
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x0600EB87 RID: 60295 RVA: 0x0022B323 File Offset: 0x00229523
		public virtual int Y
		{
			get
			{
				return this.Instance.Y;
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x0600EB88 RID: 60296 RVA: 0x0022B330 File Offset: 0x00229530
		public virtual int Z
		{
			get
			{
				return this.Instance.Z;
			}
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x0600EB89 RID: 60297 RVA: 0x0022B340 File Offset: 0x00229540
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

		// Token: 0x040081B3 RID: 33203
		private IFireBulletEffect Instance;
	}
}
