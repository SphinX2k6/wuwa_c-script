using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AB9 RID: 6841
public class EntityInfoItem : UiPanelBase
{
	// Token: 0x06010EFE RID: 69374 RVA: 0x004F798C File Offset: 0x004F5B8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06010EFF RID: 69375 RVA: 0x004F79E8 File Offset: 0x004F5BE8
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

	// Token: 0x06010F00 RID: 69376 RVA: 0x004F7A40 File Offset: 0x004F5C40
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

	// Token: 0x06010F01 RID: 69377 RVA: 0x004F7A98 File Offset: 0x004F5C98
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

	// Token: 0x06010F02 RID: 69378 RVA: 0x004F7B1C File Offset: 0x004F5D1C
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

	// Token: 0x0400955D RID: 38237
	[Nullable(2)]
	protected LevelSequencePlayer UiSequencePlayer;

	// Token: 0x0400955E RID: 38238
	private bool Finished;

	// Token: 0x02007D65 RID: 32101
	private enum EItemChildType
	{
		// Token: 0x04028989 RID: 166281
		TitleBg,
		// Token: 0x0402898A RID: 166282
		SpriteTick,
		// Token: 0x0402898B RID: 166283
		Text
	}
}
