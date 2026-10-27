using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002A9 RID: 681
	[NullableContext(1)]
	[Nullable(0)]
	public class IDaNpcModel : INpcModelConfig
	{
		// Token: 0x06000CBB RID: 3259 RVA: 0x00030B38 File Offset: 0x0002ED38
		private IDaNpcModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDaNpcModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDaNpcModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDaNpcModel_SetValue());
			}
			return result;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00030B70 File Offset: 0x0002ED70
		public static IDaNpcModel Create([Nullable(2)] IDaNpcModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaNpcModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00030B83 File Offset: 0x0002ED83
		public static IDaNpcModel CreateFromSetValue([Nullable(2)] IDaNpcModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDaNpcModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00030B96 File Offset: 0x0002ED96
		public new IDaNpcModel_SetValue ToSetValue()
		{
			return new IDaNpcModel_SetValue
			{
				Type = this.Type,
				Da = this.Da
			};
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00030BB5 File Offset: 0x0002EDB5
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		public override ENpcModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00030BEE File Offset: 0x0002EDEE
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00030C19 File Offset: 0x0002EE19
		public virtual string Da
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Da;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Da;
			}
			set
			{
				this.GetOrCreatePoco().Da = value;
			}
		}

		// Token: 0x04000BCE RID: 3022
		[Nullable(2)]
		protected new IDaNpcModel FbInstance;

		// Token: 0x04000BCF RID: 3023
		[Nullable(2)]
		protected new IDaNpcModel_SetValue PocoInterface;
	}
}
