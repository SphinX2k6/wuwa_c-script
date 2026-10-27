using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039E RID: 926
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerPollutionPointLightConfig
	{
		// Token: 0x06001271 RID: 4721 RVA: 0x0003CDFC File Offset: 0x0003AFFC
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

		// Token: 0x06001272 RID: 4722 RVA: 0x0003CE34 File Offset: 0x0003B034
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

		// Token: 0x06001273 RID: 4723 RVA: 0x0003CE47 File Offset: 0x0003B047
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

		// Token: 0x06001274 RID: 4724 RVA: 0x0003CE5A File Offset: 0x0003B05A
		public IFlowerPollutionPointLightConfig_SetValue ToSetValue()
		{
			return new IFlowerPollutionPointLightConfig_SetValue
			{
				PointLightEntityIds = this.PointLightEntityIds,
				PointLightConfig = this.PointLightConfig
			};
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0003CE79 File Offset: 0x0003B079
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x0003CEA0 File Offset: 0x0003B0A0
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0003CF43 File Offset: 0x0003B143
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

		// Token: 0x04000EDA RID: 3802
		[Nullable(2)]
		protected IFlowerPollutionPointLightConfig FbInstance;

		// Token: 0x04000EDB RID: 3803
		[Nullable(2)]
		protected IFlowerPollutionPointLightConfig_SetValue PocoInterface;

		// Token: 0x04000EDC RID: 3804
		private List<IPointLightOperations> _PointLightConfigCache;

		// Token: 0x04000EDD RID: 3805
		private bool _PointLightConfigInited;
	}
}
