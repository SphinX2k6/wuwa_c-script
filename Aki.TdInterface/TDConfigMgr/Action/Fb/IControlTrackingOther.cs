using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3A RID: 10810
	public class IControlTrackingOther : IControlTrackingType
	{
		// Token: 0x0600EED2 RID: 61138 RVA: 0x002302E5 File Offset: 0x0022E4E5
		public static IControlTrackingOther Create(IControlTrackingOther? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingOther
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x0600EED3 RID: 61139 RVA: 0x00230304 File Offset: 0x0022E504
		public override EControlTrackingType Type
		{
			get
			{
				return (EControlTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x0600EED4 RID: 61140 RVA: 0x00230314 File Offset: 0x0022E514
		public virtual List<int> Entities
		{
			get
			{
				if (this._EntitiesInited)
				{
					return this._EntitiesCache;
				}
				this._EntitiesInited = true;
				int entitiesLength = this.Instance.EntitiesLength;
				this._EntitiesCache = new List<int>(entitiesLength);
				for (int i = 0; i < entitiesLength; i++)
				{
					this._EntitiesCache.Add(this.Instance.Entities(i));
				}
				return this._EntitiesCache;
			}
		}

		// Token: 0x04008322 RID: 33570
		private IControlTrackingOther Instance;

		// Token: 0x04008323 RID: 33571
		private List<int> _EntitiesCache;

		// Token: 0x04008324 RID: 33572
		private bool _EntitiesInited;
	}
}
