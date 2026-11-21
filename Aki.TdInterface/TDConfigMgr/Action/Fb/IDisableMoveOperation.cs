using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C23 RID: 11299
	public class IDisableMoveOperation : IMoveOperationType
	{
		// Token: 0x0600F89E RID: 63646 RVA: 0x00242215 File Offset: 0x00240415
		public static IDisableMoveOperation Create(IDisableMoveOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableMoveOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x0600F89F RID: 63647 RVA: 0x00242234 File Offset: 0x00240434
		public override EMoveOperationType Type
		{
			get
			{
				return (EMoveOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x0600F8A0 RID: 63648 RVA: 0x00242241 File Offset: 0x00240441
		public virtual bool Forward
		{
			get
			{
				return this.Instance.Forward;
			}
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x0600F8A1 RID: 63649 RVA: 0x0024224E File Offset: 0x0024044E
		public virtual bool Back
		{
			get
			{
				return this.Instance.Back;
			}
		}

		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x0600F8A2 RID: 63650 RVA: 0x0024225B File Offset: 0x0024045B
		public virtual bool Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x0600F8A3 RID: 63651 RVA: 0x00242268 File Offset: 0x00240468
		public virtual bool Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x0600F8A4 RID: 63652 RVA: 0x00242278 File Offset: 0x00240478
		public virtual bool? ForceWalk
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForceWalk);
			}
		}

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x0600F8A5 RID: 63653 RVA: 0x002422B0 File Offset: 0x002404B0
		public virtual bool? ForceJog
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForceJog);
			}
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x002422E8 File Offset: 0x002404E8
		public virtual bool? ForbidSprint
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForbidSprint);
			}
		}

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x0600F8A7 RID: 63655 RVA: 0x00242320 File Offset: 0x00240520
		public virtual bool? ForbidAndDisableSprint
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForbidAndDisableSprint);
			}
		}

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x0600F8A8 RID: 63656 RVA: 0x00242358 File Offset: 0x00240558
		public virtual bool? ForbidAndDisableMotorcycleSprint
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForbidAndDisableMotorcycleSprint);
			}
		}

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x0600F8A9 RID: 63657 RVA: 0x00242390 File Offset: 0x00240590
		public virtual bool? DisableClimbAndStep
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableClimbAndStep);
			}
		}

		// Token: 0x04008805 RID: 34821
		private IDisableMoveOperation Instance;
	}
}
