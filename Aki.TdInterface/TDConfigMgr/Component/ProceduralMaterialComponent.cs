using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000859 RID: 2137
	[NullableContext(1)]
	[Nullable(0)]
	public class ProceduralMaterialComponent : IComponentBase
	{
		// Token: 0x06002F2B RID: 12075 RVA: 0x00079C7C File Offset: 0x00077E7C
		private ProceduralMaterialComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ProceduralMaterialComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ProceduralMaterialComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ProceduralMaterialComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00079CB4 File Offset: 0x00077EB4
		public static ProceduralMaterialComponent Create([Nullable(2)] ProceduralMaterialComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProceduralMaterialComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00079CC7 File Offset: 0x00077EC7
		public static ProceduralMaterialComponent CreateFromSetValue([Nullable(2)] ProceduralMaterialComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ProceduralMaterialComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00079CDA File Offset: 0x00077EDA
		public new ProceduralMaterialComponent_SetValue ToSetValue()
		{
			return new ProceduralMaterialComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ProceduralMaterialConfigs = this.ProceduralMaterialConfigs
			};
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x00079D08 File Offset: 0x00077F08
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00079D42 File Offset: 0x00077F42
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ProceduralMaterialComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x00079D50 File Offset: 0x00077F50
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00079D7A File Offset: 0x00077F7A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x00079D88 File Offset: 0x00077F88
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x00079E1B File Offset: 0x0007801B
		public virtual List<ICustomPrimitiveDataConfig> ProceduralMaterialConfigs
		{
			get
			{
				if (this._ProceduralMaterialConfigsInited)
				{
					return this._ProceduralMaterialConfigsCache;
				}
				this._ProceduralMaterialConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ICustomPrimitiveDataConfig> proceduralMaterialConfigs = this.FbInstance.ProceduralMaterialConfigs;
					if (proceduralMaterialConfigs != null)
					{
						this._ProceduralMaterialConfigsCache = new List<ICustomPrimitiveDataConfig>(proceduralMaterialConfigs.Count);
						for (int i = 0; i < proceduralMaterialConfigs.Count; i++)
						{
							this._ProceduralMaterialConfigsCache.Add(ICustomPrimitiveDataConfig.Create(proceduralMaterialConfigs[i]));
						}
					}
				}
				else
				{
					ProceduralMaterialComponent_SetValue pocoInterface = this.PocoInterface;
					this._ProceduralMaterialConfigsCache = ((pocoInterface != null) ? pocoInterface.ProceduralMaterialConfigs : null);
				}
				return this._ProceduralMaterialConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().ProceduralMaterialConfigs = value;
				this._ProceduralMaterialConfigsInited = false;
			}
		}

		// Token: 0x04001F23 RID: 7971
		[Nullable(2)]
		protected new ProceduralMaterialComponent FbInstance;

		// Token: 0x04001F24 RID: 7972
		[Nullable(2)]
		protected new ProceduralMaterialComponent_SetValue PocoInterface;

		// Token: 0x04001F25 RID: 7973
		private List<ICustomPrimitiveDataConfig> _ProceduralMaterialConfigsCache;

		// Token: 0x04001F26 RID: 7974
		private bool _ProceduralMaterialConfigsInited;
	}
}
