using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001725 RID: 5925
	[NullableContext(1)]
	[Nullable(0)]
	public class FireBullet : ActionParams
	{
		// Token: 0x06007D75 RID: 32117 RVA: 0x0012CFAC File Offset: 0x0012B1AC
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

		// Token: 0x06007D76 RID: 32118 RVA: 0x0012CFE4 File Offset: 0x0012B1E4
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

		// Token: 0x06007D77 RID: 32119 RVA: 0x0012CFF7 File Offset: 0x0012B1F7
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

		// Token: 0x06007D78 RID: 32120 RVA: 0x0012D00A File Offset: 0x0012B20A
		public FireBullet_SetValue ToSetValue()
		{
			return new FireBullet_SetValue
			{
				Type = this.Type,
				Launcher = this.Launcher
			};
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x0012D029 File Offset: 0x0012B229
		// (set) Token: 0x06007D7A RID: 32122 RVA: 0x0012D050 File Offset: 0x0012B250
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

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x0012D060 File Offset: 0x0012B260
		// (set) Token: 0x06007D7C RID: 32124 RVA: 0x0012D09A File Offset: 0x0012B29A
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

		// Token: 0x04005011 RID: 20497
		[Nullable(2)]
		protected new FireBullet FbInstance;

		// Token: 0x04005012 RID: 20498
		[Nullable(2)]
		protected FireBullet_SetValue PocoInterface;
	}
}
