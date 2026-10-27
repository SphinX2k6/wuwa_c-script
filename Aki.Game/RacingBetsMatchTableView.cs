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

// Token: 0x02002736 RID: 10038
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsMatchTableView : UiViewBase
{
	// Token: 0x06014986 RID: 84358 RVA: 0x0053613C File Offset: 0x0053433C
	public RacingBetsMatchTableView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014987 RID: 84359 RVA: 0x0053614C File Offset: 0x0053434C
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

	// Token: 0x06014988 RID: 84360 RVA: 0x005361DF File Offset: 0x005343DF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsReplay, new Action(this.OnCloseBtnClick));
	}

	// Token: 0x06014989 RID: 84361 RVA: 0x005361FD File Offset: 0x005343FD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsReplay, new Action(this.OnCloseBtnClick));
	}

	// Token: 0x0601498A RID: 84362 RVA: 0x0053621C File Offset: 0x0053441C
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsMatchTableView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsMatchTableView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601498B RID: 84363 RVA: 0x00536260 File Offset: 0x00534460
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

	// Token: 0x0601498C RID: 84364 RVA: 0x00536364 File Offset: 0x00534564
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

	// Token: 0x0601498D RID: 84365 RVA: 0x005363AF File Offset: 0x005345AF
	private void OnTabClick(ERacingBetsMatchTableType type)
	{
		GenericLayout<RacingBetsMatchTableTabItem, ERacingBetsMatchTableType> tabLayout = this.TabLayout;
		if (tabLayout != null)
		{
			tabLayout.SelectGridProxyByKey(type, false);
		}
		this.ShowContent(type).Forget();
	}

	// Token: 0x0601498E RID: 84366 RVA: 0x005363D5 File Offset: 0x005345D5
	private RacingBetsMatchTableTabItem CreateTabItem()
	{
		return new RacingBetsMatchTableTabItem
		{
			OnToggleCallBack = new Action<ERacingBetsMatchTableType>(this.OnTabClick)
		};
	}

	// Token: 0x0601498F RID: 84367 RVA: 0x005363EE File Offset: 0x005345EE
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009AC8 RID: 39624
	private ERacingBetsMatchTableType SelectedTabType = ERacingBetsMatchTableType.GroupMatch;

	// Token: 0x04009AC9 RID: 39625
	[Nullable(2)]
	private RacingBetsGroupMatchPanel GroupMatchPanel;

	// Token: 0x04009ACA RID: 39626
	[Nullable(2)]
	private RacingBetsEliminationMatchPanel EliminationMatchPanel;

	// Token: 0x04009ACB RID: 39627
	[Nullable(2)]
	private RacingBetsFinalMatchPanel FinalMatchPanel;

	// Token: 0x04009ACC RID: 39628
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RacingBetsMatchTableTabItem, ERacingBetsMatchTableType> TabLayout;

	// Token: 0x02008DA7 RID: 36263
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DFB9 RID: 188345
		public const int BtnClose = 0;

		// Token: 0x0402DFBA RID: 188346
		public const int ItemSponsor = 1;

		// Token: 0x0402DFBB RID: 188347
		public const int LayoutTab = 2;

		// Token: 0x0402DFBC RID: 188348
		public const int ItemTab = 3;

		// Token: 0x0402DFBD RID: 188349
		public const int ItemParent = 4;
	}
}
