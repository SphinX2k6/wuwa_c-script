using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C4 RID: 5572
	public class ITetrisSingleBlock
	{
		// Token: 0x06007DBE RID: 32190 RVA: 0x0012B0AE File Offset: 0x001292AE
		public static ITetrisSingleBlock Create(ITetrisSingleBlock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleBlock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x0012B0CD File Offset: 0x001292CD
		public virtual string StyleName
		{
			get
			{
				return this.Instance.StyleName;
			}
		}

		// Token: 0x040048BC RID: 18620
		private ITetrisSingleBlock Instance;
	}
}
