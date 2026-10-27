using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001007 RID: 4103
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingGameView : UiTickViewBase
{
	// Token: 0x06006934 RID: 26932 RVA: 0x0014F3EC File Offset: 0x0014D5EC
	public GolemHackingGameView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006935 RID: 26933 RVA: 0x0014F3F8 File Offset: 0x0014D5F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006936 RID: 26934 RVA: 0x0014F484 File Offset: 0x0014D684
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingGameView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingGameView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006937 RID: 26935 RVA: 0x0014F4C8 File Offset: 0x0014D6C8
	protected override void OnBeforeDestroy()
	{
		if (this.ActivityData != null)
		{
			this.ActivityData.SetCurrentId(null);
		}
	}

	// Token: 0x06006938 RID: 26936 RVA: 0x0014F4F1 File Offset: 0x0014D6F1
	protected override void OnAfterShow()
	{
		this.Proxy.SetCanInteractive(true);
	}

	// Token: 0x06006939 RID: 26937 RVA: 0x0014F4FF File Offset: 0x0014D6FF
	protected override void OnTick(float delta)
	{
		this.MatrixPanel.OnTick(delta);
	}

	// Token: 0x0600693A RID: 26938 RVA: 0x0014F510 File Offset: 0x0014D710
	private void OnClickedClose()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(this.IsMainLevel ? EConfirmBoxConfigId.GolemHackingMainLevelExitConfirm : EConfirmBoxConfigId.GolemHackingNormalLevelExitConfirm);
		if (!this.IsMainLevel)
		{
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				this.Proxy.Reset();
				this.Proxy.LogReport(EGolemHackingReportType.Reset, false);
				this.OpenLogReport();
				this.Proxy.FailCount = 0;
				this.Proxy.ResetCount = 0;
			};
		}
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			if (GolemHackingController.Instance.IsActivityOpen)
			{
				this.Proxy.FailCount++;
				this.Proxy.LogReport(EGolemHackingReportType.Fail, false);
			}
			this.CloseCallback(this.IsMainLevel);
			base.CloseMe(null);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600693B RID: 26939 RVA: 0x0014F582 File Offset: 0x0014D782
	private void OnSuccessCallback()
	{
		this.CloseCallback(true);
		base.CloseMe(null);
	}

	// Token: 0x0600693C RID: 26940 RVA: 0x0014F598 File Offset: 0x0014D798
	private void OpenLogReport()
	{
		GolemHackingController instance = GolemHackingController.Instance;
		if (!instance.IsActivityOpen)
		{
			return;
		}
		int activityOpenTime = (int)TimeUtil.Instance.GetServerTime();
		instance.ActivityOpenTime = activityOpenTime;
		int cacheLevelId = instance.CacheLevelId;
		GolemHackingLevelInfo levelInfo = instance.GetActivityData().GetLevelInfo(cacheLevelId);
		GolemHackingStartEvent golemHackingStartEvent = new GolemHackingStartEvent();
		golemHackingStartEvent.i_id = cacheLevelId;
		golemHackingStartEvent.i_type = (instance.CacheHardMode ? 2 : 1);
		golemHackingStartEvent.s_trace_id = activityOpenTime.ToString();
		bool flag = levelInfo.State == GolemCrackState.GolemCrackFinished;
		golemHackingStartEvent.i_first_pass = ((!flag) ? 1 : 0);
		LogReportController.Instance.LogReport(golemHackingStartEvent);
	}

	// Token: 0x0600693D RID: 26941 RVA: 0x0014F628 File Offset: 0x0014D828
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 2 && configParams[0] == "Left_Col_Panel")
		{
			int index = int.Parse(configParams[1]);
			GolemHackingMatrixVerticalPanel verticalPanelByIndex = this.MatrixPanel.GetVerticalPanelByIndex(index);
			if (verticalPanelByIndex == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				verticalPanelByIndex.GetRootItem(),
				verticalPanelByIndex.GetRootItem()
			};
		}
		else if (configParams.Length == 2 && (configParams[0] == "Left_Item" || configParams[0] == "New:Left_Item"))
		{
			int index2 = int.Parse(configParams[1]);
			GolemHackingMatrixCodeButton codeButtonByIndex = this.MatrixPanel.GetCodeButtonByIndex(index2);
			if (codeButtonByIndex == null)
			{
				return null;
			}
			string a = configParams[0];
			if (!(a == "Left_Item"))
			{
				if (a == "New:Left_Item")
				{
					UUIItem codeButtonNavListenerByIndex = this.MatrixPanel.GetCodeButtonNavListenerByIndex(index2);
					if (codeButtonNavListenerByIndex != null)
					{
						return new UUIItem[]
						{
							codeButtonByIndex.GetRootItem(),
							codeButtonNavListenerByIndex
						};
					}
				}
				return null;
			}
			return new UUIItem[]
			{
				codeButtonByIndex.GetRootItem(),
				codeButtonByIndex.GetRootItem()
			};
		}
		else
		{
			if (configParams.Length != 2 || !(configParams[0] == "Right_Row_Panel"))
			{
				return null;
			}
			int index3 = int.Parse(configParams[1]);
			GolemHackingCodeKeyListItem horizontalPanelByIndex = this.HackingPanel.GetHorizontalPanelByIndex(index3);
			if (horizontalPanelByIndex == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				horizontalPanelByIndex.GetRootItem(),
				horizontalPanelByIndex.GetRootItem()
			};
		}
	}

	// Token: 0x0600693E RID: 26942 RVA: 0x0014F778 File Offset: 0x0014D978
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x04003074 RID: 12404
	private const int HELP_ID = 577;

	// Token: 0x04003075 RID: 12405
	protected Action<bool> CloseCallback;

	// Token: 0x04003076 RID: 12406
	protected PopupCaptionItem Caption;

	// Token: 0x04003077 RID: 12407
	protected GolemHackingGameProxy Proxy;

	// Token: 0x04003078 RID: 12408
	protected GolemHackingMatrixPanel MatrixPanel;

	// Token: 0x04003079 RID: 12409
	protected GolemHackingCodePanel HackingPanel;

	// Token: 0x0400307A RID: 12410
	protected bool IsMainLevel;

	// Token: 0x0400307B RID: 12411
	protected int ConfigId;

	// Token: 0x0400307C RID: 12412
	[Nullable(2)]
	protected GolemHackingActivityData ActivityData;

	// Token: 0x020075FF RID: 30207
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026FC2 RID: 159682
		CaptionItem,
		// Token: 0x04026FC3 RID: 159683
		MatrixPanel,
		// Token: 0x04026FC4 RID: 159684
		HackingPanel
	}
}
