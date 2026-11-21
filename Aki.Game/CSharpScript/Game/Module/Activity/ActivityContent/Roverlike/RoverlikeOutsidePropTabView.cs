using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050AE RID: 20654
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsidePropTabView : RoverlikeOutsideTabViewBase
	{
		// Token: 0x170064F4 RID: 25844
		// (get) Token: 0x06033B1A RID: 211738 RVA: 0x00E783EF File Offset: 0x00E765EF
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected override IReadOnlyList<ValueTuple<EOutsideSlot, Type>> Layout
		{
			[return: TupleElementNames(new string[]
			{
				"Slot",
				"Type"
			})]
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				return RoverlikeOutsideLayout.Compact;
			}
		}

		// Token: 0x06033B1B RID: 211739 RVA: 0x00E783F8 File Offset: 0x00E765F8
		protected override UniTask CreateDetailCardAsync()
		{
			RoverlikeOutsidePropTabView.<CreateDetailCardAsync>d__3 <CreateDetailCardAsync>d__;
			<CreateDetailCardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailCardAsync>d__.<>4__this = this;
			<CreateDetailCardAsync>d__.<>1__state = -1;
			<CreateDetailCardAsync>d__.<>t__builder.Start<RoverlikeOutsidePropTabView.<CreateDetailCardAsync>d__3>(ref <CreateDetailCardAsync>d__);
			return <CreateDetailCardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033B1C RID: 211740 RVA: 0x00E7843B File Offset: 0x00E7663B
		[NullableContext(2)]
		protected override UUIItem GetDetailItemComponent()
		{
			return base.GetSlotItem(EOutsideSlot.ItemPropDetail);
		}

		// Token: 0x06033B1D RID: 211741 RVA: 0x00E78448 File Offset: 0x00E76648
		protected override void RefreshDetailCard(RoverlikeGainEntry entry)
		{
			RoverlikePropItemData data = new RoverlikePropItemData
			{
				ConfigId = entry.ConfigId,
				IsInGame = false
			};
			RoverlikePropCardItem detailCard = this.DetailCard;
			if (detailCard == null)
			{
				return;
			}
			detailCard.Refresh(data, false, 0);
		}

		// Token: 0x06033B1E RID: 211742 RVA: 0x00E78481 File Offset: 0x00E76681
		protected override bool ShouldShowCollectProgress()
		{
			return false;
		}

		// Token: 0x06033B1F RID: 211743 RVA: 0x00E78484 File Offset: 0x00E76684
		protected override int BuildScrollDataList()
		{
			List<RoverRogueItem> list = new List<RoverRogueItem>();
			foreach (RoverRogueItem item in RoverlikeConfig.Instance.GetItemConfigList())
			{
				if (item.Classify == 2)
				{
					list.Add(item);
				}
			}
			list.Sort(delegate(RoverRogueItem a, RoverRogueItem b)
			{
				if (a.Quality != b.Quality)
				{
					return b.Quality - a.Quality;
				}
				return b.Id - a.Id;
			});
			int num = -1;
			if (list.Count > 0)
			{
				base.PushTitle("RoverRogue_SystemShow_Item");
				foreach (RoverRogueItem roverRogueItem in list)
				{
					RoverlikeGainEntry entry = RoverlikeGainEntry.Create(RoverRogueGainDataType.RoverRogueGainItem, roverRogueItem.Id);
					int num2 = base.PushGrid(entry);
					if (num < 0)
					{
						num = num2;
					}
				}
			}
			return num;
		}

		// Token: 0x06033B20 RID: 211744 RVA: 0x00E7857C File Offset: 0x00E7677C
		protected override bool IsEntryLocked(RoverlikeGainEntry entry)
		{
			return false;
		}

		// Token: 0x0401B692 RID: 112274
		[Nullable(2)]
		private RoverlikePropCardItem DetailCard;
	}
}
