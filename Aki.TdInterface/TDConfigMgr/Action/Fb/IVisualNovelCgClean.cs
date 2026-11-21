using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002811 RID: 10257
	public class IVisualNovelCgClean : IVisualNovelCgBase
	{
		// Token: 0x0600E463 RID: 58467 RVA: 0x0021C517 File Offset: 0x0021A717
		public static IVisualNovelCgClean Create(IVisualNovelCgClean? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgClean
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x0600E464 RID: 58468 RVA: 0x0021C536 File Offset: 0x0021A736
		public override EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x04007D67 RID: 32103
		private IVisualNovelCgClean Instance;
	}
}
