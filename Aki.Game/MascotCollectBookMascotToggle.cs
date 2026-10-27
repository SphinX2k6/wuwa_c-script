using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F0F RID: 7951
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MascotCollectBookMascotToggle : GridProxyAbstract<HonamiStoryMascotData>
{
	// Token: 0x0600F4F1 RID: 62705 RVA: 0x003B1C58 File Offset: 0x003AFE58
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle))
		};
	}

	// Token: 0x0600F4F2 RID: 62706 RVA: 0x003B1CD5 File Offset: 0x003AFED5
	protected override void OnStart()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F4F3 RID: 62707 RVA: 0x003B1CF3 File Offset: 0x003AFEF3
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F4F4 RID: 62708 RVA: 0x003B1D11 File Offset: 0x003AFF11
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Bozai_Unlock")
		{
			this.RefreshItem();
		}
	}

	// Token: 0x0600F4F5 RID: 62709 RVA: 0x003B1D26 File Offset: 0x003AFF26
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x17001323 RID: 4899
	// (get) Token: 0x0600F4F6 RID: 62710 RVA: 0x003B1D40 File Offset: 0x003AFF40
	public HonamiStoryMascotData Data
	{
		get
		{
			return this.MascotData;
		}
	}

	// Token: 0x0600F4F7 RID: 62711 RVA: 0x003B1D48 File Offset: 0x003AFF48
	public override void Refresh(HonamiStoryMascotData mascotData, bool isSelected, int gridIndex)
	{
		this.MascotData = mascotData;
		bool flag = (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMascotUnlockSet, new HashSet<int>()) ?? new HashSet<int>()).Contains(mascotData.Id);
		if (mascotData.State != EHonamiStoryCollectState.Finished || !flag)
		{
			this.RefreshItem();
			return;
		}
		UiBehaviorLevelSequence levelPlaySequence = this.LevelPlaySequence;
		if (levelPlaySequence == null)
		{
			return;
		}
		levelPlaySequence.PlaySequence("PnlHead_Unlock", false, null);
	}

	// Token: 0x0600F4F8 RID: 62712 RVA: 0x003B1DB4 File Offset: 0x003AFFB4
	private void RefreshItem()
	{
		base.GetTexture(2).SetUIActive(this.MascotData.State == EHonamiStoryCollectState.Finished);
		string path = this.MascotData.Config.Value.TogglePicture;
		if (this.MascotData.State == EHonamiStoryCollectState.Unfinished)
		{
			path = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity28/HonamiStory/HonamiStoryHead/T_HonamiStoryHeadBEmpty.T_HonamiStoryHeadBEmpty";
		}
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x0600F4F9 RID: 62713 RVA: 0x003B1E22 File Offset: 0x003B0022
	public void BindMascotToggleClick(Action<MascotCollectBookMascotToggle> callback)
	{
		this.OnMascotToggleClick = callback;
	}

	// Token: 0x0600F4FA RID: 62714 RVA: 0x003B1E2B File Offset: 0x003B002B
	private void OnToggle(EToggleState toggleState)
	{
		Action<MascotCollectBookMascotToggle> onMascotToggleClick = this.OnMascotToggleClick;
		if (onMascotToggleClick == null)
		{
			return;
		}
		onMascotToggleClick(this);
	}

	// Token: 0x0600F4FB RID: 62715 RVA: 0x003B1E3E File Offset: 0x003B003E
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600F4FC RID: 62716 RVA: 0x003B1E50 File Offset: 0x003B0050
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04007150 RID: 29008
	private HonamiStoryMascotData MascotData;

	// Token: 0x04007151 RID: 29009
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MascotCollectBookMascotToggle> OnMascotToggleClick;

	// Token: 0x04007152 RID: 29010
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x0200851E RID: 34078
	[NullableContext(0)]
	private enum EMascotCollectBookMascotToggleComponent
	{
		// Token: 0x0402B52E RID: 177454
		Toggle,
		// Token: 0x0402B52F RID: 177455
		PictureTexture,
		// Token: 0x0402B530 RID: 177456
		RewardTexture
	}
}
