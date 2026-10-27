using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE7 RID: 3559
	[NullableContext(1)]
	[Nullable(0)]
	public class ProceduralMaterialComponent : IComponentBase
	{
		// Token: 0x060050AA RID: 20650 RVA: 0x000C721E File Offset: 0x000C541E
		public static ProceduralMaterialComponent Create(IProceduralMaterialComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProceduralMaterialComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x000C7240 File Offset: 0x000C5440
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x000C7278 File Offset: 0x000C5478
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x000C7290 File Offset: 0x000C5490
		public virtual List<ICustomPrimitiveDataConfig> ProceduralMaterialConfigs
		{
			get
			{
				if (this._ProceduralMaterialConfigsInited)
				{
					return this._ProceduralMaterialConfigsCache;
				}
				this._ProceduralMaterialConfigsInited = true;
				int proceduralMaterialConfigsLength = this.Instance.ProceduralMaterialConfigsLength;
				this._ProceduralMaterialConfigsCache = new List<ICustomPrimitiveDataConfig>(proceduralMaterialConfigsLength);
				for (int i = 0; i < proceduralMaterialConfigsLength; i++)
				{
					this._ProceduralMaterialConfigsCache.Add(ICustomPrimitiveDataConfig.Create(this.Instance.ProceduralMaterialConfigs(i)));
				}
				return this._ProceduralMaterialConfigsCache;
			}
		}

		// Token: 0x04002E50 RID: 11856
		private IProceduralMaterialComponent Instance;

		// Token: 0x04002E51 RID: 11857
		private List<ICustomPrimitiveDataConfig> _ProceduralMaterialConfigsCache;

		// Token: 0x04002E52 RID: 11858
		private bool _ProceduralMaterialConfigsInited;
	}
}
