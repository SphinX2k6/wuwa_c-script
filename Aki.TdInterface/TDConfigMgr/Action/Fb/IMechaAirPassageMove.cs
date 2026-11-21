using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB4 RID: 11188
	public class IMechaAirPassageMove : ISplineMovePattern
	{
		// Token: 0x0600F69A RID: 63130 RVA: 0x0023EBFF File Offset: 0x0023CDFF
		public static IMechaAirPassageMove Create(IMechaAirPassageMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaAirPassageMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x0600F69B RID: 63131 RVA: 0x0023EC1E File Offset: 0x0023CE1E
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x0600F69C RID: 63132 RVA: 0x0023EC2C File Offset: 0x0023CE2C
		public override float? MaxOffsetDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxOffsetDistance);
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x0600F69D RID: 63133 RVA: 0x0023EC64 File Offset: 0x0023CE64
		public override bool? IsOneWay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOneWay);
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x0600F69E RID: 63134 RVA: 0x0023EC9C File Offset: 0x0023CE9C
		public override float? LayerVerticalLimit
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LayerVerticalLimit);
			}
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x0600F69F RID: 63135 RVA: 0x0023ECD4 File Offset: 0x0023CED4
		public override bool? DynamicGravity
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DynamicGravity);
			}
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x0600F6A0 RID: 63136 RVA: 0x0023ED0C File Offset: 0x0023CF0C
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.GravitySwitchAngularVelocity);
			}
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x0600F6A1 RID: 63137 RVA: 0x0023ED44 File Offset: 0x0023CF44
		public override int? AutoExitDistance
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AutoExitDistance);
			}
		}

		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x0600F6A2 RID: 63138 RVA: 0x0023ED7B File Offset: 0x0023CF7B
		public virtual float ForwardAngleLimit
		{
			get
			{
				return this.Instance.ForwardAngleLimit;
			}
		}

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x0600F6A3 RID: 63139 RVA: 0x0023ED88 File Offset: 0x0023CF88
		[Nullable(2)]
		public virtual string ForwardAngleLimitCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ForwardAngleLimitCurve;
			}
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x0600F6A4 RID: 63140 RVA: 0x0023ED95 File Offset: 0x0023CF95
		public virtual string InputCorrectionCurve
		{
			get
			{
				return this.Instance.InputCorrectionCurve;
			}
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x0600F6A5 RID: 63141 RVA: 0x0023EDA4 File Offset: 0x0023CFA4
		public virtual float? InputCorrectionBaseAngle
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new float?(this.Instance.InputCorrectionBaseAngle);
			}
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x0600F6A6 RID: 63142 RVA: 0x0023EDDC File Offset: 0x0023CFDC
		public virtual float? CorrectionPredictionDistance
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new float?(this.Instance.CorrectionPredictionDistance);
			}
		}

		// Token: 0x04008720 RID: 34592
		private IMechaAirPassageMove Instance;
	}
}
