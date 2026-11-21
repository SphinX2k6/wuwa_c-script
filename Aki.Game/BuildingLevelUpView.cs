using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007A7 RID: 1959
[NullableContext(1)]
[Nullable(0)]
public class BuildingLevelUpView : UiTickViewBase
{
	// Token: 0x060059C6 RID: 22982 RVA: 0x001D274B File Offset: 0x001D094B
	public BuildingLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060059C7 RID: 22983 RVA: 0x001D2760 File Offset: 0x001D0960
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

	// Token: 0x060059C8 RID: 22984 RVA: 0x001D28DC File Offset: 0x001D0ADC
	protected override void OnStart()
	{
		this.Vc.RegisterView(this);
		this.Vc.Start();
		this.Slider = base.GetSlider(0);
		this.BuildingSequencePlayer = new UiSequencePlayer(base.GetItem(13));
		this.SetFillAmount(0f);
	}

	// Token: 0x060059C9 RID: 22985 RVA: 0x001D292B File Offset: 0x001D0B2B
	protected override void OnTick(float delta)
	{
		this.Vc.Tick(delta);
	}

	// Token: 0x060059CA RID: 22986 RVA: 0x001D293C File Offset: 0x001D0B3C
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

	// Token: 0x060059CB RID: 22987 RVA: 0x001D2A92 File Offset: 0x001D0C92
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

	// Token: 0x060059CC RID: 22988 RVA: 0x001D2AC4 File Offset: 0x001D0CC4
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

	// Token: 0x060059CD RID: 22989 RVA: 0x001D2BF4 File Offset: 0x001D0DF4
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

	// Token: 0x060059CE RID: 22990 RVA: 0x001D2CD3 File Offset: 0x001D0ED3
	public void ShowLevelUp()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060059CF RID: 22991 RVA: 0x001D2CE8 File Offset: 0x001D0EE8
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

	// Token: 0x060059D0 RID: 22992 RVA: 0x001D2D94 File Offset: 0x001D0F94
	public void SetFillAmount(float fillAmount)
	{
		this.Slider.SetValue(fillAmount, true);
	}

	// Token: 0x060059D1 RID: 22993 RVA: 0x001D2DA4 File Offset: 0x001D0FA4
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

	// Token: 0x04003CB0 RID: 15536
	private UUISliderComponent Slider;

	// Token: 0x04003CB1 RID: 15537
	[Nullable(2)]
	private UiSequencePlayer BuildingSequencePlayer;

	// Token: 0x04003CB2 RID: 15538
	private bool IsPlayingBuildingSequence;

	// Token: 0x04003CB3 RID: 15539
	private readonly BuildingLevelUpViewController Vc = new BuildingLevelUpViewController();

	// Token: 0x02006AAC RID: 27308
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040231AA RID: 143786
		public const int Slider = 0;

		// Token: 0x040231AB RID: 143787
		public const int ProgressText = 1;

		// Token: 0x040231AC RID: 143788
		public const int FinishItem = 2;

		// Token: 0x040231AD RID: 143789
		public const int FinishText = 3;

		// Token: 0x040231AE RID: 143790
		public const int RewardTips = 4;

		// Token: 0x040231AF RID: 143791
		public const int UnlockBtn = 5;

		// Token: 0x040231B0 RID: 143792
		public const int CloseBtn = 6;

		// Token: 0x040231B1 RID: 143793
		public const int Texture = 7;

		// Token: 0x040231B2 RID: 143794
		public const int BuildSuccessTexture = 8;

		// Token: 0x040231B3 RID: 143795
		public const int BuildSuccessDialog = 9;

		// Token: 0x040231B4 RID: 143796
		public const int BuildFrameTexture = 10;

		// Token: 0x040231B5 RID: 143797
		public const int LevelUpFrameBgTexture = 11;

		// Token: 0x040231B6 RID: 143798
		public const int LevelUpFrameTexture = 12;

		// Token: 0x040231B7 RID: 143799
		public const int BuildingItem = 13;
	}
}
