using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000287 RID: 647
	[NullableContext(1)]
	[Nullable(0)]
	public class IConveyorBeltField
	{
		// Token: 0x06000C11 RID: 3089 RVA: 0x0002F85C File Offset: 0x0002DA5C
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

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002F894 File Offset: 0x0002DA94
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

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002F8A7 File Offset: 0x0002DAA7
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

		// Token: 0x06000C14 RID: 3092 RVA: 0x0002F8BA File Offset: 0x0002DABA
		public IConveyorBeltField_SetValue ToSetValue()
		{
			return new IConveyorBeltField_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0002F8CD File Offset: 0x0002DACD
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
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

		// Token: 0x04000B80 RID: 2944
		[Nullable(2)]
		protected IConveyorBeltField FbInstance;

		// Token: 0x04000B81 RID: 2945
		[Nullable(2)]
		protected IConveyorBeltField_SetValue PocoInterface;
	}
}
