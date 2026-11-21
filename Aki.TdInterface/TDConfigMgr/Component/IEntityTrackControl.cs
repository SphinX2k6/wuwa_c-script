using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000382 RID: 898
	public class IEntityTrackControl : ITimelineTrackControlData
	{
		// Token: 0x06001186 RID: 4486 RVA: 0x0003BA20 File Offset: 0x00039C20
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

		// Token: 0x06001187 RID: 4487 RVA: 0x0003BA58 File Offset: 0x00039C58
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

		// Token: 0x06001188 RID: 4488 RVA: 0x0003BA6B File Offset: 0x00039C6B
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

		// Token: 0x06001189 RID: 4489 RVA: 0x0003BA7E File Offset: 0x00039C7E
		public new IEntityTrackControl_SetValue ToSetValue()
		{
			return new IEntityTrackControl_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				ControlPoints = this.ControlPoints
			};
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0003BAA9 File Offset: 0x00039CA9
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x0003BAD4 File Offset: 0x00039CD4
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0003BAE2 File Offset: 0x00039CE2
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x0003BB0D File Offset: 0x00039D0D
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0003BB1C File Offset: 0x00039D1C
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x0003BBAF File Offset: 0x00039DAF
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

		// Token: 0x04000EA8 RID: 3752
		[Nullable(2)]
		protected new IEntityTrackControl FbInstance;

		// Token: 0x04000EA9 RID: 3753
		[Nullable(2)]
		protected new IEntityTrackControl_SetValue PocoInterface;

		// Token: 0x04000EAA RID: 3754
		private List<IEntityTrackControlPoint> _ControlPointsCache;

		// Token: 0x04000EAB RID: 3755
		private bool _ControlPointsInited;
	}
}
