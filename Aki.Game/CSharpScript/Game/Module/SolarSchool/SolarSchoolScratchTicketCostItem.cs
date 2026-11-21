using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200593D RID: 22845
	public class SolarSchoolScratchTicketCostItem : UiPanelBase
	{
		// Token: 0x060384D2 RID: 230610 RVA: 0x00FBDEBC File Offset: 0x00FBC0BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnTipCostClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060384D3 RID: 230611 RVA: 0x00FBDFC8 File Offset: 0x00FBC1C8
		protected override void OnStart()
		{
			this.EnsureCache();
			this.Refresh();
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x060384D4 RID: 230612 RVA: 0x00FBE038 File Offset: 0x00FBC238
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x060384D5 RID: 230613 RVA: 0x00FBE099 File Offset: 0x00FBC299
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (this.Matches(ESolarSchoolRewardType.PlayerAttr, (int)attr))
			{
				this.Refresh();
			}
		}

		// Token: 0x060384D6 RID: 230614 RVA: 0x00FBE0AB File Offset: 0x00FBC2AB
		private void OnItemChanged(int itemId)
		{
			if (this.Matches(ESolarSchoolRewardType.Item, itemId))
			{
				this.Refresh();
			}
		}

		// Token: 0x060384D7 RID: 230615 RVA: 0x00FBE0BD File Offset: 0x00FBC2BD
		private void OnFavorChanged(int roleId)
		{
			if (this.Matches(ESolarSchoolRewardType.RoleFavor, roleId))
			{
				this.Refresh();
			}
		}

		// Token: 0x060384D8 RID: 230616 RVA: 0x00FBE0D0 File Offset: 0x00FBC2D0
		private void EnsureCache()
		{
			int currentRoundId = SolarSchoolGamePlayModel.Instance.ScratchTicketData.CurrentRoundId;
			if (currentRoundId == this.CachedRoundId)
			{
				return;
			}
			SolarSchoolScratchTicketCo? scratchTicket = SolarSchoolConfig.Instance.GetScratchTicket(currentRoundId);
			if (scratchTicket == null)
			{
				return;
			}
			this.Cost1 = this.ReadCost(scratchTicket.Value.CostId1);
			this.Cost2 = this.ReadCost(scratchTicket.Value.CostId2);
			this.CachedRoundId = currentRoundId;
		}

		// Token: 0x060384D9 RID: 230617 RVA: 0x00FBE14C File Offset: 0x00FBC34C
		[return: TupleElementNames(new string[]
		{
			"type",
			"id"
		})]
		private ValueTuple<ESolarSchoolRewardType, int> ReadCost(int costId)
		{
			SolarSchoolReward? reward = SolarSchoolConfig.Instance.GetReward(costId);
			if (reward == null)
			{
				return new ValueTuple<ESolarSchoolRewardType, int>(ESolarSchoolRewardType.Item, -1);
			}
			return new ValueTuple<ESolarSchoolRewardType, int>((ESolarSchoolRewardType)reward.Value.RewardType, reward.Value.TargetId);
		}

		// Token: 0x060384DA RID: 230618 RVA: 0x00FBE199 File Offset: 0x00FBC399
		private bool Matches(ESolarSchoolRewardType changedType, int changedId)
		{
			return (this.Cost1.Item1 == changedType && this.Cost1.Item2 == changedId) || (this.Cost2.Item1 == changedType && this.Cost2.Item2 == changedId);
		}

		// Token: 0x060384DB RID: 230619 RVA: 0x00FBE1D8 File Offset: 0x00FBC3D8
		public void Refresh()
		{
			ValueTuple<string, int> textureAndCount = this.GetTextureAndCount(this.Cost1.Item1, this.Cost1.Item2);
			string item = textureAndCount.Item1;
			int item2 = textureAndCount.Item2;
			if (item == null || item2 <= 0)
			{
				ValueTuple<string, int> textureAndCount2 = this.GetTextureAndCount(this.Cost2.Item1, this.Cost2.Item2);
				item = textureAndCount2.Item1;
				item2 = textureAndCount2.Item2;
				if (item != null)
				{
					base.SetTextureByPath(item, base.GetTexture(3), null, null);
					UUIText text = base.GetText(4);
					if (text == null)
					{
						return;
					}
					text.SetText(item2.ToString(), true);
				}
				return;
			}
			base.SetTextureByPath(item, base.GetTexture(3), null, null);
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(item2.ToString(), true);
		}

		// Token: 0x060384DC RID: 230620 RVA: 0x00FBE2A4 File Offset: 0x00FBC4A4
		[return: TupleElementNames(new string[]
		{
			"texturePath",
			"count"
		})]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private ValueTuple<string, int> GetTextureAndCount(ESolarSchoolRewardType type, int id)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			switch (type)
			{
			case ESolarSchoolRewardType.PlayerAttr:
			{
				SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(instance.ActivityId, id);
				if (solarSchoolAttr == null)
				{
					return new ValueTuple<string, int>(null, -1);
				}
				return new ValueTuple<string, int>(solarSchoolAttr.Value.YellowIconSmall, instance.PlayerData.GetAttr((ESolarSchoolSecondAttr)id));
			}
			case ESolarSchoolRewardType.RoleFavor:
				return new ValueTuple<string, int>(null, -1);
			case ESolarSchoolRewardType.Item:
			{
				SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(id);
				if (item == null)
				{
					return new ValueTuple<string, int>(null, -1);
				}
				return new ValueTuple<string, int>(item.Value.Icon, instance.InventoryData.GetItemCount(item.Value.Id));
			}
			default:
				return new ValueTuple<string, int>(null, -1);
			}
		}

		// Token: 0x060384DD RID: 230621 RVA: 0x00FBE372 File Offset: 0x00FBC572
		private void OnBtnTipCostClick()
		{
		}

		// Token: 0x0401DA53 RID: 121427
		private int CachedRoundId = -1;

		// Token: 0x0401DA54 RID: 121428
		[TupleElementNames(new string[]
		{
			"type",
			"id"
		})]
		private ValueTuple<ESolarSchoolRewardType, int> Cost1;

		// Token: 0x0401DA55 RID: 121429
		[TupleElementNames(new string[]
		{
			"type",
			"id"
		})]
		private ValueTuple<ESolarSchoolRewardType, int> Cost2;

		// Token: 0x0200B4FB RID: 46331
		private class EComponents
		{
			// Token: 0x04037F5B RID: 229211
			public const int BtnTipCost = 0;

			// Token: 0x04037F5C RID: 229212
			public const int TexIcon = 1;

			// Token: 0x04037F5D RID: 229213
			public const int TxtValue = 2;

			// Token: 0x04037F5E RID: 229214
			public const int TexCoinIcon = 3;

			// Token: 0x04037F5F RID: 229215
			public const int TxtNum = 4;
		}
	}
}
