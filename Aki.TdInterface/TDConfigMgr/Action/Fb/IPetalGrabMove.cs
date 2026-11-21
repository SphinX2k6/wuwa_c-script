using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB7 RID: 11191
	public class IPetalGrabMove : ISplineMovePattern
	{
		// Token: 0x0600F6B0 RID: 63152 RVA: 0x0023EEA0 File Offset: 0x0023D0A0
		public static IPetalGrabMove Create(IPetalGrabMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x0600F6B1 RID: 63153 RVA: 0x0023EEBF File Offset: 0x0023D0BF
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x0600F6B2 RID: 63154 RVA: 0x0023EECC File Offset: 0x0023D0CC
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

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x0600F6B3 RID: 63155 RVA: 0x0023EF04 File Offset: 0x0023D104
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

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x0600F6B4 RID: 63156 RVA: 0x0023EF3C File Offset: 0x0023D13C
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

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x0600F6B5 RID: 63157 RVA: 0x0023EF74 File Offset: 0x0023D174
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

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x0600F6B6 RID: 63158 RVA: 0x0023EFAC File Offset: 0x0023D1AC
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

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x0600F6B7 RID: 63159 RVA: 0x0023EFE4 File Offset: 0x0023D1E4
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

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x0600F6B8 RID: 63160 RVA: 0x0023F01B File Offset: 0x0023D21B
		public virtual IPetalGrabMoveLinear ControlType
		{
			get
			{
				if (this._ControlTypeInited)
				{
					return this._ControlTypeCache;
				}
				this._ControlTypeInited = true;
				this._ControlTypeCache = IPetalGrabMoveLinear.Create(this.Instance.ControlType);
				return this._ControlTypeCache;
			}
		}

		// Token: 0x04008723 RID: 34595
		private IPetalGrabMove Instance;

		// Token: 0x04008724 RID: 34596
		[Nullable(2)]
		private IPetalGrabMoveLinear _ControlTypeCache;

		// Token: 0x04008725 RID: 34597
		private bool _ControlTypeInited;
	}
}
