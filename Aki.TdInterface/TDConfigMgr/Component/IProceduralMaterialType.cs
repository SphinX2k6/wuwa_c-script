using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000626 RID: 1574
	[NullableContext(1)]
	[Nullable(0)]
	public class IProceduralMaterialType
	{
		// Token: 0x06002194 RID: 8596 RVA: 0x0005CD54 File Offset: 0x0005AF54
		private IProceduralMaterialType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProceduralMaterialType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProceduralMaterialType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProceduralMaterialType_SetValue());
			}
			return result;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0005CD8C File Offset: 0x0005AF8C
		public static IProceduralMaterialType Create([Nullable(2)] IProceduralMaterialType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProceduralMaterialType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0005CD9F File Offset: 0x0005AF9F
		public static IProceduralMaterialType CreateFromSetValue([Nullable(2)] IProceduralMaterialType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProceduralMaterialType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0005CDB2 File Offset: 0x0005AFB2
		public IProceduralMaterialType_SetValue ToSetValue()
		{
			return new IProceduralMaterialType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x0005CDC5 File Offset: 0x0005AFC5
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x0005CDF0 File Offset: 0x0005AFF0
		public virtual EProceduralMaterialType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProceduralMaterialType.CustomPrimitiveData;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001770 RID: 6000
		[Nullable(2)]
		protected IProceduralMaterialType FbInstance;

		// Token: 0x04001771 RID: 6001
		[Nullable(2)]
		protected IProceduralMaterialType_SetValue PocoInterface;
	}
}
