using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB3 RID: 11187
	[NullableContext(2)]
	[Nullable(0)]
	public class IAirPassageMove : ISplineMovePattern
	{
		// Token: 0x0600F690 RID: 63120 RVA: 0x0023EA46 File Offset: 0x0023CC46
		[NullableContext(0)]
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

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x0600F691 RID: 63121 RVA: 0x0023EA65 File Offset: 0x0023CC65
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x0600F692 RID: 63122 RVA: 0x0023EA74 File Offset: 0x0023CC74
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

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x0600F693 RID: 63123 RVA: 0x0023EAAC File Offset: 0x0023CCAC
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

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x0600F694 RID: 63124 RVA: 0x0023EAE4 File Offset: 0x0023CCE4
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

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x0600F695 RID: 63125 RVA: 0x0023EB1C File Offset: 0x0023CD1C
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

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x0600F696 RID: 63126 RVA: 0x0023EB54 File Offset: 0x0023CD54
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

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x0600F697 RID: 63127 RVA: 0x0023EB8C File Offset: 0x0023CD8C
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

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x0600F698 RID: 63128 RVA: 0x0023EBC3 File Offset: 0x0023CDC3
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

		// Token: 0x0400871D RID: 34589
		private IAirPassageMove Instance;

		// Token: 0x0400871E RID: 34590
		private IAirPassageMoveLimit _LimitCache;

		// Token: 0x0400871F RID: 34591
		private bool _LimitInited;
	}
}
