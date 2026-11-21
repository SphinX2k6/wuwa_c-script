using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BAB RID: 11179
	public class ISplineMovePattern
	{
		// Token: 0x0600F655 RID: 63061 RVA: 0x0023E203 File Offset: 0x0023C403
		public static ISplineMovePattern Create(ISplineMovePattern? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMovePattern
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x0600F656 RID: 63062 RVA: 0x0023E222 File Offset: 0x0023C422
		public virtual ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x0600F657 RID: 63063 RVA: 0x0023E230 File Offset: 0x0023C430
		public virtual float? MaxOffsetDistance
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

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x0600F658 RID: 63064 RVA: 0x0023E268 File Offset: 0x0023C468
		public virtual bool? IsOneWay
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

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x0600F659 RID: 63065 RVA: 0x0023E2A0 File Offset: 0x0023C4A0
		public virtual float? LayerVerticalLimit
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

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x0600F65A RID: 63066 RVA: 0x0023E2D8 File Offset: 0x0023C4D8
		public virtual bool? DynamicGravity
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

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x0600F65B RID: 63067 RVA: 0x0023E310 File Offset: 0x0023C510
		public virtual float? GravitySwitchAngularVelocity
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

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x0600F65C RID: 63068 RVA: 0x0023E348 File Offset: 0x0023C548
		public virtual int? AutoExitDistance
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

		// Token: 0x04008713 RID: 34579
		private ISplineMovePattern Instance;
	}
}
