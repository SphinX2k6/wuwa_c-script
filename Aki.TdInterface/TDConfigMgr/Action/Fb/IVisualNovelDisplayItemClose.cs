using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002818 RID: 10264
	public class IVisualNovelDisplayItemClose : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600E47B RID: 58491 RVA: 0x0021C6AA File Offset: 0x0021A8AA
		public static IVisualNovelDisplayItemClose Create(IVisualNovelDisplayItemClose? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemClose
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x0600E47C RID: 58492 RVA: 0x0021C6C9 File Offset: 0x0021A8C9
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x04007D6E RID: 32110
		private IVisualNovelDisplayItemClose Instance;
	}
}
