using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FC RID: 2300
	public class ProceduralMaterialComponent : IComponentBase
	{
		// Token: 0x06003267 RID: 12903 RVA: 0x00081164 File Offset: 0x0007F364
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

		// Token: 0x06003268 RID: 12904 RVA: 0x0008119C File Offset: 0x0007F39C
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

		// Token: 0x06003269 RID: 12905 RVA: 0x000811AF File Offset: 0x0007F3AF
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

		// Token: 0x0600326A RID: 12906 RVA: 0x000811C2 File Offset: 0x0007F3C2
		public new ProceduralMaterialComponent_SetValue ToSetValue()
		{
			return new ProceduralMaterialComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ProceduralMaterialConfigs = this.ProceduralMaterialConfigs
			};
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000811F0 File Offset: 0x0007F3F0
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x0008122A File Offset: 0x0007F42A
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

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x00081238 File Offset: 0x0007F438
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x00081262 File Offset: 0x0007F462
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

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x00081270 File Offset: 0x0007F470
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x00081303 File Offset: 0x0007F503
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

		// Token: 0x04002135 RID: 8501
		[Nullable(2)]
		protected new ProceduralMaterialComponent FbInstance;

		// Token: 0x04002136 RID: 8502
		[Nullable(2)]
		protected new ProceduralMaterialComponent_SetValue PocoInterface;

		// Token: 0x04002137 RID: 8503
		private List<ICustomPrimitiveDataConfig> _ProceduralMaterialConfigsCache;

		// Token: 0x04002138 RID: 8504
		private bool _ProceduralMaterialConfigsInited;
	}
}
