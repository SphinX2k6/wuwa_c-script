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

// Token: 0x02001753 RID: 5971
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTaskTabView : UiTabViewBase
{
	// Token: 0x0600E7F4 RID: 59380 RVA: 0x0043ED50 File Offset: 0x0043CF50
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

	// Token: 0x0600E7F5 RID: 59381 RVA: 0x0043EE54 File Offset: 0x0043D054
	protected override void OnStart()
	{
		this.TabComponent = new TabComponent<MotorcycleTreeTypeTabItem>(base.GetHorizontalLayout(6).RootUIComp.Get(), new Func<UUIItem, int?, MotorcycleTreeTypeTabItem>(this.InitTreeTabItem), new Action<int>(this.ToggleCallBack), base.GetItem(7));
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(0);
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.TaskLoopScroll = new LoopScrollView<MotorcycleTaskItem, MotorTechTaskNode>(loopScrollViewComponent, gridActor, new Func<MotorcycleTaskItem>(this.InitTaskItem), true);
	}

	// Token: 0x0600E7F6 RID: 59382 RVA: 0x0043EED4 File Offset: 0x0043D0D4
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

	// Token: 0x0600E7F7 RID: 59383 RVA: 0x0043EF4A File Offset: 0x0043D14A
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(this.OnTaskUpdate));
	}

	// Token: 0x0600E7F8 RID: 59384 RVA: 0x0043EF68 File Offset: 0x0043D168
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(this.OnTaskUpdate));
	}

	// Token: 0x0600E7F9 RID: 59385 RVA: 0x0043EF86 File Offset: 0x0043D186
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

	// Token: 0x0600E7FA RID: 59386 RVA: 0x0043EFA8 File Offset: 0x0043D1A8
	private UniTask OnTabUpdateAsync()
	{
		MotorcycleTaskTabView.<OnTabUpdateAsync>d__10 <OnTabUpdateAsync>d__;
		<OnTabUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabUpdateAsync>d__.<>4__this = this;
		<OnTabUpdateAsync>d__.<>1__state = -1;
		<OnTabUpdateAsync>d__.<>t__builder.Start<MotorcycleTaskTabView.<OnTabUpdateAsync>d__10>(ref <OnTabUpdateAsync>d__);
		return <OnTabUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E7FB RID: 59387 RVA: 0x0043EFEC File Offset: 0x0043D1EC
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

	// Token: 0x0600E7FC RID: 59388 RVA: 0x0043F060 File Offset: 0x0043D260
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

	// Token: 0x0600E7FD RID: 59389 RVA: 0x0043F0B0 File Offset: 0x0043D2B0
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

	// Token: 0x0600E7FE RID: 59390 RVA: 0x0043F1B0 File Offset: 0x0043D3B0
	private MotorcycleTreeTypeTabItem InitTreeTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTreeTypeTabItem();
	}

	// Token: 0x0600E7FF RID: 59391 RVA: 0x0043F1B7 File Offset: 0x0043D3B7
	private MotorcycleTaskItem InitTaskItem()
	{
		return new MotorcycleTaskItem();
	}

	// Token: 0x0600E800 RID: 59392 RVA: 0x0043F1BE File Offset: 0x0043D3BE
	private void OnBtnAskClick()
	{
		HelpController.Instance.OpenHelpById(471);
	}

	// Token: 0x0600E801 RID: 59393 RVA: 0x0043F1D0 File Offset: 0x0043D3D0
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

	// Token: 0x04008439 RID: 33849
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleTreeTypeTabItem> TabComponent;

	// Token: 0x0400843A RID: 33850
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleTaskItem, MotorTechTaskNode> TaskLoopScroll;

	// Token: 0x0400843B RID: 33851
	private int TreeType;

	// Token: 0x02007929 RID: 31017
	[NullableContext(0)]
	private class EMotorTaskComponent
	{
		// Token: 0x04027452 RID: 160850
		public const int LoopScrollView = 0;

		// Token: 0x04027453 RID: 160851
		public const int PnlItem = 1;

		// Token: 0x04027454 RID: 160852
		public const int TxtProgress = 2;

		// Token: 0x04027455 RID: 160853
		public const int TxtCurFree = 3;

		// Token: 0x04027456 RID: 160854
		public const int BtnAsk = 4;

		// Token: 0x04027457 RID: 160855
		public const int SprProgress = 5;

		// Token: 0x04027458 RID: 160856
		public const int TabLayout = 6;

		// Token: 0x04027459 RID: 160857
		public const int TabItem = 7;

		// Token: 0x0402745A RID: 160858
		public const int TexIcon = 8;
	}
}
