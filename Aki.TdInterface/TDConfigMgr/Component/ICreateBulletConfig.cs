using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D2 RID: 722
	public class ICreateBulletConfig
	{
		// Token: 0x06000D53 RID: 3411 RVA: 0x00032974 File Offset: 0x00030B74
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

		// Token: 0x06000D54 RID: 3412 RVA: 0x000329AC File Offset: 0x00030BAC
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

		// Token: 0x06000D55 RID: 3413 RVA: 0x000329BF File Offset: 0x00030BBF
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

		// Token: 0x06000D56 RID: 3414 RVA: 0x000329D2 File Offset: 0x00030BD2
		public ICreateBulletConfig_SetValue ToSetValue()
		{
			return new ICreateBulletConfig_SetValue
			{
				BulletId = this.BulletId,
				Delay = this.Delay
			};
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000329F1 File Offset: 0x00030BF1
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00032A1D File Offset: 0x00030C1D
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

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00032A2B File Offset: 0x00030C2B
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00032A5A File Offset: 0x00030C5A
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

		// Token: 0x04000C73 RID: 3187
		[Nullable(2)]
		protected ICreateBulletConfig FbInstance;

		// Token: 0x04000C74 RID: 3188
		[Nullable(2)]
		protected ICreateBulletConfig_SetValue PocoInterface;
	}
}
