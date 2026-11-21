using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE3 RID: 3811
	public class ProceduralMaterialComponent : IComponentBase
	{
		// Token: 0x060055D1 RID: 21969 RVA: 0x000D2AE6 File Offset: 0x000D0CE6
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

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x000D2B08 File Offset: 0x000D0D08
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

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x060055D3 RID: 21971 RVA: 0x000D2B40 File Offset: 0x000D0D40
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x000D2B58 File Offset: 0x000D0D58
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

		// Token: 0x04003118 RID: 12568
		private IProceduralMaterialComponent Instance;

		// Token: 0x04003119 RID: 12569
		private List<ICustomPrimitiveDataConfig> _ProceduralMaterialConfigsCache;

		// Token: 0x0400311A RID: 12570
		private bool _ProceduralMaterialConfigsInited;
	}
}
