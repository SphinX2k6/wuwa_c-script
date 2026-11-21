using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B5 RID: 10421
	public class PosAndRot : PosA
	{
		// Token: 0x0600E823 RID: 59427 RVA: 0x002250F6 File Offset: 0x002232F6
		public static PosAndRot Create(IPosAndRot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PosAndRot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x0600E824 RID: 59428 RVA: 0x00225118 File Offset: 0x00223318
		public override float? X
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.X);
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x0600E825 RID: 59429 RVA: 0x00225150 File Offset: 0x00223350
		public override float? Y
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Y);
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x0600E826 RID: 59430 RVA: 0x00225188 File Offset: 0x00223388
		public override float? Z
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Z);
			}
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0600E827 RID: 59431 RVA: 0x002251C0 File Offset: 0x002233C0
		public override float? A
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.A);
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x0600E828 RID: 59432 RVA: 0x002251F8 File Offset: 0x002233F8
		public virtual float? Roll
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Roll);
			}
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x0600E829 RID: 59433 RVA: 0x00225230 File Offset: 0x00223430
		public virtual float? Pitch
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Pitch);
			}
		}

		// Token: 0x04007FD3 RID: 32723
		private IPosAndRot Instance;
	}
}
