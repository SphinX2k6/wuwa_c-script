using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A24 RID: 10788
	public class IBvbChangeHandCard : IBvbPlayerOperationType
	{
		// Token: 0x0600EDC2 RID: 60866 RVA: 0x0022A5B5 File Offset: 0x002287B5
		[NullableContext(1)]
		public static IBvbChangeHandCard Create(IBvbChangeHandCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbChangeHandCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x0600EDC3 RID: 60867 RVA: 0x0022A5D4 File Offset: 0x002287D4
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x0600EDC4 RID: 60868 RVA: 0x0022A5E4 File Offset: 0x002287E4
		public virtual int? HandCardIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HandCardIndex);
			}
		}

		// Token: 0x040082DE RID: 33502
		private IBvbChangeHandCard Instance;
	}
}
