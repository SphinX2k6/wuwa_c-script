using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F3A RID: 3898
	public class IGraph3dEdgeBase
	{
		// Token: 0x0600578B RID: 22411 RVA: 0x000D66D9 File Offset: 0x000D48D9
		public static IGraph3dEdgeBase Create(IGraph3dEdgeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEdgeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600578C RID: 22412 RVA: 0x000D66F8 File Offset: 0x000D48F8
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x000D6705 File Offset: 0x000D4905
		public virtual int From
		{
			get
			{
				return this.Instance.From;
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x000D6712 File Offset: 0x000D4912
		public virtual int To
		{
			get
			{
				return this.Instance.To;
			}
		}

		// Token: 0x04003245 RID: 12869
		private IGraph3dEdgeBase Instance;
	}
}
