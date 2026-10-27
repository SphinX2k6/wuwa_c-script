using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001727 RID: 5927
	[NullableContext(1)]
	[Nullable(0)]
	public class FireBulletEffect : ActionParams
	{
		// Token: 0x06007D7F RID: 32127 RVA: 0x0012D0B8 File Offset: 0x0012B2B8
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

		// Token: 0x06007D80 RID: 32128 RVA: 0x0012D0F0 File Offset: 0x0012B2F0
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

		// Token: 0x06007D81 RID: 32129 RVA: 0x0012D103 File Offset: 0x0012B303
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

		// Token: 0x06007D82 RID: 32130 RVA: 0x0012D118 File Offset: 0x0012B318
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

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x06007D83 RID: 32131 RVA: 0x0012D166 File Offset: 0x0012B366
		// (set) Token: 0x06007D84 RID: 32132 RVA: 0x0012D191 File Offset: 0x0012B391
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

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x06007D85 RID: 32133 RVA: 0x0012D19F File Offset: 0x0012B39F
		// (set) Token: 0x06007D86 RID: 32134 RVA: 0x0012D1CA File Offset: 0x0012B3CA
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

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x06007D87 RID: 32135 RVA: 0x0012D1D8 File Offset: 0x0012B3D8
		// (set) Token: 0x06007D88 RID: 32136 RVA: 0x0012D203 File Offset: 0x0012B403
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

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x06007D89 RID: 32137 RVA: 0x0012D211 File Offset: 0x0012B411
		// (set) Token: 0x06007D8A RID: 32138 RVA: 0x0012D23C File Offset: 0x0012B43C
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

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x0012D24C File Offset: 0x0012B44C
		// (set) Token: 0x06007D8C RID: 32140 RVA: 0x0012D286 File Offset: 0x0012B486
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

		// Token: 0x04005015 RID: 20501
		[Nullable(2)]
		protected new FireBulletEffect FbInstance;

		// Token: 0x04005016 RID: 20502
		[Nullable(2)]
		protected FireBulletEffect_SetValue PocoInterface;
	}
}
