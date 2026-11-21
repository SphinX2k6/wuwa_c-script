using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C3 RID: 1731
	public class IProceduralMaterialType
	{
		// Token: 0x0600249A RID: 9370 RVA: 0x00063A68 File Offset: 0x00061C68
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

		// Token: 0x0600249B RID: 9371 RVA: 0x00063AA0 File Offset: 0x00061CA0
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

		// Token: 0x0600249C RID: 9372 RVA: 0x00063AB3 File Offset: 0x00061CB3
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

		// Token: 0x0600249D RID: 9373 RVA: 0x00063AC6 File Offset: 0x00061CC6
		public IProceduralMaterialType_SetValue ToSetValue()
		{
			return new IProceduralMaterialType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x00063AD9 File Offset: 0x00061CD9
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x00063B04 File Offset: 0x00061D04
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

		// Token: 0x04001962 RID: 6498
		[Nullable(2)]
		protected IProceduralMaterialType FbInstance;

		// Token: 0x04001963 RID: 6499
		[Nullable(2)]
		protected IProceduralMaterialType_SetValue PocoInterface;
	}
}
