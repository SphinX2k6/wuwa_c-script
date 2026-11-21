using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047E6 RID: 18406
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardSmallItemGrid : LoopScrollSmallItemGrid<RewardItemData>
	{
		// Token: 0x0602E3DE RID: 189406 RVA: 0x00CE5C7D File Offset: 0x00CE3E7D
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
		}

		// Token: 0x0602E3DF RID: 189407 RVA: 0x00CE5C86 File Offset: 0x00CE3E86
		protected override void OnAddEvents()
		{
			base.OnAddEvents();
			EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnFuncValueChange));
		}

		// Token: 0x0602E3E0 RID: 189408 RVA: 0x00CE5CAA File Offset: 0x00CE3EAA
		protected override void OnRemoveEvents()
		{
			base.OnRemoveEvents();
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnFuncValueChange));
		}

		// Token: 0x0602E3E1 RID: 189409 RVA: 0x00CE5CCE File Offset: 0x00CE3ECE
		protected override void OnRefresh(RewardItemData data, bool isSelected, int gridIndex)
		{
			this.RefreshByData(data);
		}

		// Token: 0x0602E3E2 RID: 189410 RVA: 0x00CE5CD8 File Offset: 0x00CE3ED8
		private void RefreshByData(RewardItemData data)
		{
			this.ItemData = data;
			ItemConfig config = data.GetConfig();
			int configId = data.ConfigId;
			string topRightTextId = null;
			string topRightTextBgColor = null;
			string topRightTextColor = null;
			EDropItemType dropItemType = data.GetDropItemType();
			bool value = false;
			if (dropItemType != EDropItemType.Activity)
			{
				if (dropItemType == EDropItemType.MultiTimeExchange)
				{
					topRightTextId = "Reward_Tag_Magnification";
					topRightTextBgColor = ConfigCommonParamById.GetStringConfig("Reward_Tag_Magnification_Bg_Color");
					topRightTextColor = ConfigCommonParamById.GetStringConfig("Reward_Tag_Magnification_Text_Color");
				}
			}
			else if (!DailyActivityModel.Instance.ShouldShowLivenessRewardDoubleTag(configId))
			{
				topRightTextId = "Reward_Tag_Extra";
				topRightTextBgColor = ConfigCommonParamById.GetStringConfig("Reward_Tag_Extra_Bg_Color");
				topRightTextColor = ConfigCommonParamById.GetStringConfig("Reward_Tag_Extra_Text_Color");
			}
			else
			{
				value = true;
			}
			bool flag = true;
			InventoryDefine.EItemDataType itemDataType = config.ItemDataType;
			if (itemDataType <= InventoryDefine.EItemDataType.PhantomItem)
			{
				if (itemDataType == InventoryDefine.EItemDataType.RoleItem)
				{
					RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(configId);
					CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
					{
						Data = data,
						ItemConfigId = new int?(configId),
						BottomTextId = roleConfig.Value.Name,
						QualityId = new int?(roleConfig.Value.QualityId),
						TopRightTextId = topRightTextId,
						TopRightTextBgColor = topRightTextBgColor,
						TopRightTextColor = topRightTextColor,
						IsDoubleRewardVisible = new bool?(value)
					};
					base.Apply<CharacterSmallItemGrid>(parameters);
					return;
				}
				if (itemDataType == InventoryDefine.EItemDataType.PhantomItem)
				{
					if (PhantomBattleConfig.Instance.GetPhantomItemById(configId).Value.ParentMonsterId == 0)
					{
						PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(data.UniqueId);
						PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(data.UniqueId);
						if (phantomItemData != null && phantomBattleData != null)
						{
							PhantomSmallItemGrid phantomSmallItemGrid = new PhantomSmallItemGrid();
							phantomSmallItemGrid.Data = data;
							phantomSmallItemGrid.ItemConfigId = new int?(configId);
							phantomSmallItemGrid.TopRightTextId = topRightTextId;
							phantomSmallItemGrid.TopRightTextBgColor = topRightTextBgColor;
							phantomSmallItemGrid.TopRightTextColor = topRightTextColor;
							phantomSmallItemGrid.FetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
							phantomSmallItemGrid.IsPhantomLock = new bool?(phantomItemData.GetIsLock());
							phantomSmallItemGrid.IsPhantomDeprecate = new bool?(phantomItemData.GetIsDeprecated());
							phantomSmallItemGrid.IsDoubleRewardVisible = new bool?(value);
							string bottomText;
							if (data.Count <= 1)
							{
								bottomText = null;
							}
							else
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
								defaultInterpolatedStringHandler.AppendLiteral("x");
								defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
								bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
							}
							phantomSmallItemGrid.BottomText = bottomText;
							PhantomSmallItemGrid parameters2 = phantomSmallItemGrid;
							base.Apply<PhantomSmallItemGrid>(parameters2);
							return;
						}
					}
				}
			}
			else if (itemDataType == InventoryDefine.EItemDataType.MotorStickerItem || itemDataType - InventoryDefine.EItemDataType.MotorFrameItem <= 2)
			{
				flag = false;
			}
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.ItemConfigId = new int?(configId);
			string bottomText2;
			if (!flag)
			{
				bottomText2 = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				bottomText2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propSmallItemGrid.BottomText = bottomText2;
			propSmallItemGrid.TopRightTextId = topRightTextId;
			propSmallItemGrid.TopRightTextBgColor = topRightTextBgColor;
			propSmallItemGrid.TopRightTextColor = topRightTextColor;
			propSmallItemGrid.RoleDevelopStateTagType = data.GetRoleDevelopStateTagType();
			propSmallItemGrid.IsTimeFlagVisible = new bool?(data.GetShowTimeFlag());
			propSmallItemGrid.IsDoubleRewardVisible = new bool?(value);
			PropSmallItemGrid parameters3 = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters3);
		}

		// Token: 0x0602E3E3 RID: 189411 RVA: 0x00CE5FCF File Offset: 0x00CE41CF
		private void OnFuncValueChange(int uniqueId)
		{
			if (this.ItemData == null || this.ItemData.UniqueId != uniqueId)
			{
				return;
			}
			this.RefreshByData(this.ItemData);
		}

		// Token: 0x04018A00 RID: 100864
		[Nullable(2)]
		private RewardItemData ItemData;
	}
}
