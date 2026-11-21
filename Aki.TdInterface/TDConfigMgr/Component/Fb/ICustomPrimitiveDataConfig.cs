using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE2 RID: 3810
	public class ICustomPrimitiveDataConfig : IProceduralMaterialType
	{
		// Token: 0x060055CC RID: 21964 RVA: 0x000D2A10 File Offset: 0x000D0C10
		public static ICustomPrimitiveDataConfig Create(ICustomPrimitiveDataConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPrimitiveDataConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x060055CD RID: 21965 RVA: 0x000D2A2F File Offset: 0x000D0C2F
		public override EProceduralMaterialType Type
		{
			get
			{
				return (EProceduralMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x000D2A3C File Offset: 0x000D0C3C
		public virtual List<ICustomPrimitiveMapping> PrimitiveConfigs
		{
			get
			{
				if (this._PrimitiveConfigsInited)
				{
					return this._PrimitiveConfigsCache;
				}
				this._PrimitiveConfigsInited = true;
				int primitiveConfigsLength = this.Instance.PrimitiveConfigsLength;
				this._PrimitiveConfigsCache = new List<ICustomPrimitiveMapping>(primitiveConfigsLength);
				for (int i = 0; i < primitiveConfigsLength; i++)
				{
					this._PrimitiveConfigsCache.Add(ICustomPrimitiveMapping.Create(this.Instance.PrimitiveConfigs(i)));
				}
				return this._PrimitiveConfigsCache;
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x000D2AA8 File Offset: 0x000D0CA8
		public virtual bool? IsChildEffective
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsChildEffective);
			}
		}

		// Token: 0x04003115 RID: 12565
		private ICustomPrimitiveDataConfig Instance;

		// Token: 0x04003116 RID: 12566
		private List<ICustomPrimitiveMapping> _PrimitiveConfigsCache;

		// Token: 0x04003117 RID: 12567
		private bool _PrimitiveConfigsInited;
	}
}
