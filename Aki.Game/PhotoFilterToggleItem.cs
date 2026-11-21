using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AB1 RID: 6833
[NullableContext(2)]
[Nullable(0)]
public class PhotoFilterToggleItem : UiPanelBase
{
	// Token: 0x06010EB5 RID: 69301 RVA: 0x004F6DF0 File Offset: 0x004F4FF0
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

	// Token: 0x06010EB6 RID: 69302 RVA: 0x004F6E57 File Offset: 0x004F5057
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetButton(1).RootUIComp);
	}

	// Token: 0x06010EB7 RID: 69303 RVA: 0x004F6E75 File Offset: 0x004F5075
	protected override void OnBeforeShow()
	{
		this.CurrentOptionState = PhotographModel.Instance.GetFilterToggleState();
		this.ExecuteOption(false);
	}

	// Token: 0x06010EB8 RID: 69304 RVA: 0x004F6E8E File Offset: 0x004F508E
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06010EB9 RID: 69305 RVA: 0x004F6EA4 File Offset: 0x004F50A4
	public void Initialize()
	{
		string textStringId = "CameraFlitercontroller";
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x06010EBA RID: 69306 RVA: 0x004F6ED0 File Offset: 0x004F50D0
	[NullableContext(1)]
	public void BindSetSubOptionVisible(Action<bool, bool> setSubOptionVisible)
	{
		this.SetSubOptionVisible = setSubOptionVisible;
	}

	// Token: 0x06010EBB RID: 69307 RVA: 0x004F6ED9 File Offset: 0x004F50D9
	[NullableContext(1)]
	public void BindDeselectOnFilterItem(Action deselectOnFilterItem)
	{
		this.DeselectOnFilterItem = deselectOnFilterItem;
	}

	// Token: 0x06010EBC RID: 69308 RVA: 0x004F6EE2 File Offset: 0x004F50E2
	private void OnClickedButton()
	{
		this.CurrentOptionState = !this.CurrentOptionState;
		PhotographModel.Instance.SetFilterToggleState(this.CurrentOptionState);
		this.ExecuteOption(true);
	}

	// Token: 0x06010EBD RID: 69309 RVA: 0x004F6F0C File Offset: 0x004F510C
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

	// Token: 0x06010EBE RID: 69310 RVA: 0x004F6F5C File Offset: 0x004F515C
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

	// Token: 0x04009546 RID: 38214
	private bool CurrentOptionState = true;

	// Token: 0x04009547 RID: 38215
	private Action<bool, bool> SetSubOptionVisible;

	// Token: 0x04009548 RID: 38216
	private Action DeselectOnFilterItem;

	// Token: 0x04009549 RID: 38217
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007D61 RID: 32097
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028978 RID: 166264
		OptionNameText,
		// Token: 0x04028979 RID: 166265
		OptionButton
	}
}
