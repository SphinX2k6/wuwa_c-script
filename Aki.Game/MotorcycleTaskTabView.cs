using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200226F RID: 8815
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTaskTabView : UiTabViewBase
{
	// Token: 0x0601135E RID: 70494 RVA: 0x00432144 File Offset: 0x00430344
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnBtnAskClick))
		};
	}

	// Token: 0x0601135F RID: 70495 RVA: 0x00432248 File Offset: 0x00430448
	protected override void OnStart()
	{
		this.TabComponent = new TabComponent<MotorcycleTreeTypeTabItem>(base.GetHorizontalLayout(6).RootUIComp.Get(), new Func<UUIItem, int?, MotorcycleTreeTypeTabItem>(this.InitTreeTabItem), new Action<int>(this.ToggleCallBack), base.GetItem(7));
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(0);
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.TaskLoopScroll = new LoopScrollView<MotorcycleTaskItem, MotorTechTaskNode>(loopScrollViewComponent, gridActor, new Func<MotorcycleTaskItem>(this.InitTaskItem), true);
	}

	// Token: 0x06011360 RID: 70496 RVA: 0x004322C8 File Offset: 0x004304C8
	protected override void OnBeforeShow()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetLoopScrollViewComponent(0).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController != null)
		{
			uuiinturnAnimController.Play("", -1, false);
		}
		this.TreeType = MotorcycleDevelopModel.Instance.GetSelectedTreeType();
		if (this.TreeType == 0)
		{
			this.TreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		}
		this.OnTabUpdateAsync();
	}

	// Token: 0x06011361 RID: 70497 RVA: 0x0043233E File Offset: 0x0043053E
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(this.OnTaskUpdate));
	}

	// Token: 0x06011362 RID: 70498 RVA: 0x0043235C File Offset: 0x0043055C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(this.OnTaskUpdate));
	}

	// Token: 0x06011363 RID: 70499 RVA: 0x0043237A File Offset: 0x0043057A
	private void OnTaskUpdate()
	{
		new UiAsyncTask("TabUpdate", delegate()
		{
			MotorcycleTaskTabView.<<OnTaskUpdate>b__9_0>d <<OnTaskUpdate>b__9_0>d;
			<<OnTaskUpdate>b__9_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnTaskUpdate>b__9_0>d.<>4__this = this;
			<<OnTaskUpdate>b__9_0>d.<>1__state = -1;
			<<OnTaskUpdate>b__9_0>d.<>t__builder.Start<MotorcycleTaskTabView.<<OnTaskUpdate>b__9_0>d>(ref <<OnTaskUpdate>b__9_0>d);
			return <<OnTaskUpdate>b__9_0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x06011364 RID: 70500 RVA: 0x0043239C File Offset: 0x0043059C
	private UniTask OnTabUpdateAsync()
	{
		MotorcycleTaskTabView.<OnTabUpdateAsync>d__10 <OnTabUpdateAsync>d__;
		<OnTabUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabUpdateAsync>d__.<>4__this = this;
		<OnTabUpdateAsync>d__.<>1__state = -1;
		<OnTabUpdateAsync>d__.<>t__builder.Start<MotorcycleTaskTabView.<OnTabUpdateAsync>d__10>(ref <OnTabUpdateAsync>d__);
		return <OnTabUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011365 RID: 70501 RVA: 0x004323E0 File Offset: 0x004305E0
	private void ToggleCallBack(int index)
	{
		List<int> activatedTreeTypeList = MotorcycleDevelopModel.Instance.GetActivatedTreeTypeList();
		this.TreeType = activatedTreeTypeList[index];
		MotorcycleDevelopModel.Instance.UpdateSelectedTreeType(this.TreeType);
		this.RefreshTaskList();
		this.RefreshOther();
		if (MotorcycleDevelopModel.Instance.RedDotHasNewTechTree(this.TreeType))
		{
			MotorcycleDevelopModel.Instance.UpdateTechTreeNewUnlocked(this.TreeType, false);
			EventSystem.Instance.Emit(EEventName.MotorDevelopTreeTypeRedDotUpdate);
		}
	}

	// Token: 0x06011366 RID: 70502 RVA: 0x00432454 File Offset: 0x00430654
	private void RefreshTaskList()
	{
		MotorcycleTaskTabView.<>c__DisplayClass12_0 CS$<>8__locals1 = new MotorcycleTaskTabView.<>c__DisplayClass12_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.taskList = MotorcycleDevelopModel.Instance.GetTaskListByTree(this.TreeType);
		new UiAsyncTask("TaskListUpdate", delegate()
		{
			MotorcycleTaskTabView.<>c__DisplayClass12_0.<<RefreshTaskList>b__0>d <<RefreshTaskList>b__0>d;
			<<RefreshTaskList>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshTaskList>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshTaskList>b__0>d.<>1__state = -1;
			<<RefreshTaskList>b__0>d.<>t__builder.Start<MotorcycleTaskTabView.<>c__DisplayClass12_0.<<RefreshTaskList>b__0>d>(ref <<RefreshTaskList>b__0>d);
			return <<RefreshTaskList>b__0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x06011367 RID: 70503 RVA: 0x004324A4 File Offset: 0x004306A4
	private void RefreshOther()
	{
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(this.TreeType);
		if (motorTechTreeConfig == null)
		{
			return;
		}
		int costPointByTree = MotorcycleDevelopModel.Instance.GetCostPointByTree(this.TreeType);
		int freePointByTree = MotorcycleDevelopModel.Instance.GetFreePointByTree(this.TreeType);
		int totalPointByTree = MotorcycleDevelopModel.Instance.GetTotalPointByTree(this.TreeType);
		int num = costPointByTree + freePointByTree;
		float fillAmount = (float)num / (float)totalPointByTree;
		string icon = ItemConfig.Instance.GetConfig(motorTechTreeConfig.Value.TpItemId).Value.Icon;
		base.GetSprite(5).SetFillAmount(fillAmount);
		base.GetText(2).SetText(num.ToString() + "/" + totalPointByTree.ToString(), true);
		base.SetTextureByPath(icon, base.GetTexture(8), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "MotorBike_TechCube_CurrentAvailable", new <>z__ReadOnlySingleElementList<object>(freePointByTree));
	}

	// Token: 0x06011368 RID: 70504 RVA: 0x004325A4 File Offset: 0x004307A4
	private MotorcycleTreeTypeTabItem InitTreeTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTreeTypeTabItem();
	}

	// Token: 0x06011369 RID: 70505 RVA: 0x004325AB File Offset: 0x004307AB
	private MotorcycleTaskItem InitTaskItem()
	{
		return new MotorcycleTaskItem();
	}

	// Token: 0x0601136A RID: 70506 RVA: 0x004325B2 File Offset: 0x004307B2
	private void OnBtnAskClick()
	{
		HelpController.Instance.OpenHelpById(471);
	}

	// Token: 0x0601136B RID: 70507 RVA: 0x004325C4 File Offset: 0x004307C4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string text = configParams[0];
		if (text == "Tab")
		{
			int index = int.Parse(configParams[1]);
			TabComponent<MotorcycleTreeTypeTabItem> tabComponent = this.TabComponent;
			MotorcycleTreeTypeTabItem motorcycleTreeTypeTabItem = (tabComponent != null) ? tabComponent.GetTabItemByIndex(index) : null;
			UUIItem uuiitem = (motorcycleTreeTypeTabItem != null) ? motorcycleTreeTypeTabItem.GetRootItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else
		{
			if (!text.Contains("Reward"))
			{
				return null;
			}
			int gridIndex = int.Parse(configParams[1]);
			LoopScrollView<MotorcycleTaskItem, MotorTechTaskNode> taskLoopScroll = this.TaskLoopScroll;
			MotorcycleTaskItem motorcycleTaskItem = (taskLoopScroll != null) ? taskLoopScroll.UnsafeGetGridProxy(gridIndex, false) : null;
			UUIItem uuiitem2 = (motorcycleTaskItem != null) ? motorcycleTaskItem.GetBtnGet() : null;
			UUIItem uuiitem3 = (motorcycleTaskItem != null) ? motorcycleTaskItem.GetNavigationItem() : null;
			if (motorcycleTaskItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem3
			};
		}
	}

	// Token: 0x040082FB RID: 33531
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleTreeTypeTabItem> TabComponent;

	// Token: 0x040082FC RID: 33532
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleTaskItem, MotorTechTaskNode> TaskLoopScroll;

	// Token: 0x040082FD RID: 33533
	private int TreeType;

	// Token: 0x020087A0 RID: 34720
	[NullableContext(0)]
	private class EMotorTaskComponent
	{
		// Token: 0x0402C13A RID: 180538
		public const int LoopScrollView = 0;

		// Token: 0x0402C13B RID: 180539
		public const int PnlItem = 1;

		// Token: 0x0402C13C RID: 180540
		public const int TxtProgress = 2;

		// Token: 0x0402C13D RID: 180541
		public const int TxtCurFree = 3;

		// Token: 0x0402C13E RID: 180542
		public const int BtnAsk = 4;

		// Token: 0x0402C13F RID: 180543
		public const int SprProgress = 5;

		// Token: 0x0402C140 RID: 180544
		public const int TabLayout = 6;

		// Token: 0x0402C141 RID: 180545
		public const int TabItem = 7;

		// Token: 0x0402C142 RID: 180546
		public const int TexIcon = 8;
	}
}
