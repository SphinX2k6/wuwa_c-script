using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C0 RID: 5568
	public class ITetrisPlayModeBase
	{
		// Token: 0x06007DAD RID: 32173 RVA: 0x0012AF48 File Offset: 0x00129148
		public static ITetrisPlayModeBase Create(ITetrisPlayModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0012AF67 File Offset: 0x00129167
		public virtual ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x040048B8 RID: 18616
		private ITetrisPlayModeBase Instance;
	}
}
