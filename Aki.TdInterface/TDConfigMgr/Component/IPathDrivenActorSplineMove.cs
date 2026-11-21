using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066F RID: 1647
	public class IPathDrivenActorSplineMove : IPathDrivenActorMoveBase
	{
		// Token: 0x06002292 RID: 8850 RVA: 0x0005F424 File Offset: 0x0005D624
		private IPathDrivenActorSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathDrivenActorSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathDrivenActorSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathDrivenActorSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0005F45C File Offset: 0x0005D65C
		public static IPathDrivenActorSplineMove Create([Nullable(2)] IPathDrivenActorSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0005F46F File Offset: 0x0005D66F
		public static IPathDrivenActorSplineMove CreateFromSetValue([Nullable(2)] IPathDrivenActorSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathDrivenActorSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0005F484 File Offset: 0x0005D684
		public new IPathDrivenActorSplineMove_SetValue ToSetValue()
		{
			return new IPathDrivenActorSplineMove_SetValue
			{
				Type = this.Type,
				SplineEntityIds = this.SplineEntityIds,
				IsRandomSpline = this.IsRandomSpline,
				IsChainedSpline = this.IsChainedSpline,
				IsLoop = this.IsLoop,
				IsFollowSplineDir = this.IsFollowSplineDir
			};
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x0005F4DE File Offset: 0x0005D6DE
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x0005F509 File Offset: 0x0005D709
		public override EPathDrivenActorMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathDrivenActorMoveType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0005F517 File Offset: 0x0005D717
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x0005F53E File Offset: 0x0005D73E
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityIds;
				}
				IPathDrivenActorSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityIds = value;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0005F54C File Offset: 0x0005D74C
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0005F586 File Offset: 0x0005D786
		public virtual bool? IsRandomSpline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRandomSpline;
				}
				IPathDrivenActorSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRandomSpline;
			}
			set
			{
				this.GetOrCreatePoco().IsRandomSpline = value;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0005F594 File Offset: 0x0005D794
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0005F5CE File Offset: 0x0005D7CE
		public virtual bool? IsChainedSpline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsChainedSpline;
				}
				IPathDrivenActorSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsChainedSpline;
			}
			set
			{
				this.GetOrCreatePoco().IsChainedSpline = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x0005F5DC File Offset: 0x0005D7DC
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x0005F616 File Offset: 0x0005D816
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				IPathDrivenActorSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0005F624 File Offset: 0x0005D824
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x0005F65E File Offset: 0x0005D85E
		public virtual bool? IsFollowSplineDir
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFollowSplineDir;
				}
				IPathDrivenActorSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFollowSplineDir;
			}
			set
			{
				this.GetOrCreatePoco().IsFollowSplineDir = value;
			}
		}

		// Token: 0x04001838 RID: 6200
		[Nullable(2)]
		protected new IPathDrivenActorSplineMove FbInstance;

		// Token: 0x04001839 RID: 6201
		[Nullable(2)]
		protected new IPathDrivenActorSplineMove_SetValue PocoInterface;
	}
}
