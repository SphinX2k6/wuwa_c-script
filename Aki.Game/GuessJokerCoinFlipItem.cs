using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001070 RID: 4208
public class GuessJokerCoinFlipItem : UiPanelBase
{
	// Token: 0x06006CAF RID: 27823 RVA: 0x0015F9B0 File Offset: 0x0015DBB0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnMaskButtonClick))
		};
	}

	// Token: 0x06006CB0 RID: 27824 RVA: 0x0015FA5C File Offset: 0x0015DC5C
	public void Refresh()
	{
		EGuessJokerPlayerType firstPlayerTurn = GuessJokerGamePlayModel.Instance.FirstPlayerTurn;
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById == null)
		{
			return;
		}
		string coinIconPath = jokerLevelById.Value.CoinIconPath;
		string resourceId = (WorldLevelModel.Instance.Sex == 1) ? "T_GhostCardFlipCoin_Boy" : "T_GhostCardFlipCoin_Girl";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		if (firstPlayerTurn == EGuessJokerPlayerType.Ai)
		{
			base.SetTextureByPath(coinIconPath, base.GetTexture(1), null, null);
			base.SetTextureByPath(coinIconPath, base.GetTexture(4), null, null);
			base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		}
		else
		{
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			base.SetTextureByPath(resourcePath, base.GetTexture(4), null, null);
			base.SetTextureByPath(coinIconPath, base.GetTexture(3), null, null);
		}
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(firstPlayerTurn);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "GuessJoker_FirstPlayerText", new <>z__ReadOnlySingleElementList<object>(playerNameByType));
	}

	// Token: 0x06006CB1 RID: 27825 RVA: 0x0015FB98 File Offset: 0x0015DD98
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06006CB2 RID: 27826 RVA: 0x0015FBA1 File Offset: 0x0015DDA1
	public void SetClickEnable(bool enable)
	{
		this.ClickEnable = enable;
	}

	// Token: 0x06006CB3 RID: 27827 RVA: 0x0015FBAA File Offset: 0x0015DDAA
	private void OnMaskButtonClick()
	{
		if (!this.ClickEnable)
		{
			return;
		}
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x04003253 RID: 12883
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x04003254 RID: 12884
	private bool ClickEnable;

	// Token: 0x02007665 RID: 30309
	private static class EComponentDefine
	{
		// Token: 0x0402714A RID: 160074
		public const int MaskButton = 0;

		// Token: 0x0402714B RID: 160075
		public const int CoinTexture = 1;

		// Token: 0x0402714C RID: 160076
		public const int ResultText = 2;

		// Token: 0x0402714D RID: 160077
		public const int BackCoinTexture = 3;

		// Token: 0x0402714E RID: 160078
		public const int FrontCoinTexture = 4;
	}
}
