using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF6 RID: 7414
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerResultView : UiViewBase
{
	// Token: 0x060125B5 RID: 75189 RVA: 0x0056B3BC File Offset: 0x005695BC
	public RoleTowerResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060125B6 RID: 75190 RVA: 0x0056B3C8 File Offset: 0x005695C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(17, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickBattleDetail)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickReBattle)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnClickShare)),
			new ValueTuple<int, Delegate>(16, new Action(this.OnClickContinue))
		};
	}

	// Token: 0x060125B7 RID: 75191 RVA: 0x0056B5E4 File Offset: 0x005697E4
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<RoleTowerPauseStarItem, bool>(base.GetHorizontalLayout(9), () => new RoleTowerPauseStarItem(), null, false, true);
	}

	// Token: 0x060125B8 RID: 75192 RVA: 0x0056B61B File Offset: 0x0056981B
	private static bool IsRankShown(RoleTowerSettleData settle)
	{
		return !RoleTowerModel.Instance.IsTeachLevel(RoleTowerModel.Instance.CurSelectLevel) && settle.RankErrorCode == Aki.Protocol.ErrorCode.Success;
	}

	// Token: 0x060125B9 RID: 75193 RVA: 0x0056B640 File Offset: 0x00569840
	private void RefreshRank(RoleTowerSettleData settle)
	{
		RoleTowerRankData data = new RoleTowerRankData
		{
			PassWave = settle.PassWave,
			FuzzyPercent = settle.Rank
		};
		RoleTowerRankItem.SetSelfServerRankText(base.GetText(6), data);
	}

	// Token: 0x060125BA RID: 75194 RVA: 0x0056B678 File Offset: 0x00569878
	protected override void OnBeforeShow()
	{
		RoleTowerSettleData lastSettle = RoleTowerModel.Instance.GetLastSettle();
		if (lastSettle == null)
		{
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.LJQ, "RoleTower.Result 结算数据未下发(待协议)", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(lastSettle.MainRoleId);
		if (roleConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), roleConfig.Value.Name, Array.Empty<object>());
		}
		this.RefreshRoleShareTexture(lastSettle.MainRoleId);
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(lastSettle.PassWave.ToString(), true);
		}
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetText(RoleTowerTimeUtil.Format(lastSettle.RemainTime), true);
		}
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			text3.SetText(RoleTowerTimeUtil.Format(lastSettle.TotalCostTime), true);
		}
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(lastSettle.IsNewRecord);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		bool flag = RoleTowerResultView.IsRankShown(lastSettle);
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(flag);
		}
		if (flag)
		{
			this.RefreshRank(lastSettle);
		}
		this.RefreshStar();
		UUIText text4 = base.GetText(11);
		if (text4 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(RoleTowerModel.Instance.GetCurEchoLevel());
			text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIItem item4 = base.GetItem(13);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(true);
	}

	// Token: 0x060125BB RID: 75195 RVA: 0x0056B800 File Offset: 0x00569A00
	private unsafe void RefreshRoleShareTexture(int mainRoleId)
	{
		UUITexture texture = base.GetTexture(17);
		if (texture == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.Result TexBgRole 未绑定(检查预制体 Components 索引17)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mainRoleId", mainRoleId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(mainRoleId);
		GaChaShare? gaChaShare;
		string text = (ConfigGaChaShareById.GetConfig(baseRoleId, true) != null) ? gaChaShare.GetValueOrDefault().SharePic : null;
		if (string.IsNullOrEmpty(text))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Temp;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "RoleTower.Result GaChaShare.SharePic 缺失";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mainRoleId", mainRoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", baseRoleId);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			texture.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		base.SetTextureByPath(text, texture, null, null);
	}

	// Token: 0x060125BC RID: 75196 RVA: 0x0056B8FC File Offset: 0x00569AFC
	private void RefreshStar()
	{
		int curTeamStar = RoleTowerModel.Instance.GetCurTeamStar();
		IReadOnlyList<RoleTowerStar> starCfgListByRole = RoleTowerModel.Instance.GetStarCfgListByRole(0);
		List<bool> list = new List<bool>();
		for (int i = 0; i < starCfgListByRole.Count; i++)
		{
			list.Add(i < curTeamStar);
		}
		GenericLayout<RoleTowerPauseStarItem, bool> starLayout = this.StarLayout;
		if (starLayout == null)
		{
			return;
		}
		starLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060125BD RID: 75197 RVA: 0x0056B954 File Offset: 0x00569B54
	private void OnClickBattleDetail()
	{
		RoleTowerModel.Instance.OpenRecordView(RoleTowerModel.Instance.CurSelectLevel, true);
	}

	// Token: 0x060125BE RID: 75198 RVA: 0x0056B96B File Offset: 0x00569B6B
	private void OnClickReBattle()
	{
		RoleTowerModel.Instance.RestartChallengeFromResult();
		base.CloseMe(null);
	}

	// Token: 0x060125BF RID: 75199 RVA: 0x0056B980 File Offset: 0x00569B80
	private void OnClickShare()
	{
		UiAsyncTask task = new UiAsyncTask("RoleTowerResultShare", delegate()
		{
			RoleTowerResultView.<<OnClickShare>b__12_0>d <<OnClickShare>b__12_0>d;
			<<OnClickShare>b__12_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickShare>b__12_0>d.<>4__this = this;
			<<OnClickShare>b__12_0>d.<>1__state = -1;
			<<OnClickShare>b__12_0>d.<>t__builder.Start<RoleTowerResultView.<<OnClickShare>b__12_0>d>(ref <<OnClickShare>b__12_0>d);
			return <<OnClickShare>b__12_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060125C0 RID: 75200 RVA: 0x0056B9B0 File Offset: 0x00569BB0
	private void SetShareState(bool isShow)
	{
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(isShow);
		}
		UUIButtonComponent button = base.GetButton(14);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(isShow);
			}
		}
		UUIButtonComponent button2 = base.GetButton(15);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(isShow);
			}
		}
		UUIButtonComponent button3 = base.GetButton(16);
		if (button3 == null)
		{
			return;
		}
		UUIItem uuiitem3 = button3.RootUIComp.Get();
		if (uuiitem3 == null)
		{
			return;
		}
		uuiitem3.SetUIActive(isShow);
	}

	// Token: 0x060125C1 RID: 75201 RVA: 0x0056BA44 File Offset: 0x00569C44
	private UniTask OpenShareViewAsync()
	{
		RoleTowerResultView.<OpenShareViewAsync>d__14 <OpenShareViewAsync>d__;
		<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenShareViewAsync>d__.<>4__this = this;
		<OpenShareViewAsync>d__.<>1__state = -1;
		<OpenShareViewAsync>d__.<>t__builder.Start<RoleTowerResultView.<OpenShareViewAsync>d__14>(ref <OpenShareViewAsync>d__);
		return <OpenShareViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125C2 RID: 75202 RVA: 0x0056BA87 File Offset: 0x00569C87
	private void OnClickContinue()
	{
		RoleTowerModel.Instance.OpenActivityMainView(false, null, null);
		base.CloseMe(null);
	}

	// Token: 0x0400A00B RID: 40971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseStarItem, bool> StarLayout;

	// Token: 0x02008011 RID: 32785
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040296F7 RID: 169719
		public const int TxtRoleName = 0;

		// Token: 0x040296F8 RID: 169720
		public const int PnlNewRecord = 1;

		// Token: 0x040296F9 RID: 169721
		public const int TxtWave = 2;

		// Token: 0x040296FA RID: 169722
		public const int TxtTime = 3;

		// Token: 0x040296FB RID: 169723
		public const int TxtAllTime = 4;

		// Token: 0x040296FC RID: 169724
		public const int PnlRank = 5;

		// Token: 0x040296FD RID: 169725
		public const int TxtRankNum = 6;

		// Token: 0x040296FE RID: 169726
		public const int PnlRankOpen = 7;

		// Token: 0x040296FF RID: 169727
		public const int TxtRankOpenTime = 8;

		// Token: 0x04029700 RID: 169728
		public const int PnlHor = 9;

		// Token: 0x04029701 RID: 169729
		public const int UiItemStar = 10;

		// Token: 0x04029702 RID: 169730
		public const int TxtLevel = 11;

		// Token: 0x04029703 RID: 169731
		public const int BtnBattleDetail = 12;

		// Token: 0x04029704 RID: 169732
		public const int PnlHide = 13;

		// Token: 0x04029705 RID: 169733
		public const int BtnReBattle = 14;

		// Token: 0x04029706 RID: 169734
		public const int BtnShare = 15;

		// Token: 0x04029707 RID: 169735
		public const int BtnContinue = 16;

		// Token: 0x04029708 RID: 169736
		public const int TexBgRole = 17;
	}
}
