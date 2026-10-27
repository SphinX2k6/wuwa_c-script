using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006805 RID: 26629
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTemplateData : IMultiTemplateGridData<DangoBrawlHandBookItemData, DangoBrawlHandBookItem>, IMultiTemplateGridData
	{
		// Token: 0x1700972F RID: 38703
		// (get) Token: 0x060426A3 RID: 272035 RVA: 0x01021063 File Offset: 0x0101F263
		// (set) Token: 0x060426A4 RID: 272036 RVA: 0x0102106B File Offset: 0x0101F26B
		public DangoBrawlHandBookItemData Data { get; set; }

		// Token: 0x17009730 RID: 38704
		// (get) Token: 0x060426A5 RID: 272037 RVA: 0x01021074 File Offset: 0x0101F274
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x060426A6 RID: 272038 RVA: 0x0102107C File Offset: 0x0101F27C
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060426A7 RID: 272039 RVA: 0x01021080 File Offset: 0x0101F280
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

		// Token: 0x060426A8 RID: 272040 RVA: 0x0102110D File Offset: 0x0101F30D
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x040229DB RID: 141787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlHandBookItemData, int> OnClickCb;

		// Token: 0x040229DC RID: 141788
		[Nullable(2)]
		public Action<int> OnUnlockAnimPlayed;

		// Token: 0x040229DD RID: 141789
		[Nullable(2)]
		public Func<int, bool> IsSelected;

		// Token: 0x040229DE RID: 141790
		private const int ItemTemplateIndex = 1;
	}
}
