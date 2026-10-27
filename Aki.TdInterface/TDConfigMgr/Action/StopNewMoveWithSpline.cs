using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002220 RID: 8736
	[NullableContext(1)]
	[Nullable(0)]
	public class StopNewMoveWithSpline : ActionParams
	{
		// Token: 0x0600BFC6 RID: 49094 RVA: 0x001B8D60 File Offset: 0x001B6F60
		private StopNewMoveWithSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StopNewMoveWithSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StopNewMoveWithSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StopNewMoveWithSpline_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFC7 RID: 49095 RVA: 0x001B8D98 File Offset: 0x001B6F98
		public static StopNewMoveWithSpline Create([Nullable(2)] StopNewMoveWithSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopNewMoveWithSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFC8 RID: 49096 RVA: 0x001B8DAB File Offset: 0x001B6FAB
		public static StopNewMoveWithSpline CreateFromSetValue([Nullable(2)] StopNewMoveWithSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StopNewMoveWithSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFC9 RID: 49097 RVA: 0x001B8DBE File Offset: 0x001B6FBE
		public StopNewMoveWithSpline_SetValue ToSetValue()
		{
			return new StopNewMoveWithSpline_SetValue
			{
				StopTarget = this.StopTarget,
				StopType = this.StopType
			};
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600BFCA RID: 49098 RVA: 0x001B8DDD File Offset: 0x001B6FDD
		// (set) Token: 0x0600BFCB RID: 49099 RVA: 0x001B8E04 File Offset: 0x001B7004
		public virtual INewSplineStopTarget StopTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopTarget;
				}
				StopNewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopTarget;
			}
			set
			{
				this.GetOrCreatePoco().StopTarget = value;
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600BFCC RID: 49100 RVA: 0x001B8E12 File Offset: 0x001B7012
		// (set) Token: 0x0600BFCD RID: 49101 RVA: 0x001B8E39 File Offset: 0x001B7039
		public virtual IStopNewMoveWithSplineType StopType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopType;
				}
				StopNewMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopType;
			}
			set
			{
				this.GetOrCreatePoco().StopType = value;
			}
		}

		// Token: 0x0400725E RID: 29278
		[Nullable(2)]
		protected new StopNewMoveWithSpline FbInstance;

		// Token: 0x0400725F RID: 29279
		[Nullable(2)]
		protected StopNewMoveWithSpline_SetValue PocoInterface;
	}
}
