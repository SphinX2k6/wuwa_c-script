using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BF9 RID: 7161
public class RacingBetsDangoBroadcastItem : UiPanelBase
{
	// Token: 0x06011CC7 RID: 72903 RVA: 0x0053BBF0 File Offset: 0x00539DF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06011CC8 RID: 72904 RVA: 0x0053BC60 File Offset: 0x00539E60
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
	}

	// Token: 0x06011CC9 RID: 72905 RVA: 0x0053BC8B File Offset: 0x00539E8B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x06011CCA RID: 72906 RVA: 0x0053BCA5 File Offset: 0x00539EA5
	[NullableContext(1)]
	private void OnSequenceFinish(string sequenceName)
	{
		if (sequenceName == "TipsHide" && this.IsPlayingHide)
		{
			base.GetItem(0).SetUIActive(false);
			this.IsPlayingHide = false;
		}
	}

	// Token: 0x06011CCB RID: 72907 RVA: 0x0053BCD0 File Offset: 0x00539ED0
	[NullableContext(1)]
	public void Init(RacingBetsLegMatchData legMatchData)
	{
		this.LegMatchData = legMatchData;
	}

	// Token: 0x06011CCC RID: 72908 RVA: 0x0053BCDC File Offset: 0x00539EDC
	public void OnTick(float deltaTime)
	{
		if (this.IsShowBroadcast)
		{
			this.MoveLeft(deltaTime);
			this.CurBroadcastTime += deltaTime;
			if (this.CurBroadcastTime > this.ScrollDuration && !this.HasTriggeredHideThisRound)
			{
				this.HasTriggeredHideThisRound = true;
				this.IsPlayingHide = true;
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlaySequencePurely("TipsHide", false, false, null, null, false);
				}
			}
			if (this.CurBroadcastTime > this.BroadcastInterval)
			{
				this.CurBroadcastTime = 0f;
				this.IsShowBroadcast = false;
				return;
			}
		}
		else
		{
			this.InitBroadcast();
		}
	}

	// Token: 0x06011CCD RID: 72909 RVA: 0x0053BD74 File Offset: 0x00539F74
	private void MoveLeft(float delta)
	{
		UUIItem item = base.GetItem(3);
		item.SetAnchorOffsetX(item.GetAnchorOffsetX() - delta * 0.2f);
	}

	// Token: 0x06011CCE RID: 72910 RVA: 0x0053BD90 File Offset: 0x00539F90
	private void InitBroadcast()
	{
		this.IsShowBroadcast = true;
		this.IsPlayingHide = false;
		this.HasTriggeredHideThisRound = false;
		UUIText text = base.GetText(1);
		UUIItem item = base.GetItem(3);
		UUITexture texture = base.GetTexture(2);
		float ruleRate = RacingBetsConfig.Instance.GetRuleRate();
		if (Random.Shared.NextDouble() < (double)ruleRate)
		{
			string randomRuleText = this.LegMatchData.GetRandomRuleText();
			text.ShowTextNew(randomRuleText);
			texture.SetUIActive(false);
		}
		else
		{
			ValueTuple<string, int> dangoBroadcastText = this.LegMatchData.GetDangoBroadcastText();
			text.ShowTextNew(dangoBroadcastText.Item1);
			base.SetTextureShowUntilLoaded(DangoConfig.Instance.GetDangoById(dangoBroadcastText.Item2).Value.Icon, texture, null);
			texture.SetUIActive(true);
		}
		base.GetItem(0).SetUIActive(true);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlaySequencePurely("TipsShow", false, false, null, null, false);
		}
		float width = base.GetItem(0).Width;
		item.SetAnchorOffsetX(width);
		float num = text.GetTextRenderSize().X;
		num += texture.Width;
		this.ScrollDuration = (width + num) / 0.2f;
		this.BroadcastInterval = this.ScrollDuration + 5000f;
	}

	// Token: 0x04009B85 RID: 39813
	private float BroadcastInterval;

	// Token: 0x04009B86 RID: 39814
	private float ScrollDuration;

	// Token: 0x04009B87 RID: 39815
	private float CurBroadcastTime;

	// Token: 0x04009B88 RID: 39816
	private bool IsShowBroadcast;

	// Token: 0x04009B89 RID: 39817
	[Nullable(2)]
	private RacingBetsLegMatchData LegMatchData;

	// Token: 0x04009B8A RID: 39818
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04009B8B RID: 39819
	private bool IsPlayingHide;

	// Token: 0x04009B8C RID: 39820
	private bool HasTriggeredHideThisRound;

	// Token: 0x02007EE5 RID: 32485
	private class EComponent
	{
		// Token: 0x04029106 RID: 168198
		public const int RootItem = 0;

		// Token: 0x04029107 RID: 168199
		public const int Text = 1;

		// Token: 0x04029108 RID: 168200
		public const int DangoIconTexture = 2;

		// Token: 0x04029109 RID: 168201
		public const int PosItem = 3;
	}
}
