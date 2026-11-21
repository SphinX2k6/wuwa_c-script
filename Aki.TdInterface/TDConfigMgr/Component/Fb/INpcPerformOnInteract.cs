using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C89 RID: 3209
	public class INpcPerformOnInteract
	{
		// Token: 0x06004935 RID: 18741 RVA: 0x000B8C40 File Offset: 0x000B6E40
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

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x000B8C5F File Offset: 0x000B6E5F
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x000B8C6C File Offset: 0x000B6E6C
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

		// Token: 0x0400293C RID: 10556
		private INpcPerformOnInteract Instance;
	}
}
