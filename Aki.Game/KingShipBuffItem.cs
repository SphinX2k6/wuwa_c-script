using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001509 RID: 5385
public class KingShipBuffItem : UiPanelBase
{
	// Token: 0x0600D765 RID: 55141 RVA: 0x003FDA3C File Offset: 0x003FBC3C
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

	// Token: 0x0600D766 RID: 55142 RVA: 0x003FDAE5 File Offset: 0x003FBCE5
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600D767 RID: 55143 RVA: 0x003FDAFF File Offset: 0x003FBCFF
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

	// Token: 0x0600D768 RID: 55144 RVA: 0x003FDB38 File Offset: 0x003FBD38
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

	// Token: 0x0600D769 RID: 55145 RVA: 0x003FDB90 File Offset: 0x003FBD90
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

	// Token: 0x0600D76A RID: 55146 RVA: 0x003FDC10 File Offset: 0x003FBE10
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

	// Token: 0x0600D76B RID: 55147 RVA: 0x003FDCC4 File Offset: 0x003FBEC4
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

	// Token: 0x0600D76C RID: 55148 RVA: 0x003FDD22 File Offset: 0x003FBF22
	public bool GetIsShowingRoundsBuff()
	{
		return this.Rounds > 0;
	}

	// Token: 0x0400788D RID: 30861
	private int BuffId;

	// Token: 0x0400788E RID: 30862
	private int Rounds;

	// Token: 0x0400788F RID: 30863
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007890 RID: 30864
	[Nullable(2)]
	public Action<bool> OnClickTipsCallBack;

	// Token: 0x020077B7 RID: 30647
	private class EComponentDefine
	{
		// Token: 0x04026DB9 RID: 159161
		public const int Button = 0;

		// Token: 0x04026DBA RID: 159162
		public const int IconSprite = 1;

		// Token: 0x04026DBB RID: 159163
		public const int TipsItem = 2;

		// Token: 0x04026DBC RID: 159164
		public const int TipsTitleText = 3;

		// Token: 0x04026DBD RID: 159165
		public const int TipsDesText = 4;
	}
}
