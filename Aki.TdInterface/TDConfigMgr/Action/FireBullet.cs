using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A2 RID: 6306
	public class FireBullet : ActionParams
	{
		// Token: 0x06008453 RID: 33875 RVA: 0x0013C058 File Offset: 0x0013A258
		private FireBullet_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FireBullet 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FireBullet_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FireBullet_SetValue());
			}
			return result;
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x0013C090 File Offset: 0x0013A290
		public static FireBullet Create([Nullable(2)] FireBullet instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FireBullet
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x0013C0A3 File Offset: 0x0013A2A3
		public static FireBullet CreateFromSetValue([Nullable(2)] FireBullet_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FireBullet
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x0013C0B6 File Offset: 0x0013A2B6
		public FireBullet_SetValue ToSetValue()
		{
			return new FireBullet_SetValue
			{
				Type = this.Type,
				Launcher = this.Launcher
			};
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x06008457 RID: 33879 RVA: 0x0013C0D5 File Offset: 0x0013A2D5
		// (set) Token: 0x06008458 RID: 33880 RVA: 0x0013C0FC File Offset: 0x0013A2FC
		public virtual IFireBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				FireBullet_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x06008459 RID: 33881 RVA: 0x0013C10C File Offset: 0x0013A30C
		// (set) Token: 0x0600845A RID: 33882 RVA: 0x0013C146 File Offset: 0x0013A346
		public virtual EBulletLauncher? Launcher
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Launcher;
				}
				FireBullet_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005440 RID: 21568
		[Nullable(2)]
		protected new FireBullet FbInstance;

		// Token: 0x04005441 RID: 21569
		[Nullable(2)]
		protected FireBullet_SetValue PocoInterface;
	}
}
