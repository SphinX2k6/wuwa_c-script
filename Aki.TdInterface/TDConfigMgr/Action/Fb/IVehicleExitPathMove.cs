using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D6 RID: 10710
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleExitPathMove : IVehicleControlType
	{
		// Token: 0x0600ECAA RID: 60586 RVA: 0x00228D51 File Offset: 0x00226F51
		public static IVehicleExitPathMove Create(IVehicleExitPathMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleExitPathMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x0600ECAB RID: 60587 RVA: 0x00228D70 File Offset: 0x00226F70
		public override EVehicleControlType Type
		{
			get
			{
				return (EVehicleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x0600ECAC RID: 60588 RVA: 0x00228D7D File Offset: 0x00226F7D
		public virtual ICloseSplineMovePattern Pattern
		{
			get
			{
				if (this._PatternInited)
				{
					return this._PatternCache;
				}
				this._PatternInited = true;
				this._PatternCache = ActionReadHelper.ReadIVehicleExitPathMove_Pattern(this.Instance);
				return this._PatternCache;
			}
		}

		// Token: 0x04008252 RID: 33362
		private IVehicleExitPathMove Instance;

		// Token: 0x04008253 RID: 33363
		private ICloseSplineMovePattern _PatternCache;

		// Token: 0x04008254 RID: 33364
		private bool _PatternInited;
	}
}
