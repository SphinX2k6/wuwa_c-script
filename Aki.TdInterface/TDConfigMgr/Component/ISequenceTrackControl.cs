using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000761 RID: 1889
	public class ISequenceTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06002844 RID: 10308 RVA: 0x0006B460 File Offset: 0x00069660
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

		// Token: 0x06002845 RID: 10309 RVA: 0x0006B498 File Offset: 0x00069698
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

		// Token: 0x06002846 RID: 10310 RVA: 0x0006B4AB File Offset: 0x000696AB
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

		// Token: 0x06002847 RID: 10311 RVA: 0x0006B4BE File Offset: 0x000696BE
		public new ISequenceTrackControl_SetValue ToSetValue()
		{
			return new ISequenceTrackControl_SetValue
			{
				Type = this.Type,
				Sequence = this.Sequence,
				ControlPoints = this.ControlPoints
			};
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x0006B4E9 File Offset: 0x000696E9
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x0006B514 File Offset: 0x00069714
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

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x0006B522 File Offset: 0x00069722
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0006B54D File Offset: 0x0006974D
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

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x0006B55C File Offset: 0x0006975C
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x0006B5EF File Offset: 0x000697EF
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

		// Token: 0x04001B68 RID: 7016
		[Nullable(2)]
		protected new ISequenceTrackControl FbInstance;

		// Token: 0x04001B69 RID: 7017
		[Nullable(2)]
		protected new ISequenceTrackControl_SetValue PocoInterface;

		// Token: 0x04001B6A RID: 7018
		private List<ISequenceTrackControlPoint> _ControlPointsCache;

		// Token: 0x04001B6B RID: 7019
		private bool _ControlPointsInited;
	}
}
