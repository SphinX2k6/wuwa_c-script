using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C33 RID: 3123
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06004781 RID: 18305 RVA: 0x000B4119 File Offset: 0x000B2319
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

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x000B4138 File Offset: 0x000B2338
		public override ETrackControlMode Type
		{
			get
			{
				return (ETrackControlMode)this.Instance.Type;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x000B4145 File Offset: 0x000B2345
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x000B4154 File Offset: 0x000B2354
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

		// Token: 0x0400289E RID: 10398
		private IEntityTrackControl Instance;

		// Token: 0x0400289F RID: 10399
		private List<IEntityTrackControlPoint> _ControlPointsCache;

		// Token: 0x040028A0 RID: 10400
		private bool _ControlPointsInited;
	}
}
