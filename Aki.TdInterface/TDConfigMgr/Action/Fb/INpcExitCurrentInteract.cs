using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AED RID: 10989
	public class INpcExitCurrentInteract : INpcLeisureInteractType
	{
		// Token: 0x0600F1E3 RID: 61923 RVA: 0x00235BEB File Offset: 0x00233DEB
		public static INpcExitCurrentInteract Create(INpcExitCurrentInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcExitCurrentInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x0600F1E4 RID: 61924 RVA: 0x00235C0A File Offset: 0x00233E0A
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x0600F1E5 RID: 61925 RVA: 0x00235C18 File Offset: 0x00233E18
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

		// Token: 0x040084CD RID: 33997
		private INpcExitCurrentInteract Instance;
	}
}
