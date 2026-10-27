using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000247 RID: 583
	[NullableContext(1)]
	[Nullable(0)]
	public class ICollectAnimalConfig : ISpecialAnimalTypeConfig
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x0002B9B4 File Offset: 0x00029BB4
		private ICollectAnimalConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICollectAnimalConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICollectAnimalConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICollectAnimalConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002B9EC File Offset: 0x00029BEC
		public static ICollectAnimalConfig Create([Nullable(2)] ICollectAnimalConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICollectAnimalConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002B9FF File Offset: 0x00029BFF
		public static ICollectAnimalConfig CreateFromSetValue([Nullable(2)] ICollectAnimalConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICollectAnimalConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002BA12 File Offset: 0x00029C12
		public new ICollectAnimalConfig_SetValue ToSetValue()
		{
			return new ICollectAnimalConfig_SetValue
			{
				Type = this.Type,
				PartsMap = this.PartsMap
			};
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002BA31 File Offset: 0x00029C31
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002BA5C File Offset: 0x00029C5C
		public override ESpecialAnimalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialAnimalType.CollectAnimal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002BA6C File Offset: 0x00029C6C
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0002BAFF File Offset: 0x00029CFF
		public virtual List<ICollectAnimalPartsConfig> PartsMap
		{
			get
			{
				if (this._PartsMapInited)
				{
					return this._PartsMapCache;
				}
				this._PartsMapInited = true;
				if (this.FbInstance != null)
				{
					List<ICollectAnimalPartsConfig> partsMap = this.FbInstance.PartsMap;
					if (partsMap != null)
					{
						this._PartsMapCache = new List<ICollectAnimalPartsConfig>(partsMap.Count);
						for (int i = 0; i < partsMap.Count; i++)
						{
							this._PartsMapCache.Add(ICollectAnimalPartsConfig.Create(partsMap[i]));
						}
					}
				}
				else
				{
					ICollectAnimalConfig_SetValue pocoInterface = this.PocoInterface;
					this._PartsMapCache = ((pocoInterface != null) ? pocoInterface.PartsMap : null);
				}
				return this._PartsMapCache;
			}
			set
			{
				this.GetOrCreatePoco().PartsMap = value;
				this._PartsMapInited = false;
			}
		}

		// Token: 0x04000A73 RID: 2675
		[Nullable(2)]
		protected new ICollectAnimalConfig FbInstance;

		// Token: 0x04000A74 RID: 2676
		[Nullable(2)]
		protected new ICollectAnimalConfig_SetValue PocoInterface;

		// Token: 0x04000A75 RID: 2677
		private List<ICollectAnimalPartsConfig> _PartsMapCache;

		// Token: 0x04000A76 RID: 2678
		private bool _PartsMapInited;
	}
}
