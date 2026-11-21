using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014EB RID: 5355
	public class IShowUiAll : IShowUi
	{
		// Token: 0x06007963 RID: 31075 RVA: 0x00122296 File Offset: 0x00120496
		public static IShowUiAll Create(IShowUiAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x06007964 RID: 31076 RVA: 0x001222B5 File Offset: 0x001204B5
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x040045D9 RID: 17881
		private IShowUiAll Instance;
	}
}
