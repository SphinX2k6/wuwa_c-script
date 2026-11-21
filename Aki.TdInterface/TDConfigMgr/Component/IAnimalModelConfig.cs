using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001EC RID: 492
	public class IAnimalModelConfig
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x00025E98 File Offset: 0x00024098
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

		// Token: 0x060007A3 RID: 1955 RVA: 0x00025ED0 File Offset: 0x000240D0
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

		// Token: 0x060007A4 RID: 1956 RVA: 0x00025EE3 File Offset: 0x000240E3
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

		// Token: 0x060007A5 RID: 1957 RVA: 0x00025EF6 File Offset: 0x000240F6
		public IAnimalModelConfig_SetValue ToSetValue()
		{
			return new IAnimalModelConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00025F09 File Offset: 0x00024109
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00025F34 File Offset: 0x00024134
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

		// Token: 0x04000907 RID: 2311
		[Nullable(2)]
		protected IAnimalModelConfig FbInstance;

		// Token: 0x04000908 RID: 2312
		[Nullable(2)]
		protected IAnimalModelConfig_SetValue PocoInterface;
	}
}
