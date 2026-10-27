using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002796 RID: 10134
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyDataLayers : IHideGroupType
	{
		// Token: 0x0600E192 RID: 57746 RVA: 0x00215618 File Offset: 0x00213818
		public static IHideSpecifyDataLayers Create(IHideSpecifyDataLayers? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyDataLayers
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x0600E193 RID: 57747 RVA: 0x00215637 File Offset: 0x00213837
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x0600E194 RID: 57748 RVA: 0x00215644 File Offset: 0x00213844
		public virtual List<int> DataLayers
		{
			get
			{
				if (this._DataLayersInited)
				{
					return this._DataLayersCache;
				}
				this._DataLayersInited = true;
				int dataLayersLength = this.Instance.DataLayersLength;
				this._DataLayersCache = new List<int>(dataLayersLength);
				for (int i = 0; i < dataLayersLength; i++)
				{
					this._DataLayersCache.Add(this.Instance.DataLayers(i));
				}
				return this._DataLayersCache;
			}
		}

		// Token: 0x04007D16 RID: 32022
		private IHideSpecifyDataLayers Instance;

		// Token: 0x04007D17 RID: 32023
		private List<int> _DataLayersCache;

		// Token: 0x04007D18 RID: 32024
		private bool _DataLayersInited;
	}
}
