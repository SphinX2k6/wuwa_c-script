using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248B RID: 9355
	public class StopNewMoveWithSpline : ActionParams
	{
		// Token: 0x0600CB84 RID: 52100 RVA: 0x001D042C File Offset: 0x001CE62C
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

		// Token: 0x0600CB85 RID: 52101 RVA: 0x001D0464 File Offset: 0x001CE664
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

		// Token: 0x0600CB86 RID: 52102 RVA: 0x001D0477 File Offset: 0x001CE677
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

		// Token: 0x0600CB87 RID: 52103 RVA: 0x001D048A File Offset: 0x001CE68A
		public StopNewMoveWithSpline_SetValue ToSetValue()
		{
			return new StopNewMoveWithSpline_SetValue
			{
				StopTarget = this.StopTarget,
				StopType = this.StopType
			};
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600CB88 RID: 52104 RVA: 0x001D04A9 File Offset: 0x001CE6A9
		// (set) Token: 0x0600CB89 RID: 52105 RVA: 0x001D04D0 File Offset: 0x001CE6D0
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

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x001D04DE File Offset: 0x001CE6DE
		// (set) Token: 0x0600CB8B RID: 52107 RVA: 0x001D0505 File Offset: 0x001CE705
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

		// Token: 0x040078A8 RID: 30888
		[Nullable(2)]
		protected new StopNewMoveWithSpline FbInstance;

		// Token: 0x040078A9 RID: 30889
		[Nullable(2)]
		protected StopNewMoveWithSpline_SetValue PocoInterface;
	}
}
