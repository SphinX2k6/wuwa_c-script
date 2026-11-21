using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015BB RID: 5563
	public class IEntityRefSearchProp
	{
		// Token: 0x06007D91 RID: 32145 RVA: 0x0012AAA6 File Offset: 0x00128CA6
		public static IEntityRefSearchProp Create(IEntityRefSearchProp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityRefSearchProp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x06007D92 RID: 32146 RVA: 0x0012AAC5 File Offset: 0x00128CC5
		public virtual string SearchText
		{
			get
			{
				return this.Instance.SearchText;
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x0012AAD4 File Offset: 0x00128CD4
		public virtual int? ResultCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ResultCount);
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x06007D94 RID: 32148 RVA: 0x0012AB0C File Offset: 0x00128D0C
		public virtual int? ResultIndex
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ResultIndex);
			}
		}

		// Token: 0x040048A5 RID: 18597
		private IEntityRefSearchProp Instance;
	}
}
