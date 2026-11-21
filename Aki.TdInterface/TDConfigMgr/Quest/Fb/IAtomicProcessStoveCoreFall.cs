using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001563 RID: 5475
	public class IAtomicProcessStoveCoreFall : IAtomicProcessBase
	{
		// Token: 0x06007B76 RID: 31606 RVA: 0x00125AAB File Offset: 0x00123CAB
		public static IAtomicProcessStoveCoreFall Create(IAtomicProcessStoveCoreFall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessStoveCoreFall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x06007B77 RID: 31607 RVA: 0x00125ACA File Offset: 0x00123CCA
		public override EAtomicProcess Type
		{
			get
			{
				return (EAtomicProcess)this.Instance.Type;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x06007B78 RID: 31608 RVA: 0x00125AD8 File Offset: 0x00123CD8
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this._SplineEntityIdsInited)
				{
					return this._SplineEntityIdsCache;
				}
				this._SplineEntityIdsInited = true;
				int splineEntityIdsLength = this.Instance.SplineEntityIdsLength;
				this._SplineEntityIdsCache = new List<int>(splineEntityIdsLength);
				for (int i = 0; i < splineEntityIdsLength; i++)
				{
					this._SplineEntityIdsCache.Add(this.Instance.SplineEntityIds(i));
				}
				return this._SplineEntityIdsCache;
			}
		}

		// Token: 0x04004721 RID: 18209
		private IAtomicProcessStoveCoreFall Instance;

		// Token: 0x04004722 RID: 18210
		private List<int> _SplineEntityIdsCache;

		// Token: 0x04004723 RID: 18211
		private bool _SplineEntityIdsInited;
	}
}
