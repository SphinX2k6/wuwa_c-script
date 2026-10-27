using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C0 RID: 1728
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06002524 RID: 9508 RVA: 0x000643F0 File Offset: 0x000625F0
		private ISequenceTrackControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISequenceTrackControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISequenceTrackControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISequenceTrackControl_SetValue());
			}
			return result;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00064428 File Offset: 0x00062628
		public static ISequenceTrackControl Create([Nullable(2)] ISequenceTrackControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceTrackControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0006443B File Offset: 0x0006263B
		public static ISequenceTrackControl CreateFromSetValue([Nullable(2)] ISequenceTrackControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISequenceTrackControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0006444E File Offset: 0x0006264E
		public new ISequenceTrackControl_SetValue ToSetValue()
		{
			return new ISequenceTrackControl_SetValue
			{
				Type = this.Type,
				Sequence = this.Sequence,
				ControlPoints = this.ControlPoints
			};
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00064479 File Offset: 0x00062679
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x000644A4 File Offset: 0x000626A4
		public override ETrackControlMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackControlMode.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000644B2 File Offset: 0x000626B2
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x000644DD File Offset: 0x000626DD
		public virtual string Sequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Sequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Sequence;
			}
			set
			{
				this.GetOrCreatePoco().Sequence = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000644EC File Offset: 0x000626EC
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x0006457F File Offset: 0x0006277F
		public virtual List<ISequenceTrackControlPoint> ControlPoints
		{
			get
			{
				if (this._ControlPointsInited)
				{
					return this._ControlPointsCache;
				}
				this._ControlPointsInited = true;
				if (this.FbInstance != null)
				{
					List<ISequenceTrackControlPoint> controlPoints = this.FbInstance.ControlPoints;
					if (controlPoints != null)
					{
						this._ControlPointsCache = new List<ISequenceTrackControlPoint>(controlPoints.Count);
						for (int i = 0; i < controlPoints.Count; i++)
						{
							this._ControlPointsCache.Add(ISequenceTrackControlPoint.Create(controlPoints[i]));
						}
					}
				}
				else
				{
					ISequenceTrackControl_SetValue pocoInterface = this.PocoInterface;
					this._ControlPointsCache = ((pocoInterface != null) ? pocoInterface.ControlPoints : null);
				}
				return this._ControlPointsCache;
			}
			set
			{
				this.GetOrCreatePoco().ControlPoints = value;
				this._ControlPointsInited = false;
			}
		}

		// Token: 0x04001969 RID: 6505
		[Nullable(2)]
		protected new ISequenceTrackControl FbInstance;

		// Token: 0x0400196A RID: 6506
		[Nullable(2)]
		protected new ISequenceTrackControl_SetValue PocoInterface;

		// Token: 0x0400196B RID: 6507
		private List<ISequenceTrackControlPoint> _ControlPointsCache;

		// Token: 0x0400196C RID: 6508
		private bool _ControlPointsInited;
	}
}
