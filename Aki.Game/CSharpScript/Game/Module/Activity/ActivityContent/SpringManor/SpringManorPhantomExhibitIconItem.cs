using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200604C RID: 24652
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorPhantomExhibitIconItem : LoopScrollSmallItemGrid<SpringManorPhantomDisplayItem>
	{
		// Token: 0x0603E627 RID: 255527 RVA: 0x00F1126E File Offset: 0x00F0F46E
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0603E628 RID: 255528 RVA: 0x00F11278 File Offset: 0x00F0F478
		protected override void OnRefresh(SpringManorPhantomDisplayItem data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x0603E629 RID: 255529 RVA: 0x00F11284 File Offset: 0x00F0F484
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

		// Token: 0x0402097C RID: 133500
		private int PhantomId;
	}
}
