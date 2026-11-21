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
	// Token: 0x020050A9 RID: 20649
	public class RoverlikeDetailRoleTabView : UiTabViewBase
	{
		// Token: 0x06033AF6 RID: 211702 RVA: 0x00E7781C File Offset: 0x00E75A1C
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

		// Token: 0x06033AF7 RID: 211703 RVA: 0x00E7792C File Offset: 0x00E75B2C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailRoleTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailRoleTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033AF8 RID: 211704 RVA: 0x00E77970 File Offset: 0x00E75B70
		protected override void OnStart()
		{
			this.AttributeLayout = new GenericScrollViewNew<RoverlikeRoleAttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetScrollViewWithScrollbar(5), () => new RoverlikeRoleAttributeItem(), base.GetItem(6).GetOwner() as AUIBaseActor, false, null);
			this.RefreshRoleInfo();
		}

		// Token: 0x06033AF9 RID: 211705 RVA: 0x00E779C8 File Offset: 0x00E75BC8
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

		// Token: 0x06033AFA RID: 211706 RVA: 0x00E77AA8 File Offset: 0x00E75CA8
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

		// Token: 0x06033AFB RID: 211707 RVA: 0x00E77B84 File Offset: 0x00E75D84
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

		// Token: 0x06033AFC RID: 211708 RVA: 0x00E77C00 File Offset: 0x00E75E00
		private UniTask RefreshRoleSpineAsync()
		{
			RoverlikeDetailRoleTabView.<RefreshRoleSpineAsync>d__10 <RefreshRoleSpineAsync>d__;
			<RefreshRoleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpineAsync>d__.<>4__this = this;
			<RefreshRoleSpineAsync>d__.<>1__state = -1;
			<RefreshRoleSpineAsync>d__.<>t__builder.Start<RoverlikeDetailRoleTabView.<RefreshRoleSpineAsync>d__10>(ref <RefreshRoleSpineAsync>d__);
			return <RefreshRoleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B680 RID: 112256
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeRoleAttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

		// Token: 0x0401B681 RID: 112257
		[Nullable(2)]
		private BigElementItem ElementIcon;

		// Token: 0x0401B682 RID: 112258
		[Nullable(2)]
		private RoverlikeLootCardItem LootCard;

		// Token: 0x0200AD6E RID: 44398
		private enum EComponents
		{
			// Token: 0x04035983 RID: 219523
			SpineRole,
			// Token: 0x04035984 RID: 219524
			PnlElementBigIcon,
			// Token: 0x04035985 RID: 219525
			TxtAttributeLabel,
			// Token: 0x04035986 RID: 219526
			TxtRoleName,
			// Token: 0x04035987 RID: 219527
			ItemCardSpoils,
			// Token: 0x04035988 RID: 219528
			AttributeLayout,
			// Token: 0x04035989 RID: 219529
			AttributeItem
		}
	}
}
