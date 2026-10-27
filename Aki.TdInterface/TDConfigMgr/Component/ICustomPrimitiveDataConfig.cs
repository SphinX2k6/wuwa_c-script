using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200029B RID: 667
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomPrimitiveDataConfig : IProceduralMaterialType
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x000302E0 File Offset: 0x0002E4E0
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

		// Token: 0x06000C72 RID: 3186 RVA: 0x00030318 File Offset: 0x0002E518
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

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003032B File Offset: 0x0002E52B
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

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003033E File Offset: 0x0002E53E
		public new ICustomPrimitiveDataConfig_SetValue ToSetValue()
		{
			return new ICustomPrimitiveDataConfig_SetValue
			{
				Type = this.Type,
				PrimitiveConfigs = this.PrimitiveConfigs,
				IsChildEffective = this.IsChildEffective
			};
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00030369 File Offset: 0x0002E569
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00030394 File Offset: 0x0002E594
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

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000303A4 File Offset: 0x0002E5A4
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00030437 File Offset: 0x0002E637
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

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0003044C File Offset: 0x0002E64C
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00030486 File Offset: 0x0002E686
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

		// Token: 0x04000BAC RID: 2988
		[Nullable(2)]
		protected new ICustomPrimitiveDataConfig FbInstance;

		// Token: 0x04000BAD RID: 2989
		[Nullable(2)]
		protected new ICustomPrimitiveDataConfig_SetValue PocoInterface;

		// Token: 0x04000BAE RID: 2990
		private List<ICustomPrimitiveMapping> _PrimitiveConfigsCache;

		// Token: 0x04000BAF RID: 2991
		private bool _PrimitiveConfigsInited;
	}
}
