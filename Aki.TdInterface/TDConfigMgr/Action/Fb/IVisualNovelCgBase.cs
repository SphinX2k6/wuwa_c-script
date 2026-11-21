using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280E RID: 10254
	public class IVisualNovelCgBase
	{
		// Token: 0x0600E457 RID: 58455 RVA: 0x0021C454 File Offset: 0x0021A654
		public static IVisualNovelCgBase Create(IVisualNovelCgBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x0600E458 RID: 58456 RVA: 0x0021C473 File Offset: 0x0021A673
		public virtual EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x04007D64 RID: 32100
		private IVisualNovelCgBase Instance;
	}
}
