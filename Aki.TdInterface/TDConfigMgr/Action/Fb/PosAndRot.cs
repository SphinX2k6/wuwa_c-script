using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F5 RID: 9717
	public class PosAndRot : PosA
	{
		// Token: 0x0600DA56 RID: 55894 RVA: 0x002089A2 File Offset: 0x00206BA2
		[NullableContext(1)]
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

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x0600DA57 RID: 55895 RVA: 0x002089C4 File Offset: 0x00206BC4
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

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x0600DA58 RID: 55896 RVA: 0x002089FC File Offset: 0x00206BFC
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

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x0600DA59 RID: 55897 RVA: 0x00208A34 File Offset: 0x00206C34
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

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x0600DA5A RID: 55898 RVA: 0x00208A6C File Offset: 0x00206C6C
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

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x0600DA5B RID: 55899 RVA: 0x00208AA4 File Offset: 0x00206CA4
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

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x0600DA5C RID: 55900 RVA: 0x00208ADC File Offset: 0x00206CDC
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

		// Token: 0x04007939 RID: 31033
		private IPosAndRot Instance;
	}
}
