using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033B RID: 827
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x00038A54 File Offset: 0x00036C54
		private IEntityTrackControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityTrackControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityTrackControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityTrackControl_SetValue());
			}
			return result;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00038A8C File Offset: 0x00036C8C
		public static IEntityTrackControl Create([Nullable(2)] IEntityTrackControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityTrackControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00038A9F File Offset: 0x00036C9F
		public static IEntityTrackControl CreateFromSetValue([Nullable(2)] IEntityTrackControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityTrackControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00038AB2 File Offset: 0x00036CB2
		public new IEntityTrackControl_SetValue ToSetValue()
		{
			return new IEntityTrackControl_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				ControlPoints = this.ControlPoints
			};
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00038ADD File Offset: 0x00036CDD
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00038B08 File Offset: 0x00036D08
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00038B16 File Offset: 0x00036D16
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x00038B41 File Offset: 0x00036D41
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00038B50 File Offset: 0x00036D50
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00038BE3 File Offset: 0x00036DE3
		public virtual List<IEntityTrackControlPoint> ControlPoints
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
					List<IEntityTrackControlPoint> controlPoints = this.FbInstance.ControlPoints;
					if (controlPoints != null)
					{
						this._ControlPointsCache = new List<IEntityTrackControlPoint>(controlPoints.Count);
						for (int i = 0; i < controlPoints.Count; i++)
						{
							this._ControlPointsCache.Add(IEntityTrackControlPoint.Create(controlPoints[i]));
						}
					}
				}
				else
				{
					IEntityTrackControl_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000DBD RID: 3517
		[Nullable(2)]
		protected new IEntityTrackControl FbInstance;

		// Token: 0x04000DBE RID: 3518
		[Nullable(2)]
		protected new IEntityTrackControl_SetValue PocoInterface;

		// Token: 0x04000DBF RID: 3519
		private List<IEntityTrackControlPoint> _ControlPointsCache;

		// Token: 0x04000DC0 RID: 3520
		private bool _ControlPointsInited;
	}
}
