using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001ABC RID: 6844
[NullableContext(2)]
[Nullable(0)]
public class PhotographOptionSetup : PhotographSetupBase
{
	// Token: 0x06010F15 RID: 69397 RVA: 0x004F80DC File Offset: 0x004F62DC
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

	// Token: 0x06010F16 RID: 69398 RVA: 0x004F8159 File Offset: 0x004F6359
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetButton(1).RootUIComp);
		this.ToggleLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010F17 RID: 69399 RVA: 0x004F8188 File Offset: 0x004F6388
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
		this.ToggleLevelSequencePlayer = null;
	}

	// Token: 0x06010F18 RID: 69400 RVA: 0x004F81A4 File Offset: 0x004F63A4
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer toggleLevelSequencePlayer = this.ToggleLevelSequencePlayer;
		if (toggleLevelSequencePlayer == null)
		{
			return;
		}
		toggleLevelSequencePlayer.PlayLevelSequenceByName("Start02", false, null, false);
	}

	// Token: 0x06010F19 RID: 69401 RVA: 0x004F81D1 File Offset: 0x004F63D1
	public override void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.Refresh();
		this.SetEnable(true);
		this.RefreshRedDot();
	}

	// Token: 0x06010F1A RID: 69402 RVA: 0x004F81ED File Offset: 0x004F63ED
	public override void InitializeById(int setupId)
	{
		base.InitializeById(setupId);
		this.SetEnable(true);
		this.RefreshRedDot();
	}

	// Token: 0x06010F1B RID: 69403 RVA: 0x004F8204 File Offset: 0x004F6404
	private void RefreshRedDot()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(base.IsPhotoSetupRedDotVisible());
	}

	// Token: 0x06010F1C RID: 69404 RVA: 0x004F8229 File Offset: 0x004F6429
	private void InitToggle(int optionIndex)
	{
		this.CurrentOptionIndex = optionIndex;
		this.SetOptionStateByIndex(this.CurrentOptionIndex);
		this.ExecuteOption();
	}

	// Token: 0x06010F1D RID: 69405 RVA: 0x004F8244 File Offset: 0x004F6444
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

	// Token: 0x06010F1E RID: 69406 RVA: 0x004F82C0 File Offset: 0x004F64C0
	public override void SetEnable(bool bEnable)
	{
		float alpha = bEnable ? 1f : 0.5f;
		this.RootItem.SetAlpha(alpha);
		base.GetButton(1).SetEnable(bEnable);
	}

	// Token: 0x06010F1F RID: 69407 RVA: 0x004F82F6 File Offset: 0x004F64F6
	[NullableContext(1)]
	public void BindOnIndexChanged(Action<int> onIndexChanged)
	{
		this.OnIndexChanged = onIndexChanged;
	}

	// Token: 0x06010F20 RID: 69408 RVA: 0x004F8300 File Offset: 0x004F6500
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

	// Token: 0x06010F21 RID: 69409 RVA: 0x004F835C File Offset: 0x004F655C
	private void SetOptionStateByIndex(int index)
	{
		int num = this.SetupConfig.Value.Options().Length - 1;
		this.SetToggleState(index == num, false);
	}

	// Token: 0x06010F22 RID: 69410 RVA: 0x004F838C File Offset: 0x004F658C
	private void SetOptionIndexByState(bool state)
	{
		int num = this.SetupConfig.Value.Options().Length - 1;
		this.CurrentOptionIndex = (state ? num : 0);
	}

	// Token: 0x06010F23 RID: 69411 RVA: 0x004F83C0 File Offset: 0x004F65C0
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

	// Token: 0x06010F24 RID: 69412 RVA: 0x004F8418 File Offset: 0x004F6618
	private void ExecuteOption()
	{
		PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, (float)this.CurrentOptionIndex, false, true);
	}

	// Token: 0x04009568 RID: 38248
	private int CurrentOptionIndex;

	// Token: 0x04009569 RID: 38249
	private bool CurrentOptionState;

	// Token: 0x0400956A RID: 38250
	private LevelSequencePlayer ToggleLevelSequencePlayer;

	// Token: 0x0400956B RID: 38251
	private Action<int> OnIndexChanged;

	// Token: 0x0400956C RID: 38252
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007D68 RID: 32104
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028996 RID: 166294
		OptionNameText,
		// Token: 0x04028997 RID: 166295
		OptionButton,
		// Token: 0x04028998 RID: 166296
		RedDot
	}
}
