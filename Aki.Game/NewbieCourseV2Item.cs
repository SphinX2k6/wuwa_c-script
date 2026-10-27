using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200139C RID: 5020
[NullableContext(1)]
[Nullable(0)]
public class NewbieCourseV2Item : GridProxyAbstract<NewbieCourseV2>
{
	// Token: 0x06008CCD RID: 36045 RVA: 0x001E3300 File Offset: 0x001E1500
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

	// Token: 0x06008CCE RID: 36046 RVA: 0x001E346C File Offset: 0x001E166C
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

	// Token: 0x06008CCF RID: 36047 RVA: 0x001E34D8 File Offset: 0x001E16D8
	protected override void OnBeforeDestroy()
	{
		this.CancelDigitMaterialLoad();
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		foreach (CommonItemSmallItemGrid child in (((rewardLayout != null) ? rewardLayout.GetLayoutItemList() : null) ?? new List<CommonItemSmallItemGrid>()))
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06008CD0 RID: 36048 RVA: 0x001E3548 File Offset: 0x001E1748
	public void SetActivityData(ActivityNewbieCourseV2Data activityData)
	{
		this.ActivityData = activityData;
	}

	// Token: 0x06008CD1 RID: 36049 RVA: 0x001E3551 File Offset: 0x001E1751
	public override void Refresh(NewbieCourseV2 config, bool isSelected, int gridIndex)
	{
		this.Config = new NewbieCourseV2?(config);
		this.RefreshLevelDisplay(NewbieCourseV2Item.ReadTargetLevel(config));
		this.RefreshCurrentState();
	}

	// Token: 0x06008CD2 RID: 36050 RVA: 0x001E3571 File Offset: 0x001E1771
	public override object GetKey(NewbieCourseV2 data, int displayIndex)
	{
		return NewbieCourseV2Item.ReadId(data);
	}

	// Token: 0x06008CD3 RID: 36051 RVA: 0x001E3580 File Offset: 0x001E1780
	public void RefreshCurrentState()
	{
		if (this.Config == null || this.ActivityData == null)
		{
			return;
		}
		NewbieCourseV2 value = this.Config.Value;
		this.CurrentState = this.ActivityData.GetRewardState(NewbieCourseV2Item.ReadTargetLevel(value));
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

	// Token: 0x06008CD4 RID: 36052 RVA: 0x001E35F9 File Offset: 0x001E17F9
	private CommonItemSmallItemGrid InitRewardItem()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.SetAllowClickBack(true);
		commonItemSmallItemGrid.ShowReceivedCallBack = delegate(TItem _)
		{
			if (this.ActivityData == null || this.Config == null)
			{
				return false;
			}
			NewbieCourseV2 value = this.Config.Value;
			return this.ActivityData.GetRewardState(NewbieCourseV2Item.ReadTargetLevel(value)) == ENewbieCourseV2ItemState.HasReceived;
		};
		return commonItemSmallItemGrid;
	}

	// Token: 0x06008CD5 RID: 36053 RVA: 0x001E361C File Offset: 0x001E181C
	private void RefreshRewardList()
	{
		if (this.Config == null || this.RewardLayout == null)
		{
			return;
		}
		NewbieCourseV2 value = this.Config.Value;
		ItemData[] rewardList = ActivityNewbieCourseV2Config.Instance.GetRewardList(NewbieCourseV2Item.ReadRewardId(value));
		TItem[] rewardItems = (from reward in rewardList
		select new TItem
		{
			ItemData = new InventoryDefine.GetItemData(reward.ItemId, 0),
			Count = reward.Count
		}).ToArray<TItem>();
		bool showReceivable = this.CurrentState == ENewbieCourseV2ItemState.CanReceive;
		bool isClaimedDim = this.CurrentState == ENewbieCourseV2ItemState.HasReceived;
		this.RewardLayout.RefreshByData(rewardItems, delegate
		{
			for (int i = 0; i < rewardItems.Length; i++)
			{
				CommonItemSmallItemGrid layoutItemByIndex = this.RewardLayout.GetLayoutItemByIndex(i);
				if (layoutItemByIndex != null)
				{
					this.ApplySmallGridRewardOverlay(layoutItemByIndex, rewardItems[i].ItemData.ItemId, showReceivable, isClaimedDim);
				}
			}
		}, false);
	}

	// Token: 0x06008CD6 RID: 36054 RVA: 0x001E36D8 File Offset: 0x001E18D8
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

	// Token: 0x06008CD7 RID: 36055 RVA: 0x001E3738 File Offset: 0x001E1938
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

	// Token: 0x06008CD8 RID: 36056 RVA: 0x001E37F0 File Offset: 0x001E19F0
	private string GetDigitTexturePath(char digit, bool isLeftDigit)
	{
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted(isLeftDigit ? "T_NumL" : "T_NumR");
		defaultInterpolatedStringHandler.AppendFormatted<char>(digit);
		return instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06008CD9 RID: 36057 RVA: 0x001E3838 File Offset: 0x001E1A38
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

	// Token: 0x06008CDA RID: 36058 RVA: 0x001E38A7 File Offset: 0x001E1AA7
	private void RefreshRewardBackground()
	{
		this.RefreshRewardBackgroundTransition();
	}

	// Token: 0x06008CDB RID: 36059 RVA: 0x001E38B0 File Offset: 0x001E1AB0
	private UniTask RefreshRewardBackgroundTransition()
	{
		NewbieCourseV2Item.<RefreshRewardBackgroundTransition>d__21 <RefreshRewardBackgroundTransition>d__;
		<RefreshRewardBackgroundTransition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardBackgroundTransition>d__.<>4__this = this;
		<RefreshRewardBackgroundTransition>d__.<>1__state = -1;
		<RefreshRewardBackgroundTransition>d__.<>t__builder.Start<NewbieCourseV2Item.<RefreshRewardBackgroundTransition>d__21>(ref <RefreshRewardBackgroundTransition>d__);
		return <RefreshRewardBackgroundTransition>d__.<>t__builder.Task;
	}

	// Token: 0x06008CDC RID: 36060 RVA: 0x001E38F4 File Offset: 0x001E1AF4
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

	// Token: 0x06008CDD RID: 36061 RVA: 0x001E3974 File Offset: 0x001E1B74
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

	// Token: 0x06008CDE RID: 36062 RVA: 0x001E3A30 File Offset: 0x001E1C30
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

	// Token: 0x06008CDF RID: 36063 RVA: 0x001E3A80 File Offset: 0x001E1C80
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

	// Token: 0x06008CE0 RID: 36064 RVA: 0x001E3ADC File Offset: 0x001E1CDC
	private static int ReadId(NewbieCourseV2 config)
	{
		Type type = config.GetType();
		PropertyInfo property = type.GetProperty("Id");
		object obj = (property != null) ? property.GetValue(config) : null;
		if (obj is int)
		{
			return (int)obj;
		}
		MethodInfo methodInfo = type.GetMethod("Id", Type.EmptyTypes) ?? type.GetMethod("id", Type.EmptyTypes);
		obj = ((methodInfo != null) ? methodInfo.Invoke(config, null) : null);
		if (obj is int)
		{
			return (int)obj;
		}
		return 0;
	}

	// Token: 0x06008CE1 RID: 36065 RVA: 0x001E3B70 File Offset: 0x001E1D70
	private static int ReadTargetLevel(NewbieCourseV2 config)
	{
		Type type = config.GetType();
		PropertyInfo property = type.GetProperty("TargetLevel");
		object obj = (property != null) ? property.GetValue(config) : null;
		if (obj is int)
		{
			return (int)obj;
		}
		MethodInfo methodInfo = type.GetMethod("TargetLevel", Type.EmptyTypes) ?? type.GetMethod("targetlevel", Type.EmptyTypes);
		obj = ((methodInfo != null) ? methodInfo.Invoke(config, null) : null);
		if (obj is int)
		{
			return (int)obj;
		}
		return 0;
	}

	// Token: 0x06008CE2 RID: 36066 RVA: 0x001E3C04 File Offset: 0x001E1E04
	private static int ReadRewardId(NewbieCourseV2 config)
	{
		Type type = config.GetType();
		PropertyInfo property = type.GetProperty("Reward");
		object obj = (property != null) ? property.GetValue(config) : null;
		if (obj is int)
		{
			return (int)obj;
		}
		MethodInfo methodInfo = type.GetMethod("Reward", Type.EmptyTypes) ?? type.GetMethod("reward", Type.EmptyTypes);
		obj = ((methodInfo != null) ? methodInfo.Invoke(config, null) : null);
		if (obj is int)
		{
			return (int)obj;
		}
		return 0;
	}

	// Token: 0x04003E77 RID: 15991
	private NewbieCourseV2? Config;

	// Token: 0x04003E78 RID: 15992
	[Nullable(2)]
	private ActivityNewbieCourseV2Data ActivityData;

	// Token: 0x04003E79 RID: 15993
	private ENewbieCourseV2ItemState CurrentState;

	// Token: 0x04003E7A RID: 15994
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04003E7B RID: 15995
	private int LeftMaterialHandleId = -1;

	// Token: 0x04003E7C RID: 15996
	private int RightMaterialHandleId = -1;

	// Token: 0x02007A0A RID: 31242
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040282B0 RID: 164528
		public const int StripButton = 0;

		// Token: 0x040282B1 RID: 164529
		public const int RedPointPanel = 1;

		// Token: 0x040282B2 RID: 164530
		public const int LevelSprite = 2;

		// Token: 0x040282B3 RID: 164531
		public const int NumberLeft = 3;

		// Token: 0x040282B4 RID: 164532
		public const int NumberRight = 4;

		// Token: 0x040282B5 RID: 164533
		public const int RewardListLayout = 5;

		// Token: 0x040282B6 RID: 164534
		public const int RewardItemTemplate = 6;

		// Token: 0x040282B7 RID: 164535
		public const int BackgroundTexture = 7;
	}
}
