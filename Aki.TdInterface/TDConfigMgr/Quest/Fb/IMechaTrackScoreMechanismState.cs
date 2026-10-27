using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001353 RID: 4947
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreMechanismState : IMechaTrackScoreDetectionType
	{
		// Token: 0x06007150 RID: 29008 RVA: 0x00111274 File Offset: 0x0010F474
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

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x00111293 File Offset: 0x0010F493
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				return (EMechaTrackScoreDetectionType)this.Instance.Type;
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x001112A0 File Offset: 0x0010F4A0
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

		// Token: 0x0400416F RID: 16751
		private IMechaTrackScoreMechanismState Instance;

		// Token: 0x04004170 RID: 16752
		private List<IMechaTrackScoreMechanismStateType> _MechanismStateTypesCache;

		// Token: 0x04004171 RID: 16753
		private bool _MechanismStateTypesInited;
	}
}
