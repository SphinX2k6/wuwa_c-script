using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002CA RID: 714
	public class IConveyorBeltField
	{
		// Token: 0x06000D2B RID: 3371 RVA: 0x0003254C File Offset: 0x0003074C
		private IConveyorBeltField_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConveyorBeltField 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConveyorBeltField_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConveyorBeltField_SetValue());
			}
			return result;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00032584 File Offset: 0x00030784
		public static IConveyorBeltField Create([Nullable(2)] IConveyorBeltField instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltField
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00032597 File Offset: 0x00030797
		public static IConveyorBeltField CreateFromSetValue([Nullable(2)] IConveyorBeltField_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConveyorBeltField
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000325AA File Offset: 0x000307AA
		public IConveyorBeltField_SetValue ToSetValue()
		{
			return new IConveyorBeltField_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000325BD File Offset: 0x000307BD
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x000325E8 File Offset: 0x000307E8
		public virtual EConveyorBeltFieldType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConveyorBeltFieldType.DirectionalField;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C61 RID: 3169
		[Nullable(2)]
		protected IConveyorBeltField FbInstance;

		// Token: 0x04000C62 RID: 3170
		[Nullable(2)]
		protected IConveyorBeltField_SetValue PocoInterface;
	}
}
