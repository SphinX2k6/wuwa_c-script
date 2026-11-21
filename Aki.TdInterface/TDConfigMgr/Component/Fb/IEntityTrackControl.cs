using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D06 RID: 3334
	public class IEntityTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06004BF1 RID: 19441 RVA: 0x000BE4C9 File Offset: 0x000BC6C9
		public static IEntityTrackControl Create(IEntityTrackControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityTrackControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x000BE4E8 File Offset: 0x000BC6E8
		public override ETrackControlMode Type
		{
			get
			{
				return (ETrackControlMode)this.Instance.Type;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x000BE4F5 File Offset: 0x000BC6F5
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x000BE504 File Offset: 0x000BC704
		public virtual List<IEntityTrackControlPoint> ControlPoints
		{
			get
			{
				if (this._ControlPointsInited)
				{
					return this._ControlPointsCache;
				}
				this._ControlPointsInited = true;
				int controlPointsLength = this.Instance.ControlPointsLength;
				this._ControlPointsCache = new List<IEntityTrackControlPoint>(controlPointsLength);
				for (int i = 0; i < controlPointsLength; i++)
				{
					this._ControlPointsCache.Add(IEntityTrackControlPoint.Create(this.Instance.ControlPoints(i)));
				}
				return this._ControlPointsCache;
			}
		}

		// Token: 0x04002AF3 RID: 10995
		private IEntityTrackControl Instance;

		// Token: 0x04002AF4 RID: 10996
		private List<IEntityTrackControlPoint> _ControlPointsCache;

		// Token: 0x04002AF5 RID: 10997
		private bool _ControlPointsInited;
	}
}
