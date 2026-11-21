using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A4 RID: 6308
	public class FireBulletEffect : ActionParams
	{
		// Token: 0x0600845D RID: 33885 RVA: 0x0013C164 File Offset: 0x0013A364
		private FireBulletEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FireBulletEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FireBulletEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FireBulletEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x0013C19C File Offset: 0x0013A39C
		public static FireBulletEffect Create([Nullable(2)] FireBulletEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FireBulletEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x0013C1AF File Offset: 0x0013A3AF
		public static FireBulletEffect CreateFromSetValue([Nullable(2)] FireBulletEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FireBulletEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x0013C1C4 File Offset: 0x0013A3C4
		public FireBulletEffect_SetValue ToSetValue()
		{
			return new FireBulletEffect_SetValue
			{
				Id = this.Id,
				X = this.X,
				Y = this.Y,
				Z = this.Z,
				Launcher = this.Launcher
			};
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x06008461 RID: 33889 RVA: 0x0013C212 File Offset: 0x0013A412
		// (set) Token: 0x06008462 RID: 33890 RVA: 0x0013C23D File Offset: 0x0013A43D
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x06008463 RID: 33891 RVA: 0x0013C24B File Offset: 0x0013A44B
		// (set) Token: 0x06008464 RID: 33892 RVA: 0x0013C276 File Offset: 0x0013A476
		public virtual int X
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.X;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.X;
			}
			set
			{
				this.GetOrCreatePoco().X = value;
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x0013C284 File Offset: 0x0013A484
		// (set) Token: 0x06008466 RID: 33894 RVA: 0x0013C2AF File Offset: 0x0013A4AF
		public virtual int Y
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Y;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Y;
			}
			set
			{
				this.GetOrCreatePoco().Y = value;
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x0013C2BD File Offset: 0x0013A4BD
		// (set) Token: 0x06008468 RID: 33896 RVA: 0x0013C2E8 File Offset: 0x0013A4E8
		public virtual int Z
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Z;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Z;
			}
			set
			{
				this.GetOrCreatePoco().Z = value;
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x06008469 RID: 33897 RVA: 0x0013C2F8 File Offset: 0x0013A4F8
		// (set) Token: 0x0600846A RID: 33898 RVA: 0x0013C332 File Offset: 0x0013A532
		public virtual EBulletLauncher? Launcher
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Launcher;
				}
				FireBulletEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Launcher;
			}
			set
			{
				this.GetOrCreatePoco().Launcher = value;
			}
		}

		// Token: 0x04005444 RID: 21572
		[Nullable(2)]
		protected new FireBulletEffect FbInstance;

		// Token: 0x04005445 RID: 21573
		[Nullable(2)]
		protected FireBulletEffect_SetValue PocoInterface;
	}
}
