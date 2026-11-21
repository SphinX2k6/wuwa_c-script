using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002345 RID: 9029
	public class NewMoveWithSpline : ActionParams
	{
		// Token: 0x0600C496 RID: 50326 RVA: 0x001C2F90 File Offset: 0x001C1190
		private NewMoveWithSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NewMoveWithSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NewMoveWithSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NewMoveWithSpline_SetValue());
			}
			return result;
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x001C2FC8 File Offset: 0x001C11C8
		public static NewMoveWithSpline Create([Nullable(2)] NewMoveWithSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NewMoveWithSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C498 RID: 50328 RVA: 0x001C2FDB File Offset: 0x001C11DB
		public static NewMoveWithSpline CreateFromSetValue([Nullable(2)] NewMoveWithSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NewMoveWithSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C499 RID: 50329 RVA: 0x001C2FF0 File Offset: 0x001C11F0
		public NewMoveWithSpline_SetValue ToSetValue()
		{
			return new NewMoveWithSpline_SetValue
			{
				MoveTarget = this.MoveTarget,
				Move = this.Move,
				SplineEntityId = this.SplineEntityId,
				StartPointIndex = this.StartPointIndex,
				EndPointIndex = this.EndPointIndex,
				IsStartFromCurrentPos = this.IsStartFromCurrentPos,
				IsFollowStrictly = this.IsFollowStrictly
			};
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600C49A RID: 50330 RVA: 0x001C3056 File Offset: 0x001C1256
		// (set) Token: 0x0600C49B RID: 50331 RVA: 0x001C307D File Offset: 0x001C127D
		public virtual INewSplineMoveTarget MoveTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveTarget;
				}
				NewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveTarget;
			}
			set
			{
				this.GetOrCreatePoco().MoveTarget = value;
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600C49C RID: 50332 RVA: 0x001C308C File Offset: 0x001C128C
		// (set) Token: 0x0600C49D RID: 50333 RVA: 0x001C30ED File Offset: 0x001C12ED
		[Nullable(2)]
		public virtual IFrontAxleTrackingSplineMove Move
		{
			[NullableContext(2)]
			get
			{
				if (this._MoveInited)
				{
					return this._MoveCache;
				}
				this._MoveInited = true;
				if (this.FbInstance != null)
				{
					this._MoveCache = IFrontAxleTrackingSplineMove.Create(this.FbInstance.Move);
				}
				else
				{
					NewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
					this._MoveCache = ((pocoInterface != null) ? pocoInterface.Move : null);
				}
				return this._MoveCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Move = value;
				this._MoveInited = false;
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600C49E RID: 50334 RVA: 0x001C3102 File Offset: 0x001C1302
		// (set) Token: 0x0600C49F RID: 50335 RVA: 0x001C312D File Offset: 0x001C132D
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0600C4A0 RID: 50336 RVA: 0x001C313C File Offset: 0x001C133C
		// (set) Token: 0x0600C4A1 RID: 50337 RVA: 0x001C3176 File Offset: 0x001C1376
		public virtual int? StartPointIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartPointIndex;
				}
				NewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartPointIndex;
			}
			set
			{
				this.GetOrCreatePoco().StartPointIndex = value;
			}
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600C4A2 RID: 50338 RVA: 0x001C3184 File Offset: 0x001C1384
		// (set) Token: 0x0600C4A3 RID: 50339 RVA: 0x001C31BE File Offset: 0x001C13BE
		public virtual int? EndPointIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPointIndex;
				}
				NewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndPointIndex;
			}
			set
			{
				this.GetOrCreatePoco().EndPointIndex = value;
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600C4A4 RID: 50340 RVA: 0x001C31CC File Offset: 0x001C13CC
		// (set) Token: 0x0600C4A5 RID: 50341 RVA: 0x001C3206 File Offset: 0x001C1406
		public virtual bool? IsStartFromCurrentPos
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsStartFromCurrentPos;
				}
				NewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsStartFromCurrentPos;
			}
			set
			{
				this.GetOrCreatePoco().IsStartFromCurrentPos = value;
			}
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x001C3214 File Offset: 0x001C1414
		// (set) Token: 0x0600C4A7 RID: 50343 RVA: 0x001C324E File Offset: 0x001C144E
		public virtual bool? IsFollowStrictly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFollowStrictly;
				}
				NewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFollowStrictly;
			}
			set
			{
				this.GetOrCreatePoco().IsFollowStrictly = value;
			}
		}

		// Token: 0x04007508 RID: 29960
		[Nullable(2)]
		protected new NewMoveWithSpline FbInstance;

		// Token: 0x04007509 RID: 29961
		[Nullable(2)]
		protected NewMoveWithSpline_SetValue PocoInterface;

		// Token: 0x0400750A RID: 29962
		private IFrontAxleTrackingSplineMove _MoveCache;

		// Token: 0x0400750B RID: 29963
		private bool _MoveInited;
	}
}
