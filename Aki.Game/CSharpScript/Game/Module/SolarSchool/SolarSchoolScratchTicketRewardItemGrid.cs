using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200593E RID: 22846
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolScratchTicketRewardItemGrid : LoopScrollSmallItemGrid<SolarSchoolScratchTicketRewardShow>
	{
		// Token: 0x060384DF RID: 230623 RVA: 0x00FBE383 File Offset: 0x00FBC583
		protected override void OnRefresh(SolarSchoolScratchTicketRewardShow data, bool isSelected, int gridIndex)
		{
			this.data = data;
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				base.SetIconByPath(data.IconPath);
			}
			base.SetBottomText(data.Count.ToString());
			base.SetBottomTextVisible(true);
		}

		// Token: 0x060384E0 RID: 230624 RVA: 0x00FBE3BD File Offset: 0x00FBC5BD
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x060384E1 RID: 230625 RVA: 0x00FBE3C0 File Offset: 0x00FBC5C0
		protected override void OnExtendToggleClicked()
		{
			if (this.data.RewardType == ESolarSchoolRewardType.Item)
			{
				SolarSchoolUtils.ShowItemDetailPopup(this.data.TargetId, this.data.Count, null);
			}
		}

		// Token: 0x0401DA56 RID: 121430
		private SolarSchoolScratchTicketRewardShow data;
	}
}
