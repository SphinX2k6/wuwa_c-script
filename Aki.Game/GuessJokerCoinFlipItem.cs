using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000524 RID: 1316
public class GuessJokerCoinFlipItem : UiPanelBase
{
	// Token: 0x06004044 RID: 16452 RVA: 0x001682E4 File Offset: 0x001664E4
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

	// Token: 0x06004045 RID: 16453 RVA: 0x00168390 File Offset: 0x00166590
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

	// Token: 0x06004046 RID: 16454 RVA: 0x001684CC File Offset: 0x001666CC
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06004047 RID: 16455 RVA: 0x001684D5 File Offset: 0x001666D5
	public void SetClickEnable(bool enable)
	{
		this.ClickEnable = enable;
	}

	// Token: 0x06004048 RID: 16456 RVA: 0x001684DE File Offset: 0x001666DE
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

	// Token: 0x040032EC RID: 13036
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x040032ED RID: 13037
	private bool ClickEnable;

	// Token: 0x020067F9 RID: 26617
	private static class EComponentDefine
	{
		// Token: 0x04022495 RID: 140437
		public const int MaskButton = 0;

		// Token: 0x04022496 RID: 140438
		public const int CoinTexture = 1;

		// Token: 0x04022497 RID: 140439
		public const int ResultText = 2;

		// Token: 0x04022498 RID: 140440
		public const int BackCoinTexture = 3;

		// Token: 0x04022499 RID: 140441
		public const int FrontCoinTexture = 4;
	}
}
