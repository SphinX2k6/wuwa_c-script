using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E4 RID: 8420
	[NullableContext(1)]
	[Nullable(0)]
	public class NewMoveWithSpline : ActionParams
	{
		// Token: 0x0600B90C RID: 47372 RVA: 0x001ABEB4 File Offset: 0x001AA0B4
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

		// Token: 0x0600B90D RID: 47373 RVA: 0x001ABEEC File Offset: 0x001AA0EC
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

		// Token: 0x0600B90E RID: 47374 RVA: 0x001ABEFF File Offset: 0x001AA0FF
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

		// Token: 0x0600B90F RID: 47375 RVA: 0x001ABF14 File Offset: 0x001AA114
		public NewMoveWithSpline_SetValue ToSetValue()
		{
			return new NewMoveWithSpline_SetValue
			{
				MoveTarget = this.MoveTarget,
				SplineEntityId = this.SplineEntityId,
				StartPointIndex = this.StartPointIndex,
				EndPointIndex = this.EndPointIndex,
				IsStartFromCurrentPos = this.IsStartFromCurrentPos,
				IsFollowStrictly = this.IsFollowStrictly
			};
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600B910 RID: 47376 RVA: 0x001ABF6E File Offset: 0x001AA16E
		// (set) Token: 0x0600B911 RID: 47377 RVA: 0x001ABF95 File Offset: 0x001AA195
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

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600B912 RID: 47378 RVA: 0x001ABFA3 File Offset: 0x001AA1A3
		// (set) Token: 0x0600B913 RID: 47379 RVA: 0x001ABFCE File Offset: 0x001AA1CE
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

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600B914 RID: 47380 RVA: 0x001ABFDC File Offset: 0x001AA1DC
		// (set) Token: 0x0600B915 RID: 47381 RVA: 0x001AC016 File Offset: 0x001AA216
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

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600B916 RID: 47382 RVA: 0x001AC024 File Offset: 0x001AA224
		// (set) Token: 0x0600B917 RID: 47383 RVA: 0x001AC05E File Offset: 0x001AA25E
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

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600B918 RID: 47384 RVA: 0x001AC06C File Offset: 0x001AA26C
		// (set) Token: 0x0600B919 RID: 47385 RVA: 0x001AC0A6 File Offset: 0x001AA2A6
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

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600B91A RID: 47386 RVA: 0x001AC0B4 File Offset: 0x001AA2B4
		// (set) Token: 0x0600B91B RID: 47387 RVA: 0x001AC0EE File Offset: 0x001AA2EE
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

		// Token: 0x04006ED7 RID: 28375
		[Nullable(2)]
		protected new NewMoveWithSpline FbInstance;

		// Token: 0x04006ED8 RID: 28376
		[Nullable(2)]
		protected NewMoveWithSpline_SetValue PocoInterface;
	}
}
