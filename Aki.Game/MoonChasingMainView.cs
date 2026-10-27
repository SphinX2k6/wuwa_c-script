using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001355 RID: 4949
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingMainView : UiViewBase
{
	// Token: 0x060089C6 RID: 35270 RVA: 0x001D70BD File Offset: 0x001D52BD
	public MoonChasingMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060089C7 RID: 35271 RVA: 0x001D70D4 File Offset: 0x001D52D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIInturnAnimController))
		};
	}

	// Token: 0x060089C8 RID: 35272 RVA: 0x001D71E0 File Offset: 0x001D53E0
	protected override void OnStart()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
	}

	// Token: 0x060089C9 RID: 35273 RVA: 0x001D7203 File Offset: 0x001D5403
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName != "InturnAni")
		{
			return;
		}
		base.GetUiInturnAnimController(10).Play("", -1, false);
	}

	// Token: 0x060089CA RID: 35274 RVA: 0x001D7228 File Offset: 0x001D5428
	private UniTask InitPopularity()
	{
		MoonChasingMainView.<InitPopularity>d__13 <InitPopularity>d__;
		<InitPopularity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopularity>d__.<>4__this = this;
		<InitPopularity>d__.<>1__state = -1;
		<InitPopularity>d__.<>t__builder.Start<MoonChasingMainView.<InitPopularity>d__13>(ref <InitPopularity>d__);
		return <InitPopularity>d__.<>t__builder.Task;
	}

	// Token: 0x060089CB RID: 35275 RVA: 0x001D726C File Offset: 0x001D546C
	private UniTask InitCaption()
	{
		MoonChasingMainView.<InitCaption>d__14 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<MoonChasingMainView.<InitCaption>d__14>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x060089CC RID: 35276 RVA: 0x001D72B0 File Offset: 0x001D54B0
	private UniTask InitBuildingMainModule()
	{
		MoonChasingMainView.<InitBuildingMainModule>d__15 <InitBuildingMainModule>d__;
		<InitBuildingMainModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBuildingMainModule>d__.<>4__this = this;
		<InitBuildingMainModule>d__.<>1__state = -1;
		<InitBuildingMainModule>d__.<>t__builder.Start<MoonChasingMainView.<InitBuildingMainModule>d__15>(ref <InitBuildingMainModule>d__);
		return <InitBuildingMainModule>d__.<>t__builder.Task;
	}

	// Token: 0x060089CD RID: 35277 RVA: 0x001D72F4 File Offset: 0x001D54F4
	private void InitBtn()
	{
		this.BusinessBtn = new ButtonItem(base.GetItem(2));
		this.BusinessBtn.SetFunction(new Action<int>(this.Vc.SkipToBusinessByParam));
		this.BuildBtn = new ButtonItem(base.GetItem(3));
		this.BuildBtn.SetFunction(new Action<int>(this.Vc.SkipToBuildByParam));
		this.TaskBtn = new ButtonItem(base.GetItem(4));
		this.TaskBtn.SetFunction(delegate(int _)
		{
			this.Vc.SkipToTask(EMoonChasingTaskType.MainLine, false);
		});
		this.HandbookBtn = new ButtonItem(base.GetItem(0));
		this.HandbookBtn.SetFunction(new Action<int>(this.Vc.SkipToHandbook));
		this.RewardBtn = new ButtonItem(base.GetItem(1));
		this.RewardBtn.SetFunction(new Action<int>(this.Vc.SkipToReward));
		this.RewardBtn.SetUiActive(false);
	}

	// Token: 0x060089CE RID: 35278 RVA: 0x001D73F0 File Offset: 0x001D55F0
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingMainView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingMainView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060089CF RID: 35279 RVA: 0x001D7433 File Offset: 0x001D5633
	protected override void OnBeforeShow()
	{
		this.Vc.Show();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x060089D0 RID: 35280 RVA: 0x001D744A File Offset: 0x001D564A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PopularityChange, new Action(this.OnPopularityChange));
	}

	// Token: 0x060089D1 RID: 35281 RVA: 0x001D7468 File Offset: 0x001D5668
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PopularityChange, new Action(this.OnPopularityChange));
	}

	// Token: 0x060089D2 RID: 35282 RVA: 0x001D7488 File Offset: 0x001D5688
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "Cost")
		{
			UUIItem costContent = this.CaptionItem.GetCostContent();
			if (costContent == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				costContent,
				costContent
			};
		}
		else
		{
			if (a == "BuildMap")
			{
				return this.BuildingMainModule.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			return null;
		}
	}

	// Token: 0x060089D3 RID: 35283 RVA: 0x001D74E9 File Offset: 0x001D56E9
	private void OnPopularityChange()
	{
		this.Popularity.RefreshPopularity();
	}

	// Token: 0x060089D4 RID: 35284 RVA: 0x001D74F6 File Offset: 0x001D56F6
	public void RefreshBuildingModule()
	{
		this.BuildingMainModule.RefreshModule();
	}

	// Token: 0x060089D5 RID: 35285 RVA: 0x001D7503 File Offset: 0x001D5703
	public void BuildingBackToMainView()
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.BuildingMainModule.HideBuildingModule();
	}

	// Token: 0x060089D6 RID: 35286 RVA: 0x001D7523 File Offset: 0x001D5723
	public void SkipToBuild()
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.BuildingMainModule.ShowBuilding();
	}

	// Token: 0x060089D7 RID: 35287 RVA: 0x001D7543 File Offset: 0x001D5743
	public void RefreshMainModule(int buildingId)
	{
		this.BuildingMainModule.RefreshBuilding(buildingId);
	}

	// Token: 0x060089D8 RID: 35288 RVA: 0x001D7554 File Offset: 0x001D5754
	public void RefreshRedDot()
	{
		this.BusinessBtn.BindRedDot(ERedDotName.MoonChasingDelegation, 0);
		this.BuildBtn.BindRedDot(ERedDotName.MoonChasingBuilding, 0);
		this.HandbookBtn.BindRedDot(ERedDotName.MoonChasingHandbook, 0);
		this.RewardBtn.BindRedDot(ERedDotName.MoonChasingRewardAndShop, 0);
		this.TaskBtn.BindRedDot(ERedDotName.MoonChasingAllQuest, 0);
	}

	// Token: 0x04003D76 RID: 15734
	private PopularityModule Popularity;

	// Token: 0x04003D77 RID: 15735
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003D78 RID: 15736
	private BuildingMainModule BuildingMainModule;

	// Token: 0x04003D79 RID: 15737
	private ButtonItem BusinessBtn;

	// Token: 0x04003D7A RID: 15738
	private ButtonItem BuildBtn;

	// Token: 0x04003D7B RID: 15739
	private ButtonItem TaskBtn;

	// Token: 0x04003D7C RID: 15740
	private ButtonItem HandbookBtn;

	// Token: 0x04003D7D RID: 15741
	private ButtonItem RewardBtn;

	// Token: 0x04003D7E RID: 15742
	private readonly MoonChasingViewController Vc = new MoonChasingViewController();

	// Token: 0x020079B9 RID: 31161
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402812C RID: 164140
		public const int HandbookBtn = 0;

		// Token: 0x0402812D RID: 164141
		public const int RewardBtn = 1;

		// Token: 0x0402812E RID: 164142
		public const int BusinessBtn = 2;

		// Token: 0x0402812F RID: 164143
		public const int BuildBtn = 3;

		// Token: 0x04028130 RID: 164144
		public const int TaskBtn = 4;

		// Token: 0x04028131 RID: 164145
		public const int CaptionItem = 5;

		// Token: 0x04028132 RID: 164146
		public const int PopularityItem = 6;

		// Token: 0x04028133 RID: 164147
		public const int ContentItem = 7;

		// Token: 0x04028134 RID: 164148
		public const int BuildMainItem = 8;

		// Token: 0x04028135 RID: 164149
		public const int CaptionItem2 = 9;

		// Token: 0x04028136 RID: 164150
		public const int Lantern = 10;
	}
}
