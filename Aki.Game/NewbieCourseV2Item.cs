using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000850 RID: 2128
[NullableContext(1)]
[Nullable(0)]
public class NewbieCourseV2Item : GridProxyAbstract<NewbieCourseV2>
{
	// Token: 0x06006066 RID: 24678 RVA: 0x001EC0B0 File Offset: 0x001EA2B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITextureTransitionComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006067 RID: 24679 RVA: 0x001EC21C File Offset: 0x001EA41C
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		UUIItem item = base.GetItem(6);
		if (scrollViewWithScrollbar == null || item == null)
		{
			return;
		}
		scrollViewWithScrollbar.AllowEventBubbleUp = true;
		UUILayoutBase layout = scrollViewWithScrollbar.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(layout, new Func<CommonItemSmallItemGrid>(this.InitRewardItem), item.GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06006068 RID: 24680 RVA: 0x001EC288 File Offset: 0x001EA488
	protected override void OnBeforeDestroy()
	{
		this.CancelDigitMaterialLoad();
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		foreach (CommonItemSmallItemGrid child in (((rewardLayout != null) ? rewardLayout.GetLayoutItemList() : null) ?? new List<CommonItemSmallItemGrid>()))
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06006069 RID: 24681 RVA: 0x001EC2F8 File Offset: 0x001EA4F8
	public void SetActivityData(ActivityNewbieCourseV2Data activityData)
	{
		this.ActivityData = activityData;
	}

	// Token: 0x0600606A RID: 24682 RVA: 0x001EC301 File Offset: 0x001EA501
	public override void Refresh(NewbieCourseV2 config, bool isSelected, int gridIndex)
	{
		this.Config = new NewbieCourseV2?(config);
		this.RefreshLevelDisplay(config.TargetLevel);
		this.RefreshCurrentState();
	}

	// Token: 0x0600606B RID: 24683 RVA: 0x001EC322 File Offset: 0x001EA522
	public override object GetKey(NewbieCourseV2 data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600606C RID: 24684 RVA: 0x001EC330 File Offset: 0x001EA530
	public void RefreshCurrentState()
	{
		if (this.Config == null || this.ActivityData == null)
		{
			return;
		}
		this.CurrentState = this.ActivityData.GetRewardState(this.Config.Value.TargetLevel);
		this.RefreshLevelPrefix();
		this.RefreshRewardBackground();
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(this.CurrentState == ENewbieCourseV2ItemState.CanReceive);
		}
		this.RefreshDigitMaterial();
		this.RefreshRewardList();
	}

	// Token: 0x0600606D RID: 24685 RVA: 0x001EC3AA File Offset: 0x001EA5AA
	private CommonItemSmallItemGrid InitRewardItem()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.SetAllowClickBack(true);
		commonItemSmallItemGrid.ShowReceivedCallBack = ((TItem _) => this.ActivityData != null && this.Config != null && this.ActivityData.GetRewardState(this.Config.Value.TargetLevel) == ENewbieCourseV2ItemState.HasReceived);
		return commonItemSmallItemGrid;
	}

	// Token: 0x0600606E RID: 24686 RVA: 0x001EC3CC File Offset: 0x001EA5CC
	private void RefreshRewardList()
	{
		if (this.Config == null || this.RewardLayout == null)
		{
			return;
		}
		ItemData[] rewardList = ActivityNewbieCourseV2Config.Instance.GetRewardList(this.Config.Value.Reward);
		TItem[] rewardItems = new TItem[rewardList.Length];
		for (int i = 0; i < rewardList.Length; i++)
		{
			ItemData itemData = rewardList[i];
			rewardItems[i] = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(itemData.ItemId, 0),
				Count = itemData.Count
			};
		}
		bool showReceivable = this.CurrentState == ENewbieCourseV2ItemState.CanReceive;
		bool isClaimedDim = this.CurrentState == ENewbieCourseV2ItemState.HasReceived;
		this.RewardLayout.RefreshByData(rewardItems, delegate
		{
			for (int j = 0; j < rewardItems.Length; j++)
			{
				CommonItemSmallItemGrid layoutItemByIndex = this.RewardLayout.GetLayoutItemByIndex(j);
				if (layoutItemByIndex != null)
				{
					this.ApplySmallGridRewardOverlay(layoutItemByIndex, rewardItems[j].ItemData.ItemId, showReceivable, isClaimedDim);
				}
			}
		}, false);
	}

	// Token: 0x0600606F RID: 24687 RVA: 0x001EC4B0 File Offset: 0x001EA6B0
	private void ApplySmallGridRewardOverlay(CommonItemSmallItemGrid item, int itemConfigId, bool showReceivable, bool isClaimedDim)
	{
		int itemDataTypeByConfigId = (int)InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemConfigId));
		item.SetReceivableVisible(showReceivable);
		item.SetLockVisible(false);
		item.SetLockBlackVisible(false);
		if (itemDataTypeByConfigId == 1)
		{
			item.SetIsBlack(isClaimedDim);
			item.SetIsDisable(new bool?(false));
			return;
		}
		item.SetIsBlack(false);
		item.SetIsDisable(new bool?(isClaimedDim));
	}

	// Token: 0x06006070 RID: 24688 RVA: 0x001EC510 File Offset: 0x001EA710
	private void RefreshLevelDisplay(int targetLevel)
	{
		UUITexture texture = base.GetTexture(3);
		UUITexture texture2 = base.GetTexture(4);
		string text = Math.Max(0, targetLevel).ToString("D2");
		char digit = text[0];
		char digit2 = text[1];
		if (texture != null)
		{
			string digitTexturePath = this.GetDigitTexturePath(digit, true);
			texture.SetUIActive(!string.IsNullOrEmpty(digitTexturePath));
			if (!string.IsNullOrEmpty(digitTexturePath))
			{
				base.SetTextureByPath(digitTexturePath, texture, null, null);
			}
		}
		if (texture2 != null)
		{
			string digitTexturePath2 = this.GetDigitTexturePath(digit2, false);
			texture2.SetUIActive(!string.IsNullOrEmpty(digitTexturePath2));
			if (!string.IsNullOrEmpty(digitTexturePath2))
			{
				base.SetTextureByPath(digitTexturePath2, texture2, null, null);
			}
		}
	}

	// Token: 0x06006071 RID: 24689 RVA: 0x001EC5C8 File Offset: 0x001EA7C8
	private string GetDigitTexturePath(char digit, bool isLeftDigit)
	{
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted(isLeftDigit ? "T_NumL" : "T_NumR");
		defaultInterpolatedStringHandler.AppendFormatted<char>(digit);
		return instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06006072 RID: 24690 RVA: 0x001EC610 File Offset: 0x001EA810
	private void RefreshLevelPrefix()
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite == null)
		{
			return;
		}
		string resourceId;
		if (!NewbieCourseV2Define.LevelPrefixSpriteIds.TryGetValue(this.CurrentState, out resourceId))
		{
			resourceId = NewbieCourseV2Define.LevelPrefixSpriteIds[ENewbieCourseV2ItemState.Unaccomplished];
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		sprite.SetUIActive(!string.IsNullOrEmpty(resourcePath));
		if (!string.IsNullOrEmpty(resourcePath))
		{
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x001EC67F File Offset: 0x001EA87F
	private void RefreshRewardBackground()
	{
		this.RefreshRewardBackgroundTransition();
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x001EC688 File Offset: 0x001EA888
	private UniTask RefreshRewardBackgroundTransition()
	{
		NewbieCourseV2Item.<RefreshRewardBackgroundTransition>d__21 <RefreshRewardBackgroundTransition>d__;
		<RefreshRewardBackgroundTransition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardBackgroundTransition>d__.<>4__this = this;
		<RefreshRewardBackgroundTransition>d__.<>1__state = -1;
		<RefreshRewardBackgroundTransition>d__.<>t__builder.Start<NewbieCourseV2Item.<RefreshRewardBackgroundTransition>d__21>(ref <RefreshRewardBackgroundTransition>d__);
		return <RefreshRewardBackgroundTransition>d__.<>t__builder.Task;
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x001EC6CC File Offset: 0x001EA8CC
	private void RefreshDigitMaterial()
	{
		UUITexture texture = base.GetTexture(3);
		UUITexture texture2 = base.GetTexture(4);
		if (texture == null || texture2 == null)
		{
			return;
		}
		string text;
		string materialId = NewbieCourseV2Define.LeftDigitMaterialIds.TryGetValue(this.CurrentState, out text) ? text : NewbieCourseV2Define.LeftDigitMaterialIds[ENewbieCourseV2ItemState.Unaccomplished];
		string text2;
		string materialId2 = NewbieCourseV2Define.RightDigitMaterialIds.TryGetValue(this.CurrentState, out text2) ? text2 : NewbieCourseV2Define.RightDigitMaterialIds[ENewbieCourseV2ItemState.Unaccomplished];
		this.LoadDigitMaterial(materialId, texture, true);
		this.LoadDigitMaterial(materialId2, texture2, false);
	}

	// Token: 0x06006076 RID: 24694 RVA: 0x001EC74C File Offset: 0x001EA94C
	private void LoadDigitMaterial(string materialId, UUITexture texture, bool isLeft)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(materialId);
		if (string.IsNullOrEmpty(resourcePath))
		{
			texture.SetCustomUIMaterial(null);
			return;
		}
		if (isLeft)
		{
			if (this.LeftMaterialHandleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LeftMaterialHandleId);
			}
			this.LeftMaterialHandleId = ResourceSystem.Instance.LoadAsync<UMaterialInterface>(resourcePath, delegate([Nullable(2)] UMaterialInterface materialInterface, string _)
			{
				texture.SetCustomUIMaterial(materialInterface);
			}, ResourceSystem.EResourceLoadPriority.Ui, this.MemoryTag);
			return;
		}
		if (this.RightMaterialHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.RightMaterialHandleId);
		}
		this.RightMaterialHandleId = ResourceSystem.Instance.LoadAsync<UMaterialInterface>(resourcePath, delegate([Nullable(2)] UMaterialInterface materialInterface, string _)
		{
			texture.SetCustomUIMaterial(materialInterface);
		}, ResourceSystem.EResourceLoadPriority.Ui, this.MemoryTag);
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x001EC808 File Offset: 0x001EAA08
	private void CancelDigitMaterialLoad()
	{
		if (this.LeftMaterialHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LeftMaterialHandleId);
			this.LeftMaterialHandleId = -1;
		}
		if (this.RightMaterialHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.RightMaterialHandleId);
			this.RightMaterialHandleId = -1;
		}
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x001EC858 File Offset: 0x001EAA58
	private void OnClickReward()
	{
		if (this.Config == null || this.ActivityData == null)
		{
			return;
		}
		if (this.CurrentState != ENewbieCourseV2ItemState.CanReceive)
		{
			return;
		}
		ActivityNewbieCourseV2Controller activityNewbieCourseV2Controller = ActivityManager.GetActivityController(this.ActivityData.Type) as ActivityNewbieCourseV2Controller;
		if (activityNewbieCourseV2Controller == null)
		{
			return;
		}
		activityNewbieCourseV2Controller.RequestAllClaimableRewards(new int?(this.ActivityData.Id));
	}

	// Token: 0x04003F0F RID: 16143
	private NewbieCourseV2? Config;

	// Token: 0x04003F10 RID: 16144
	[Nullable(2)]
	private ActivityNewbieCourseV2Data ActivityData;

	// Token: 0x04003F11 RID: 16145
	private ENewbieCourseV2ItemState CurrentState;

	// Token: 0x04003F12 RID: 16146
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04003F13 RID: 16147
	private int LeftMaterialHandleId = -1;

	// Token: 0x04003F14 RID: 16148
	private int RightMaterialHandleId = -1;

	// Token: 0x02006B92 RID: 27538
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040235D3 RID: 144851
		public const int StripButton = 0;

		// Token: 0x040235D4 RID: 144852
		public const int RedPointPanel = 1;

		// Token: 0x040235D5 RID: 144853
		public const int LevelSprite = 2;

		// Token: 0x040235D6 RID: 144854
		public const int NumberLeft = 3;

		// Token: 0x040235D7 RID: 144855
		public const int NumberRight = 4;

		// Token: 0x040235D8 RID: 144856
		public const int RewardListLayout = 5;

		// Token: 0x040235D9 RID: 144857
		public const int RewardItemTemplate = 6;

		// Token: 0x040235DA RID: 144858
		public const int BackgroundTexture = 7;
	}
}
