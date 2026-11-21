using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E0 RID: 736
	public class ICustomPrimitiveDataConfig : IProceduralMaterialType
	{
		// Token: 0x06000D95 RID: 3477 RVA: 0x000330D0 File Offset: 0x000312D0
		private ICustomPrimitiveDataConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomPrimitiveDataConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomPrimitiveDataConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomPrimitiveDataConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00033108 File Offset: 0x00031308
		public static ICustomPrimitiveDataConfig Create([Nullable(2)] ICustomPrimitiveDataConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPrimitiveDataConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0003311B File Offset: 0x0003131B
		public static ICustomPrimitiveDataConfig CreateFromSetValue([Nullable(2)] ICustomPrimitiveDataConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomPrimitiveDataConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0003312E File Offset: 0x0003132E
		public new ICustomPrimitiveDataConfig_SetValue ToSetValue()
		{
			return new ICustomPrimitiveDataConfig_SetValue
			{
				Type = this.Type,
				PrimitiveConfigs = this.PrimitiveConfigs,
				IsChildEffective = this.IsChildEffective
			};
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00033159 File Offset: 0x00031359
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00033184 File Offset: 0x00031384
		public override EProceduralMaterialType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProceduralMaterialType.CustomPrimitiveData;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00033194 File Offset: 0x00031394
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00033227 File Offset: 0x00031427
		public virtual List<ICustomPrimitiveMapping> PrimitiveConfigs
		{
			get
			{
				if (this._PrimitiveConfigsInited)
				{
					return this._PrimitiveConfigsCache;
				}
				this._PrimitiveConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ICustomPrimitiveMapping> primitiveConfigs = this.FbInstance.PrimitiveConfigs;
					if (primitiveConfigs != null)
					{
						this._PrimitiveConfigsCache = new List<ICustomPrimitiveMapping>(primitiveConfigs.Count);
						for (int i = 0; i < primitiveConfigs.Count; i++)
						{
							this._PrimitiveConfigsCache.Add(ICustomPrimitiveMapping.Create(primitiveConfigs[i]));
						}
					}
				}
				else
				{
					ICustomPrimitiveDataConfig_SetValue pocoInterface = this.PocoInterface;
					this._PrimitiveConfigsCache = ((pocoInterface != null) ? pocoInterface.PrimitiveConfigs : null);
				}
				return this._PrimitiveConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().PrimitiveConfigs = value;
				this._PrimitiveConfigsInited = false;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0003323C File Offset: 0x0003143C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00033276 File Offset: 0x00031476
		public virtual bool? IsChildEffective
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsChildEffective;
				}
				ICustomPrimitiveDataConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsChildEffective;
			}
			set
			{
				this.GetOrCreatePoco().IsChildEffective = value;
			}
		}

		// Token: 0x04000C91 RID: 3217
		[Nullable(2)]
		protected new ICustomPrimitiveDataConfig FbInstance;

		// Token: 0x04000C92 RID: 3218
		[Nullable(2)]
		protected new ICustomPrimitiveDataConfig_SetValue PocoInterface;

		// Token: 0x04000C93 RID: 3219
		private List<ICustomPrimitiveMapping> _PrimitiveConfigsCache;

		// Token: 0x04000C94 RID: 3220
		private bool _PrimitiveConfigsInited;
	}
}
