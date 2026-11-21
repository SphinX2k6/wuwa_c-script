using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005755 RID: 22357
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTemplateData : IMultiTemplateGridData<DangoBrawlHandBookItemData, DangoBrawlHandBookItem>, IMultiTemplateGridData
	{
		// Token: 0x17006A70 RID: 27248
		// (get) Token: 0x060371F8 RID: 225784 RVA: 0x00F625A7 File Offset: 0x00F607A7
		// (set) Token: 0x060371F9 RID: 225785 RVA: 0x00F625AF File Offset: 0x00F607AF
		public DangoBrawlHandBookItemData Data { get; set; }

		// Token: 0x17006A71 RID: 27249
		// (get) Token: 0x060371FA RID: 225786 RVA: 0x00F625B8 File Offset: 0x00F607B8
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x060371FB RID: 225787 RVA: 0x00F625C0 File Offset: 0x00F607C0
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060371FC RID: 225788 RVA: 0x00F625C4 File Offset: 0x00F607C4
		public DangoBrawlHandBookItem CreateProxy()
		{
			DangoBrawlHandBookItem proxy = new DangoBrawlHandBookItem();
			proxy.OnClickCb = delegate(DangoBrawlHandBookItemData data)
			{
				Action<DangoBrawlHandBookItemData, int> onClickCb = this.OnClickCb;
				if (onClickCb == null)
				{
					return;
				}
				onClickCb(data, proxy.GridIndex);
			};
			proxy.OnUnlockAnimPlayed = delegate(int id)
			{
				Action<int> onUnlockAnimPlayed = this.OnUnlockAnimPlayed;
				if (onUnlockAnimPlayed == null)
				{
					return;
				}
				onUnlockAnimPlayed(id);
			};
			DangoBrawlHandBookItem proxy2 = proxy;
			Func<int, bool> isSelected;
			if ((isSelected = this.IsSelected) == null && (isSelected = DangoBrawlHandBookItemTemplateData.<>c.<>9__10_2) == null)
			{
				isSelected = (DangoBrawlHandBookItemTemplateData.<>c.<>9__10_2 = ((int _) => false));
			}
			proxy2.IsSelected = isSelected;
			return proxy;
		}

		// Token: 0x060371FD RID: 225789 RVA: 0x00F62651 File Offset: 0x00F60851
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0401D238 RID: 119352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlHandBookItemData, int> OnClickCb;

		// Token: 0x0401D239 RID: 119353
		[Nullable(2)]
		public Action<int> OnUnlockAnimPlayed;

		// Token: 0x0401D23A RID: 119354
		[Nullable(2)]
		public Func<int, bool> IsSelected;

		// Token: 0x0401D23B RID: 119355
		private const int ItemTemplateIndex = 1;
	}
}
