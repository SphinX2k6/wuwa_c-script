using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C9 RID: 457
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnimalModelConfig
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00024B94 File Offset: 0x00022D94
		private IAnimalModelConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAnimalModelConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAnimalModelConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAnimalModelConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00024BCC File Offset: 0x00022DCC
		public static IAnimalModelConfig Create([Nullable(2)] IAnimalModelConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnimalModelConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00024BDF File Offset: 0x00022DDF
		public static IAnimalModelConfig CreateFromSetValue([Nullable(2)] IAnimalModelConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAnimalModelConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00024BF2 File Offset: 0x00022DF2
		public IAnimalModelConfig_SetValue ToSetValue()
		{
			return new IAnimalModelConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00024C05 File Offset: 0x00022E05
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00024C30 File Offset: 0x00022E30
		public virtual EAnimalModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAnimalModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000893 RID: 2195
		[Nullable(2)]
		protected IAnimalModelConfig FbInstance;

		// Token: 0x04000894 RID: 2196
		[Nullable(2)]
		protected IAnimalModelConfig_SetValue PocoInterface;
	}
}
