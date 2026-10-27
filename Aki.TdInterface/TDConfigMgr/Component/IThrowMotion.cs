using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200076A RID: 1898
	[NullableContext(1)]
	[Nullable(0)]
	public class IThrowMotion
	{
		// Token: 0x06002907 RID: 10503 RVA: 0x0006C778 File Offset: 0x0006A978
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

		// Token: 0x06002908 RID: 10504 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
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

		// Token: 0x06002909 RID: 10505 RVA: 0x0006C7C3 File Offset: 0x0006A9C3
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

		// Token: 0x0600290A RID: 10506 RVA: 0x0006C7D6 File Offset: 0x0006A9D6
		public IThrowMotion_SetValue ToSetValue()
		{
			return new IThrowMotion_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x0006C7E9 File Offset: 0x0006A9E9
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x0006C814 File Offset: 0x0006AA14
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

		// Token: 0x04001B92 RID: 7058
		[Nullable(2)]
		protected IThrowMotion FbInstance;

		// Token: 0x04001B93 RID: 7059
		[Nullable(2)]
		protected IThrowMotion_SetValue PocoInterface;
	}
}
