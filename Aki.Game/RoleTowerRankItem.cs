using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF4 RID: 7412
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRankItem : GridProxyAbstract<RoleTowerRankData>
{
	// Token: 0x06012591 RID: 75153 RVA: 0x0056A434 File Offset: 0x00568634
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIArtText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickFunc))
		};
	}

	// Token: 0x06012592 RID: 75154 RVA: 0x0056A594 File Offset: 0x00568794
	public override void Refresh(RoleTowerRankData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool hasRecord = data.PassWave > 0;
		this.RefreshRankNum(data, hasRecord);
		this.RefreshDataFields(data, hasRecord);
		this.RefreshFuncBtn(data, hasRecord);
		this.RefreshTopGlow(data, hasRecord);
		this.RefreshSelfHighlight(data);
	}

	// Token: 0x06012593 RID: 75155 RVA: 0x0056A5D9 File Offset: 0x005687D9
	private void RefreshSelfHighlight(RoleTowerRankData data)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.RowMode == ERoleTowerRankRowMode.Friend && data.IsSelf);
	}

	// Token: 0x06012594 RID: 75156 RVA: 0x0056A600 File Offset: 0x00568800
	public override UniTask RefreshAsync(RoleTowerRankData data, bool isSelected, int gridIndex)
	{
		RoleTowerRankItem.<RefreshAsync>d__9 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.isSelected = isSelected;
		<RefreshAsync>d__.gridIndex = gridIndex;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleTowerRankItem.<RefreshAsync>d__9>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012595 RID: 75157 RVA: 0x0056A65C File Offset: 0x0056885C
	private void RefreshRankNum(RoleTowerRankData data, bool hasRecord)
	{
		UUITexture texture = base.GetTexture(1);
		UUISprite sprite = base.GetSprite(2);
		UUIArtText artText = base.GetArtText(3);
		UUIText text = base.GetText(4);
		if (!hasRecord)
		{
			bool flag = this.RowMode == ERoleTowerRankRowMode.SelfServer;
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(flag);
			}
			if (artText != null)
			{
				artText.SetUIActive(false);
			}
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (flag)
			{
				RoleTowerRankItem.SetSelfServerRankText(text, data);
			}
			return;
		}
		if (this.RowMode == ERoleTowerRankRowMode.SelfServer)
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			if (artText != null)
			{
				artText.SetUIActive(false);
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
			RoleTowerRankItem.SetSelfServerRankText(text, data);
			return;
		}
		int rank = data.Rank;
		bool flag2 = rank >= 1 && rank <= 3;
		bool flag3 = data.Rank >= 1;
		if (texture != null)
		{
			texture.SetUIActive(flag2);
		}
		if (sprite != null)
		{
			sprite.SetUIActive(!flag2);
		}
		if (artText != null)
		{
			artText.SetUIActive(flag3);
		}
		if (text != null)
		{
			text.SetUIActive(!flag3);
		}
		if (flag2 && texture != null)
		{
			ReadOnlySpan<char> str = "T_MowingTowerRankBg";
			char c = (char)(65 + data.Rank - 1);
			string resourceId = str + new ReadOnlySpan<char>(ref c);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), texture, null, null);
		}
		if (flag3)
		{
			if (artText != null)
			{
				artText.SetText(data.Rank.ToString("D2"));
			}
			if (artText != null)
			{
				artText.SetColor(FColor.FromHex(RoleTowerRankItem.GetRankArtColorHex(data.Rank)));
				return;
			}
		}
		else if (text != null)
		{
			text.SetText(data.Rank.ToString(), true);
		}
	}

	// Token: 0x06012596 RID: 75158 RVA: 0x0056A7F8 File Offset: 0x005689F8
	private static string GetRankArtColorHex(int rank)
	{
		string result;
		switch (rank)
		{
		case 1:
			result = "e6c582";
			break;
		case 2:
			result = "a0bdc8";
			break;
		case 3:
			result = "dba3a1";
			break;
		default:
			result = "ced6e1";
			break;
		}
		return result;
	}

	// Token: 0x06012597 RID: 75159 RVA: 0x0056A83C File Offset: 0x00568A3C
	[NullableContext(2)]
	public static void SetSelfServerRankText(UUIText txt, RoleTowerRankData data)
	{
		if (data == null || data.PassWave <= 0)
		{
			LguiUtil.Instance.SetLocalTextNew(txt, "RoleTowerNotRanked", Array.Empty<object>());
			return;
		}
		RoleTowerParam? roleTowerParam;
		int num = (RoleTowerConfig.Instance.GetParamByActivityId(RoleTowerModel.Instance.ActivityId) != null) ? roleTowerParam.GetValueOrDefault().MaxRankDisplay : 0;
		if (num <= 0 || data.FuzzyPercent <= num)
		{
			LguiUtil.Instance.SetLocalTextNew(txt, "RoleTowerRankedTop", new <>z__ReadOnlySingleElementList<object>(RoleTowerRankItem.FormatRankPercent(data.FuzzyPercent)));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(txt, "RoleTowerRankedLow", new <>z__ReadOnlySingleElementList<object>(RoleTowerRankItem.FormatRankPercentInt(num)));
	}

	// Token: 0x06012598 RID: 75160 RVA: 0x0056A8E8 File Offset: 0x00568AE8
	private static string FormatRankPercentInt(int tenThousandth)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>((tenThousandth + 99) / 100);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06012599 RID: 75161 RVA: 0x0056A920 File Offset: 0x00568B20
	private static string FormatRankPercent(int tenThousandth)
	{
		int num = Math.Max(10, (tenThousandth + 9) / 10);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num / 10);
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num % 10);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601259A RID: 75162 RVA: 0x0056A97C File Offset: 0x00568B7C
	private void RefreshDataFields(RoleTowerRankData data, bool hasRecord)
	{
		bool flag = this.RowMode == ERoleTowerRankRowMode.SelfServer;
		bool uiactive = hasRecord || flag;
		string newText = (flag && string.IsNullOrEmpty(data.PlayerName)) ? (FunctionModel.Instance.GetPlayerName() ?? "") : ((!string.IsNullOrEmpty(data.Remark)) ? data.Remark : data.PlayerName);
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		UUIText text2 = base.GetText(5);
		if (text2 != null)
		{
			text2.SetUIActive(uiactive);
		}
		UUIText text3 = base.GetText(6);
		if (text3 != null)
		{
			text3.SetUIActive(uiactive);
		}
		UUIText text4 = base.GetText(8);
		if (text4 != null)
		{
			text4.SetUIActive(uiactive);
		}
		bool flag2 = data.IsSelf || flag;
		bool flag3 = data.IsNewRecord || (flag2 && this.NewRecordTagFilter != null);
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			bool uiactive2;
			if (hasRecord && flag3)
			{
				Func<bool> newRecordTagFilter = this.NewRecordTagFilter;
				uiactive2 = (newRecordTagFilter == null || newRecordTagFilter());
			}
			else
			{
				uiactive2 = false;
			}
			item.SetUIActive(uiactive2);
		}
		if (!hasRecord)
		{
			if (flag)
			{
				UUIText text5 = base.GetText(6);
				if (text5 != null)
				{
					text5.SetText("-", true);
				}
				UUIText text6 = base.GetText(8);
				if (text6 == null)
				{
					return;
				}
				text6.SetText("-", true);
			}
			return;
		}
		UUIText text7 = base.GetText(6);
		if (text7 != null)
		{
			text7.SetText(data.PassWave.ToString(), true);
		}
		UUIText text8 = base.GetText(8);
		if (text8 == null)
		{
			return;
		}
		text8.SetText(RoleTowerTimeUtil.Format(data.RemainTime), true);
	}

	// Token: 0x0601259B RID: 75163 RVA: 0x0056AAE8 File Offset: 0x00568CE8
	private void RefreshTopGlow(RoleTowerRankData data, bool hasRecord)
	{
		int num = (hasRecord && this.RowMode == ERoleTowerRankRowMode.Friend) ? data.Rank : 0;
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(num == 1);
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(num == 2);
		}
		UUIItem item3 = base.GetItem(12);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(num == 3);
	}

	// Token: 0x0601259C RID: 75164 RVA: 0x0056AB50 File Offset: 0x00568D50
	private void RefreshFuncBtn(RoleTowerRankData data, bool hasRecord)
	{
		bool uiactive = this.RowMode == ERoleTowerRankRowMode.SelfServer && hasRecord;
		UUIButtonComponent button = base.GetButton(9);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(uiactive);
	}

	// Token: 0x0601259D RID: 75165 RVA: 0x0056AB8E File Offset: 0x00568D8E
	private void OnClickFunc()
	{
		if (this.Data != null)
		{
			Action<RoleTowerRankData> onClickFuncCallback = this.OnClickFuncCallback;
			if (onClickFuncCallback == null)
			{
				return;
			}
			onClickFuncCallback(this.Data);
		}
	}

	// Token: 0x04009FFA RID: 40954
	[Nullable(2)]
	private RoleTowerRankData Data;

	// Token: 0x04009FFB RID: 40955
	public ERoleTowerRankRowMode RowMode;

	// Token: 0x04009FFC RID: 40956
	public bool CanGetServerReward;

	// Token: 0x04009FFD RID: 40957
	[Nullable(2)]
	public Func<bool> NewRecordTagFilter;

	// Token: 0x04009FFE RID: 40958
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleTowerRankData> OnClickFuncCallback;

	// Token: 0x0200800B RID: 32779
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040296D3 RID: 169683
		public const int Item = 0;

		// Token: 0x040296D4 RID: 169684
		public const int TexRankBg = 1;

		// Token: 0x040296D5 RID: 169685
		public const int SpriteRankNormal = 2;

		// Token: 0x040296D6 RID: 169686
		public const int ArtTxtSort = 3;

		// Token: 0x040296D7 RID: 169687
		public const int TxtSort = 4;

		// Token: 0x040296D8 RID: 169688
		public const int TxtPlayerName = 5;

		// Token: 0x040296D9 RID: 169689
		public const int TxtWave = 6;

		// Token: 0x040296DA RID: 169690
		public const int PnlNewRecord = 7;

		// Token: 0x040296DB RID: 169691
		public const int TxtTime = 8;

		// Token: 0x040296DC RID: 169692
		public const int BtnFunc = 9;

		// Token: 0x040296DD RID: 169693
		public const int ItemGlowFirst = 10;

		// Token: 0x040296DE RID: 169694
		public const int ItemGlowSecond = 11;

		// Token: 0x040296DF RID: 169695
		public const int ItemGlowThird = 12;
	}
}
