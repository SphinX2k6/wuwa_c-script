using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200612F RID: 24879
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideEnhanceTabView : RoverlikeOutsideTabViewBase
	{
		// Token: 0x17009191 RID: 37265
		// (get) Token: 0x0603EE51 RID: 257617 RVA: 0x00F31444 File Offset: 0x00F2F644
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

		// Token: 0x0603EE52 RID: 257618 RVA: 0x00F3144C File Offset: 0x00F2F64C
		protected override UniTask CreateDetailCardAsync()
		{
			RoverlikeOutsideEnhanceTabView.<CreateDetailCardAsync>d__3 <CreateDetailCardAsync>d__;
			<CreateDetailCardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailCardAsync>d__.<>4__this = this;
			<CreateDetailCardAsync>d__.<>1__state = -1;
			<CreateDetailCardAsync>d__.<>t__builder.Start<RoverlikeOutsideEnhanceTabView.<CreateDetailCardAsync>d__3>(ref <CreateDetailCardAsync>d__);
			return <CreateDetailCardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EE53 RID: 257619 RVA: 0x00F3148F File Offset: 0x00F2F68F
		[NullableContext(2)]
		protected override UUIItem GetDetailItemComponent()
		{
			return base.GetSlotItem(EOutsideSlot.ItemReinforceDetail);
		}

		// Token: 0x0603EE54 RID: 257620 RVA: 0x00F3149C File Offset: 0x00F2F69C
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

		// Token: 0x0603EE55 RID: 257621 RVA: 0x00F314DC File Offset: 0x00F2F6DC
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
					List<RoverRogueRoleEnhance> list = roleEnhanceConfigList.Where(delegate(RoverRogueRoleEnhance cfg)
					{
						int[] roleTypeArray = cfg.GetRoleTypeArray();
						return roleTypeArray != null && roleTypeArray.Contains(roleTypeCfg.Id);
					}).ToList<RoverRogueRoleEnhance>();
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

		// Token: 0x0603EE56 RID: 257622 RVA: 0x00F315DC File Offset: 0x00F2F7DC
		protected override bool IsEntryLocked(RoverlikeGainEntry entry)
		{
			return false;
		}

		// Token: 0x04020D64 RID: 134500
		[Nullable(2)]
		private RoverlikeReinforcementCardItem DetailCard;
	}
}
