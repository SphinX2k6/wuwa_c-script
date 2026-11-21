using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEB RID: 10987
	public class INpcSwing : INpcLeisureInteractType
	{
		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00235AA8 File Offset: 0x00233CA8
		public static INpcSwing Create(INpcSwing? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSwing
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x0600F1D7 RID: 61911 RVA: 0x00235AC7 File Offset: 0x00233CC7
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x0600F1D8 RID: 61912 RVA: 0x00235AD4 File Offset: 0x00233CD4
		public override bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x0600F1D9 RID: 61913 RVA: 0x00235B0A File Offset: 0x00233D0A
		public virtual int TargetNpcId
		{
			get
			{
				return this.Instance.TargetNpcId;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x0600F1DA RID: 61914 RVA: 0x00235B17 File Offset: 0x00233D17
		public virtual string SwingDa
		{
			get
			{
				return this.Instance.SwingDa;
			}
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x0600F1DB RID: 61915 RVA: 0x00235B24 File Offset: 0x00233D24
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x0600F1DC RID: 61916 RVA: 0x00235B34 File Offset: 0x00233D34
		public virtual bool? SkipSitDown
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SkipSitDown);
			}
		}

		// Token: 0x040084CB RID: 33995
		private INpcSwing Instance;
	}
}
