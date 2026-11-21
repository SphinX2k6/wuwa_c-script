using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000703 RID: 1795
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyTaskItem : GridProxyAbstract<global::DangoMonopolyTaskData>
{
	// Token: 0x060052E1 RID: 21217 RVA: 0x001B8120 File Offset: 0x001B6320
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickReceive)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickJump))
		};
	}

	// Token: 0x060052E2 RID: 21218 RVA: 0x001B8250 File Offset: 0x001B6450
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyTaskItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyTaskItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060052E3 RID: 21219 RVA: 0x001B8293 File Offset: 0x001B6493
	protected override void OnStart()
	{
		base.GetText(5).ShowTextNew("DangoMonopoly_title_10");
	}

	// Token: 0x060052E4 RID: 21220 RVA: 0x001B82A6 File Offset: 0x001B64A6
	private void OnClickReward(MediumItemGridExtendCallback _)
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemData.RewardItemId, true, null, false);
	}

	// Token: 0x060052E5 RID: 21221 RVA: 0x001B82C0 File Offset: 0x001B64C0
	public override void Refresh(global::DangoMonopolyTaskData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(1).ShowTextNew(this.ItemData.TaskDesc);
		this.UpdateProgressDesc();
		this.UpdateReward();
		this.UpdateState();
	}

	// Token: 0x060052E6 RID: 21222 RVA: 0x001B82F4 File Offset: 0x001B64F4
	private void UpdateProgressDesc()
	{
		UUIText text = base.GetText(2);
		bool flag = this.ItemData.TotalProgress > 0;
		text.SetUIActive(flag);
		if (flag)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ItemData.Progress);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ItemData.TotalProgress);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			text.SetText(newText, true);
		}
	}

	// Token: 0x060052E7 RID: 21223 RVA: 0x001B8384 File Offset: 0x001B6584
	private void UpdateReward()
	{
		int rewardItemCount = this.ItemData.RewardItemCount;
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = this.ItemData;
		propSmallItemGrid.ItemConfigId = new int?(this.ItemData.RewardItemId);
		string bottomText;
		if (rewardItemCount <= 0)
		{
			bottomText = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(rewardItemCount);
			bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText;
		propSmallItemGrid.IsReceivedVisible = new bool?(this.ItemData.TaskState == DangoMonopolyTaskState.HasGet);
		PropSmallItemGrid parameters = propSmallItemGrid;
		this.RewardItem.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x060052E8 RID: 21224 RVA: 0x001B8414 File Offset: 0x001B6614
	private void UpdateState()
	{
		UUIText text = base.GetText(5);
		UUISprite sprite = base.GetSprite(6);
		UUIButtonComponent button = base.GetButton(4);
		UUIButtonComponent button2 = base.GetButton(3);
		UUIItem item = base.GetItem(9);
		bool flag = this.ItemData.Source != 0;
		sprite.SetUIActive(false);
		text.SetUIActive(false);
		button2.RootUIComp.Get().SetUIActive(false);
		button.RootUIComp.Get().SetUIActive(false);
		item.SetUIActive(false);
		switch (this.ItemData.TaskState)
		{
		case DangoMonopolyTaskState.NotCompleted:
			text.SetUIActive(!flag);
			button2.RootUIComp.Get().SetUIActive(flag);
			return;
		case DangoMonopolyTaskState.Completed:
			button.RootUIComp.Get().SetUIActive(true);
			item.SetUIActive(true);
			return;
		case DangoMonopolyTaskState.HasGet:
			sprite.SetUIActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x060052E9 RID: 21225 RVA: 0x001B8503 File Offset: 0x001B6703
	private void OnClickReceive()
	{
		Action<global::DangoMonopolyTaskData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x060052EA RID: 21226 RVA: 0x001B851B File Offset: 0x001B671B
	private void OnClickJump()
	{
		UiManager.Instance.CloseView(EUiViewName.DangoMonopolyTaskView, null);
		this.ItemData.JumpSource();
	}

	// Token: 0x04003A8B RID: 14987
	private global::DangoMonopolyTaskData ItemData;

	// Token: 0x04003A8C RID: 14988
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<global::DangoMonopolyTaskData> ClickCallBack;

	// Token: 0x04003A8D RID: 14989
	private SmallItemGrid RewardItem;

	// Token: 0x020069F2 RID: 27122
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022DF8 RID: 142840
		ItemReward,
		// Token: 0x04022DF9 RID: 142841
		TxtDesc,
		// Token: 0x04022DFA RID: 142842
		TxtProgressDesc,
		// Token: 0x04022DFB RID: 142843
		BtnJump,
		// Token: 0x04022DFC RID: 142844
		BtnReceive,
		// Token: 0x04022DFD RID: 142845
		TxtProgress,
		// Token: 0x04022DFE RID: 142846
		SpriteCompleted,
		// Token: 0x04022DFF RID: 142847
		TxtJump,
		// Token: 0x04022E00 RID: 142848
		TxtReceive,
		// Token: 0x04022E01 RID: 142849
		ItemReceiveRedDot
	}
}
