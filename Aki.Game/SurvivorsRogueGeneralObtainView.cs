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

// Token: 0x02002B77 RID: 11127
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueGeneralObtainView : UiViewBase, ISurvivorsRogueCommandView
{
	// Token: 0x060170AD RID: 94381 RVA: 0x005D9BE5 File Offset: 0x005D7DE5
	public SurvivorsRogueGeneralObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001EC0 RID: 7872
	// (get) Token: 0x060170AE RID: 94382 RVA: 0x005D9BEE File Offset: 0x005D7DEE
	SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
	{
		get
		{
			return this.Command;
		}
	}

	// Token: 0x17001EC1 RID: 7873
	// (get) Token: 0x060170AF RID: 94383 RVA: 0x005D9BF6 File Offset: 0x005D7DF6
	int ISurvivorsRogueCommandView.CommandIncId
	{
		get
		{
			return this.CommandIncId;
		}
	}

	// Token: 0x060170B0 RID: 94384 RVA: 0x005D9C00 File Offset: 0x005D7E00
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

	// Token: 0x060170B1 RID: 94385 RVA: 0x005D9CA9 File Offset: 0x005D7EA9
	public void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060170B2 RID: 94386 RVA: 0x005D9CB4 File Offset: 0x005D7EB4
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

	// Token: 0x060170B3 RID: 94387 RVA: 0x005D9D68 File Offset: 0x005D7F68
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueGeneralObtainView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueGeneralObtainView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060170B4 RID: 94388 RVA: 0x005D9DAB File Offset: 0x005D7FAB
	protected override void OnBeforeCreate()
	{
		EventSystem.Instance.Add(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView));
	}

	// Token: 0x060170B5 RID: 94389 RVA: 0x005D9DC9 File Offset: 0x005D7FC9
	protected override void OnAddEventListener()
	{
		if (!EventSystem.Instance.Has(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView)))
		{
			EventSystem.Instance.Add(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView));
		}
	}

	// Token: 0x060170B6 RID: 94390 RVA: 0x005D9E04 File Offset: 0x005D8004
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SurvivorsRebindCommandView, new Action<int>(this.OnSurvivorsRebindCommandView));
	}

	// Token: 0x060170B7 RID: 94391 RVA: 0x005D9E22 File Offset: 0x005D8022
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCommandBaseObtain command = this.Command;
		if (command == null)
		{
			return;
		}
		command.BindView(null);
	}

	// Token: 0x060170B8 RID: 94392 RVA: 0x005D9E35 File Offset: 0x005D8035
	private void SeqStartFinished(string s)
	{
		Action onSeqStartFinished = this.OnSeqStartFinished;
		if (onSeqStartFinished == null)
		{
			return;
		}
		onSeqStartFinished();
	}

	// Token: 0x060170B9 RID: 94393 RVA: 0x005D9E47 File Offset: 0x005D8047
	private SurvivorsRogueCardObtainItem CreateCardItem()
	{
		SurvivorsRogueCardObtainItem survivorsRogueCardObtainItem = new SurvivorsRogueCardObtainItem();
		survivorsRogueCardObtainItem.BindOnStateChangeCallback(new Action<ISurvivorsRogueCardBase, EToggleState>(this.OnStateChangeCallback));
		survivorsRogueCardObtainItem.BindOnCanExecuteChangeCallback(new Func<ISurvivorsRogueCardBase, EToggleState, bool>(this.OnCanExecuteChangeCallback));
		return survivorsRogueCardObtainItem;
	}

	// Token: 0x060170BA RID: 94394 RVA: 0x005D9E74 File Offset: 0x005D8074
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

	// Token: 0x060170BB RID: 94395 RVA: 0x005D9ED8 File Offset: 0x005D80D8
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

	// Token: 0x060170BC RID: 94396 RVA: 0x005D9F30 File Offset: 0x005D8130
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

	// Token: 0x060170BD RID: 94397 RVA: 0x005D9F6C File Offset: 0x005D816C
	private void SetConfirmButtonInteract(bool bInteractive)
	{
		base.GetButton(3).SetSelfInteractive(bInteractive);
	}

	// Token: 0x060170BE RID: 94398 RVA: 0x005D9F7C File Offset: 0x005D817C
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

	// Token: 0x060170BF RID: 94399 RVA: 0x005DA02C File Offset: 0x005D822C
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

	// Token: 0x060170C0 RID: 94400 RVA: 0x005DA059 File Offset: 0x005D8259
	[NullableContext(2)]
	public SurvivorsRogueRoleStatePanel GetRoleStatePanel()
	{
		return this.BaseItem.RoleStatePanel;
	}

	// Token: 0x060170C1 RID: 94401 RVA: 0x005DA068 File Offset: 0x005D8268
	private UniTask RefreshAsync()
	{
		SurvivorsRogueGeneralObtainView.<RefreshAsync>d__30 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueGeneralObtainView.<RefreshAsync>d__30>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060170C2 RID: 94402 RVA: 0x005DA0AC File Offset: 0x005D82AC
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

	// Token: 0x0400AC6E RID: 44142
	public int CommandIncId;

	// Token: 0x0400AC6F RID: 44143
	public SurvivorsRogueCommandBaseObtain Command;

	// Token: 0x0400AC70 RID: 44144
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<SurvivorsRogueCardObtainItem, GoodsDetail> CardList;

	// Token: 0x0400AC71 RID: 44145
	[Nullable(2)]
	private SurvivorsRogueViewBase BaseItem;

	// Token: 0x0400AC72 RID: 44146
	[Nullable(2)]
	private new ISurvivorsObtainViewInfo ViewInfo;

	// Token: 0x0400AC73 RID: 44147
	private int SelectIncId;

	// Token: 0x0400AC74 RID: 44148
	[Nullable(2)]
	public Action<int, bool> OnGoodsSelected;

	// Token: 0x0400AC75 RID: 44149
	[Nullable(2)]
	public Action OnSeqStartFinished;
}
