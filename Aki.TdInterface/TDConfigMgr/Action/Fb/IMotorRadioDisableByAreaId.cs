using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C12 RID: 11282
	public class IMotorRadioDisableByAreaId : IMotorRadioDisableRange
	{
		// Token: 0x0600F859 RID: 63577 RVA: 0x00241B6D File Offset: 0x0023FD6D
		public static IMotorRadioDisableByAreaId Create(IMotorRadioDisableByAreaId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioDisableByAreaId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x0600F85A RID: 63578 RVA: 0x00241B8C File Offset: 0x0023FD8C
		public override EMotorRadioDisableRangeType Type
		{
			get
			{
				return (EMotorRadioDisableRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x0600F85B RID: 63579 RVA: 0x00241B9C File Offset: 0x0023FD9C
		public virtual List<int> AreaIdList
		{
			get
			{
				if (this._AreaIdListInited)
				{
					return this._AreaIdListCache;
				}
				this._AreaIdListInited = true;
				int areaIdListLength = this.Instance.AreaIdListLength;
				this._AreaIdListCache = new List<int>(areaIdListLength);
				for (int i = 0; i < areaIdListLength; i++)
				{
					this._AreaIdListCache.Add(this.Instance.AreaIdList(i));
				}
				return this._AreaIdListCache;
			}
		}

		// Token: 0x040087E2 RID: 34786
		private IMotorRadioDisableByAreaId Instance;

		// Token: 0x040087E3 RID: 34787
		private List<int> _AreaIdListCache;

		// Token: 0x040087E4 RID: 34788
		private bool _AreaIdListInited;
	}
}
