using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DE RID: 10462
	[NullableContext(2)]
	[Nullable(0)]
	public class IAirPassageMove : ISplineMovePattern
	{
		// Token: 0x0600E861 RID: 59489 RVA: 0x00221AC6 File Offset: 0x0021FCC6
		[NullableContext(1)]
		public static IAirPassageMove Create(IAirPassageMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x0600E862 RID: 59490 RVA: 0x00221AE5 File Offset: 0x0021FCE5
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x0600E863 RID: 59491 RVA: 0x00221AF4 File Offset: 0x0021FCF4
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

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x0600E864 RID: 59492 RVA: 0x00221B2C File Offset: 0x0021FD2C
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

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x0600E865 RID: 59493 RVA: 0x00221B64 File Offset: 0x0021FD64
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

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x0600E866 RID: 59494 RVA: 0x00221B9C File Offset: 0x0021FD9C
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

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x0600E867 RID: 59495 RVA: 0x00221BD4 File Offset: 0x0021FDD4
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

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x0600E868 RID: 59496 RVA: 0x00221C0C File Offset: 0x0021FE0C
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

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x0600E869 RID: 59497 RVA: 0x00221C43 File Offset: 0x0021FE43
		public virtual IAirPassageMoveLimit Limit
		{
			get
			{
				if (this._LimitInited)
				{
					return this._LimitCache;
				}
				this._LimitInited = true;
				this._LimitCache = IAirPassageMoveLimit.Create(this.Instance.Limit);
				return this._LimitCache;
			}
		}

		// Token: 0x0400805E RID: 32862
		private IAirPassageMove Instance;

		// Token: 0x0400805F RID: 32863
		private IAirPassageMoveLimit _LimitCache;

		// Token: 0x04008060 RID: 32864
		private bool _LimitInited;
	}
}
