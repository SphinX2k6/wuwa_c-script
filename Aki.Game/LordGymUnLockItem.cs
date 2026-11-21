using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200169D RID: 5789
public class LordGymUnLockItem : UiPanelBase
{
	// Token: 0x0600E163 RID: 57699 RVA: 0x004214B1 File Offset: 0x0041F6B1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600E164 RID: 57700 RVA: 0x004214D4 File Offset: 0x0041F6D4
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(this.RootItem);
		this.LevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
	}

	// Token: 0x0600E165 RID: 57701 RVA: 0x00421500 File Offset: 0x0041F700
	public void RefreshLord(int lordId)
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "LordGymUnLock", new <>z__ReadOnlySingleElementList<object>(value.GymTitle));
		this.LevelSequence.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600E166 RID: 57702 RVA: 0x00421568 File Offset: 0x0041F768
	[NullableContext(1)]
	private void SequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			this.LevelSequence.PlayLevelSequenceByName("Close", false, null, false);
		}
		if (sequenceName == "Close")
		{
			this.SetActive(false);
		}
	}

	// Token: 0x040080F4 RID: 33012
	[Nullable(2)]
	private LevelSequencePlayer LevelSequence;

	// Token: 0x0200788E RID: 30862
	private class EChildType
	{
		// Token: 0x040271C3 RID: 160195
		public const int UnLockText = 0;
	}
}
