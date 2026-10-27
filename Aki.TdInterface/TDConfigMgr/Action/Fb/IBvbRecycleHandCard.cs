using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A26 RID: 10790
	public class IBvbRecycleHandCard : IBvbPlayerOperationType
	{
		// Token: 0x0600EDCB RID: 60875 RVA: 0x0022A705 File Offset: 0x00228905
		[NullableContext(1)]
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

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x0600EDCC RID: 60876 RVA: 0x0022A724 File Offset: 0x00228924
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x0600EDCD RID: 60877 RVA: 0x0022A734 File Offset: 0x00228934
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

		// Token: 0x040082E2 RID: 33506
		private IBvbRecycleHandCard Instance;
	}
}
