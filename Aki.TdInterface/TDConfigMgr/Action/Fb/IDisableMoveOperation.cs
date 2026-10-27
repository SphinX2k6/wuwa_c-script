using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002941 RID: 10561
	public class IDisableMoveOperation : IMoveOperationType
	{
		// Token: 0x0600EA33 RID: 59955 RVA: 0x00224C35 File Offset: 0x00222E35
		[NullableContext(1)]
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

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x0600EA34 RID: 59956 RVA: 0x00224C54 File Offset: 0x00222E54
		public override EMoveOperationType Type
		{
			get
			{
				return (EMoveOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x0600EA35 RID: 59957 RVA: 0x00224C61 File Offset: 0x00222E61
		public virtual bool Forward
		{
			get
			{
				return this.Instance.Forward;
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x0600EA36 RID: 59958 RVA: 0x00224C6E File Offset: 0x00222E6E
		public virtual bool Back
		{
			get
			{
				return this.Instance.Back;
			}
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x0600EA37 RID: 59959 RVA: 0x00224C7B File Offset: 0x00222E7B
		public virtual bool Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x0600EA38 RID: 59960 RVA: 0x00224C88 File Offset: 0x00222E88
		public virtual bool Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x00224C98 File Offset: 0x00222E98
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

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x0600EA3A RID: 59962 RVA: 0x00224CD0 File Offset: 0x00222ED0
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

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x0600EA3B RID: 59963 RVA: 0x00224D08 File Offset: 0x00222F08
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

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x0600EA3C RID: 59964 RVA: 0x00224D40 File Offset: 0x00222F40
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

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x0600EA3D RID: 59965 RVA: 0x00224D78 File Offset: 0x00222F78
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

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x0600EA3E RID: 59966 RVA: 0x00224DB0 File Offset: 0x00222FB0
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

		// Token: 0x04008129 RID: 33065
		private IDisableMoveOperation Instance;
	}
}
