using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020012ED RID: 4845
[NullableContext(1)]
[Nullable(0)]
public class BuildingItem : UiPanelBase
{
	// Token: 0x060085DE RID: 34270 RVA: 0x001C84C9 File Offset: 0x001C66C9
	public BuildingItem(int buildingId)
	{
		this.BuildingId = buildingId;
	}

	// Token: 0x17000B7B RID: 2939
	// (get) Token: 0x060085DF RID: 34271 RVA: 0x001C84D8 File Offset: 0x001C66D8
	public int BuildingId { get; }

	// Token: 0x060085E0 RID: 34272 RVA: 0x001C84E0 File Offset: 0x001C66E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISpriteTransition)),
			new ValueTuple<int, Type>(2, typeof(UUISpriteTransition)),
			new ValueTuple<int, Type>(3, typeof(UUISpriteTransition)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OpenBuildingTips))
		};
	}

	// Token: 0x060085E1 RID: 34273 RVA: 0x001C85F8 File Offset: 0x001C67F8
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.HideBuildingTips), false);
	}

	// Token: 0x060085E2 RID: 34274 RVA: 0x001C8623 File Offset: 0x001C6823
	protected override void OnBeforeShow()
	{
		this.AddEventListener();
		this.Refresh();
	}

	// Token: 0x060085E3 RID: 34275 RVA: 0x001C8631 File Offset: 0x001C6831
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x060085E4 RID: 34276 RVA: 0x001C8639 File Offset: 0x001C6839
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshBuildingRedDot, new Action(this.RefreshRedDot));
	}

	// Token: 0x060085E5 RID: 34277 RVA: 0x001C8657 File Offset: 0x001C6857
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshBuildingRedDot, new Action(this.RefreshRedDot));
	}

	// Token: 0x060085E6 RID: 34278 RVA: 0x001C8675 File Offset: 0x001C6875
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
	}

	// Token: 0x060085E7 RID: 34279 RVA: 0x001C8684 File Offset: 0x001C6884
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIItem rootComponent = base.GetButton(6).GetRootComponent();
		if (rootComponent == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			rootComponent,
			rootComponent
		};
	}

	// Token: 0x060085E8 RID: 34280 RVA: 0x001C86B1 File Offset: 0x001C68B1
	private void OpenBuildingTips()
	{
		MoonChasingController.Instance.OpenBuildingTipsInfoView(this.BuildingId);
	}

	// Token: 0x060085E9 RID: 34281 RVA: 0x001C86C4 File Offset: 0x001C68C4
	private void HideBuildingTips(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			bool isBuild = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId).IsBuild;
			this.SetTipsActive(false);
			base.GetItem(9).SetUIActive(isBuild);
			base.GetTexture(0).SetUIActive(isBuild);
		}
	}

	// Token: 0x060085EA RID: 34282 RVA: 0x001C8716 File Offset: 0x001C6916
	public void SetTipsActive(bool value)
	{
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x060085EB RID: 34283 RVA: 0x001C872C File Offset: 0x001C692C
	public void SetExhibitionMode(bool bHide)
	{
		bool isBuild = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId).IsBuild;
		this.SetTipsActive(!bHide);
		base.GetTexture(0).SetUIActive(!bHide || isBuild);
		base.GetItem(9).SetUIActive(!bHide);
	}

	// Token: 0x060085EC RID: 34284 RVA: 0x001C8780 File Offset: 0x001C6980
	public void SetBuildingItemActive(bool value)
	{
		bool isBuild = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId).IsBuild;
		this.RefreshRedDot();
		if (value)
		{
			string sequenceName = isBuild ? "Close" : "Close01";
			this.SequencePlayer.StopSequenceByKey(sequenceName, false, false);
			this.SetTipsActive(true);
			base.GetTexture(0).SetUIActive(true);
			base.GetItem(9).SetUIActive(true);
			string sequenceName2 = isBuild ? "Start" : "Start01";
			this.SequencePlayer.PlayLevelSequenceByName(sequenceName2, false, null, false);
		}
		else
		{
			string sequenceName3 = isBuild ? "Close" : "Close01";
			this.SequencePlayer.PlayLevelSequenceByName(sequenceName3, false, null, false);
		}
		this.SetInteractive(value);
	}

	// Token: 0x060085ED RID: 34285 RVA: 0x001C8845 File Offset: 0x001C6A45
	public void SetInteractive(bool value)
	{
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(value);
	}

	// Token: 0x060085EE RID: 34286 RVA: 0x001C885C File Offset: 0x001C6A5C
	private void SetBuildingTexture()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.BuildingId);
		if (buildingDataById.IsUnlock)
		{
			if (!buildingDataById.IsBuild)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_BuildItemBUnlock");
				base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
				return;
			}
			base.SetTextureByPath(buildingById.BuildingTexture, base.GetTexture(0), null, null);
		}
	}

	// Token: 0x060085EF RID: 34287 RVA: 0x001C88E4 File Offset: 0x001C6AE4
	private void SetStateSprite()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		string resourcePath;
		if (buildingDataById.IsMax)
		{
			resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_TogPointMaxNor");
		}
		else if (buildingDataById.IsUnlock)
		{
			if (buildingDataById.Level == 0)
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_TogPointUnLock");
			}
			else
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_TogPointNor");
			}
		}
		else
		{
			resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_TogPointNorLock");
		}
		UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(3);
		base.SetSpriteTransitionByPath(resourcePath, uiSpriteTransition, EUISelectableSelectionState.Normal).Forget();
	}

	// Token: 0x060085F0 RID: 34288 RVA: 0x001C8978 File Offset: 0x001C6B78
	private void SetTipsSprite()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.BuildingId);
		UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(1);
		uiSpriteTransition.RootUIComp.Get().SetUIActive(buildingDataById.IsUnlock);
		FColor? fcolor = null;
		if (buildingDataById.IsMax)
		{
			fcolor = new FColor?(FColor.FromHex("#ecb138"));
		}
		else if (buildingDataById.IsUnlock)
		{
			if (buildingDataById.Level == 0)
			{
				fcolor = new FColor?(FColor.FromHex("#595854"));
			}
			else
			{
				fcolor = new FColor?(FColor.FromHex("#b49570"));
			}
		}
		else
		{
			fcolor = new FColor?(FColor.FromHex("#ffffff"));
		}
		base.SetSpriteTransitionByPath(buildingById.TipsSprite, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX).Forget();
		uiSpriteTransition.TransitionInfo.NormalTransition.Color = fcolor.Value;
	}

	// Token: 0x060085F1 RID: 34289 RVA: 0x001C8A60 File Offset: 0x001C6C60
	private void SetLockTipsSprite()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		base.GetUiSpriteTransition(2).RootUIComp.Get().SetUIActive(!buildingDataById.IsUnlock);
	}

	// Token: 0x060085F2 RID: 34290 RVA: 0x001C8AA0 File Offset: 0x001C6CA0
	private void SetLevelUpItem()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(buildingDataById.IsAvailableLevelUp);
	}

	// Token: 0x060085F3 RID: 34291 RVA: 0x001C8AD8 File Offset: 0x001C6CD8
	private void SetRedDot()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		bool uiactive = MoonChasingBuildingModel.Instance.CheckBuildingRedDotState(buildingDataById);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x060085F4 RID: 34292 RVA: 0x001C8B14 File Offset: 0x001C6D14
	private void RefreshRedDot()
	{
		this.SetRedDot();
	}

	// Token: 0x060085F5 RID: 34293 RVA: 0x001C8B1C File Offset: 0x001C6D1C
	private void SetName()
	{
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.BuildingId);
		UUIText text = base.GetText(8);
		LguiUtil.Instance.SetLocalTextNew(text, buildingById.Name, Array.Empty<object>());
	}

	// Token: 0x060085F6 RID: 34294 RVA: 0x001C8B59 File Offset: 0x001C6D59
	public void Refresh()
	{
		this.SetBuildingTexture();
		this.SetTipsSprite();
		this.SetLockTipsSprite();
		this.SetStateSprite();
		this.SetLevelUpItem();
		this.SetRedDot();
		this.SetName();
	}

	// Token: 0x04003C06 RID: 15366
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0200790D RID: 30989
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027E10 RID: 163344
		public const int Texture = 0;

		// Token: 0x04027E11 RID: 163345
		public const int TipsSprite = 1;

		// Token: 0x04027E12 RID: 163346
		public const int LockTipsSprite = 2;

		// Token: 0x04027E13 RID: 163347
		public const int StateSprite = 3;

		// Token: 0x04027E14 RID: 163348
		public const int CanLevelUpItem = 4;

		// Token: 0x04027E15 RID: 163349
		public const int RedDotItem = 5;

		// Token: 0x04027E16 RID: 163350
		public const int InteractiveBtn = 6;

		// Token: 0x04027E17 RID: 163351
		public const int TipsItem = 7;

		// Token: 0x04027E18 RID: 163352
		public const int Name = 8;

		// Token: 0x04027E19 RID: 163353
		public const int NameItem = 9;
	}
}
