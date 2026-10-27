using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200270E RID: 9998
public class RacingBetsDangoBroadcastItem : UiPanelBase
{
	// Token: 0x060147E5 RID: 83941 RVA: 0x0052CED4 File Offset: 0x0052B0D4
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

	// Token: 0x060147E6 RID: 83942 RVA: 0x0052CF44 File Offset: 0x0052B144
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
	}

	// Token: 0x060147E7 RID: 83943 RVA: 0x0052CF6F File Offset: 0x0052B16F
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x060147E8 RID: 83944 RVA: 0x0052CF89 File Offset: 0x0052B189
	[NullableContext(1)]
	private void OnSequenceFinish(string sequenceName)
	{
		if (sequenceName == "TipsHide" && this.IsPlayingHide)
		{
			base.GetItem(0).SetUIActive(false);
			this.IsPlayingHide = false;
		}
	}

	// Token: 0x060147E9 RID: 83945 RVA: 0x0052CFB4 File Offset: 0x0052B1B4
	[NullableContext(1)]
	public void Init(RacingBetsLegMatchData legMatchData)
	{
		this.LegMatchData = legMatchData;
	}

	// Token: 0x060147EA RID: 83946 RVA: 0x0052CFC0 File Offset: 0x0052B1C0
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

	// Token: 0x060147EB RID: 83947 RVA: 0x0052D058 File Offset: 0x0052B258
	private void MoveLeft(float delta)
	{
		UUIItem item = base.GetItem(3);
		item.SetAnchorOffsetX(item.GetAnchorOffsetX() - delta * 0.2f);
	}

	// Token: 0x060147EC RID: 83948 RVA: 0x0052D074 File Offset: 0x0052B274
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

	// Token: 0x04009A2D RID: 39469
	private float BroadcastInterval;

	// Token: 0x04009A2E RID: 39470
	private float ScrollDuration;

	// Token: 0x04009A2F RID: 39471
	private float CurBroadcastTime;

	// Token: 0x04009A30 RID: 39472
	private bool IsShowBroadcast;

	// Token: 0x04009A31 RID: 39473
	[Nullable(2)]
	private RacingBetsLegMatchData LegMatchData;

	// Token: 0x04009A32 RID: 39474
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04009A33 RID: 39475
	private bool IsPlayingHide;

	// Token: 0x04009A34 RID: 39476
	private bool HasTriggeredHideThisRound;

	// Token: 0x02008D5C RID: 36188
	private class EComponent
	{
		// Token: 0x0402DDEF RID: 187887
		public const int RootItem = 0;

		// Token: 0x0402DDF0 RID: 187888
		public const int Text = 1;

		// Token: 0x0402DDF1 RID: 187889
		public const int DangoIconTexture = 2;

		// Token: 0x0402DDF2 RID: 187890
		public const int PosItem = 3;
	}
}
