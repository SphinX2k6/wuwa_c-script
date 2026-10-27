using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E3 RID: 10467
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSplineMove : ISplineMoveConfig
	{
		// Token: 0x0600E893 RID: 59539 RVA: 0x0022221B File Offset: 0x0022041B
		public static IOpenSplineMove Create(IOpenSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x0600E894 RID: 59540 RVA: 0x0022223A File Offset: 0x0022043A
		public override ESplineMoveConfigType Type
		{
			get
			{
				return (ESplineMoveConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x0600E895 RID: 59541 RVA: 0x00222247 File Offset: 0x00220447
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIOpenSplineMove_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x0600E896 RID: 59542 RVA: 0x00222276 File Offset: 0x00220476
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x0600E897 RID: 59543 RVA: 0x00222283 File Offset: 0x00220483
		public virtual ISplineMovePattern Pattern
		{
			get
			{
				if (this._PatternInited)
				{
					return this._PatternCache;
				}
				this._PatternInited = true;
				this._PatternCache = ActionReadHelper.ReadIOpenSplineMove_Pattern(this.Instance);
				return this._PatternCache;
			}
		}

		// Token: 0x04008069 RID: 32873
		private IOpenSplineMove Instance;

		// Token: 0x0400806A RID: 32874
		private ITargetEntityType _TargetCache;

		// Token: 0x0400806B RID: 32875
		private bool _TargetInited;

		// Token: 0x0400806C RID: 32876
		private ISplineMovePattern _PatternCache;

		// Token: 0x0400806D RID: 32877
		private bool _PatternInited;
	}
}
