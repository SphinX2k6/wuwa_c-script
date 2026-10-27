using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004FE RID: 1278
	[NullableContext(1)]
	[Nullable(0)]
	public class IModelId : IModelConfig
	{
		// Token: 0x06001A00 RID: 6656 RVA: 0x0004C534 File Offset: 0x0004A734
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

		// Token: 0x06001A01 RID: 6657 RVA: 0x0004C56C File Offset: 0x0004A76C
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

		// Token: 0x06001A02 RID: 6658 RVA: 0x0004C57F File Offset: 0x0004A77F
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

		// Token: 0x06001A03 RID: 6659 RVA: 0x0004C592 File Offset: 0x0004A792
		public new IModelId_SetValue ToSetValue()
		{
			return new IModelId_SetValue
			{
				Type = this.Type,
				ModelId = this.ModelId
			};
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0004C5B1 File Offset: 0x0004A7B1
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0004C5DC File Offset: 0x0004A7DC
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

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0004C5EA File Offset: 0x0004A7EA
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0004C615 File Offset: 0x0004A815
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

		// Token: 0x040012F6 RID: 4854
		[Nullable(2)]
		protected new IModelId FbInstance;

		// Token: 0x040012F7 RID: 4855
		[Nullable(2)]
		protected new IModelId_SetValue PocoInterface;
	}
}
