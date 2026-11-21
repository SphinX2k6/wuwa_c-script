using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C14 RID: 11284
	public class IMotorRadioDisableByRangeEntities : IMotorRadioDisableRange
	{
		// Token: 0x0600F862 RID: 63586 RVA: 0x00241C78 File Offset: 0x0023FE78
		public static IMotorRadioDisableByRangeEntities Create(IMotorRadioDisableByRangeEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioDisableByRangeEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x0600F863 RID: 63587 RVA: 0x00241C97 File Offset: 0x0023FE97
		public override EMotorRadioDisableRangeType Type
		{
			get
			{
				return (EMotorRadioDisableRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x0600F864 RID: 63588 RVA: 0x00241CA4 File Offset: 0x0023FEA4
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this._RangeEntitiesInited)
				{
					return this._RangeEntitiesCache;
				}
				this._RangeEntitiesInited = true;
				int rangeEntitiesLength = this.Instance.RangeEntitiesLength;
				this._RangeEntitiesCache = new List<int>(rangeEntitiesLength);
				for (int i = 0; i < rangeEntitiesLength; i++)
				{
					this._RangeEntitiesCache.Add(this.Instance.RangeEntities(i));
				}
				return this._RangeEntitiesCache;
			}
		}

		// Token: 0x040087E8 RID: 34792
		private IMotorRadioDisableByRangeEntities Instance;

		// Token: 0x040087E9 RID: 34793
		private List<int> _RangeEntitiesCache;

		// Token: 0x040087EA RID: 34794
		private bool _RangeEntitiesInited;
	}
}
