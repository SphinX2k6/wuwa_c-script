using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D8 RID: 728
	public class ICubeMapBinding
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x00032D38 File Offset: 0x00030F38
		private ICubeMapBinding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICubeMapBinding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICubeMapBinding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICubeMapBinding_SetValue());
			}
			return result;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00032D70 File Offset: 0x00030F70
		public static ICubeMapBinding Create([Nullable(2)] ICubeMapBinding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICubeMapBinding
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00032D83 File Offset: 0x00030F83
		public static ICubeMapBinding CreateFromSetValue([Nullable(2)] ICubeMapBinding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICubeMapBinding
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00032D96 File Offset: 0x00030F96
		public ICubeMapBinding_SetValue ToSetValue()
		{
			return new ICubeMapBinding_SetValue
			{
				CubeMapActorKey = this.CubeMapActorKey,
				CubeMapPath = this.CubeMapPath
			};
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00032DB5 File Offset: 0x00030FB5
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x00032DE0 File Offset: 0x00030FE0
		public virtual string CubeMapActorKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CubeMapActorKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CubeMapActorKey;
			}
			set
			{
				this.GetOrCreatePoco().CubeMapActorKey = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00032DEE File Offset: 0x00030FEE
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00032E19 File Offset: 0x00031019
		public virtual string CubeMapPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CubeMapPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CubeMapPath;
			}
			set
			{
				this.GetOrCreatePoco().CubeMapPath = value;
			}
		}

		// Token: 0x04000C83 RID: 3203
		[Nullable(2)]
		protected ICubeMapBinding FbInstance;

		// Token: 0x04000C84 RID: 3204
		[Nullable(2)]
		protected ICubeMapBinding_SetValue PocoInterface;
	}
}
