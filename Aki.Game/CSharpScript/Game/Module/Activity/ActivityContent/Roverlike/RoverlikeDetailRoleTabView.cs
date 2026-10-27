using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200612B RID: 24875
	public class RoverlikeDetailRoleTabView : UiTabViewBase
	{
		// Token: 0x0603EE34 RID: 257588 RVA: 0x00F30A08 File Offset: 0x00F2EC08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EE35 RID: 257589 RVA: 0x00F30B18 File Offset: 0x00F2ED18
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailRoleTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailRoleTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EE36 RID: 257590 RVA: 0x00F30B5C File Offset: 0x00F2ED5C
		protected override void OnStart()
		{
			this.AttributeLayout = new GenericScrollViewNew<RoverlikeRoleAttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetScrollViewWithScrollbar(5), () => new RoverlikeRoleAttributeItem(), base.GetItem(6).GetOwner() as AUIBaseActor, false, null);
			this.RefreshRoleInfo();
		}

		// Token: 0x0603EE37 RID: 257591 RVA: 0x00F30BB4 File Offset: 0x00F2EDB4
		private void RefreshRoleInfo()
		{
			int mainRoleId = RoverlikeModel.Instance.GetMainRoleId();
			int roleType = RoverlikeModel.Instance.InstanceData.RoleType;
			RoverRogueRoleType value = RoverlikeConfig.Instance.GetRoleTypeConfig(roleType).Value;
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(value.ElementId);
			if (elementConfig == null)
			{
				return;
			}
			base.GetText(3).SetText(FunctionModel.Instance.GetPlayerName(), true);
			BigElementItem elementIcon = this.ElementIcon;
			if (elementIcon != null)
			{
				elementIcon.Refresh(value.ElementId);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), elementConfig.Value.Name, Array.Empty<object>());
			FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
			base.GetText(2).SetColor(color);
			this.RefreshAttributeList(mainRoleId);
			this.RefreshLootCard();
		}

		// Token: 0x0603EE38 RID: 257592 RVA: 0x00F30C94 File Offset: 0x00F2EE94
		private void RefreshAttributeList(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			int[] array = ((instance != null) ? instance.GetCurrentActivityData() : null).GetParamConfig().Value.AttributeList();
			List<CSharpScript.Game.Module.Common.AttributeData> list = new List<CSharpScript.Game.Module.Common.AttributeData>();
			for (int i = 0; i < array.Length; i++)
			{
				int id = array[i];
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(id);
				if (propertyIndexInfo != null)
				{
					CSharpScript.Game.Module.Common.AttributeData item = new CSharpScript.Game.Module.Common.AttributeData
					{
						Id = id,
						IsRatio = propertyIndexInfo.Value.IsPercent,
						CurValue = roleDataById.GetShowAttributeValueById(id),
						BgActive = new bool?(array.Length > 2 && i % 2 == 0)
					};
					list.Add(item);
				}
			}
			this.AttributeLayout.RefreshByData(list, null, true);
		}

		// Token: 0x0603EE39 RID: 257593 RVA: 0x00F30D70 File Offset: 0x00F2EF70
		private void RefreshLootCard()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			List<RoverlikeLootGainEntry> list = ((instanceData != null) ? instanceData.GetLootItemList() : null) ?? new List<RoverlikeLootGainEntry>();
			RoverlikeLootGainEntry roverlikeLootGainEntry = (list.Count > 0) ? list[0] : null;
			if (roverlikeLootGainEntry != null)
			{
				RoverlikeLootCardItem lootCard = this.LootCard;
				if (lootCard != null)
				{
					lootCard.Refresh(roverlikeLootGainEntry);
				}
				UUIItem item = base.GetItem(4);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(4);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603EE3A RID: 257594 RVA: 0x00F30DEC File Offset: 0x00F2EFEC
		private UniTask RefreshRoleSpineAsync()
		{
			RoverlikeDetailRoleTabView.<RefreshRoleSpineAsync>d__10 <RefreshRoleSpineAsync>d__;
			<RefreshRoleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpineAsync>d__.<>4__this = this;
			<RefreshRoleSpineAsync>d__.<>1__state = -1;
			<RefreshRoleSpineAsync>d__.<>t__builder.Start<RoverlikeDetailRoleTabView.<RefreshRoleSpineAsync>d__10>(ref <RefreshRoleSpineAsync>d__);
			return <RefreshRoleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04020D53 RID: 134483
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeRoleAttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

		// Token: 0x04020D54 RID: 134484
		[Nullable(2)]
		private BigElementItem ElementIcon;

		// Token: 0x04020D55 RID: 134485
		[Nullable(2)]
		private RoverlikeLootCardItem LootCard;

		// Token: 0x0200C386 RID: 50054
		private enum EComponents
		{
			// Token: 0x0403B01E RID: 241694
			SpineRole,
			// Token: 0x0403B01F RID: 241695
			PnlElementBigIcon,
			// Token: 0x0403B020 RID: 241696
			TxtAttributeLabel,
			// Token: 0x0403B021 RID: 241697
			TxtRoleName,
			// Token: 0x0403B022 RID: 241698
			ItemCardSpoils,
			// Token: 0x0403B023 RID: 241699
			AttributeLayout,
			// Token: 0x0403B024 RID: 241700
			AttributeItem
		}
	}
}
