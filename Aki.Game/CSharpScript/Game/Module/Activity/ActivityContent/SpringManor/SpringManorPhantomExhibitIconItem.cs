using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FCA RID: 20426
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorPhantomExhibitIconItem : LoopScrollSmallItemGrid<SpringManorPhantomDisplayItem>
	{
		// Token: 0x060332EB RID: 209643 RVA: 0x00E58032 File Offset: 0x00E56232
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x060332EC RID: 209644 RVA: 0x00E5803C File Offset: 0x00E5623C
		protected override void OnRefresh(SpringManorPhantomDisplayItem data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x060332ED RID: 209645 RVA: 0x00E58048 File Offset: 0x00E56248
		public void Refresh(SpringManorPhantomDisplayItem data)
		{
			this.PhantomId = data.PhantomId;
			PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(this.PhantomId);
			if (phantomItemById == null)
			{
				return;
			}
			if (CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(phantomItemById.Value.MonsterId) == null)
			{
				return;
			}
			PhantomSmallItemGrid parameters = new PhantomSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.PhantomId),
				IsQualityHidden = new bool?(true)
			};
			base.Apply<PhantomSmallItemGrid>(parameters);
		}

		// Token: 0x0401B2A9 RID: 111273
		private int PhantomId;
	}
}
