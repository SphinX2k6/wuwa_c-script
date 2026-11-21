using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020004BB RID: 1211
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingGameView : UiTickViewBase
{
	// Token: 0x06003CC9 RID: 15561 RVA: 0x00157D14 File Offset: 0x00155F14
	public GolemHackingGameView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06003CCA RID: 15562 RVA: 0x00157D20 File Offset: 0x00155F20
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

	// Token: 0x06003CCB RID: 15563 RVA: 0x00157DAC File Offset: 0x00155FAC
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingGameView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingGameView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003CCC RID: 15564 RVA: 0x00157DF0 File Offset: 0x00155FF0
	protected override void OnBeforeDestroy()
	{
		if (this.ActivityData != null)
		{
			this.ActivityData.SetCurrentId(null);
		}
	}

	// Token: 0x06003CCD RID: 15565 RVA: 0x00157E19 File Offset: 0x00156019
	protected override void OnAfterShow()
	{
		this.Proxy.SetCanInteractive(true);
	}

	// Token: 0x06003CCE RID: 15566 RVA: 0x00157E27 File Offset: 0x00156027
	protected override void OnTick(float delta)
	{
		this.MatrixPanel.OnTick(delta);
	}

	// Token: 0x06003CCF RID: 15567 RVA: 0x00157E38 File Offset: 0x00156038
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

	// Token: 0x06003CD0 RID: 15568 RVA: 0x00157EAA File Offset: 0x001560AA
	private void OnSuccessCallback()
	{
		this.CloseCallback(true);
		base.CloseMe(null);
	}

	// Token: 0x06003CD1 RID: 15569 RVA: 0x00157EC0 File Offset: 0x001560C0
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

	// Token: 0x06003CD2 RID: 15570 RVA: 0x00157F50 File Offset: 0x00156150
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

	// Token: 0x06003CD3 RID: 15571 RVA: 0x001580A0 File Offset: 0x001562A0
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0400310D RID: 12557
	private const int HELP_ID = 577;

	// Token: 0x0400310E RID: 12558
	protected Action<bool> CloseCallback;

	// Token: 0x0400310F RID: 12559
	protected PopupCaptionItem Caption;

	// Token: 0x04003110 RID: 12560
	protected GolemHackingGameProxy Proxy;

	// Token: 0x04003111 RID: 12561
	protected GolemHackingMatrixPanel MatrixPanel;

	// Token: 0x04003112 RID: 12562
	protected GolemHackingCodePanel HackingPanel;

	// Token: 0x04003113 RID: 12563
	protected bool IsMainLevel;

	// Token: 0x04003114 RID: 12564
	protected int ConfigId;

	// Token: 0x04003115 RID: 12565
	[Nullable(2)]
	protected GolemHackingActivityData ActivityData;

	// Token: 0x02006793 RID: 26515
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402230D RID: 140045
		CaptionItem,
		// Token: 0x0402230E RID: 140046
		MatrixPanel,
		// Token: 0x0402230F RID: 140047
		HackingPanel
	}
}
