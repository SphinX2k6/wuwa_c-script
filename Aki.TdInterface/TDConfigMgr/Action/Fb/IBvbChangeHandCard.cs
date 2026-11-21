using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D11 RID: 11537
	public class IBvbChangeHandCard : IBvbPlayerOperationType
	{
		// Token: 0x0600FC5A RID: 64602 RVA: 0x00247F69 File Offset: 0x00246169
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

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x0600FC5B RID: 64603 RVA: 0x00247F88 File Offset: 0x00246188
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x0600FC5C RID: 64604 RVA: 0x00247F98 File Offset: 0x00246198
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

		// Token: 0x040089D1 RID: 35281
		private IBvbChangeHandCard Instance;
	}
}
