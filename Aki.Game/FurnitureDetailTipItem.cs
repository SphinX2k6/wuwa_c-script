using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000480 RID: 1152
public class FurnitureDetailTipItem : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x06003B81 RID: 15233 RVA: 0x00152AC8 File Offset: 0x00150CC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickJumpButton))
		};
	}

	// Token: 0x06003B82 RID: 15234 RVA: 0x00152C53 File Offset: 0x00150E53
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06003B83 RID: 15235 RVA: 0x00152C68 File Offset: 0x00150E68
	public UniTask PlayCloseSequence()
	{
		FurnitureDetailTipItem.<PlayCloseSequence>d__5 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<FurnitureDetailTipItem.<PlayCloseSequence>d__5>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06003B84 RID: 15236 RVA: 0x00152CAC File Offset: 0x00150EAC
	[NullableContext(1)]
	public void Refresh(ItemTipsData data)
	{
		TipsFurnitureData tipsFurnitureData = data as TipsFurnitureData;
		if (tipsFurnitureData == null)
		{
			return;
		}
		this.RefreshByFurnitureId(tipsFurnitureData.ConfigId, false);
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x00152CD4 File Offset: 0x00150ED4
	public void RefreshByFurnitureId(int id, bool showBottomEmptyItem)
	{
		this.FurnitureId = id;
		Furniture? furnitureConfig = FurnitureConfig.Instance.GetFurnitureConfig(id);
		if (furnitureConfig == null)
		{
			return;
		}
		base.SetTextureByPath(furnitureConfig.Value.Icon, base.GetTexture(2), null, null);
		int tagId = furnitureConfig.Value.TagId;
		FurnitureDiyTag? furnitureTagConfig = FurnitureConfig.Instance.GetFurnitureTagConfig(tagId);
		if (furnitureTagConfig != null)
		{
			this.SetSpriteByPath(furnitureTagConfig.Value.OccupiedIcon, base.GetSprite(3), false, null, null);
		}
		base.GetText(4).SetText(furnitureConfig.Value.Atmosphere.ToString(), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), furnitureConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), furnitureConfig.Value.AttributesDescription, Array.Empty<object>());
		FurnitureQualityConfig? furnitureQualityConfig = FurnitureConfig.Instance.GetFurnitureQualityConfig(furnitureConfig.Value.QualityId);
		if (furnitureQualityConfig != null)
		{
			base.GetSprite(0).SetColor(FColor.FromHex(furnitureQualityConfig.Value.TipBgColor));
			base.GetSprite(1).SetColor(FColor.FromHex(furnitureQualityConfig.Value.TipLineColor));
		}
		EFurnitureSourceType sourceType = (EFurnitureSourceType)furnitureConfig.Value.SourceType;
		bool isFurnitureUnlockById = FurnitureModel.Instance.GetIsFurnitureUnlockById(furnitureConfig.Value.Id);
		base.GetButton(7).RootUIComp.Get().SetUIActive(!isFurnitureUnlockById);
		base.GetItem(13).SetUIActive(!isFurnitureUnlockById);
		base.GetItem(14).SetUIActive(isFurnitureUnlockById && showBottomEmptyItem);
		base.GetTexture(2).SetAlpha(isFurnitureUnlockById ? 1f : 0.5f);
		if (!isFurnitureUnlockById)
		{
			base.GetItem(8).SetUIActive(sourceType == EFurnitureSourceType.Gift);
			UUISprite sprite = base.GetSprite(10);
			string textStringId = "";
			string[] array = null;
			string resourceId = "";
			bool flag = false;
			bool flag2 = false;
			switch (sourceType)
			{
			case EFurnitureSourceType.Shop:
				textStringId = "DIY_Furniture_Obtain_ShopState";
				flag = true;
				resourceId = "SP_FuncIconShop";
				flag2 = true;
				break;
			case EFurnitureSourceType.Gift:
				textStringId = "DIY_Furniture_Obtain_PresentState";
				base.SetTextureByPath(furnitureConfig.Value.RoleIconPath, base.GetTexture(9), null, null);
				flag2 = true;
				break;
			case EFurnitureSourceType.Atmosphere:
				textStringId = "DIY_Dic_AtmoLockedState";
				flag = true;
				resourceId = "SP_FurnitureInfoIconEmpty";
				array = new string[]
				{
					furnitureConfig.Value.GetWayId.ToString()
				};
				break;
			}
			sprite.SetUIActive(flag);
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetRaycastTarget(flag2);
			}
			UUISprite sprite2 = base.GetSprite(12);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag2);
			}
			if (flag)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			}
			if (array != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), textStringId, array);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), textStringId, Array.Empty<object>());
		}
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x00153048 File Offset: 0x00151248
	private void OnClickJumpButton()
	{
		Furniture? furnitureConfig = FurnitureConfig.Instance.GetFurnitureConfig(this.FurnitureId);
		if (furnitureConfig == null)
		{
			return;
		}
		EFurnitureSourceType sourceType = (EFurnitureSourceType)furnitureConfig.Value.SourceType;
		if (sourceType == EFurnitureSourceType.Shop)
		{
			FurnitureController.Instance.OpenFurnitureShopViewAsync(furnitureConfig.Value.GetWayId);
			return;
		}
		if (sourceType == EFurnitureSourceType.Gift)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.SpringManorQuestView))
			{
				Action tipViewCloseDelegate = this.TipViewCloseDelegate;
				if (tipViewCloseDelegate == null)
				{
					return;
				}
				tipViewCloseDelegate();
				return;
			}
			else
			{
				FurnitureController.Instance.TryJumpToFurnitureGift(furnitureConfig.Value);
			}
		}
	}

	// Token: 0x04002FF6 RID: 12278
	protected int FurnitureId;

	// Token: 0x04002FF7 RID: 12279
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04002FF8 RID: 12280
	[Nullable(2)]
	public Action TipViewCloseDelegate;
}
