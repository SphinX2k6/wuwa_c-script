using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002036 RID: 8246
public class KingShipBuffItem : UiPanelBase
{
	// Token: 0x060102FD RID: 66301 RVA: 0x003F1444 File Offset: 0x003EF644
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
		};
	}

	// Token: 0x060102FE RID: 66302 RVA: 0x003F14ED File Offset: 0x003EF6ED
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060102FF RID: 66303 RVA: 0x003F1507 File Offset: 0x003EF707
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string name)
		{
			if (name == "Close")
			{
				base.SetUiActive(false);
			}
		}, false);
	}

	// Token: 0x06010300 RID: 66304 RVA: 0x003F1540 File Offset: 0x003EF740
	public void RefreshItem()
	{
		this.Rounds--;
		if (this.Rounds <= 0)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayOrReplaySequenceByName("Close", false, null);
		}
	}

	// Token: 0x06010301 RID: 66305 RVA: 0x003F1598 File Offset: 0x003EF798
	public void ShowBuffItem(int data, int rounds)
	{
		this.BuffId = data;
		this.Rounds = rounds;
		base.SetUiActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayOrReplaySequenceByName("Start", false, null);
		}
		this.SetSpriteByPath(KingShipConfig.Instance.GetKingShipBuff(data).Icon, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06010302 RID: 66306 RVA: 0x003F1618 File Offset: 0x003EF818
	private void OnClickButton()
	{
		if (this.BuffId == 0)
		{
			return;
		}
		base.GetItem(2).SetUIActive(true);
		Action<bool> onClickTipsCallBack = this.OnClickTipsCallBack;
		if (onClickTipsCallBack != null)
		{
			onClickTipsCallBack(true);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayOrReplaySequenceByName("InfoIn", false, null);
		}
		KingShipBuff kingShipBuff = KingShipConfig.Instance.GetKingShipBuff(this.BuffId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), kingShipBuff.DesText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), kingShipBuff.NameText, Array.Empty<object>());
	}

	// Token: 0x06010303 RID: 66307 RVA: 0x003F16CC File Offset: 0x003EF8CC
	public void CloseTipsItem()
	{
		base.GetItem(2).SetUIActive(false);
		Action<bool> onClickTipsCallBack = this.OnClickTipsCallBack;
		if (onClickTipsCallBack != null)
		{
			onClickTipsCallBack(false);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayOrReplaySequenceByName("InfoOut", false, null);
	}

	// Token: 0x06010304 RID: 66308 RVA: 0x003F172A File Offset: 0x003EF92A
	public bool GetIsShowingRoundsBuff()
	{
		return this.Rounds > 0;
	}

	// Token: 0x040077A4 RID: 30628
	private int BuffId;

	// Token: 0x040077A5 RID: 30629
	private int Rounds;

	// Token: 0x040077A6 RID: 30630
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040077A7 RID: 30631
	[Nullable(2)]
	public Action<bool> OnClickTipsCallBack;

	// Token: 0x02008630 RID: 34352
	private class EComponentDefine
	{
		// Token: 0x0402BAAA RID: 178858
		public const int Button = 0;

		// Token: 0x0402BAAB RID: 178859
		public const int IconSprite = 1;

		// Token: 0x0402BAAC RID: 178860
		public const int TipsItem = 2;

		// Token: 0x0402BAAD RID: 178861
		public const int TipsTitleText = 3;

		// Token: 0x0402BAAE RID: 178862
		public const int TipsDesText = 4;
	}
}
