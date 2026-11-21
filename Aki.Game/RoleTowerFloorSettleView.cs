using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CCE RID: 7374
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerFloorSettleView : UiViewBase
{
	// Token: 0x0601242D RID: 74797 RVA: 0x0056208F File Offset: 0x0056028F
	[NullableContext(1)]
	public RoleTowerFloorSettleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B6D RID: 7021
	// (get) Token: 0x0601242E RID: 74798 RVA: 0x00562098 File Offset: 0x00560298
	private new RoleTowerFloorSettleViewParams OpenParam
	{
		get
		{
			return this.OpenParam as RoleTowerFloorSettleViewParams;
		}
	}

	// Token: 0x0601242F RID: 74799 RVA: 0x005620A8 File Offset: 0x005602A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickRestart)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickContinue))
		};
	}

	// Token: 0x06012430 RID: 74800 RVA: 0x0056216C File Offset: 0x0056036C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerFloorSettleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerFloorSettleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012431 RID: 74801 RVA: 0x005621AF File Offset: 0x005603AF
	protected override void OnStart()
	{
		this.HasShown = false;
	}

	// Token: 0x06012432 RID: 74802 RVA: 0x005621B8 File Offset: 0x005603B8
	protected override void OnBeforeShow()
	{
		this.RefreshTopDesc();
		RoleTowerSettleLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel != null)
		{
			leftPanel.Refresh();
		}
		RoleTowerSettleRightPanel rightPanel = this.RightPanel;
		if (rightPanel != null)
		{
			rightPanel.Refresh(!this.HasShown);
		}
		this.HasShown = true;
	}

	// Token: 0x06012433 RID: 74803 RVA: 0x005621F2 File Offset: 0x005603F2
	protected override void OnAfterPlayStartSequence()
	{
		RoleTowerSettleRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.PlayEchoExpAnim();
	}

	// Token: 0x06012434 RID: 74804 RVA: 0x00562204 File Offset: 0x00560404
	private void RefreshTopDesc()
	{
		int num = 0;
		int num2 = 0;
		bool flag = false;
		foreach (RoleTowerWaveRecordData roleTowerWaveRecordData in RoleTowerModel.Instance.GetBattleWaveRecords())
		{
			RoleTowerFloor? roleTowerFloor;
			int num3 = (RoleTowerConfig.Instance.GetFloorById(roleTowerWaveRecordData.FloorId) != null) ? roleTowerFloor.GetValueOrDefault().FloorIndex : 0;
			if (!flag)
			{
				num2 = (num = num3);
				flag = true;
			}
			else
			{
				if (num3 < num)
				{
					num = num3;
				}
				if (num3 > num2)
				{
					num2 = num3;
				}
			}
		}
		UUIText text = base.GetText(0);
		if (num == num2)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerOneFloorTitle", new <>z__ReadOnlySingleElementList<object>(num));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerLevelSettleDes", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			num2
		}));
	}

	// Token: 0x06012435 RID: 74805 RVA: 0x005622FC File Offset: 0x005604FC
	private void OnClickRestart()
	{
		RoleTowerModel.Instance.ConfirmStageRetry(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06012436 RID: 74806 RVA: 0x00562314 File Offset: 0x00560514
	private void OnClickContinue()
	{
		RoleTowerController.Instance.StepAdvanceSettle().Forget<bool>();
		base.CloseMe(null);
	}

	// Token: 0x04009F79 RID: 40825
	private RoleTowerSettleLeftPanel LeftPanel;

	// Token: 0x04009F7A RID: 40826
	private RoleTowerSettleRightPanel RightPanel;

	// Token: 0x04009F7B RID: 40827
	private bool HasShown;

	// Token: 0x02007FBE RID: 32702
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402953D RID: 169277
		public const int TxtTopBattleDesc = 0;

		// Token: 0x0402953E RID: 169278
		public const int PnlLeft = 1;

		// Token: 0x0402953F RID: 169279
		public const int PnlRight = 2;

		// Token: 0x04029540 RID: 169280
		public const int BtnConfirmReStar = 3;

		// Token: 0x04029541 RID: 169281
		public const int BtnConfirmContinue = 4;
	}
}
