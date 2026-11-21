using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FE RID: 10494
	public class IDestroyItemData : IItemData
	{
		// Token: 0x0600E97A RID: 59770 RVA: 0x00227A3C File Offset: 0x00225C3C
		public static IDestroyItemData Create(IDestroyItemData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyItemData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x0600E97B RID: 59771 RVA: 0x00227A5B File Offset: 0x00225C5B
		public override int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x0600E97C RID: 59772 RVA: 0x00227A68 File Offset: 0x00225C68
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x0600E97D RID: 59773 RVA: 0x00227A75 File Offset: 0x00225C75
		public virtual bool IsAll
		{
			get
			{
				return this.Instance.IsAll;
			}
		}

		// Token: 0x040080AE RID: 32942
		private IDestroyItemData Instance;
	}
}
