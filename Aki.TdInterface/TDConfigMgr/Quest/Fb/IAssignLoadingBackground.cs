using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001524 RID: 5412
	public class IAssignLoadingBackground : IOperation
	{
		// Token: 0x06007A7D RID: 31357 RVA: 0x00124331 File Offset: 0x00122531
		public static IAssignLoadingBackground Create(IAssignLoadingBackground? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssignLoadingBackground
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x00124350 File Offset: 0x00122550
		public override EOperation Type
		{
			get
			{
				return (EOperation)this.Instance.Type;
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x06007A7F RID: 31359 RVA: 0x0012435D File Offset: 0x0012255D
		public virtual string ImagePath
		{
			get
			{
				return this.Instance.ImagePath;
			}
		}

		// Token: 0x04004692 RID: 18066
		private IAssignLoadingBackground Instance;
	}
}
