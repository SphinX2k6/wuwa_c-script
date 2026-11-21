using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200055D RID: 1373
	public class IModelConfig
	{
		// Token: 0x06001BDA RID: 7130 RVA: 0x00050FBC File Offset: 0x0004F1BC
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

		// Token: 0x06001BDB RID: 7131 RVA: 0x00050FF4 File Offset: 0x0004F1F4
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

		// Token: 0x06001BDC RID: 7132 RVA: 0x00051007 File Offset: 0x0004F207
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

		// Token: 0x06001BDD RID: 7133 RVA: 0x0005101A File Offset: 0x0004F21A
		public IModelConfig_SetValue ToSetValue()
		{
			return new IModelConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0005102D File Offset: 0x0004F22D
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x00051058 File Offset: 0x0004F258
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

		// Token: 0x04001453 RID: 5203
		[Nullable(2)]
		protected IModelConfig FbInstance;

		// Token: 0x04001454 RID: 5204
		[Nullable(2)]
		protected IModelConfig_SetValue PocoInterface;
	}
}
