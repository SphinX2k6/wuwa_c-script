using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280F RID: 10255
	public class IVisualNovelCgLoadPrefab : IVisualNovelCgBase
	{
		// Token: 0x0600E45A RID: 58458 RVA: 0x0021C488 File Offset: 0x0021A688
		public static IVisualNovelCgLoadPrefab Create(IVisualNovelCgLoadPrefab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadPrefab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x0600E45B RID: 58459 RVA: 0x0021C4A7 File Offset: 0x0021A6A7
		public override EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x0600E45C RID: 58460 RVA: 0x0021C4B4 File Offset: 0x0021A6B4
		public virtual int PrefabId
		{
			get
			{
				return this.Instance.PrefabId;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x0600E45D RID: 58461 RVA: 0x0021C4C1 File Offset: 0x0021A6C1
		public virtual string AnimationName
		{
			get
			{
				return this.Instance.AnimationName;
			}
		}

		// Token: 0x04007D65 RID: 32101
		private IVisualNovelCgLoadPrefab Instance;
	}
}
