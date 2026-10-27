using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D56 RID: 11606
public class WeeklyRogueSelectArtifactView : UiViewBase
{
	// Token: 0x06018639 RID: 99897 RVA: 0x00635E3E File Offset: 0x0063403E
	[NullableContext(1)]
	public WeeklyRogueSelectArtifactView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601863A RID: 99898 RVA: 0x00635E48 File Offset: 0x00634048
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnBtnConfirm))
		};
	}

	// Token: 0x0601863B RID: 99899 RVA: 0x00635EDC File Offset: 0x006340DC
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSelectArtifactView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSelectArtifactView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601863C RID: 99900 RVA: 0x00635F1F File Offset: 0x0063411F
	protected override void OnBeforeShow()
	{
		this.TokenLayout.PlayGridAnim();
	}

	// Token: 0x0601863D RID: 99901 RVA: 0x00635F2C File Offset: 0x0063412C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x0601863E RID: 99902 RVA: 0x00635F4A File Offset: 0x0063414A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x0601863F RID: 99903 RVA: 0x00635F68 File Offset: 0x00634168
	private void OnCycleRefresh()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeeklyRogueCycleRefresh);
		confirmBoxDataNew.FunctionMap.Add(1, new Action(WeeklyRogueSelectArtifactView.<OnCycleRefresh>g__ConfirmCallback|9_0));
		confirmBoxDataNew.FunctionMap.Add(0, new Action(WeeklyRogueSelectArtifactView.<OnCycleRefresh>g__ConfirmCallback|9_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06018640 RID: 99904 RVA: 0x00635FBC File Offset: 0x006341BC
	[NullableContext(1)]
	private WeeklyRogueArtifactItem CreateTokenItem()
	{
		return new WeeklyRogueArtifactItem
		{
			OnSelectedChange = new Action<int?>(this.OnSelectChange)
		};
	}

	// Token: 0x06018641 RID: 99905 RVA: 0x00635FD8 File Offset: 0x006341D8
	private void OnSelectChange(int? selectIndex)
	{
		if (selectIndex == null)
		{
			GenericLayout<WeeklyRogueArtifactItem, RogueWeeklyEntry> tokenLayout = this.TokenLayout;
			if (tokenLayout != null)
			{
				tokenLayout.DeselectCurrentGridProxy();
			}
			base.GetButton(3).SetSelfInteractive(false);
			return;
		}
		GenericLayout<WeeklyRogueArtifactItem, RogueWeeklyEntry> tokenLayout2 = this.TokenLayout;
		if (tokenLayout2 != null)
		{
			tokenLayout2.SelectGridProxy(selectIndex.Value, false);
		}
		base.GetButton(3).SetSelfInteractive(true);
	}

	// Token: 0x06018642 RID: 99906 RVA: 0x00636034 File Offset: 0x00634234
	private void OnBtnConfirm()
	{
		UiLayer.Instance.SetShowMaskLayer("WeeklyRogueSelectArtifactView.SelectArtifactRequest", true);
		WeeklyRogueController.Instance.SelectArtifactRequest().ContinueWith(delegate(bool success)
		{
			if (success)
			{
				List<int> selectRoleIdList = WeeklyRogueModel.Instance.SelectRoleIdList;
				WeeklyRogueController.Instance.RogueWeeklyStartRequest(selectRoleIdList);
			}
			UiLayer.Instance.SetShowMaskLayer("WeeklyRogueSelectArtifactView.SelectArtifactRequest", false);
		});
	}

	// Token: 0x06018643 RID: 99907 RVA: 0x00636080 File Offset: 0x00634280
	private void OnBtnBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06018644 RID: 99908 RVA: 0x00636089 File Offset: 0x00634289
	[CompilerGenerated]
	internal static void <OnCycleRefresh>g__ConfirmCallback|9_0()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x0400B4F4 RID: 46324
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueArtifactItem, RogueWeeklyEntry> TokenLayout;

	// Token: 0x0400B4F5 RID: 46325
	[Nullable(2)]
	private WeeklyRogueCaptionItem CaptionItem;

	// Token: 0x020092EF RID: 37615
	private enum EWeeklyRogueSelectTokenDefine
	{
		// Token: 0x0402F7DF RID: 194527
		CaptionItem,
		// Token: 0x0402F7E0 RID: 194528
		ArtifactLayout,
		// Token: 0x0402F7E1 RID: 194529
		ArtifactItem,
		// Token: 0x0402F7E2 RID: 194530
		BtnConfirm
	}
}
