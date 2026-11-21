using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BBB RID: 11195
	public class IOpenSplineMove : ISplineMoveConfig
	{
		// Token: 0x0600F6D4 RID: 63188 RVA: 0x0023F3D3 File Offset: 0x0023D5D3
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

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x0600F6D5 RID: 63189 RVA: 0x0023F3F2 File Offset: 0x0023D5F2
		public override ESplineMoveConfigType Type
		{
			get
			{
				return (ESplineMoveConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x0600F6D6 RID: 63190 RVA: 0x0023F3FF File Offset: 0x0023D5FF
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

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x0600F6D7 RID: 63191 RVA: 0x0023F42E File Offset: 0x0023D62E
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x0600F6D8 RID: 63192 RVA: 0x0023F43B File Offset: 0x0023D63B
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

		// Token: 0x0400872D RID: 34605
		private IOpenSplineMove Instance;

		// Token: 0x0400872E RID: 34606
		private ITargetEntityType _TargetCache;

		// Token: 0x0400872F RID: 34607
		private bool _TargetInited;

		// Token: 0x04008730 RID: 34608
		private ISplineMovePattern _PatternCache;

		// Token: 0x04008731 RID: 34609
		private bool _PatternInited;
	}
}
