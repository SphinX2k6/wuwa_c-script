using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080B RID: 2059
	public class IThrowMotion
	{
		// Token: 0x06002C2B RID: 11307 RVA: 0x00073920 File Offset: 0x00071B20
		private IThrowMotion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IThrowMotion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IThrowMotion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IThrowMotion_SetValue());
			}
			return result;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00073958 File Offset: 0x00071B58
		public static IThrowMotion Create([Nullable(2)] IThrowMotion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowMotion
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x0007396B File Offset: 0x00071B6B
		public static IThrowMotion CreateFromSetValue([Nullable(2)] IThrowMotion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IThrowMotion
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x0007397E File Offset: 0x00071B7E
		public IThrowMotion_SetValue ToSetValue()
		{
			return new IThrowMotion_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x00073991 File Offset: 0x00071B91
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x000739BC File Offset: 0x00071BBC
		public virtual EThrowMotion Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EThrowMotion.Projectile;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001D97 RID: 7575
		[Nullable(2)]
		protected IThrowMotion FbInstance;

		// Token: 0x04001D98 RID: 7576
		[Nullable(2)]
		protected IThrowMotion_SetValue PocoInterface;
	}
}
