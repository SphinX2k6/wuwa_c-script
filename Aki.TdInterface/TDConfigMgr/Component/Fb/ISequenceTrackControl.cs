using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C32 RID: 3122
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceTrackControl : ITimelineTrackControlData
	{
		// Token: 0x0600477C RID: 18300 RVA: 0x000B406E File Offset: 0x000B226E
		public static ISequenceTrackControl Create(ISequenceTrackControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceTrackControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x000B408D File Offset: 0x000B228D
		public override ETrackControlMode Type
		{
			get
			{
				return (ETrackControlMode)this.Instance.Type;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x000B409A File Offset: 0x000B229A
		public virtual string Sequence
		{
			get
			{
				return this.Instance.Sequence;
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x000B40A8 File Offset: 0x000B22A8
		public virtual List<ISequenceTrackControlPoint> ControlPoints
		{
			get
			{
				if (this._ControlPointsInited)
				{
					return this._ControlPointsCache;
				}
				this._ControlPointsInited = true;
				int controlPointsLength = this.Instance.ControlPointsLength;
				this._ControlPointsCache = new List<ISequenceTrackControlPoint>(controlPointsLength);
				for (int i = 0; i < controlPointsLength; i++)
				{
					this._ControlPointsCache.Add(ISequenceTrackControlPoint.Create(this.Instance.ControlPoints(i)));
				}
				return this._ControlPointsCache;
			}
		}

		// Token: 0x0400289B RID: 10395
		private ISequenceTrackControl Instance;

		// Token: 0x0400289C RID: 10396
		private List<ISequenceTrackControlPoint> _ControlPointsCache;

		// Token: 0x0400289D RID: 10397
		private bool _ControlPointsInited;
	}
}
