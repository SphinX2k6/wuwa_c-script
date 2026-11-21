using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000288 RID: 648
	public class ICollectAnimalConfig : ISpecialAnimalTypeConfig
	{
		// Token: 0x06000B8A RID: 2954 RVA: 0x0002E564 File Offset: 0x0002C764
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

		// Token: 0x06000B8B RID: 2955 RVA: 0x0002E59C File Offset: 0x0002C79C
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

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002E5AF File Offset: 0x0002C7AF
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

		// Token: 0x06000B8D RID: 2957 RVA: 0x0002E5C2 File Offset: 0x0002C7C2
		public new ICollectAnimalConfig_SetValue ToSetValue()
		{
			return new ICollectAnimalConfig_SetValue
			{
				Type = this.Type,
				PartsMap = this.PartsMap
			};
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0002E5E1 File Offset: 0x0002C7E1
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0002E60C File Offset: 0x0002C80C
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0002E61C File Offset: 0x0002C81C
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0002E6AF File Offset: 0x0002C8AF
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

		// Token: 0x04000B4F RID: 2895
		[Nullable(2)]
		protected new ICollectAnimalConfig FbInstance;

		// Token: 0x04000B50 RID: 2896
		[Nullable(2)]
		protected new ICollectAnimalConfig_SetValue PocoInterface;

		// Token: 0x04000B51 RID: 2897
		private List<ICollectAnimalPartsConfig> _PartsMapCache;

		// Token: 0x04000B52 RID: 2898
		private bool _PartsMapInited;
	}
}
