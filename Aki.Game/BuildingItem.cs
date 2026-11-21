using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020007A1 RID: 1953
[NullableContext(1)]
[Nullable(0)]
public class BuildingItem : UiPanelBase
{
	// Token: 0x06005979 RID: 22905 RVA: 0x001D1335 File Offset: 0x001CF535
	public BuildingItem(int buildingId)
	{
		this.BuildingId = buildingId;
	}

	// Token: 0x17000B9B RID: 2971
	// (get) Token: 0x0600597A RID: 22906 RVA: 0x001D1344 File Offset: 0x001CF544
	public int BuildingId { get; }

	// Token: 0x0600597B RID: 22907 RVA: 0x001D134C File Offset: 0x001CF54C
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

	// Token: 0x0600597C RID: 22908 RVA: 0x001D1464 File Offset: 0x001CF664
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.HideBuildingTips), false);
	}

	// Token: 0x0600597D RID: 22909 RVA: 0x001D148F File Offset: 0x001CF68F
	protected override void OnBeforeShow()
	{
		this.AddEventListener();
		this.Refresh();
	}

	// Token: 0x0600597E RID: 22910 RVA: 0x001D149D File Offset: 0x001CF69D
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600597F RID: 22911 RVA: 0x001D14A5 File Offset: 0x001CF6A5
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshBuildingRedDot, new Action(this.RefreshRedDot));
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x001D14C3 File Offset: 0x001CF6C3
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshBuildingRedDot, new Action(this.RefreshRedDot));
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x001D14E1 File Offset: 0x001CF6E1
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x001D14F0 File Offset: 0x001CF6F0
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

	// Token: 0x06005983 RID: 22915 RVA: 0x001D151D File Offset: 0x001CF71D
	private void OpenBuildingTips()
	{
		MoonChasingController.Instance.OpenBuildingTipsInfoView(this.BuildingId);
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x001D1530 File Offset: 0x001CF730
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

	// Token: 0x06005985 RID: 22917 RVA: 0x001D1582 File Offset: 0x001CF782
	public void SetTipsActive(bool value)
	{
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x06005986 RID: 22918 RVA: 0x001D1598 File Offset: 0x001CF798
	public void SetExhibitionMode(bool bHide)
	{
		bool isBuild = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId).IsBuild;
		this.SetTipsActive(!bHide);
		base.GetTexture(0).SetUIActive(!bHide || isBuild);
		base.GetItem(9).SetUIActive(!bHide);
	}

	// Token: 0x06005987 RID: 22919 RVA: 0x001D15EC File Offset: 0x001CF7EC
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

	// Token: 0x06005988 RID: 22920 RVA: 0x001D16B1 File Offset: 0x001CF8B1
	public void SetInteractive(bool value)
	{
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(value);
	}

	// Token: 0x06005989 RID: 22921 RVA: 0x001D16C8 File Offset: 0x001CF8C8
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

	// Token: 0x0600598A RID: 22922 RVA: 0x001D1750 File Offset: 0x001CF950
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

	// Token: 0x0600598B RID: 22923 RVA: 0x001D17E4 File Offset: 0x001CF9E4
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

	// Token: 0x0600598C RID: 22924 RVA: 0x001D18CC File Offset: 0x001CFACC
	private void SetLockTipsSprite()
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(this.BuildingId);
		base.GetUiSpriteTransition(2).RootUIComp.Get().SetUIActive(!buildingDataById.IsUnlock);
	}

	// Token: 0x0600598D RID: 22925 RVA: 0x001D190C File Offset: 0x001CFB0C
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

	// Token: 0x0600598E RID: 22926 RVA: 0x001D1944 File Offset: 0x001CFB44
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

	// Token: 0x0600598F RID: 22927 RVA: 0x001D1980 File Offset: 0x001CFB80
	private void RefreshRedDot()
	{
		this.SetRedDot();
	}

	// Token: 0x06005990 RID: 22928 RVA: 0x001D1988 File Offset: 0x001CFB88
	private void SetName()
	{
		Building buildingById = BuildingConfig.Instance.GetBuildingById(this.BuildingId);
		UUIText text = base.GetText(8);
		LguiUtil.Instance.SetLocalTextNew(text, buildingById.Name, Array.Empty<object>());
	}

	// Token: 0x06005991 RID: 22929 RVA: 0x001D19C5 File Offset: 0x001CFBC5
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

	// Token: 0x04003C9E RID: 15518
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02006A97 RID: 27287
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402313D RID: 143677
		public const int Texture = 0;

		// Token: 0x0402313E RID: 143678
		public const int TipsSprite = 1;

		// Token: 0x0402313F RID: 143679
		public const int LockTipsSprite = 2;

		// Token: 0x04023140 RID: 143680
		public const int StateSprite = 3;

		// Token: 0x04023141 RID: 143681
		public const int CanLevelUpItem = 4;

		// Token: 0x04023142 RID: 143682
		public const int RedDotItem = 5;

		// Token: 0x04023143 RID: 143683
		public const int InteractiveBtn = 6;

		// Token: 0x04023144 RID: 143684
		public const int TipsItem = 7;

		// Token: 0x04023145 RID: 143685
		public const int Name = 8;

		// Token: 0x04023146 RID: 143686
		public const int NameItem = 9;
	}
}
