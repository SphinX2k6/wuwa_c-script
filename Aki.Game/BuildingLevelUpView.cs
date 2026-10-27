using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012F3 RID: 4851
[NullableContext(1)]
[Nullable(0)]
public class BuildingLevelUpView : UiTickViewBase
{
	// Token: 0x0600862B RID: 34347 RVA: 0x001C98DF File Offset: 0x001C7ADF
	public BuildingLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600862C RID: 34348 RVA: 0x001C98F4 File Offset: 0x001C7AF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.Vc.CloseSelf))
		};
	}

	// Token: 0x0600862D RID: 34349 RVA: 0x001C9A70 File Offset: 0x001C7C70
	protected override void OnStart()
	{
		this.Vc.RegisterView(this);
		this.Vc.Start();
		this.Slider = base.GetSlider(0);
		this.BuildingSequencePlayer = new UiSequencePlayer(base.GetItem(13));
		this.SetFillAmount(0f);
	}

	// Token: 0x0600862E RID: 34350 RVA: 0x001C9ABF File Offset: 0x001C7CBF
	protected override void OnTick(float delta)
	{
		this.Vc.Tick(delta);
	}

	// Token: 0x0600862F RID: 34351 RVA: 0x001C9AD0 File Offset: 0x001C7CD0
	public void InitUnlock(int buildingId)
	{
		Building buildingById = BuildingConfig.Instance.GetBuildingById(buildingId);
		EntrustRole entrustRoleById = BusinessConfig.Instance.GetEntrustRoleById(buildingById.AssociateRole);
		UUISliderComponent slider = base.GetSlider(0);
		if (slider != null)
		{
			UUIItem rootComponent = slider.GetRootComponent();
			if (rootComponent != null)
			{
				rootComponent.SetUIActive(true);
			}
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			UUIItem rootComponent2 = button.GetRootComponent();
			if (rootComponent2 != null)
			{
				rootComponent2.SetUIActive(false);
			}
		}
		UUIButtonComponent button2 = base.GetButton(5);
		if (button2 != null)
		{
			button2.OnPointDownCallBack.Bind(new Action(this.Vc.UnlockPress));
		}
		if (button2 != null)
		{
			button2.OnPointUpCallBack.Bind(new Action(this.Vc.UnlockRelease));
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Moonfiesta_StartBuild", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), entrustRoleById.BuildSuccessDialog, Array.Empty<object>());
		base.SetTextureByPath(entrustRoleById.SmallHeadIcon, base.GetTexture(8), null, null);
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(12);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(false);
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x001C9C26 File Offset: 0x001C7E26
	public void ShowUnlock()
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(5);
		if (button == null)
		{
			return;
		}
		UUIItem rootComponent = button.GetRootComponent();
		if (rootComponent == null)
		{
			return;
		}
		rootComponent.SetUIActive(false);
	}

	// Token: 0x06008631 RID: 34353 RVA: 0x001C9C58 File Offset: 0x001C7E58
	public void FinishUnlock(int buildingId)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(buildingId);
		UUISliderComponent slider = base.GetSlider(0);
		if (slider != null)
		{
			UUIItem rootComponent = slider.GetRootComponent();
			if (rootComponent != null)
			{
				rootComponent.SetUIActive(false);
			}
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			UUIItem rootComponent2 = button.GetRootComponent();
			if (rootComponent2 != null)
			{
				rootComponent2.SetUIActive(true);
			}
		}
		base.SetTextureByPath(BuildingConfig.Instance.GetBuildingById(buildingId).BuildingTexture, base.GetTexture(7), null, null);
		string levelUpIncreaseDesc = buildingDataById.GetLevelUpIncreaseDesc();
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(levelUpIncreaseDesc, true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Moonfiesta_BuildingTips_Built", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Moonfiesta_ClickContinue", Array.Empty<object>());
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(12);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(true);
	}

	// Token: 0x06008632 RID: 34354 RVA: 0x001C9D88 File Offset: 0x001C7F88
	public void InitLevelUp(int buildingId)
	{
		UUISliderComponent slider = base.GetSlider(0);
		if (slider != null)
		{
			UUIItem rootComponent = slider.GetRootComponent();
			if (rootComponent != null)
			{
				rootComponent.SetUIActive(false);
			}
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			UUIItem rootComponent2 = button.GetRootComponent();
			if (rootComponent2 != null)
			{
				rootComponent2.SetUIActive(false);
			}
		}
		UUIButtonComponent button2 = base.GetButton(6);
		if (button2 != null)
		{
			UUIItem rootComponent3 = button2.GetRootComponent();
			if (rootComponent3 != null)
			{
				rootComponent3.SetUIActive(false);
			}
		}
		base.SetTextureByPath(BuildingConfig.Instance.GetBuildingById(buildingId).BuildingTexture, base.GetTexture(7), null, null);
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(12);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(true);
	}

	// Token: 0x06008633 RID: 34355 RVA: 0x001C9E67 File Offset: 0x001C8067
	public void ShowLevelUp()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x001C9E7C File Offset: 0x001C807C
	public void FinishLevelUp(int buildingId)
	{
		BuildingData buildingDataById = MoonChasingBuildingModel.Instance.GetBuildingDataById(buildingId);
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			UUIItem rootComponent = button.GetRootComponent();
			if (rootComponent != null)
			{
				rootComponent.SetUIActive(true);
			}
		}
		string levelUpIncreaseDesc = buildingDataById.GetLevelUpIncreaseDesc();
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(levelUpIncreaseDesc, true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Moonfiesta_BuildingTips_Built", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Moonfiesta_ClickContinue", Array.Empty<object>());
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x001C9F28 File Offset: 0x001C8128
	public void SetFillAmount(float fillAmount)
	{
		this.Slider.SetValue(fillAmount, true);
	}

	// Token: 0x06008636 RID: 34358 RVA: 0x001C9F38 File Offset: 0x001C8138
	public void PlayBuildingLoopSequence(bool isPlay)
	{
		if (this.IsPlayingBuildingSequence == isPlay)
		{
			return;
		}
		this.IsPlayingBuildingSequence = isPlay;
		if (isPlay)
		{
			this.BuildingSequencePlayer.PlaySequence("Loop", false, null);
			return;
		}
		this.BuildingSequencePlayer.StopPrevSequence(false, true);
	}

	// Token: 0x04003C18 RID: 15384
	private UUISliderComponent Slider;

	// Token: 0x04003C19 RID: 15385
	[Nullable(2)]
	private UiSequencePlayer BuildingSequencePlayer;

	// Token: 0x04003C1A RID: 15386
	private bool IsPlayingBuildingSequence;

	// Token: 0x04003C1B RID: 15387
	private readonly BuildingLevelUpViewController Vc = new BuildingLevelUpViewController();

	// Token: 0x02007922 RID: 31010
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027E7D RID: 163453
		public const int Slider = 0;

		// Token: 0x04027E7E RID: 163454
		public const int ProgressText = 1;

		// Token: 0x04027E7F RID: 163455
		public const int FinishItem = 2;

		// Token: 0x04027E80 RID: 163456
		public const int FinishText = 3;

		// Token: 0x04027E81 RID: 163457
		public const int RewardTips = 4;

		// Token: 0x04027E82 RID: 163458
		public const int UnlockBtn = 5;

		// Token: 0x04027E83 RID: 163459
		public const int CloseBtn = 6;

		// Token: 0x04027E84 RID: 163460
		public const int Texture = 7;

		// Token: 0x04027E85 RID: 163461
		public const int BuildSuccessTexture = 8;

		// Token: 0x04027E86 RID: 163462
		public const int BuildSuccessDialog = 9;

		// Token: 0x04027E87 RID: 163463
		public const int BuildFrameTexture = 10;

		// Token: 0x04027E88 RID: 163464
		public const int LevelUpFrameBgTexture = 11;

		// Token: 0x04027E89 RID: 163465
		public const int LevelUpFrameTexture = 12;

		// Token: 0x04027E8A RID: 163466
		public const int BuildingItem = 13;
	}
}
