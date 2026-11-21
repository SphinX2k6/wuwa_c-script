using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281A RID: 10266
	public class IVisualNovelPortraitPosPreset
	{
		// Token: 0x0600E483 RID: 58499 RVA: 0x0021C7AE File Offset: 0x0021A9AE
		public static IVisualNovelPortraitPosPreset Create(IVisualNovelPortraitPosPreset? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPortraitPosPreset
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x0600E484 RID: 58500 RVA: 0x0021C7CD File Offset: 0x0021A9CD
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x0600E485 RID: 58501 RVA: 0x0021C7DA File Offset: 0x0021A9DA
		public virtual int PosX
		{
			get
			{
				return this.Instance.PosX;
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x0600E486 RID: 58502 RVA: 0x0021C7E7 File Offset: 0x0021A9E7
		public virtual int PosY
		{
			get
			{
				return this.Instance.PosY;
			}
		}

		// Token: 0x04007D70 RID: 32112
		private IVisualNovelPortraitPosPreset Instance;
	}
}
