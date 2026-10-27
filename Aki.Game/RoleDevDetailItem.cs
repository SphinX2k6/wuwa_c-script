using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020027F7 RID: 10231
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevDetailItem : GridProxyAbstract<global::IRoleDevDetailItemData>
{
	// Token: 0x06014FFE RID: 86014 RVA: 0x00551434 File Offset: 0x0054F634
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014FFF RID: 86015 RVA: 0x00551564 File Offset: 0x0054F764
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevDetailItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevDetailItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015000 RID: 86016 RVA: 0x005515A7 File Offset: 0x0054F7A7
	protected override void OnStart()
	{
		this.ItemGroupHorizontalLayout = new GenericLayout<RoleDevDetailSubItemList, global::IMaterialItemData>(base.GetHorizontalLayout(2), new Func<RoleDevDetailSubItemList>(this.InitItemGroupItem), null, false, true);
	}

	// Token: 0x06015001 RID: 86017 RVA: 0x005515CC File Offset: 0x0054F7CC
	public override void Refresh(global::IRoleDevDetailItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Title, Array.Empty<object>());
		List<global::IMaterialItemData> list = new List<global::IMaterialItemData>();
		foreach (global::IItemMaterial itemMaterial in data.ItemGroup)
		{
			list.Add(RoleDevDetailSubItemList.CreateMaterialData(itemMaterial.ItemId, itemMaterial.RequiredCount));
		}
		GenericLayout<RoleDevDetailSubItemList, global::IMaterialItemData> itemGroupHorizontalLayout = this.ItemGroupHorizontalLayout;
		if (itemGroupHorizontalLayout != null)
		{
			itemGroupHorizontalLayout.RefreshByData(list, null, false);
		}
		bool flag = true;
		foreach (global::IMaterialItemData materialItemData in list)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(materialItemData.ItemId, 0);
			if (materialItemData.RequiredCount > itemCountByConfigId)
			{
				flag = false;
				break;
			}
		}
		this.IsMaterialProspective = false;
		foreach (global::IItemMaterial itemMaterial2 in data.ItemGroup)
		{
			int itemId = itemMaterial2.ItemId;
			RoleDevCulProjectConfig? roleDevCulProjectConfig;
			int? num = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().UnknownItemId) : null;
			if (itemId == num.GetValueOrDefault() & num != null)
			{
				this.IsMaterialProspective = true;
				break;
			}
		}
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(flag && !this.IsMaterialProspective);
		}
		this.ButtonConfirm.GetRootItem().SetUIActive(!this.IsMaterialProspective);
		this.ButtonConfirm.SetLocalTextNew(this.IsMaterialProspective ? "RoleProject_Access_None" : "RoleProject_Button03", Array.Empty<object>());
		ButtonItem buttonConfirm = this.ButtonConfirm;
		if (buttonConfirm != null)
		{
			buttonConfirm.SetFunction(new Action<int>(this.OnBtnTrack));
		}
		ButtonItem buttonConfirm2 = this.ButtonConfirm;
		if (buttonConfirm2 != null)
		{
			buttonConfirm2.SetEnableClick(this.OnCanExecuteBtnTrack());
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(this.IsMaterialProspective);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "RoleProject_Access_None", Array.Empty<object>());
		this.RefreshTextMatLimit(data);
	}

	// Token: 0x06015002 RID: 86018 RVA: 0x00551830 File Offset: 0x0054FA30
	private void RefreshTextMatLimit(global::IRoleDevDetailItemData data)
	{
		RoleDevConfig instance = RoleDevConfig.Instance;
		if (instance == null)
		{
			return;
		}
		RoleDevCulProjectConfig? roleDevCulProjectConfig;
		int? num = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().UnknownItemId) : null;
		bool flag = false;
		foreach (global::IItemMaterial itemMaterial in data.ItemGroup)
		{
			int itemId = itemMaterial.ItemId;
			int? num2 = num;
			if (!(itemId == num2.GetValueOrDefault() & num2 != null))
			{
				RoleDevItemJumpGroup? itemJumpGroupConfig = instance.GetItemJumpGroupConfig(itemMaterial.ItemId);
				if (itemJumpGroupConfig != null && itemJumpGroupConfig.GetValueOrDefault().ItemType == 5)
				{
					flag = true;
					break;
				}
			}
		}
		UUIText text = base.GetText(1);
		if (flag)
		{
			if (text != null)
			{
				text.SetUIActive(true);
			}
			int num3 = 1;
			ExchangeShared value = ExchangeRewardConfig.Instance.GetExchangeShareConfig(new int?(num3)).Value;
			int exchangeRewardShareCount = ExchangeRewardModel.Instance.GetExchangeRewardShareCount(num3);
			int maxCount = value.MaxCount;
			int value2 = maxCount - exchangeRewardShareCount;
			LguiUtil instance2 = LguiUtil.Instance;
			UUIText uiText = text;
			string textTableId = "ReceivedCount";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(maxCount);
			instance2.SetLocalText(uiText, textTableId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
			return;
		}
		if (text != null)
		{
			text.SetUIActive(false);
		}
	}

	// Token: 0x06015003 RID: 86019 RVA: 0x005519B8 File Offset: 0x0054FBB8
	private bool OnCanExecuteBtnTrack()
	{
		global::IRoleDevDetailItemData data = this.Data;
		if (((data != null) ? data.ItemGroup : null) != null)
		{
			RoleDevCulProjectConfig? roleDevCulProjectConfig;
			int? num = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().UnknownItemId) : null;
			foreach (global::IItemMaterial itemMaterial in this.Data.ItemGroup)
			{
				int itemId = itemMaterial.ItemId;
				int? num2 = num;
				if (itemId == num2.GetValueOrDefault() & num2 != null)
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x06015004 RID: 86020 RVA: 0x00551A78 File Offset: 0x0054FC78
	private RoleDevDetailSubItemList InitItemGroupItem()
	{
		return new RoleDevDetailSubItemList();
	}

	// Token: 0x06015005 RID: 86021 RVA: 0x00551A80 File Offset: 0x0054FC80
	public void OnBtnTrack(int _)
	{
		global::IRoleDevDetailItemData data = this.Data;
		int num = (data != null) ? data.ItemGroup[0].ItemId : 0;
		RoleDevConfig instance = RoleDevConfig.Instance;
		RoleDevItemJumpGroup? roleDevItemJumpGroup = (instance != null) ? instance.GetItemJumpGroupConfig(num) : null;
		int num2 = (roleDevItemJumpGroup != null) ? roleDevItemJumpGroup.GetValueOrDefault().SpecialJumpGroup : 0;
		if (num2 > 0 && AdventureGuideModel.Instance.GetIsDetectionPreOpenByPreOpenId(num2))
		{
			this.HandlePreOpenDetection(num2);
			return;
		}
		global::IRoleDevDetailItemData data2 = this.Data;
		ERoleDevSubPageButton eroleDevSubPageButton = (data2 != null) ? data2.ButtonType : ERoleDevSubPageButton.None;
		RoleDevController instance2 = RoleDevController.Instance;
		global::IRoleDevDetailItemData data3 = this.Data;
		int roleId = (data3 != null) ? data3.RoleId : 0;
		global::IRoleDevDetailItemData data4 = this.Data;
		instance2.LogRoleDevSubPageClick(roleId, (data4 != null) ? data4.MainPage : ERoleDevMainPage.None, eroleDevSubPageButton);
		if (eroleDevSubPageButton == ERoleDevSubPageButton.SkillWeaponMaterialGo && this.TryWeaponSkillTrack(num))
		{
			return;
		}
		int? firstUnlockedTeleportId = RoleDevUtils.GetFirstUnlockedTeleportId((roleDevItemJumpGroup != null) ? roleDevItemJumpGroup.GetValueOrDefault().JumpGroup() : null);
		if (firstUnlockedTeleportId != null)
		{
			this.HandleSkipTaskJump(firstUnlockedTeleportId.Value);
		}
	}

	// Token: 0x06015006 RID: 86022 RVA: 0x00551B88 File Offset: 0x0054FD88
	private bool TryWeaponSkillTrack(int jumpGroupId)
	{
		RoleDevConfig instance = RoleDevConfig.Instance;
		RoleDevItemJumpGroup? roleDevItemJumpGroup = (instance != null) ? instance.GetItemJumpGroupConfig(jumpGroupId) : null;
		if (roleDevItemJumpGroup == null)
		{
			return false;
		}
		global::IRoleDevDetailItemData data = this.Data;
		int? num = (data != null) ? new int?(data.RoleId) : null;
		RoleDevConfig instance2 = RoleDevConfig.Instance;
		RoleDevProject? roleDevProject = (instance2 != null) ? instance2.GetRoleDevProjectConfig(num.Value) : null;
		if (roleDevProject == null || roleDevProject.Value.SkillItemJumpType() == null)
		{
			return false;
		}
		int[] array = roleDevItemJumpGroup.Value.JumpGroup();
		foreach (IntArray intArray in roleDevProject.Value.SkillItemJumpType())
		{
			if (intArray.ArrayIntLength >= 2 && intArray.ArrayInt(0) == roleDevItemJumpGroup.Value.ItemType)
			{
				int num2 = intArray.ArrayInt(1);
				if (num2 >= 0 && num2 < array.Length)
				{
					int num3 = array[num2];
					if (num3 != 0 && RoleDevUtils.CheckAccessPathUnlocked(num3))
					{
						this.HandleSkipTaskJump(num3);
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06015007 RID: 86023 RVA: 0x00551CB5 File Offset: 0x0054FEB5
	private void HandleSkipTaskJump(int skipTaskId)
	{
		global::IRoleDevDetailItemData data = this.Data;
		SkipTaskManager.RunByConfigId(skipTaskId, (data != null) ? data.ItemGroup[0].ItemId : 0);
	}

	// Token: 0x06015008 RID: 86024 RVA: 0x00551CE0 File Offset: 0x0054FEE0
	private void HandlePreOpenDetection(int specialJumpId)
	{
		if (OnlineModel.Instance.GetIsTeamModel())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("CantUseInMultiplayerMode", Array.Empty<object>());
			return;
		}
		PreOpenDetection? preOpenDetectionConfById = AdventureGuideConfig.Instance.GetPreOpenDetectionConfById(specialJumpId);
		if (preOpenDetectionConfById == null)
		{
			return;
		}
		if (preOpenDetectionConfById.Value.Spoiler)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreOpenSpoilConfirmBoxFromRoleDev);
			Action value = delegate()
			{
				AdventureGuideController.Instance.HandlePreOpenDetectionByPreOpenId(specialJumpId);
			};
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		AdventureGuideController.Instance.HandlePreOpenDetectionByPreOpenId(specialJumpId);
	}

	// Token: 0x04009DF3 RID: 40435
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailSubItemList, global::IMaterialItemData> ItemGroupHorizontalLayout;

	// Token: 0x04009DF4 RID: 40436
	[Nullable(2)]
	private global::IRoleDevDetailItemData Data;

	// Token: 0x04009DF5 RID: 40437
	[Nullable(2)]
	private ButtonItem ButtonConfirm;

	// Token: 0x04009DF6 RID: 40438
	private bool IsMaterialProspective;

	// Token: 0x02008E44 RID: 36420
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E268 RID: 189032
		TxtTitle,
		// Token: 0x0402E269 RID: 189033
		TxtMatLimit,
		// Token: 0x0402E26A RID: 189034
		HorizontalLayoutContent,
		// Token: 0x0402E26B RID: 189035
		ItemBaseB,
		// Token: 0x0402E26C RID: 189036
		ItemBtnConfirm,
		// Token: 0x0402E26D RID: 189037
		ItemPanelNotObtained,
		// Token: 0x0402E26E RID: 189038
		ItemFinishTag,
		// Token: 0x0402E26F RID: 189039
		TextNoMaterial
	}
}
