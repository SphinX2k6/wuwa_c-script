using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021B9 RID: 8633
public class LordGymUnLockItem : UiPanelBase
{
	// Token: 0x06010CD2 RID: 68818 RVA: 0x00414BD1 File Offset: 0x00412DD1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06010CD3 RID: 68819 RVA: 0x00414BF4 File Offset: 0x00412DF4
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(this.RootItem);
		this.LevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
	}

	// Token: 0x06010CD4 RID: 68820 RVA: 0x00414C20 File Offset: 0x00412E20
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

	// Token: 0x06010CD5 RID: 68821 RVA: 0x00414C88 File Offset: 0x00412E88
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

	// Token: 0x04007FAD RID: 32685
	[Nullable(2)]
	private LevelSequencePlayer LevelSequence;

	// Token: 0x02008703 RID: 34563
	private class EChildType
	{
		// Token: 0x0402BEA2 RID: 179874
		public const int UnLockText = 0;
	}
}
