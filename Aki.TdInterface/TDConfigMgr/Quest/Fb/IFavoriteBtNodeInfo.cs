using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200159B RID: 5531
	public class IFavoriteBtNodeInfo
	{
		// Token: 0x06007CBD RID: 31933 RVA: 0x001286F5 File Offset: 0x001268F5
		public static IFavoriteBtNodeInfo Create(IFavoriteBtNodeInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFavoriteBtNodeInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06007CBE RID: 31934 RVA: 0x00128714 File Offset: 0x00126914
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06007CBF RID: 31935 RVA: 0x00128721 File Offset: 0x00126921
		public virtual string Desc
		{
			get
			{
				return this.Instance.Desc;
			}
		}

		// Token: 0x04004809 RID: 18441
		private IFavoriteBtNodeInfo Instance;
	}
}
