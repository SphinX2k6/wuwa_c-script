using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE6 RID: 3558
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomPrimitiveDataConfig : IProceduralMaterialType
	{
		// Token: 0x060050A5 RID: 20645 RVA: 0x000C7148 File Offset: 0x000C5348
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

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x000C7167 File Offset: 0x000C5367
		public override EProceduralMaterialType Type
		{
			get
			{
				return (EProceduralMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x000C7174 File Offset: 0x000C5374
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

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x000C71E0 File Offset: 0x000C53E0
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

		// Token: 0x04002E4D RID: 11853
		private ICustomPrimitiveDataConfig Instance;

		// Token: 0x04002E4E RID: 11854
		private List<ICustomPrimitiveMapping> _PrimitiveConfigsCache;

		// Token: 0x04002E4F RID: 11855
		private bool _PrimitiveConfigsInited;
	}
}
