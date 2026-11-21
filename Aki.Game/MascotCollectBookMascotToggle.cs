using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013D1 RID: 5073
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MascotCollectBookMascotToggle : GridProxyAbstract<HonamiStoryMascotData>
{
	// Token: 0x0600C910 RID: 51472 RVA: 0x003BD744 File Offset: 0x003BB944
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

	// Token: 0x0600C911 RID: 51473 RVA: 0x003BD7C1 File Offset: 0x003BB9C1
	protected override void OnStart()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C912 RID: 51474 RVA: 0x003BD7DF File Offset: 0x003BB9DF
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C913 RID: 51475 RVA: 0x003BD7FD File Offset: 0x003BB9FD
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Bozai_Unlock")
		{
			this.RefreshItem();
		}
	}

	// Token: 0x0600C914 RID: 51476 RVA: 0x003BD812 File Offset: 0x003BBA12
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x1700134D RID: 4941
	// (get) Token: 0x0600C915 RID: 51477 RVA: 0x003BD82C File Offset: 0x003BBA2C
	public HonamiStoryMascotData Data
	{
		get
		{
			return this.MascotData;
		}
	}

	// Token: 0x0600C916 RID: 51478 RVA: 0x003BD834 File Offset: 0x003BBA34
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

	// Token: 0x0600C917 RID: 51479 RVA: 0x003BD8A0 File Offset: 0x003BBAA0
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

	// Token: 0x0600C918 RID: 51480 RVA: 0x003BD90E File Offset: 0x003BBB0E
	public void BindMascotToggleClick(Action<MascotCollectBookMascotToggle> callback)
	{
		this.OnMascotToggleClick = callback;
	}

	// Token: 0x0600C919 RID: 51481 RVA: 0x003BD917 File Offset: 0x003BBB17
	private void OnToggle(EToggleState toggleState)
	{
		Action<MascotCollectBookMascotToggle> onMascotToggleClick = this.OnMascotToggleClick;
		if (onMascotToggleClick == null)
		{
			return;
		}
		onMascotToggleClick(this);
	}

	// Token: 0x0600C91A RID: 51482 RVA: 0x003BD92A File Offset: 0x003BBB2A
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600C91B RID: 51483 RVA: 0x003BD93C File Offset: 0x003BBB3C
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04007231 RID: 29233
	private HonamiStoryMascotData MascotData;

	// Token: 0x04007232 RID: 29234
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MascotCollectBookMascotToggle> OnMascotToggleClick;

	// Token: 0x04007233 RID: 29235
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x020076A3 RID: 30371
	[NullableContext(0)]
	private enum EMascotCollectBookMascotToggleComponent
	{
		// Token: 0x04026852 RID: 157778
		Toggle,
		// Token: 0x04026853 RID: 157779
		PictureTexture,
		// Token: 0x04026854 RID: 157780
		RewardTexture
	}
}
