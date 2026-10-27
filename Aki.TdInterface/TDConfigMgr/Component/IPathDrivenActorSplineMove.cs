using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DE RID: 1502
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathDrivenActorSplineMove : IPathDrivenActorMoveBase
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x00058D98 File Offset: 0x00056F98
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

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00058DD0 File Offset: 0x00056FD0
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

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00058DE3 File Offset: 0x00056FE3
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

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00058DF8 File Offset: 0x00056FF8
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

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x00058E52 File Offset: 0x00057052
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00058E7D File Offset: 0x0005707D
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00058E8B File Offset: 0x0005708B
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x00058EB2 File Offset: 0x000570B2
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

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x00058EC0 File Offset: 0x000570C0
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x00058EFA File Offset: 0x000570FA
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

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00058F08 File Offset: 0x00057108
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00058F42 File Offset: 0x00057142
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00058F50 File Offset: 0x00057150
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00058F8A File Offset: 0x0005718A
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

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00058F98 File Offset: 0x00057198
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x00058FD2 File Offset: 0x000571D2
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

		// Token: 0x04001661 RID: 5729
		[Nullable(2)]
		protected new IPathDrivenActorSplineMove FbInstance;

		// Token: 0x04001662 RID: 5730
		[Nullable(2)]
		protected new IPathDrivenActorSplineMove_SetValue PocoInterface;
	}
}
