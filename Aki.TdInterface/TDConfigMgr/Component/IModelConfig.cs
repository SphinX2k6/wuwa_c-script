using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004FC RID: 1276
	[NullableContext(1)]
	[Nullable(0)]
	public class IModelConfig
	{
		// Token: 0x060019F8 RID: 6648 RVA: 0x0004C478 File Offset: 0x0004A678
		private IModelConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModelConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModelConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModelConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
		public static IModelConfig Create([Nullable(2)] IModelConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModelConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0004C4C3 File Offset: 0x0004A6C3
		public static IModelConfig CreateFromSetValue([Nullable(2)] IModelConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModelConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0004C4D6 File Offset: 0x0004A6D6
		public IModelConfig_SetValue ToSetValue()
		{
			return new IModelConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0004C4E9 File Offset: 0x0004A6E9
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0004C514 File Offset: 0x0004A714
		public virtual EModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModelType.LevelPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012F3 RID: 4851
		[Nullable(2)]
		protected IModelConfig FbInstance;

		// Token: 0x040012F4 RID: 4852
		[Nullable(2)]
		protected IModelConfig_SetValue PocoInterface;
	}
}
