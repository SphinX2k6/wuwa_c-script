using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B4 RID: 9908
	public class FireBulletEffect : ActionParams
	{
		// Token: 0x0600DDAD RID: 56749 RVA: 0x0020EB4A File Offset: 0x0020CD4A
		[NullableContext(1)]
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

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x0600DDAE RID: 56750 RVA: 0x0020EB69 File Offset: 0x0020CD69
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x0600DDAF RID: 56751 RVA: 0x0020EB76 File Offset: 0x0020CD76
		public virtual int X
		{
			get
			{
				return this.Instance.X;
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x0600DDB0 RID: 56752 RVA: 0x0020EB83 File Offset: 0x0020CD83
		public virtual int Y
		{
			get
			{
				return this.Instance.Y;
			}
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x0600DDB1 RID: 56753 RVA: 0x0020EB90 File Offset: 0x0020CD90
		public virtual int Z
		{
			get
			{
				return this.Instance.Z;
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x0600DDB2 RID: 56754 RVA: 0x0020EBA0 File Offset: 0x0020CDA0
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

		// Token: 0x04007B16 RID: 31510
		private IFireBulletEffect Instance;
	}
}
