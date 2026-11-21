using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007AF RID: 1967
[NullableContext(1)]
[Nullable(0)]
public class BuildingTipsInfoView : UiViewBase
{
	// Token: 0x06005A0B RID: 23051 RVA: 0x001D3B57 File Offset: 0x001D1D57
	public BuildingTipsInfoView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005A0C RID: 23052 RVA: 0x001D3B6C File Offset: 0x001D1D6C
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

	// Token: 0x06005A0D RID: 23053 RVA: 0x001D3E10 File Offset: 0x001D2010
	private UniTask InitCaption()
	{
		BuildingTipsInfoView.<InitCaption>d__8 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<BuildingTipsInfoView.<InitCaption>d__8>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x001D3E54 File Offset: 0x001D2054
	private UniTask InitCostItem()
	{
		BuildingTipsInfoView.<InitCostItem>d__9 <InitCostItem>d__;
		<InitCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostItem>d__.<>4__this = this;
		<InitCostItem>d__.<>1__state = -1;
		<InitCostItem>d__.<>t__builder.Start<BuildingTipsInfoView.<InitCostItem>d__9>(ref <InitCostItem>d__);
		return <InitCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x001D3E97 File Offset: 0x001D2097
	private void InitLayout()
	{
		this.AttrLayout = new GenericLayout<BuildingAttributeItem, IAdditionData>(base.GetLayoutBase(17), new Func<BuildingAttributeItem>(this.InitAttributeItem), (AUIBaseActor)base.GetItem(18).GetOwner(), false, true);
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x001D3ECC File Offset: 0x001D20CC
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingTipsInfoView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingTipsInfoView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x001D3F10 File Offset: 0x001D2110
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		BuildingTipsInfoView.<OnBeforeShowAsyncImplementImplement>d__12 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<BuildingTipsInfoView.<OnBeforeShowAsyncImplementImplement>d__12>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x001D3F54 File Offset: 0x001D2154
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

	// Token: 0x06005A13 RID: 23059 RVA: 0x001D3F9E File Offset: 0x001D219E
	private BuildingAttributeItem InitAttributeItem()
	{
		return new BuildingAttributeItem();
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x001D3FA8 File Offset: 0x001D21A8
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

	// Token: 0x06005A15 RID: 23061 RVA: 0x001D406C File Offset: 0x001D226C
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

	// Token: 0x06005A16 RID: 23062 RVA: 0x001D40B8 File Offset: 0x001D22B8
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

	// Token: 0x06005A17 RID: 23063 RVA: 0x001D4164 File Offset: 0x001D2364
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

	// Token: 0x06005A18 RID: 23064 RVA: 0x001D426C File Offset: 0x001D246C
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

	// Token: 0x04003CC4 RID: 15556
	protected CommonCostItem CostItem;

	// Token: 0x04003CC5 RID: 15557
	protected ButtonItem ConfirmItem;

	// Token: 0x04003CC6 RID: 15558
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003CC7 RID: 15559
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<BuildingAttributeItem, IAdditionData> AttrLayout;

	// Token: 0x04003CC8 RID: 15560
	private readonly BuildingTipsInfoViewController Vc = new BuildingTipsInfoViewController();

	// Token: 0x02006AAF RID: 27311
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040231BC RID: 143804
		public const int Texture = 0;

		// Token: 0x040231BD RID: 143805
		public const int Title = 1;

		// Token: 0x040231BE RID: 143806
		public const int Level = 2;

		// Token: 0x040231BF RID: 143807
		public const int Content = 3;

		// Token: 0x040231C0 RID: 143808
		public const int RoleItem = 4;

		// Token: 0x040231C1 RID: 143809
		public const int RoleIcon = 5;

		// Token: 0x040231C2 RID: 143810
		public const int RoleDesc = 6;

		// Token: 0x040231C3 RID: 143811
		public const int ConfirmRootItem = 7;

		// Token: 0x040231C4 RID: 143812
		public const int CostItem = 8;

		// Token: 0x040231C5 RID: 143813
		public const int ConfirmItem = 9;

		// Token: 0x040231C6 RID: 143814
		public const int LockItem = 10;

		// Token: 0x040231C7 RID: 143815
		public const int LockText = 11;

		// Token: 0x040231C8 RID: 143816
		public const int MaxItem = 12;

		// Token: 0x040231C9 RID: 143817
		public const int LeftBtn = 13;

		// Token: 0x040231CA RID: 143818
		public const int RightBtn = 14;

		// Token: 0x040231CB RID: 143819
		public const int TrackBtn = 15;

		// Token: 0x040231CC RID: 143820
		public const int CaptionItem = 16;

		// Token: 0x040231CD RID: 143821
		public const int AttributeLayout = 17;

		// Token: 0x040231CE RID: 143822
		public const int AttributeItem = 18;

		// Token: 0x040231CF RID: 143823
		public const int BuildFrameTexture = 19;

		// Token: 0x040231D0 RID: 143824
		public const int LevelUpFrameBgTexture = 20;

		// Token: 0x040231D1 RID: 143825
		public const int LevelUpFrameTexture = 21;

		// Token: 0x040231D2 RID: 143826
		public const int ConditionBtn = 22;
	}
}
