using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025C6 RID: 9670
[NullableContext(2)]
[Nullable(0)]
public class PhotoFilterToggleItem : UiPanelBase
{
	// Token: 0x060139D5 RID: 80341 RVA: 0x004E81F0 File Offset: 0x004E63F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickedButton))
		};
	}

	// Token: 0x060139D6 RID: 80342 RVA: 0x004E8257 File Offset: 0x004E6457
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetButton(1).RootUIComp);
	}

	// Token: 0x060139D7 RID: 80343 RVA: 0x004E8275 File Offset: 0x004E6475
	protected override void OnBeforeShow()
	{
		this.CurrentOptionState = PhotographModel.Instance.GetFilterToggleState();
		this.ExecuteOption(false);
	}

	// Token: 0x060139D8 RID: 80344 RVA: 0x004E828E File Offset: 0x004E648E
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060139D9 RID: 80345 RVA: 0x004E82A4 File Offset: 0x004E64A4
	public void Initialize()
	{
		string textStringId = "CameraFlitercontroller";
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x060139DA RID: 80346 RVA: 0x004E82D0 File Offset: 0x004E64D0
	[NullableContext(1)]
	public void BindSetSubOptionVisible(Action<bool, bool> setSubOptionVisible)
	{
		this.SetSubOptionVisible = setSubOptionVisible;
	}

	// Token: 0x060139DB RID: 80347 RVA: 0x004E82D9 File Offset: 0x004E64D9
	[NullableContext(1)]
	public void BindDeselectOnFilterItem(Action deselectOnFilterItem)
	{
		this.DeselectOnFilterItem = deselectOnFilterItem;
	}

	// Token: 0x060139DC RID: 80348 RVA: 0x004E82E2 File Offset: 0x004E64E2
	private void OnClickedButton()
	{
		this.CurrentOptionState = !this.CurrentOptionState;
		PhotographModel.Instance.SetFilterToggleState(this.CurrentOptionState);
		this.ExecuteOption(true);
	}

	// Token: 0x060139DD RID: 80349 RVA: 0x004E830C File Offset: 0x004E650C
	private void SetToggleState(bool state, bool needAnim = true)
	{
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

	// Token: 0x060139DE RID: 80350 RVA: 0x004E835C File Offset: 0x004E655C
	private void ExecuteOption(bool isByClickToggle = true)
	{
		this.SetToggleState(this.CurrentOptionState, false);
		if (this.SetSubOptionVisible != null)
		{
			this.SetSubOptionVisible(this.CurrentOptionState, isByClickToggle);
		}
		if (!this.CurrentOptionState && this.DeselectOnFilterItem != null)
		{
			this.DeselectOnFilterItem();
		}
	}

	// Token: 0x040093F0 RID: 37872
	private bool CurrentOptionState = true;

	// Token: 0x040093F1 RID: 37873
	private Action<bool, bool> SetSubOptionVisible;

	// Token: 0x040093F2 RID: 37874
	private Action DeselectOnFilterItem;

	// Token: 0x040093F3 RID: 37875
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008BD9 RID: 35801
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D663 RID: 185955
		OptionNameText,
		// Token: 0x0402D664 RID: 185956
		OptionButton
	}
}
