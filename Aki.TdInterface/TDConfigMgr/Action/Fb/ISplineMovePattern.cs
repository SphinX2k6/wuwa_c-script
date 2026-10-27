using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D6 RID: 10454
	public class ISplineMovePattern
	{
		// Token: 0x0600E826 RID: 59430 RVA: 0x00221283 File Offset: 0x0021F483
		[NullableContext(1)]
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

		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x0600E827 RID: 59431 RVA: 0x002212A2 File Offset: 0x0021F4A2
		public virtual ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x0600E828 RID: 59432 RVA: 0x002212B0 File Offset: 0x0021F4B0
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

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x0600E829 RID: 59433 RVA: 0x002212E8 File Offset: 0x0021F4E8
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

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x0600E82A RID: 59434 RVA: 0x00221320 File Offset: 0x0021F520
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

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x0600E82B RID: 59435 RVA: 0x00221358 File Offset: 0x0021F558
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

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x0600E82C RID: 59436 RVA: 0x00221390 File Offset: 0x0021F590
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

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x0600E82D RID: 59437 RVA: 0x002213C8 File Offset: 0x0021F5C8
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

		// Token: 0x04008054 RID: 32852
		private ISplineMovePattern Instance;
	}
}
