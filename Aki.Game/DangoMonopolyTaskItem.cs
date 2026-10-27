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

// Token: 0x0200124F RID: 4687
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyTaskItem : GridProxyAbstract<global::DangoMonopolyTaskData>
{
	// Token: 0x06007F4A RID: 32586 RVA: 0x001AF468 File Offset: 0x001AD668
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

	// Token: 0x06007F4B RID: 32587 RVA: 0x001AF598 File Offset: 0x001AD798
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyTaskItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyTaskItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F4C RID: 32588 RVA: 0x001AF5DB File Offset: 0x001AD7DB
	protected override void OnStart()
	{
		base.GetText(5).ShowTextNew("DangoMonopoly_title_10");
	}

	// Token: 0x06007F4D RID: 32589 RVA: 0x001AF5EE File Offset: 0x001AD7EE
	private void OnClickReward(MediumItemGridExtendCallback _)
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemData.RewardItemId, true, null);
	}

	// Token: 0x06007F4E RID: 32590 RVA: 0x001AF607 File Offset: 0x001AD807
	public override void Refresh(global::DangoMonopolyTaskData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(1).ShowTextNew(this.ItemData.TaskDesc);
		this.UpdateProgressDesc();
		this.UpdateReward();
		this.UpdateState();
	}

	// Token: 0x06007F4F RID: 32591 RVA: 0x001AF63C File Offset: 0x001AD83C
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

	// Token: 0x06007F50 RID: 32592 RVA: 0x001AF6CC File Offset: 0x001AD8CC
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

	// Token: 0x06007F51 RID: 32593 RVA: 0x001AF75C File Offset: 0x001AD95C
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

	// Token: 0x06007F52 RID: 32594 RVA: 0x001AF84B File Offset: 0x001ADA4B
	private void OnClickReceive()
	{
		Action<global::DangoMonopolyTaskData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x06007F53 RID: 32595 RVA: 0x001AF863 File Offset: 0x001ADA63
	private void OnClickJump()
	{
		UiManager.Instance.CloseView(EUiViewName.DangoMonopolyTaskView, null);
		this.ItemData.JumpSource();
	}

	// Token: 0x040039F3 RID: 14835
	private global::DangoMonopolyTaskData ItemData;

	// Token: 0x040039F4 RID: 14836
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<global::DangoMonopolyTaskData> ClickCallBack;

	// Token: 0x040039F5 RID: 14837
	private SmallItemGrid RewardItem;

	// Token: 0x02007867 RID: 30823
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027AC7 RID: 162503
		ItemReward,
		// Token: 0x04027AC8 RID: 162504
		TxtDesc,
		// Token: 0x04027AC9 RID: 162505
		TxtProgressDesc,
		// Token: 0x04027ACA RID: 162506
		BtnJump,
		// Token: 0x04027ACB RID: 162507
		BtnReceive,
		// Token: 0x04027ACC RID: 162508
		TxtProgress,
		// Token: 0x04027ACD RID: 162509
		SpriteCompleted,
		// Token: 0x04027ACE RID: 162510
		TxtJump,
		// Token: 0x04027ACF RID: 162511
		TxtReceive,
		// Token: 0x04027AD0 RID: 162512
		ItemReceiveRedDot
	}
}
