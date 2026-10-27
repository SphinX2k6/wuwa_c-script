using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025CE RID: 9678
public class EntityInfoItem : UiPanelBase
{
	// Token: 0x06013A1E RID: 80414 RVA: 0x004E8D8C File Offset: 0x004E6F8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013A1F RID: 80415 RVA: 0x004E8DE8 File Offset: 0x004E6FE8
	public void InitSpr()
	{
		if (this.UiSequencePlayer == null)
		{
			this.UiSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.UiSequencePlayer.StopCurrentSequence(false, true);
		this.UiSequencePlayer.PlayLevelSequenceByName("Fail", false, null, false);
		this.Finished = false;
	}

	// Token: 0x06013A20 RID: 80416 RVA: 0x004E8E40 File Offset: 0x004E7040
	[NullableContext(1)]
	public void Refresh(IInfoData info)
	{
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(info.Text);
		if (string.IsNullOrEmpty(configTextByKey))
		{
			this.RefreshFinishState(info.IsFinish);
			return;
		}
		if (info.IsOptionFinished)
		{
			this.SetTextLine(info.Text);
			return;
		}
		base.GetText(2).SetText(configTextByKey, true);
	}

	// Token: 0x06013A21 RID: 80417 RVA: 0x004E8E98 File Offset: 0x004E7098
	public void RefreshFinishState(bool bFinished)
	{
		if (bFinished && !this.Finished)
		{
			this.UiSequencePlayer.StopCurrentSequence(false, true);
			this.UiSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
			this.Finished = true;
			return;
		}
		if (!bFinished && this.Finished)
		{
			this.UiSequencePlayer.StopCurrentSequence(false, true);
			this.UiSequencePlayer.PlayLevelSequenceByName("Fail", false, null, false);
			this.Finished = false;
		}
	}

	// Token: 0x06013A22 RID: 80418 RVA: 0x004E8F1C File Offset: 0x004E711C
	[NullableContext(1)]
	public void SetTextLine(string description)
	{
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(description);
		if (!string.IsNullOrEmpty(configTextByKey))
		{
			base.GetText(2).SetText("<s>" + configTextByKey + "</s>", true);
			this.UiSequencePlayer.StopCurrentSequence(false, true);
			this.UiSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
			this.UiSequencePlayer.StopCurrentSequence(false, true);
			this.Finished = true;
		}
	}

	// Token: 0x04009407 RID: 37895
	[Nullable(2)]
	protected LevelSequencePlayer UiSequencePlayer;

	// Token: 0x04009408 RID: 37896
	private bool Finished;

	// Token: 0x02008BDD RID: 35805
	private enum EItemChildType
	{
		// Token: 0x0402D674 RID: 185972
		TitleBg,
		// Token: 0x0402D675 RID: 185973
		SpriteTick,
		// Token: 0x0402D676 RID: 185974
		Text
	}
}
