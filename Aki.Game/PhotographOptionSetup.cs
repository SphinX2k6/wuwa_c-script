using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025D1 RID: 9681
[NullableContext(2)]
[Nullable(0)]
public class PhotographOptionSetup : PhotographSetupBase
{
	// Token: 0x06013A35 RID: 80437 RVA: 0x004E94DC File Offset: 0x004E76DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickedButton))
		};
	}

	// Token: 0x06013A36 RID: 80438 RVA: 0x004E9559 File Offset: 0x004E7759
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetButton(1).RootUIComp);
		this.ToggleLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013A37 RID: 80439 RVA: 0x004E9588 File Offset: 0x004E7788
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
		this.ToggleLevelSequencePlayer = null;
	}

	// Token: 0x06013A38 RID: 80440 RVA: 0x004E95A4 File Offset: 0x004E77A4
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer toggleLevelSequencePlayer = this.ToggleLevelSequencePlayer;
		if (toggleLevelSequencePlayer == null)
		{
			return;
		}
		toggleLevelSequencePlayer.PlayLevelSequenceByName("Start02", false, null, false);
	}

	// Token: 0x06013A39 RID: 80441 RVA: 0x004E95D1 File Offset: 0x004E77D1
	public override void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.Refresh();
		this.SetEnable(true);
		this.RefreshRedDot();
	}

	// Token: 0x06013A3A RID: 80442 RVA: 0x004E95ED File Offset: 0x004E77ED
	public override void InitializeById(int setupId)
	{
		base.InitializeById(setupId);
		this.SetEnable(true);
		this.RefreshRedDot();
	}

	// Token: 0x06013A3B RID: 80443 RVA: 0x004E9604 File Offset: 0x004E7804
	private void RefreshRedDot()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(base.IsPhotoSetupRedDotVisible());
	}

	// Token: 0x06013A3C RID: 80444 RVA: 0x004E9629 File Offset: 0x004E7829
	private void InitToggle(int optionIndex)
	{
		this.CurrentOptionIndex = optionIndex;
		this.SetOptionStateByIndex(this.CurrentOptionIndex);
		this.ExecuteOption();
	}

	// Token: 0x06013A3D RID: 80445 RVA: 0x004E9644 File Offset: 0x004E7844
	public override void Refresh()
	{
		if (this.SetupConfig == null || this.SetupConfig.Value.Type != 0)
		{
			return;
		}
		this.InitToggle((int)PhotographModel.Instance.GetPhotographOption(this.SetupValueType).GetValueOrDefault());
		string name = this.SetupConfig.Value.Name;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, name, Array.Empty<object>());
	}

	// Token: 0x06013A3E RID: 80446 RVA: 0x004E96C0 File Offset: 0x004E78C0
	public override void SetEnable(bool bEnable)
	{
		float alpha = bEnable ? 1f : 0.5f;
		this.RootItem.SetAlpha(alpha);
		base.GetButton(1).SetEnable(bEnable);
	}

	// Token: 0x06013A3F RID: 80447 RVA: 0x004E96F6 File Offset: 0x004E78F6
	[NullableContext(1)]
	public void BindOnIndexChanged(Action<int> onIndexChanged)
	{
		this.OnIndexChanged = onIndexChanged;
	}

	// Token: 0x06013A40 RID: 80448 RVA: 0x004E9700 File Offset: 0x004E7900
	private void OnClickedButton()
	{
		this.SetToggleState(!this.CurrentOptionState, true);
		this.SetOptionIndexByState(this.CurrentOptionState);
		this.ExecuteOption();
		if (this.OnIndexChanged != null)
		{
			this.OnIndexChanged(this.CurrentOptionIndex);
		}
		base.MarkPhotoSetupRedDotAsRead(delegate
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		});
	}

	// Token: 0x06013A41 RID: 80449 RVA: 0x004E975C File Offset: 0x004E795C
	private void SetOptionStateByIndex(int index)
	{
		int num = this.SetupConfig.Value.Options().Length - 1;
		this.SetToggleState(index == num, false);
	}

	// Token: 0x06013A42 RID: 80450 RVA: 0x004E978C File Offset: 0x004E798C
	private void SetOptionIndexByState(bool state)
	{
		int num = this.SetupConfig.Value.Options().Length - 1;
		this.CurrentOptionIndex = (state ? num : 0);
	}

	// Token: 0x06013A43 RID: 80451 RVA: 0x004E97C0 File Offset: 0x004E79C0
	private void SetToggleState(bool state, bool needAnim = true)
	{
		this.CurrentOptionState = state;
		string sequenceName = state ? "ClickL" : "ClickR";
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}
		if (!needAnim)
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.StopSequenceByKey(sequenceName, false, true);
		}
	}

	// Token: 0x06013A44 RID: 80452 RVA: 0x004E9818 File Offset: 0x004E7A18
	private void ExecuteOption()
	{
		PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, (float)this.CurrentOptionIndex, false, true);
	}

	// Token: 0x04009412 RID: 37906
	private int CurrentOptionIndex;

	// Token: 0x04009413 RID: 37907
	private bool CurrentOptionState;

	// Token: 0x04009414 RID: 37908
	private LevelSequencePlayer ToggleLevelSequencePlayer;

	// Token: 0x04009415 RID: 37909
	private Action<int> OnIndexChanged;

	// Token: 0x04009416 RID: 37910
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008BE0 RID: 35808
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D681 RID: 185985
		OptionNameText,
		// Token: 0x0402D682 RID: 185986
		OptionButton,
		// Token: 0x0402D683 RID: 185987
		RedDot
	}
}
