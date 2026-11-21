using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D05 RID: 3333
	public class ISequenceTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06004BEC RID: 19436 RVA: 0x000BE41E File Offset: 0x000BC61E
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

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x000BE43D File Offset: 0x000BC63D
		public override ETrackControlMode Type
		{
			get
			{
				return (ETrackControlMode)this.Instance.Type;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x000BE44A File Offset: 0x000BC64A
		public virtual string Sequence
		{
			get
			{
				return this.Instance.Sequence;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x000BE458 File Offset: 0x000BC658
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

		// Token: 0x04002AF0 RID: 10992
		private ISequenceTrackControl Instance;

		// Token: 0x04002AF1 RID: 10993
		private List<ISequenceTrackControlPoint> _ControlPointsCache;

		// Token: 0x04002AF2 RID: 10994
		private bool _ControlPointsInited;
	}
}
