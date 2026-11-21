using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E7 RID: 999
	public class IFlowerPollutionPointLightConfig
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x00040134 File Offset: 0x0003E334
		private IFlowerPollutionPointLightConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowerPollutionPointLightConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowerPollutionPointLightConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowerPollutionPointLightConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0004016C File Offset: 0x0003E36C
		public static IFlowerPollutionPointLightConfig Create([Nullable(2)] IFlowerPollutionPointLightConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerPollutionPointLightConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0004017F File Offset: 0x0003E37F
		public static IFlowerPollutionPointLightConfig CreateFromSetValue([Nullable(2)] IFlowerPollutionPointLightConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowerPollutionPointLightConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00040192 File Offset: 0x0003E392
		public IFlowerPollutionPointLightConfig_SetValue ToSetValue()
		{
			return new IFlowerPollutionPointLightConfig_SetValue
			{
				PointLightEntityIds = this.PointLightEntityIds,
				PointLightConfig = this.PointLightConfig
			};
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000401B1 File Offset: 0x0003E3B1
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x000401D8 File Offset: 0x0003E3D8
		public virtual List<int> PointLightEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PointLightEntityIds;
				}
				IFlowerPollutionPointLightConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PointLightEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().PointLightEntityIds = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x000401E8 File Offset: 0x0003E3E8
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0004027B File Offset: 0x0003E47B
		public virtual List<IPointLightOperations> PointLightConfig
		{
			get
			{
				if (this._PointLightConfigInited)
				{
					return this._PointLightConfigCache;
				}
				this._PointLightConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IPointLightOperations> pointLightConfig = this.FbInstance.PointLightConfig;
					if (pointLightConfig != null)
					{
						this._PointLightConfigCache = new List<IPointLightOperations>(pointLightConfig.Count);
						for (int i = 0; i < pointLightConfig.Count; i++)
						{
							this._PointLightConfigCache.Add(IPointLightOperations.Create(pointLightConfig[i]));
						}
					}
				}
				else
				{
					IFlowerPollutionPointLightConfig_SetValue pocoInterface = this.PocoInterface;
					this._PointLightConfigCache = ((pocoInterface != null) ? pocoInterface.PointLightConfig : null);
				}
				return this._PointLightConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PointLightConfig = value;
				this._PointLightConfigInited = false;
			}
		}

		// Token: 0x04000FD2 RID: 4050
		[Nullable(2)]
		protected IFlowerPollutionPointLightConfig FbInstance;

		// Token: 0x04000FD3 RID: 4051
		[Nullable(2)]
		protected IFlowerPollutionPointLightConfig_SetValue PocoInterface;

		// Token: 0x04000FD4 RID: 4052
		private List<IPointLightOperations> _PointLightConfigCache;

		// Token: 0x04000FD5 RID: 4053
		private bool _PointLightConfigInited;
	}
}
