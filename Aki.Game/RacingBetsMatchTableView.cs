using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C21 RID: 7201
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsMatchTableView : UiViewBase
{
	// Token: 0x06011E68 RID: 73320 RVA: 0x00544E48 File Offset: 0x00543048
	public RacingBetsMatchTableView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E69 RID: 73321 RVA: 0x00544E58 File Offset: 0x00543058
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
		};
	}

	// Token: 0x06011E6A RID: 73322 RVA: 0x00544EEB File Offset: 0x005430EB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsReplay, new Action(this.OnCloseBtnClick));
	}

	// Token: 0x06011E6B RID: 73323 RVA: 0x00544F09 File Offset: 0x00543109
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsReplay, new Action(this.OnCloseBtnClick));
	}

	// Token: 0x06011E6C RID: 73324 RVA: 0x00544F28 File Offset: 0x00543128
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsMatchTableView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsMatchTableView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011E6D RID: 73325 RVA: 0x00544F6C File Offset: 0x0054316C
	private ERacingBetsMatchTableType GetCurTabId(List<ERacingBetsMatchTableType> tabList, int curLegMatchDataId)
	{
		foreach (ERacingBetsMatchTableType eracingBetsMatchTableType in tabList)
		{
			RacingBetsMatch? matchTableConfigById = RacingBetsConfig.Instance.GetMatchTableConfigById((int)eracingBetsMatchTableType);
			List<int> list = new List<int>();
			foreach (int matchId in matchTableConfigById.Value.GetGroupMatchListArray())
			{
				foreach (RacingBetsLegMatchData racingBetsLegMatchData in RacingBetsModel.Instance.GetRacingBetsGroupMatchData(matchId).GetLegMatchList())
				{
					list.Add(racingBetsLegMatchData.Id);
				}
			}
			if (list.Contains(curLegMatchDataId))
			{
				return eracingBetsMatchTableType;
			}
		}
		if (tabList.Count <= 0)
		{
			return ERacingBetsMatchTableType.GroupMatch;
		}
		return tabList[0];
	}

	// Token: 0x06011E6E RID: 73326 RVA: 0x00545070 File Offset: 0x00543270
	public UniTask ShowContent(ERacingBetsMatchTableType type)
	{
		RacingBetsMatchTableView.<ShowContent>d__12 <ShowContent>d__;
		<ShowContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowContent>d__.<>4__this = this;
		<ShowContent>d__.type = type;
		<ShowContent>d__.<>1__state = -1;
		<ShowContent>d__.<>t__builder.Start<RacingBetsMatchTableView.<ShowContent>d__12>(ref <ShowContent>d__);
		return <ShowContent>d__.<>t__builder.Task;
	}

	// Token: 0x06011E6F RID: 73327 RVA: 0x005450BB File Offset: 0x005432BB
	private void OnTabClick(ERacingBetsMatchTableType type)
	{
		GenericLayout<RacingBetsMatchTableTabItem, ERacingBetsMatchTableType> tabLayout = this.TabLayout;
		if (tabLayout != null)
		{
			tabLayout.SelectGridProxyByKey(type, false);
		}
		this.ShowContent(type).Forget();
	}

	// Token: 0x06011E70 RID: 73328 RVA: 0x005450E1 File Offset: 0x005432E1
	private RacingBetsMatchTableTabItem CreateTabItem()
	{
		return new RacingBetsMatchTableTabItem
		{
			OnToggleCallBack = new Action<ERacingBetsMatchTableType>(this.OnTabClick)
		};
	}

	// Token: 0x06011E71 RID: 73329 RVA: 0x005450FA File Offset: 0x005432FA
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009C20 RID: 39968
	private ERacingBetsMatchTableType SelectedTabType = ERacingBetsMatchTableType.GroupMatch;

	// Token: 0x04009C21 RID: 39969
	[Nullable(2)]
	private RacingBetsGroupMatchPanel GroupMatchPanel;

	// Token: 0x04009C22 RID: 39970
	[Nullable(2)]
	private RacingBetsEliminationMatchPanel EliminationMatchPanel;

	// Token: 0x04009C23 RID: 39971
	[Nullable(2)]
	private RacingBetsFinalMatchPanel FinalMatchPanel;

	// Token: 0x04009C24 RID: 39972
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RacingBetsMatchTableTabItem, ERacingBetsMatchTableType> TabLayout;

	// Token: 0x02007F2F RID: 32559
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040292CF RID: 168655
		public const int BtnClose = 0;

		// Token: 0x040292D0 RID: 168656
		public const int ItemSponsor = 1;

		// Token: 0x040292D1 RID: 168657
		public const int LayoutTab = 2;

		// Token: 0x040292D2 RID: 168658
		public const int ItemTab = 3;

		// Token: 0x040292D3 RID: 168659
		public const int ItemParent = 4;
	}
}
