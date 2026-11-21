using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200055F RID: 1375
	public class IModelId : IModelConfig
	{
		// Token: 0x06001BE2 RID: 7138 RVA: 0x00051078 File Offset: 0x0004F278
		private IModelId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModelId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModelId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModelId_SetValue());
			}
			return result;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000510B0 File Offset: 0x0004F2B0
		public static IModelId Create([Nullable(2)] IModelId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModelId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000510C3 File Offset: 0x0004F2C3
		public static IModelId CreateFromSetValue([Nullable(2)] IModelId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModelId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000510D6 File Offset: 0x0004F2D6
		public new IModelId_SetValue ToSetValue()
		{
			return new IModelId_SetValue
			{
				Type = this.Type,
				ModelId = this.ModelId
			};
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000510F5 File Offset: 0x0004F2F5
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00051120 File Offset: 0x0004F320
		public override EModelType Type
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

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0005112E File Offset: 0x0004F32E
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x00051159 File Offset: 0x0004F359
		public virtual int ModelId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ModelId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ModelId;
			}
			set
			{
				this.GetOrCreatePoco().ModelId = value;
			}
		}

		// Token: 0x04001456 RID: 5206
		[Nullable(2)]
		protected new IModelId FbInstance;

		// Token: 0x04001457 RID: 5207
		[Nullable(2)]
		protected new IModelId_SetValue PocoInterface;
	}
}
