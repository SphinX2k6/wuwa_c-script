using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D4 RID: 468
	public class IAirWallCover
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x00025004 File Offset: 0x00023204
		private IAirWallCover_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirWallCover 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirWallCover_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirWallCover_SetValue());
			}
			return result;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0002503C File Offset: 0x0002323C
		public static IAirWallCover Create([Nullable(2)] IAirWallCover instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallCover
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0002504F File Offset: 0x0002324F
		public static IAirWallCover CreateFromSetValue([Nullable(2)] IAirWallCover_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirWallCover
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00025062 File Offset: 0x00023262
		public IAirWallCover_SetValue ToSetValue()
		{
			return new IAirWallCover_SetValue
			{
				Height = this.Height
			};
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00025075 File Offset: 0x00023275
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000250A4 File Offset: 0x000232A4
		public virtual float Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x040008C8 RID: 2248
		[Nullable(2)]
		protected IAirWallCover FbInstance;

		// Token: 0x040008C9 RID: 2249
		[Nullable(2)]
		protected IAirWallCover_SetValue PocoInterface;
	}
}
