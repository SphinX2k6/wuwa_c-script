using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200028F RID: 655
	[NullableContext(1)]
	[Nullable(0)]
	public class ICreateBulletConfig
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x0002FC84 File Offset: 0x0002DE84
		private ICreateBulletConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICreateBulletConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICreateBulletConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICreateBulletConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0002FCBC File Offset: 0x0002DEBC
		public static ICreateBulletConfig Create([Nullable(2)] ICreateBulletConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateBulletConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002FCCF File Offset: 0x0002DECF
		public static ICreateBulletConfig CreateFromSetValue([Nullable(2)] ICreateBulletConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICreateBulletConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0002FCE2 File Offset: 0x0002DEE2
		public ICreateBulletConfig_SetValue ToSetValue()
		{
			return new ICreateBulletConfig_SetValue
			{
				BulletId = this.BulletId,
				Delay = this.Delay
			};
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0002FD01 File Offset: 0x0002DF01
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0002FD2D File Offset: 0x0002DF2D
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0002FD3B File Offset: 0x0002DF3B
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x0002FD6A File Offset: 0x0002DF6A
		public virtual float Delay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Delay;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Delay;
			}
			set
			{
				this.GetOrCreatePoco().Delay = value;
			}
		}

		// Token: 0x04000B92 RID: 2962
		[Nullable(2)]
		protected ICreateBulletConfig FbInstance;

		// Token: 0x04000B93 RID: 2963
		[Nullable(2)]
		protected ICreateBulletConfig_SetValue PocoInterface;
	}
}
