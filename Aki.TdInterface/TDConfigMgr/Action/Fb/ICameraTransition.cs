using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE4 RID: 11236
	public class ICameraTransition : ILevelSequenceTransitionType
	{
		// Token: 0x0600F77F RID: 63359 RVA: 0x0024050A File Offset: 0x0023E70A
		public static ICameraTransition Create(ICameraTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x0600F780 RID: 63360 RVA: 0x00240529 File Offset: 0x0023E729
		public override ELevelSequenceTransition Type
		{
			get
			{
				return (ELevelSequenceTransition)this.Instance.Type;
			}
		}

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x0600F781 RID: 63361 RVA: 0x00240538 File Offset: 0x0023E738
		public override float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x04008788 RID: 34696
		private ICameraTransition Instance;
	}
}
