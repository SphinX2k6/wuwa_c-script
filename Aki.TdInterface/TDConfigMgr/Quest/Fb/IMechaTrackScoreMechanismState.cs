using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A3 RID: 5283
	public class IMechaTrackScoreMechanismState : IMechaTrackScoreDetectionType
	{
		// Token: 0x060077F0 RID: 30704 RVA: 0x0011F7E0 File Offset: 0x0011D9E0
		public static IMechaTrackScoreMechanismState Create(IMechaTrackScoreMechanismState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x060077F1 RID: 30705 RVA: 0x0011F7FF File Offset: 0x0011D9FF
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x0011F80C File Offset: 0x0011DA0C
		public virtual List<IMechaTrackScoreMechanismStateType> MechanismStateTypes
		{
			get
			{
				if (this._MechanismStateTypesInited)
				{
					return this._MechanismStateTypesCache;
				}
				this._MechanismStateTypesInited = true;
				int mechanismStateTypesLength = this.Instance.MechanismStateTypesLength;
				this._MechanismStateTypesCache = new List<IMechaTrackScoreMechanismStateType>(mechanismStateTypesLength);
				for (int i = 0; i < mechanismStateTypesLength; i++)
				{
					this._MechanismStateTypesCache.Add(IMechaTrackScoreMechanismStateType.Create(this.Instance.MechanismStateTypes(i)));
				}
				return this._MechanismStateTypesCache;
			}
		}

		// Token: 0x040044EB RID: 17643
		private IMechaTrackScoreMechanismState Instance;

		// Token: 0x040044EC RID: 17644
		private List<IMechaTrackScoreMechanismStateType> _MechanismStateTypesCache;

		// Token: 0x040044ED RID: 17645
		private bool _MechanismStateTypesInited;
	}
}
