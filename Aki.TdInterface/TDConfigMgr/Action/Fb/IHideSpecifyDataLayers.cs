using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A68 RID: 10856
	public class IHideSpecifyDataLayers : IHideGroupType
	{
		// Token: 0x0600EFB0 RID: 61360 RVA: 0x002323AC File Offset: 0x002305AC
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

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x0600EFB1 RID: 61361 RVA: 0x002323CB File Offset: 0x002305CB
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x0600EFB2 RID: 61362 RVA: 0x002323D8 File Offset: 0x002305D8
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

		// Token: 0x040083CC RID: 33740
		private IHideSpecifyDataLayers Instance;

		// Token: 0x040083CD RID: 33741
		private List<int> _DataLayersCache;

		// Token: 0x040083CE RID: 33742
		private bool _DataLayersInited;
	}
}
