using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001366 RID: 4966
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingTaskView : UiViewBase
{
	// Token: 0x06008A6A RID: 35434 RVA: 0x001D931A File Offset: 0x001D751A
	public MoonChasingTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008A6B RID: 35435 RVA: 0x001D9324 File Offset: 0x001D7524
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

	// Token: 0x06008A6C RID: 35436 RVA: 0x001D9414 File Offset: 0x001D7614
	private UniTask InitPopularity()
	{
		MoonChasingTaskView.<InitPopularity>d__8 <InitPopularity>d__;
		<InitPopularity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopularity>d__.<>4__this = this;
		<InitPopularity>d__.<>1__state = -1;
		<InitPopularity>d__.<>t__builder.Start<MoonChasingTaskView.<InitPopularity>d__8>(ref <InitPopularity>d__);
		return <InitPopularity>d__.<>t__builder.Task;
	}

	// Token: 0x06008A6D RID: 35437 RVA: 0x001D9458 File Offset: 0x001D7658
	private UniTask InitCaptionItem()
	{
		MoonChasingTaskView.<InitCaptionItem>d__9 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<MoonChasingTaskView.<InitCaptionItem>d__9>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008A6E RID: 35438 RVA: 0x001D949B File Offset: 0x001D769B
	private void InitToggle()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(new Func<bool>(this.MainLineCanChange));
		base.GetExtendToggle(2).CanExecuteChange.Bind(new Func<bool>(this.BranchLineCanChange));
	}

	// Token: 0x06008A6F RID: 35439 RVA: 0x001D94D8 File Offset: 0x001D76D8
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008A70 RID: 35440 RVA: 0x001D951C File Offset: 0x001D771C
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

	// Token: 0x06008A71 RID: 35441 RVA: 0x001D95BD File Offset: 0x001D77BD
	protected override void OnBeforeShow()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.MoonChasingMainlineTab, base.GetItem(5), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.MoonChasingBranchTab, base.GetItem(6), null, 0);
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06008A72 RID: 35442 RVA: 0x001D95F9 File Offset: 0x001D77F9
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.MoonChasingMainlineTab);
		RedDotController.Instance.UnBindRedDot(ERedDotName.MoonChasingBranchTab);
	}

	// Token: 0x06008A73 RID: 35443 RVA: 0x001D961C File Offset: 0x001D781C
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

	// Token: 0x06008A74 RID: 35444 RVA: 0x001D9670 File Offset: 0x001D7870
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

	// Token: 0x06008A75 RID: 35445 RVA: 0x001D96BC File Offset: 0x001D78BC
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

	// Token: 0x06008A76 RID: 35446 RVA: 0x001D9724 File Offset: 0x001D7924
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

	// Token: 0x06008A77 RID: 35447 RVA: 0x001D978C File Offset: 0x001D798C
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

	// Token: 0x06008A78 RID: 35448 RVA: 0x001D97FF File Offset: 0x001D79FF
	private bool MainLineCanChange()
	{
		return this.TaskViewData.TaskType == EMoonChasingTaskType.BranchLine;
	}

	// Token: 0x06008A79 RID: 35449 RVA: 0x001D980F File Offset: 0x001D7A0F
	private bool BranchLineCanChange()
	{
		return this.TaskViewData.TaskType != EMoonChasingTaskType.BranchLine;
	}

	// Token: 0x06008A7A RID: 35450 RVA: 0x001D9822 File Offset: 0x001D7A22
	private void OnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008A7B RID: 35451 RVA: 0x001D982C File Offset: 0x001D7A2C
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

	// Token: 0x04003DAB RID: 15787
	private PopularityModule Popularity;

	// Token: 0x04003DAC RID: 15788
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003DAD RID: 15789
	private TaskBranchLineModule BranchLine;

	// Token: 0x04003DAE RID: 15790
	private TaskMainLineModule MainLine;

	// Token: 0x04003DAF RID: 15791
	private UUIInturnAnimController AnimationController;

	// Token: 0x04003DB0 RID: 15792
	private MoonChasingTaskViewData TaskViewData;

	// Token: 0x020079CE RID: 31182
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028183 RID: 164227
		public const int CaptionItem = 0;

		// Token: 0x04028184 RID: 164228
		public const int ContentItem = 1;

		// Token: 0x04028185 RID: 164229
		public const int BranchLineToggle = 2;

		// Token: 0x04028186 RID: 164230
		public const int MainLineToggle = 3;

		// Token: 0x04028187 RID: 164231
		public const int PopularityItem = 4;

		// Token: 0x04028188 RID: 164232
		public const int MainlineRedDotItem = 5;

		// Token: 0x04028189 RID: 164233
		public const int BranchRedDotItem = 6;
	}
}
