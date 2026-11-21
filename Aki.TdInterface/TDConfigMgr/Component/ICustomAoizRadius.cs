using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002DC RID: 732
	public class ICustomAoizRadius
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x00032EF4 File Offset: 0x000310F4
		private ICustomAoizRadius_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomAoizRadius 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomAoizRadius_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomAoizRadius_SetValue());
			}
			return result;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00032F2C File Offset: 0x0003112C
		public static ICustomAoizRadius Create([Nullable(2)] ICustomAoizRadius instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAoizRadius
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00032F3F File Offset: 0x0003113F
		public static ICustomAoizRadius CreateFromSetValue([Nullable(2)] ICustomAoizRadius_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomAoizRadius
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00032F52 File Offset: 0x00031152
		public ICustomAoizRadius_SetValue ToSetValue()
		{
			return new ICustomAoizRadius_SetValue
			{
				Up = this.Up,
				Down = this.Down
			};
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00032F74 File Offset: 0x00031174
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00032FAE File Offset: 0x000311AE
		public virtual int? Up
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Up;
				}
				ICustomAoizRadius_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Up;
			}
			set
			{
				this.GetOrCreatePoco().Up = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00032FBC File Offset: 0x000311BC
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00032FF6 File Offset: 0x000311F6
		public virtual int? Down
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Down;
				}
				ICustomAoizRadius_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Down;
			}
			set
			{
				this.GetOrCreatePoco().Down = value;
			}
		}

		// Token: 0x04000C8A RID: 3210
		[Nullable(2)]
		protected ICustomAoizRadius FbInstance;

		// Token: 0x04000C8B RID: 3211
		[Nullable(2)]
		protected ICustomAoizRadius_SetValue PocoInterface;
	}
}
