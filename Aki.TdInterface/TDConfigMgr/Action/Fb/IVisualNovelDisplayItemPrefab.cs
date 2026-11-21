using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002817 RID: 10263
	public class IVisualNovelDisplayItemPrefab : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600E477 RID: 58487 RVA: 0x0021C669 File Offset: 0x0021A869
		public static IVisualNovelDisplayItemPrefab Create(IVisualNovelDisplayItemPrefab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemPrefab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x0021C688 File Offset: 0x0021A888
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x0600E479 RID: 58489 RVA: 0x0021C695 File Offset: 0x0021A895
		public virtual int PrefabId
		{
			get
			{
				return this.Instance.PrefabId;
			}
		}

		// Token: 0x04007D6D RID: 32109
		private IVisualNovelDisplayItemPrefab Instance;
	}
}
