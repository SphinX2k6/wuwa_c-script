using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC2 RID: 11458
	public class IVehicleEnterPathMove : IVehicleControlType
	{
		// Token: 0x0600FB3C RID: 64316 RVA: 0x0024663E File Offset: 0x0024483E
		public static IVehicleEnterPathMove Create(IVehicleEnterPathMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnterPathMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x0600FB3D RID: 64317 RVA: 0x0024665D File Offset: 0x0024485D
		public override EVehicleControlType Type
		{
			get
			{
				return (EVehicleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x0600FB3E RID: 64318 RVA: 0x0024666A File Offset: 0x0024486A
		public virtual IVehicleCruisingParams ControlParams
		{
			get
			{
				if (this._ControlParamsInited)
				{
					return this._ControlParamsCache;
				}
				this._ControlParamsInited = true;
				this._ControlParamsCache = IVehicleCruisingParams.Create(this.Instance.ControlParams);
				return this._ControlParamsCache;
			}
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x0600FB3F RID: 64319 RVA: 0x0024669E File Offset: 0x0024489E
		public virtual ISplineMovePattern Pattern
		{
			get
			{
				if (this._PatternInited)
				{
					return this._PatternCache;
				}
				this._PatternInited = true;
				this._PatternCache = ActionReadHelper.ReadIVehicleEnterPathMove_Pattern(this.Instance);
				return this._PatternCache;
			}
		}

		// Token: 0x0400893E RID: 35134
		private IVehicleEnterPathMove Instance;

		// Token: 0x0400893F RID: 35135
		[Nullable(2)]
		private IVehicleCruisingParams _ControlParamsCache;

		// Token: 0x04008940 RID: 35136
		private bool _ControlParamsInited;

		// Token: 0x04008941 RID: 35137
		private ISplineMovePattern _PatternCache;

		// Token: 0x04008942 RID: 35138
		private bool _PatternInited;
	}
}
