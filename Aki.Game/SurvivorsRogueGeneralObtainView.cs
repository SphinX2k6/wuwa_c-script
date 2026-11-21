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

// Token: 0x020020F3 RID: 8435
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueGeneralObtainView : UiViewBase, ISurvivorsRogueCommandView
{
	// Token: 0x06014ADE RID: 84702 RVA: 0x00606755 File Offset: 0x00604955
	public SurvivorsRogueGeneralObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001F18 RID: 7960
	// (get) Token: 0x06014ADF RID: 84703 RVA: 0x0060675E File Offset: 0x0060495E
	SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
	{
		get
		{
			return this.Command;
		}
	}

	// Token: 0x17001F19 RID: 7961
	// (get) Token: 0x06014AE0 RID: 84704 RVA: 0x00606766 File Offset: 0x00604966
	int ISurvivorsRogueCommandView.CommandIncId
	{
		get
		{
			return this.CommandIncId;
		}
	}

	// Token: 0x06014AE1 RID: 84705 RVA: 0x00606770 File Offset: 0x00604970
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnConfirm))
		};
	}

	// Token: 0x06014AE2 RID: 84706 RVA: 0x00606819 File Offset: 0x00604A19
	public void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014AE3 RID: 84707 RVA: 0x00606824 File Offset: 0x00604A24
	private void OnClickBtnConfirm()
	{
		if (this.ViewInfo == null)
		{
			return;
		}
		ESurvivorsObtainMode obtainMode = this.ViewInfo.ChooseData.ObtainMode;
		if (obtainMode != ESurvivorsObtainMode.SingleSelect)
		{
			if (obtainMode == ESurvivorsObtainMode.All)
			{
				List<int> list = new List<int>();
				for (int i = 0; i < this.ViewInfo.GoodsList.Count; i++)
				{
					GoodsDetail goodsDetail = this.ViewInfo.GoodsList[i];
					if (goodsDetail.SurvivorsGainData != null)
					{
						list.Add(goodsDetail.SurvivorsGainData.IncId);
					}
				}
				this.Command.SelectIds = list;
			}
		}
		else
		{
			this.Command.SelectIds = new List<int>
			{
				this.SelectIncId
			};
		}
		this.Command.Execute();
	}

	// Token: 0x06014AE4 RID: 84708 RVA: 0x006068D8 File Offset: 0x00604AD8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueGeneralObtainView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueGeneralObtainView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014AE5 RID: 84709 RVA: 0x0060691B File Offset: 0x00604B1B
	protected override void OnBeforeCreate()
	{
		EventSystem.Instance.Add(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView));
	}

	// Token: 0x06014AE6 RID: 84710 RVA: 0x00606939 File Offset: 0x00604B39
	protected override void OnAddEventListener()
	{
		if (!EventSystem.Instance.Has(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView)))
		{
			EventSystem.Instance.Add(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView));
		}
	}

	// Token: 0x06014AE7 RID: 84711 RVA: 0x00606974 File Offset: 0x00604B74
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView));
	}

	// Token: 0x06014AE8 RID: 84712 RVA: 0x00606992 File Offset: 0x00604B92
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCommandBaseObtain command = this.Command;
		if (command == null)
		{
			return;
		}
		command.BindView(null);
	}

	// Token: 0x06014AE9 RID: 84713 RVA: 0x006069A5 File Offset: 0x00604BA5
	private void SeqStartFinished(string s)
	{
		Action onSeqStartFinished = this.OnSeqStartFinished;
		if (onSeqStartFinished == null)
		{
			return;
		}
		onSeqStartFinished();
	}

	// Token: 0x06014AEA RID: 84714 RVA: 0x006069B7 File Offset: 0x00604BB7
	private SurvivorsRogueCardObtainItem CreateCardItem()
	{
		SurvivorsRogueCardObtainItem survivorsRogueCardObtainItem = new SurvivorsRogueCardObtainItem();
		survivorsRogueCardObtainItem.BindOnStateChangeCallback(new Action<ISurvivorsRogueCardBase, EToggleState>(this.OnStateChangeCallback));
		survivorsRogueCardObtainItem.BindOnCanExecuteChangeCallback(new Func<ISurvivorsRogueCardBase, EToggleState, bool>(this.OnCanExecuteChangeCallback));
		return survivorsRogueCardObtainItem;
	}

	// Token: 0x06014AEB RID: 84715 RVA: 0x006069E4 File Offset: 0x00604BE4
	private void OnStateChangeCallback(ISurvivorsRogueCardBase data, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SetConfirmButtonInteract(true);
		}
		this.DeselectLast();
		ESurvivorsObtainMode obtainMode = this.ViewInfo.ChooseData.ObtainMode;
		if (obtainMode != ESurvivorsObtainMode.SingleSelect)
		{
			return;
		}
		this.SelectIncId = data.IncId.GetValueOrDefault();
		Action<int, bool> onGoodsSelected = this.OnGoodsSelected;
		if (onGoodsSelected == null)
		{
			return;
		}
		onGoodsSelected(this.SelectIncId, true);
	}

	// Token: 0x06014AEC RID: 84716 RVA: 0x00606A48 File Offset: 0x00604C48
	private void DeselectLast()
	{
		if (this.SelectIncId != 0)
		{
			SurvivorsRogueCardObtainItem layoutItemByKey = this.CardList.GetLayoutItemByKey(this.SelectIncId);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetSelected(false, false, true);
			}
			Action<int, bool> onGoodsSelected = this.OnGoodsSelected;
			if (onGoodsSelected != null)
			{
				onGoodsSelected(this.SelectIncId, false);
			}
		}
		this.SelectIncId = 0;
	}

	// Token: 0x06014AED RID: 84717 RVA: 0x00606AA0 File Offset: 0x00604CA0
	private bool OnCanExecuteChangeCallback(ISurvivorsRogueCardBase data, EToggleState state)
	{
		if (this.ViewInfo == null)
		{
			return false;
		}
		ESurvivorsObtainMode obtainMode = this.ViewInfo.ChooseData.ObtainMode;
		if (obtainMode != ESurvivorsObtainMode.SingleSelect)
		{
			return obtainMode != ESurvivorsObtainMode.All && false;
		}
		return state != EToggleState.ETT_Checked;
	}

	// Token: 0x06014AEE RID: 84718 RVA: 0x00606ADC File Offset: 0x00604CDC
	private void SetConfirmButtonInteract(bool bInteractive)
	{
		base.GetButton(3).SetSelfInteractive(bInteractive);
	}

	// Token: 0x06014AEF RID: 84719 RVA: 0x00606AEC File Offset: 0x00604CEC
	private void OnSurvivorsRebindCommandView(int commandId)
	{
		SurvivorsRogueCommandBase commandByIncId = SurvivorsRogueModel.Instance.CommandQueue.GetCommandByIncId(commandId);
		if (commandByIncId == null)
		{
			return;
		}
		ESurvivorsRogueCommandType type = commandByIncId.Type;
		if (type <= ESurvivorsRogueCommandType.WeaponSelect || type == ESurvivorsRogueCommandType.AdditionRewardGot)
		{
			this.Command.BindView(null);
			this.OnGoodsSelected = null;
			this.OnSeqStartFinished = null;
			this.CommandIncId = commandId;
			this.Command = (SurvivorsRogueCommandBaseObtain)commandByIncId;
			this.Refresh();
			this.Command.BindView(this);
			if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
			{
				this.UiViewSequence.ReplaySequence("Switch");
				return;
			}
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}
	}

	// Token: 0x06014AF0 RID: 84720 RVA: 0x00606B9C File Offset: 0x00604D9C
	public void Refresh()
	{
		UiAsyncTask task = new UiAsyncTask("SurvivorsRogueGeneralObtainView.Refresh", delegate()
		{
			SurvivorsRogueGeneralObtainView.<<Refresh>b__28_0>d <<Refresh>b__28_0>d;
			<<Refresh>b__28_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Refresh>b__28_0>d.<>4__this = this;
			<<Refresh>b__28_0>d.<>1__state = -1;
			<<Refresh>b__28_0>d.<>t__builder.Start<SurvivorsRogueGeneralObtainView.<<Refresh>b__28_0>d>(ref <<Refresh>b__28_0>d);
			return <<Refresh>b__28_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06014AF1 RID: 84721 RVA: 0x00606BC9 File Offset: 0x00604DC9
	[NullableContext(2)]
	public SurvivorsRogueRoleStatePanel GetRoleStatePanel()
	{
		return this.BaseItem.RoleStatePanel;
	}

	// Token: 0x06014AF2 RID: 84722 RVA: 0x00606BD8 File Offset: 0x00604DD8
	private UniTask RefreshAsync()
	{
		SurvivorsRogueGeneralObtainView.<RefreshAsync>d__30 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueGeneralObtainView.<RefreshAsync>d__30>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014AF3 RID: 84723 RVA: 0x00606C1C File Offset: 0x00604E1C
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
		if (configParams[0] == "WeaponEvolve")
		{
			GenericLayout<SurvivorsRogueCardObtainItem, GoodsDetail> cardList = this.CardList;
			List<SurvivorsRogueCardObtainItem> list = ((cardList != null) ? cardList.GetLayoutItemList() : null) ?? new List<SurvivorsRogueCardObtainItem>();
			for (int i = 0; i < list.Count; i++)
			{
				SurvivorsRogueCardObtainItem survivorsRogueCardObtainItem = list[i];
				if (survivorsRogueCardObtainItem.HasBondInfo())
				{
					return survivorsRogueCardObtainItem.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
			}
		}
		return null;
	}

	// Token: 0x0400B074 RID: 45172
	public int CommandIncId;

	// Token: 0x0400B075 RID: 45173
	public SurvivorsRogueCommandBaseObtain Command;

	// Token: 0x0400B076 RID: 45174
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<SurvivorsRogueCardObtainItem, GoodsDetail> CardList;

	// Token: 0x0400B077 RID: 45175
	[Nullable(2)]
	private SurvivorsRogueViewBase BaseItem;

	// Token: 0x0400B078 RID: 45176
	[Nullable(2)]
	private new ISurvivorsObtainViewInfo ViewInfo;

	// Token: 0x0400B079 RID: 45177
	private int SelectIncId;

	// Token: 0x0400B07A RID: 45178
	[Nullable(2)]
	public Action<int, bool> OnGoodsSelected;

	// Token: 0x0400B07B RID: 45179
	[Nullable(2)]
	public Action OnSeqStartFinished;
}
