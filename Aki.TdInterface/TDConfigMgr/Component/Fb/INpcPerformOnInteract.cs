using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBB RID: 3003
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformOnInteract
	{
		// Token: 0x060044DC RID: 17628 RVA: 0x000AEB7C File Offset: 0x000ACD7C
		public static INpcPerformOnInteract Create(INpcPerformOnInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformOnInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x000AEB9B File Offset: 0x000ACD9B
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x000AEBA8 File Offset: 0x000ACDA8
		public virtual bool? NotInterruptMontageWhenFinishedInteract
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NotInterruptMontageWhenFinishedInteract);
			}
		}

		// Token: 0x040026F4 RID: 9972
		private INpcPerformOnInteract Instance;
	}
}
