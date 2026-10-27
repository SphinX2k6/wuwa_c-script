using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012FB RID: 4859
[NullableContext(1)]
[Nullable(0)]
public class BuildingTipsInfoView : UiViewBase
{
	// Token: 0x06008670 RID: 34416 RVA: 0x001CACEB File Offset: 0x001C8EEB
	public BuildingTipsInfoView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008671 RID: 34417 RVA: 0x001CAD00 File Offset: 0x001C8F00
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(13, new Action(this.Vc.SwitchPrev)),
			new ValueTuple<int, Delegate>(14, new Action(this.Vc.SwitchNext)),
			new ValueTuple<int, Delegate>(15, new Action(this.Vc.JumpToMap)),
			new ValueTuple<int, Delegate>(22, new Action(this.Vc.JumpToConditionTip))
		};
	}

	// Token: 0x06008672 RID: 34418 RVA: 0x001CAFA4 File Offset: 0x001C91A4
	private UniTask InitCaption()
	{
		BuildingTipsInfoView.<InitCaption>d__8 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<BuildingTipsInfoView.<InitCaption>d__8>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06008673 RID: 34419 RVA: 0x001CAFE8 File Offset: 0x001C91E8
	private UniTask InitCostItem()
	{
		BuildingTipsInfoView.<InitCostItem>d__9 <InitCostItem>d__;
		<InitCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostItem>d__.<>4__this = this;
		<InitCostItem>d__.<>1__state = -1;
		<InitCostItem>d__.<>t__builder.Start<BuildingTipsInfoView.<InitCostItem>d__9>(ref <InitCostItem>d__);
		return <InitCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008674 RID: 34420 RVA: 0x001CB02B File Offset: 0x001C922B
	private void InitLayout()
	{
		this.AttrLayout = new GenericLayout<BuildingAttributeItem, IAdditionData>(base.GetLayoutBase(17), new Func<BuildingAttributeItem>(this.InitAttributeItem), (AUIBaseActor)base.GetItem(18).GetOwner(), false, true);
	}

	// Token: 0x06008675 RID: 34421 RVA: 0x001CB060 File Offset: 0x001C9260
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingTipsInfoView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingTipsInfoView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008676 RID: 34422 RVA: 0x001CB0A4 File Offset: 0x001C92A4
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		BuildingTipsInfoView.<OnBeforeShowAsyncImplementImplement>d__12 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<BuildingTipsInfoView.<OnBeforeShowAsyncImplementImplement>d__12>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06008677 RID: 34423 RVA: 0x001CB0E8 File Offset: 0x001C92E8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		if (!(configParams[0] == "Cost".ToString()))
		{
			return null;
		}
		UUIItem costContent = this.CaptionItem.GetCostContent();
		if (costContent == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			costContent,
			costContent
		};
	}

	// Token: 0x06008678 RID: 34424 RVA: 0x001CB132 File Offset: 0x001C9332
	private BuildingAttributeItem InitAttributeItem()
	{
		return new BuildingAttributeItem();
	}

	// Token: 0x06008679 RID: 34425 RVA: 0x001CB13C File Offset: 0x001C933C
	public void RefreshText(int buildingId)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(buildingId);
		UUIText text = base.GetText(2);
		UUIText text2 = base.GetText(1);
		UUIText text3 = base.GetText(3);
		text.SetUIActive(buildingDataById.IsUnlock);
		Building buildingById = BuildingConfig.Instance.GetBuildingById(buildingId);
		LguiUtil.Instance.SetLocalTextNew(text2, buildingById.Name ?? "", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text3, buildingById.Desc ?? "", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text, "Moonfiesta_BuildingLevelShow", new <>z__ReadOnlyArray<object>(new object[]
		{
			buildingDataById.Level,
			buildingDataById.LevelMax
		}));
	}

	// Token: 0x0600867A RID: 34426 RVA: 0x001CB200 File Offset: 0x001C9400
	public UniTask RefreshAttribute(int buildingId)
	{
		BuildingTipsInfoView.<RefreshAttribute>d__16 <RefreshAttribute>d__;
		<RefreshAttribute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAttribute>d__.<>4__this = this;
		<RefreshAttribute>d__.buildingId = buildingId;
		<RefreshAttribute>d__.<>1__state = -1;
		<RefreshAttribute>d__.<>t__builder.Start<BuildingTipsInfoView.<RefreshAttribute>d__16>(ref <RefreshAttribute>d__);
		return <RefreshAttribute>d__.<>t__builder.Task;
	}

	// Token: 0x0600867B RID: 34427 RVA: 0x001CB24C File Offset: 0x001C944C
	public void RefreshRoleItem(int buildingId)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(buildingId);
		UUIItem item = base.GetItem(4);
		if (!buildingDataById.IsUnlock)
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(!buildingDataById.IsBuild);
		if (!buildingDataById.IsBuild)
		{
			Building buildingById = BuildingConfig.Instance.GetBuildingById(buildingId);
			base.SetTextureByPath(BusinessConfig.Instance.GetEntrustRoleById(buildingById.AssociateRole).SmallHeadIcon, base.GetTexture(5), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), buildingById.RoleTips ?? "", Array.Empty<object>());
		}
	}

	// Token: 0x0600867C RID: 34428 RVA: 0x001CB2F8 File Offset: 0x001C94F8
	public void RefreshBottom(int buildingId)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(buildingId);
		UUIItem item = base.GetItem(7);
		UUIItem item2 = base.GetItem(10);
		UUIItem item3 = base.GetItem(12);
		item.SetUIActive(buildingDataById.IsUnlock && !buildingDataById.IsMax);
		item2.SetUIActive(!buildingDataById.IsUnlock);
		item3.SetUIActive(buildingDataById.IsMax);
		if (!buildingDataById.IsUnlock)
		{
			string textStringId = LevelGeneralCommons.GetConditionGroupHintText(BuildingConfig.Instance.GetBuildingById(buildingId).UnlockCondition) ?? "";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), textStringId, Array.Empty<object>());
			return;
		}
		if (buildingDataById.IsMax)
		{
			return;
		}
		int coinItemId = BusinessConfig.Instance.GetCoinItemId();
		this.CostItem.UpdateItem(coinItemId, buildingDataById.GetConsumeCount());
		this.CostItem.RefreshCountEnableState();
		if (buildingDataById.IsBuild)
		{
			this.ConfirmItem.SetShowText("PrefabTextItem_2996025119_Text");
			return;
		}
		this.ConfirmItem.SetShowText("Moonfiesta_BuildingTips_Building");
	}

	// Token: 0x0600867D RID: 34429 RVA: 0x001CB400 File Offset: 0x001C9600
	public void RefreshTexture(int buildingId)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(buildingId);
		Building buildingById = BuildingConfig.Instance.GetBuildingById(buildingId);
		UUIButtonComponent button = base.GetButton(15);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(13);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button3 = base.GetButton(14);
		if (button3 != null)
		{
			button3.RootUIComp.Get().SetUIActive(false);
		}
		if (!buildingDataById.IsUnlock)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_BuildItemBLock");
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}
		else if (buildingDataById.IsBuild)
		{
			base.SetTextureByPath(buildingById.BuildingTexture ?? "", base.GetTexture(0), null, null);
		}
		else
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_BuildItemBUnlock");
			base.SetTextureByPath(resourcePath2, base.GetTexture(0), null, null);
		}
		UUIItem item = base.GetItem(19);
		if (item != null)
		{
			item.SetUIActive(!buildingDataById.IsBuild);
		}
		UUIItem item2 = base.GetItem(20);
		if (item2 != null)
		{
			item2.SetUIActive(buildingDataById.IsBuild);
		}
		UUIItem item3 = base.GetItem(21);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(buildingDataById.IsBuild);
	}

	// Token: 0x04003C2C RID: 15404
	protected CommonCostItem CostItem;

	// Token: 0x04003C2D RID: 15405
	protected ButtonItem ConfirmItem;

	// Token: 0x04003C2E RID: 15406
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003C2F RID: 15407
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<BuildingAttributeItem, IAdditionData> AttrLayout;

	// Token: 0x04003C30 RID: 15408
	private readonly BuildingTipsInfoViewController Vc = new BuildingTipsInfoViewController();

	// Token: 0x02007925 RID: 31013
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027E8F RID: 163471
		public const int Texture = 0;

		// Token: 0x04027E90 RID: 163472
		public const int Title = 1;

		// Token: 0x04027E91 RID: 163473
		public const int Level = 2;

		// Token: 0x04027E92 RID: 163474
		public const int Content = 3;

		// Token: 0x04027E93 RID: 163475
		public const int RoleItem = 4;

		// Token: 0x04027E94 RID: 163476
		public const int RoleIcon = 5;

		// Token: 0x04027E95 RID: 163477
		public const int RoleDesc = 6;

		// Token: 0x04027E96 RID: 163478
		public const int ConfirmRootItem = 7;

		// Token: 0x04027E97 RID: 163479
		public const int CostItem = 8;

		// Token: 0x04027E98 RID: 163480
		public const int ConfirmItem = 9;

		// Token: 0x04027E99 RID: 163481
		public const int LockItem = 10;

		// Token: 0x04027E9A RID: 163482
		public const int LockText = 11;

		// Token: 0x04027E9B RID: 163483
		public const int MaxItem = 12;

		// Token: 0x04027E9C RID: 163484
		public const int LeftBtn = 13;

		// Token: 0x04027E9D RID: 163485
		public const int RightBtn = 14;

		// Token: 0x04027E9E RID: 163486
		public const int TrackBtn = 15;

		// Token: 0x04027E9F RID: 163487
		public const int CaptionItem = 16;

		// Token: 0x04027EA0 RID: 163488
		public const int AttributeLayout = 17;

		// Token: 0x04027EA1 RID: 163489
		public const int AttributeItem = 18;

		// Token: 0x04027EA2 RID: 163490
		public const int BuildFrameTexture = 19;

		// Token: 0x04027EA3 RID: 163491
		public const int LevelUpFrameBgTexture = 20;

		// Token: 0x04027EA4 RID: 163492
		public const int LevelUpFrameTexture = 21;

		// Token: 0x04027EA5 RID: 163493
		public const int ConditionBtn = 22;
	}
}
