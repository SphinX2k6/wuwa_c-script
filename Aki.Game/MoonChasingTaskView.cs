using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200081A RID: 2074
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingTaskView : UiViewBase
{
	// Token: 0x06005E05 RID: 24069 RVA: 0x001E2176 File Offset: 0x001E0376
	public MoonChasingTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005E06 RID: 24070 RVA: 0x001E2180 File Offset: 0x001E0380
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnBranchLine)),
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnMainLine))
		};
	}

	// Token: 0x06005E07 RID: 24071 RVA: 0x001E2270 File Offset: 0x001E0470
	private UniTask InitPopularity()
	{
		MoonChasingTaskView.<InitPopularity>d__8 <InitPopularity>d__;
		<InitPopularity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopularity>d__.<>4__this = this;
		<InitPopularity>d__.<>1__state = -1;
		<InitPopularity>d__.<>t__builder.Start<MoonChasingTaskView.<InitPopularity>d__8>(ref <InitPopularity>d__);
		return <InitPopularity>d__.<>t__builder.Task;
	}

	// Token: 0x06005E08 RID: 24072 RVA: 0x001E22B4 File Offset: 0x001E04B4
	private UniTask InitCaptionItem()
	{
		MoonChasingTaskView.<InitCaptionItem>d__9 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<MoonChasingTaskView.<InitCaptionItem>d__9>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005E09 RID: 24073 RVA: 0x001E22F7 File Offset: 0x001E04F7
	private void InitToggle()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(new Func<bool>(this.MainLineCanChange));
		base.GetExtendToggle(2).CanExecuteChange.Bind(new Func<bool>(this.BranchLineCanChange));
	}

	// Token: 0x06005E0A RID: 24074 RVA: 0x001E2334 File Offset: 0x001E0534
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005E0B RID: 24075 RVA: 0x001E2378 File Offset: 0x001E0578
	protected override void OnStart()
	{
		this.TaskViewData = (MoonChasingTaskViewData)this.OpenParam;
		if (this.TaskViewData == null)
		{
			Log.Instance.Error(ELogModule.MoonChasing, ELogAuthor.BB, "MoonChasingTaskView Invalid OpenParam", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.InitToggle();
		this.AnimationController = (UUIInturnAnimController)base.GetItem(1).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass());
		if (this.TaskViewData.TaskType == EMoonChasingTaskType.MainLine)
		{
			base.GetExtendToggle(3).SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
			return;
		}
		base.GetExtendToggle(2).SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06005E0C RID: 24076 RVA: 0x001E2419 File Offset: 0x001E0619
	protected override void OnBeforeShow()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.MoonChasingMainlineTab, base.GetItem(5), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.MoonChasingBranchTab, base.GetItem(6), null, 0);
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06005E0D RID: 24077 RVA: 0x001E2455 File Offset: 0x001E0655
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.MoonChasingMainlineTab);
		RedDotController.Instance.UnBindRedDot(ERedDotName.MoonChasingBranchTab);
	}

	// Token: 0x06005E0E RID: 24078 RVA: 0x001E2478 File Offset: 0x001E0678
	private UniTask CreateAndShowMainLine(int taskId, bool isLastTask)
	{
		MoonChasingTaskView.<CreateAndShowMainLine>d__15 <CreateAndShowMainLine>d__;
		<CreateAndShowMainLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAndShowMainLine>d__.<>4__this = this;
		<CreateAndShowMainLine>d__.taskId = taskId;
		<CreateAndShowMainLine>d__.isLastTask = isLastTask;
		<CreateAndShowMainLine>d__.<>1__state = -1;
		<CreateAndShowMainLine>d__.<>t__builder.Start<MoonChasingTaskView.<CreateAndShowMainLine>d__15>(ref <CreateAndShowMainLine>d__);
		return <CreateAndShowMainLine>d__.<>t__builder.Task;
	}

	// Token: 0x06005E0F RID: 24079 RVA: 0x001E24CC File Offset: 0x001E06CC
	private UniTask CreateAndShowBranchLine(int taskId)
	{
		MoonChasingTaskView.<CreateAndShowBranchLine>d__16 <CreateAndShowBranchLine>d__;
		<CreateAndShowBranchLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAndShowBranchLine>d__.<>4__this = this;
		<CreateAndShowBranchLine>d__.taskId = taskId;
		<CreateAndShowBranchLine>d__.<>1__state = -1;
		<CreateAndShowBranchLine>d__.<>t__builder.Start<MoonChasingTaskView.<CreateAndShowBranchLine>d__16>(ref <CreateAndShowBranchLine>d__);
		return <CreateAndShowBranchLine>d__.<>t__builder.Task;
	}

	// Token: 0x06005E10 RID: 24080 RVA: 0x001E2518 File Offset: 0x001E0718
	private void SwitchHierarchyIndex(int index)
	{
		UUIItem uuiitem = base.GetExtendToggle(3).RootUIComp.Get();
		UUIItem uuiitem2 = base.GetExtendToggle(2).RootUIComp.Get();
		int hierarchyIndex = uuiitem.GetHierarchyIndex();
		int hierarchyIndex2 = uuiitem2.GetHierarchyIndex();
		if ((hierarchyIndex > hierarchyIndex2 && index == 0) || (hierarchyIndex < hierarchyIndex2 && index == 1))
		{
			return;
		}
		uuiitem.SetHierarchyIndex(hierarchyIndex2);
		uuiitem2.SetHierarchyIndex(hierarchyIndex);
	}

	// Token: 0x06005E11 RID: 24081 RVA: 0x001E2580 File Offset: 0x001E0780
	private void OnBranchLine(EToggleState state)
	{
		this.TaskViewData.TaskType = EMoonChasingTaskType.BranchLine;
		if (this.MainLine != null)
		{
			this.MainLine.SetActive(false);
		}
		base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CreateAndShowBranchLine(this.TaskViewData.TargetTaskId).ContinueWith(delegate()
		{
			UUIInturnAnimController animationController = this.AnimationController;
			if (animationController == null)
			{
				return;
			}
			animationController.Play("", -1, false);
		});
		this.SwitchHierarchyIndex(1);
	}

	// Token: 0x06005E12 RID: 24082 RVA: 0x001E25E8 File Offset: 0x001E07E8
	private void OnMainLine(EToggleState state)
	{
		this.TaskViewData.TaskType = EMoonChasingTaskType.MainLine;
		if (this.BranchLine != null)
		{
			this.BranchLine.SetActive(false);
		}
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CreateAndShowMainLine(this.TaskViewData.TargetTaskId, this.TaskViewData.IsLastTask).ContinueWith(delegate()
		{
			UUIInturnAnimController animationController = this.AnimationController;
			if (animationController == null)
			{
				return;
			}
			animationController.Play("", -1, false);
		});
		this.SwitchHierarchyIndex(0);
	}

	// Token: 0x06005E13 RID: 24083 RVA: 0x001E265B File Offset: 0x001E085B
	private bool MainLineCanChange()
	{
		return this.TaskViewData.TaskType == EMoonChasingTaskType.BranchLine;
	}

	// Token: 0x06005E14 RID: 24084 RVA: 0x001E266B File Offset: 0x001E086B
	private bool BranchLineCanChange()
	{
		return this.TaskViewData.TaskType != EMoonChasingTaskType.BranchLine;
	}

	// Token: 0x06005E15 RID: 24085 RVA: 0x001E267E File Offset: 0x001E087E
	private void OnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005E16 RID: 24086 RVA: 0x001E2688 File Offset: 0x001E0888
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "Main")
		{
			if (this.MainLine == null)
			{
				return null;
			}
			return this.MainLine.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			if (!(a == "Branch"))
			{
				return null;
			}
			if (this.BranchLine == null)
			{
				return null;
			}
			return this.BranchLine.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x04003E43 RID: 15939
	private PopularityModule Popularity;

	// Token: 0x04003E44 RID: 15940
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003E45 RID: 15941
	private TaskBranchLineModule BranchLine;

	// Token: 0x04003E46 RID: 15942
	private TaskMainLineModule MainLine;

	// Token: 0x04003E47 RID: 15943
	private UUIInturnAnimController AnimationController;

	// Token: 0x04003E48 RID: 15944
	private MoonChasingTaskViewData TaskViewData;

	// Token: 0x02006B58 RID: 27480
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040234B0 RID: 144560
		public const int CaptionItem = 0;

		// Token: 0x040234B1 RID: 144561
		public const int ContentItem = 1;

		// Token: 0x040234B2 RID: 144562
		public const int BranchLineToggle = 2;

		// Token: 0x040234B3 RID: 144563
		public const int MainLineToggle = 3;

		// Token: 0x040234B4 RID: 144564
		public const int PopularityItem = 4;

		// Token: 0x040234B5 RID: 144565
		public const int MainlineRedDotItem = 5;

		// Token: 0x040234B6 RID: 144566
		public const int BranchRedDotItem = 6;
	}
}
