using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000809 RID: 2057
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingMainView : UiViewBase
{
	// Token: 0x06005D61 RID: 23905 RVA: 0x001DFF21 File Offset: 0x001DE121
	public MoonChasingMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005D62 RID: 23906 RVA: 0x001DFF38 File Offset: 0x001DE138
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

	// Token: 0x06005D63 RID: 23907 RVA: 0x001E0044 File Offset: 0x001DE244
	protected override void OnStart()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
	}

	// Token: 0x06005D64 RID: 23908 RVA: 0x001E0067 File Offset: 0x001DE267
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName != "InturnAni")
		{
			return;
		}
		base.GetUiInturnAnimController(10).Play("", -1, false);
	}

	// Token: 0x06005D65 RID: 23909 RVA: 0x001E008C File Offset: 0x001DE28C
	private UniTask InitPopularity()
	{
		MoonChasingMainView.<InitPopularity>d__13 <InitPopularity>d__;
		<InitPopularity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopularity>d__.<>4__this = this;
		<InitPopularity>d__.<>1__state = -1;
		<InitPopularity>d__.<>t__builder.Start<MoonChasingMainView.<InitPopularity>d__13>(ref <InitPopularity>d__);
		return <InitPopularity>d__.<>t__builder.Task;
	}

	// Token: 0x06005D66 RID: 23910 RVA: 0x001E00D0 File Offset: 0x001DE2D0
	private UniTask InitCaption()
	{
		MoonChasingMainView.<InitCaption>d__14 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<MoonChasingMainView.<InitCaption>d__14>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06005D67 RID: 23911 RVA: 0x001E0114 File Offset: 0x001DE314
	private UniTask InitBuildingMainModule()
	{
		MoonChasingMainView.<InitBuildingMainModule>d__15 <InitBuildingMainModule>d__;
		<InitBuildingMainModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBuildingMainModule>d__.<>4__this = this;
		<InitBuildingMainModule>d__.<>1__state = -1;
		<InitBuildingMainModule>d__.<>t__builder.Start<MoonChasingMainView.<InitBuildingMainModule>d__15>(ref <InitBuildingMainModule>d__);
		return <InitBuildingMainModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005D68 RID: 23912 RVA: 0x001E0158 File Offset: 0x001DE358
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

	// Token: 0x06005D69 RID: 23913 RVA: 0x001E0254 File Offset: 0x001DE454
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingMainView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingMainView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005D6A RID: 23914 RVA: 0x001E0297 File Offset: 0x001DE497
	protected override void OnBeforeShow()
	{
		this.Vc.Show();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06005D6B RID: 23915 RVA: 0x001E02AE File Offset: 0x001DE4AE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PopularityChange, new Action(this.OnPopularityChange));
	}

	// Token: 0x06005D6C RID: 23916 RVA: 0x001E02CC File Offset: 0x001DE4CC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PopularityChange, new Action(this.OnPopularityChange));
	}

	// Token: 0x06005D6D RID: 23917 RVA: 0x001E02EC File Offset: 0x001DE4EC
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

	// Token: 0x06005D6E RID: 23918 RVA: 0x001E034D File Offset: 0x001DE54D
	private void OnPopularityChange()
	{
		this.Popularity.RefreshPopularity();
	}

	// Token: 0x06005D6F RID: 23919 RVA: 0x001E035A File Offset: 0x001DE55A
	public void RefreshBuildingModule()
	{
		this.BuildingMainModule.RefreshModule();
	}

	// Token: 0x06005D70 RID: 23920 RVA: 0x001E0367 File Offset: 0x001DE567
	public void BuildingBackToMainView()
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.BuildingMainModule.HideBuildingModule();
	}

	// Token: 0x06005D71 RID: 23921 RVA: 0x001E0387 File Offset: 0x001DE587
	public void SkipToBuild()
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.BuildingMainModule.ShowBuilding();
	}

	// Token: 0x06005D72 RID: 23922 RVA: 0x001E03A7 File Offset: 0x001DE5A7
	public void RefreshMainModule(int buildingId)
	{
		this.BuildingMainModule.RefreshBuilding(buildingId);
	}

	// Token: 0x06005D73 RID: 23923 RVA: 0x001E03B8 File Offset: 0x001DE5B8
	public void RefreshRedDot()
	{
		this.BusinessBtn.BindRedDot(ERedDotName.MoonChasingDelegation, 0);
		this.BuildBtn.BindRedDot(ERedDotName.MoonChasingBuilding, 0);
		this.HandbookBtn.BindRedDot(ERedDotName.MoonChasingHandbook, 0);
		this.RewardBtn.BindRedDot(ERedDotName.MoonChasingRewardAndShop, 0);
		this.TaskBtn.BindRedDot(ERedDotName.MoonChasingAllQuest, 0);
	}

	// Token: 0x04003E0E RID: 15886
	private PopularityModule Popularity;

	// Token: 0x04003E0F RID: 15887
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003E10 RID: 15888
	private BuildingMainModule BuildingMainModule;

	// Token: 0x04003E11 RID: 15889
	private ButtonItem BusinessBtn;

	// Token: 0x04003E12 RID: 15890
	private ButtonItem BuildBtn;

	// Token: 0x04003E13 RID: 15891
	private ButtonItem TaskBtn;

	// Token: 0x04003E14 RID: 15892
	private ButtonItem HandbookBtn;

	// Token: 0x04003E15 RID: 15893
	private ButtonItem RewardBtn;

	// Token: 0x04003E16 RID: 15894
	private readonly MoonChasingViewController Vc = new MoonChasingViewController();

	// Token: 0x02006B43 RID: 27459
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04023459 RID: 144473
		public const int HandbookBtn = 0;

		// Token: 0x0402345A RID: 144474
		public const int RewardBtn = 1;

		// Token: 0x0402345B RID: 144475
		public const int BusinessBtn = 2;

		// Token: 0x0402345C RID: 144476
		public const int BuildBtn = 3;

		// Token: 0x0402345D RID: 144477
		public const int TaskBtn = 4;

		// Token: 0x0402345E RID: 144478
		public const int CaptionItem = 5;

		// Token: 0x0402345F RID: 144479
		public const int PopularityItem = 6;

		// Token: 0x04023460 RID: 144480
		public const int ContentItem = 7;

		// Token: 0x04023461 RID: 144481
		public const int BuildMainItem = 8;

		// Token: 0x04023462 RID: 144482
		public const int CaptionItem2 = 9;

		// Token: 0x04023463 RID: 144483
		public const int Lantern = 10;
	}
}
