using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D5 RID: 10709
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEnterPathMove : IVehicleControlType
	{
		// Token: 0x0600ECA5 RID: 60581 RVA: 0x00228CBA File Offset: 0x00226EBA
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

		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x0600ECA6 RID: 60582 RVA: 0x00228CD9 File Offset: 0x00226ED9
		public override EVehicleControlType Type
		{
			get
			{
				return (EVehicleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x0600ECA7 RID: 60583 RVA: 0x00228CE6 File Offset: 0x00226EE6
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

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x0600ECA8 RID: 60584 RVA: 0x00228D1A File Offset: 0x00226F1A
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

		// Token: 0x0400824D RID: 33357
		private IVehicleEnterPathMove Instance;

		// Token: 0x0400824E RID: 33358
		[Nullable(2)]
		private IVehicleCruisingParams _ControlParamsCache;

		// Token: 0x0400824F RID: 33359
		private bool _ControlParamsInited;

		// Token: 0x04008250 RID: 33360
		private ISplineMovePattern _PatternCache;

		// Token: 0x04008251 RID: 33361
		private bool _PatternInited;
	}
}
