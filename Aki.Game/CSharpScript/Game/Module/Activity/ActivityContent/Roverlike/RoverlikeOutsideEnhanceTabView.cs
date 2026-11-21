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
	// Token: 0x020050AD RID: 20653
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideEnhanceTabView : RoverlikeOutsideTabViewBase
	{
		// Token: 0x170064F3 RID: 25843
		// (get) Token: 0x06033B13 RID: 211731 RVA: 0x00E78250 File Offset: 0x00E76450
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

		// Token: 0x06033B14 RID: 211732 RVA: 0x00E78258 File Offset: 0x00E76458
		protected override UniTask CreateDetailCardAsync()
		{
			RoverlikeOutsideEnhanceTabView.<CreateDetailCardAsync>d__3 <CreateDetailCardAsync>d__;
			<CreateDetailCardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailCardAsync>d__.<>4__this = this;
			<CreateDetailCardAsync>d__.<>1__state = -1;
			<CreateDetailCardAsync>d__.<>t__builder.Start<RoverlikeOutsideEnhanceTabView.<CreateDetailCardAsync>d__3>(ref <CreateDetailCardAsync>d__);
			return <CreateDetailCardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033B15 RID: 211733 RVA: 0x00E7829B File Offset: 0x00E7649B
		[NullableContext(2)]
		protected override UUIItem GetDetailItemComponent()
		{
			return base.GetSlotItem(EOutsideSlot.ItemReinforceDetail);
		}

		// Token: 0x06033B16 RID: 211734 RVA: 0x00E782A8 File Offset: 0x00E764A8
		protected override void RefreshDetailCard(RoverlikeGainEntry entry)
		{
			RoverlikeReinforcementItemData data = new RoverlikeReinforcementItemData
			{
				ConfigId = entry.ConfigId,
				AllowToggleInteract = new bool?(false)
			};
			RoverlikeReinforcementCardItem detailCard = this.DetailCard;
			if (detailCard == null)
			{
				return;
			}
			detailCard.Refresh(data, false, 0);
		}

		// Token: 0x06033B17 RID: 211735 RVA: 0x00E782E8 File Offset: 0x00E764E8
		protected override int BuildScrollDataList()
		{
			IReadOnlyList<RoverRogueRoleEnhance> roleEnhanceConfigList = RoverlikeConfig.Instance.GetRoleEnhanceConfigList();
			IEnumerable<RoverRogueRoleType> roleTypeConfigList = RoverlikeConfig.Instance.GetRoleTypeConfigList();
			int num = -1;
			using (IEnumerator<RoverRogueRoleType> enumerator = roleTypeConfigList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					RoverRogueRoleType roleTypeCfg = enumerator.Current;
					List<RoverRogueRoleEnhance> list = NoLinq.WhereToList<RoverRogueRoleEnhance>(roleEnhanceConfigList, (RoverRogueRoleEnhance enhance) => NoLinq.Contains<int>(enhance.GetRoleTypeBytes(), roleTypeCfg.Id));
					if (list.Count != 0)
					{
						base.PushTitleIconWithText(roleTypeCfg.ElementIcon, roleTypeCfg.Element);
						foreach (RoverRogueRoleEnhance roverRogueRoleEnhance in list)
						{
							RoverlikeGainEntry entry = RoverlikeGainEntry.Create(RoverRogueGainDataType.RoverRogueGainRoleEnhance, roverRogueRoleEnhance.Id);
							int num2 = base.PushGrid(entry);
							if (num < 0)
							{
								num = num2;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06033B18 RID: 211736 RVA: 0x00E783E4 File Offset: 0x00E765E4
		protected override bool IsEntryLocked(RoverlikeGainEntry entry)
		{
			return false;
		}

		// Token: 0x0401B691 RID: 112273
		[Nullable(2)]
		private RoverlikeReinforcementCardItem DetailCard;
	}
}
