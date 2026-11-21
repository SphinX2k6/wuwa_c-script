using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D13 RID: 11539
	public class IBvbRecycleHandCard : IBvbPlayerOperationType
	{
		// Token: 0x0600FC63 RID: 64611 RVA: 0x002480B9 File Offset: 0x002462B9
		public static IBvbRecycleHandCard Create(IBvbRecycleHandCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbRecycleHandCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x0600FC64 RID: 64612 RVA: 0x002480D8 File Offset: 0x002462D8
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x0600FC65 RID: 64613 RVA: 0x002480E8 File Offset: 0x002462E8
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

		// Token: 0x040089D5 RID: 35285
		private IBvbRecycleHandCard Instance;
	}
}
