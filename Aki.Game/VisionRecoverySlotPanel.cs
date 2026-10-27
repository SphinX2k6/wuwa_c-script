using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200175E RID: 5982
public class VisionRecoverySlotPanel : UiPanelBase
{
	// Token: 0x0600AD27 RID: 44327 RVA: 0x0026ED4A File Offset: 0x0026CF4A
	[NullableContext(2)]
	public VisionRecoverySlotPanel(Action<bool, PhantomItemData> clickCallBack = null, bool showRemoveBtn = true)
	{
		this.ClickSlotCallBack = clickCallBack;
		this.ShowRemoveBtn = showRemoveBtn;
	}

	// Token: 0x0600AD28 RID: 44328 RVA: 0x0026ED78 File Offset: 0x0026CF78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600AD29 RID: 44329 RVA: 0x0026EE00 File Offset: 0x0026D000
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoverySlotPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoverySlotPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD2A RID: 44330 RVA: 0x0026EE44 File Offset: 0x0026D044
	private UniTask CreateAndAddSlotItem(VisionRecoverySlotPanel.EComponent slot)
	{
		VisionRecoverySlotPanel.<CreateAndAddSlotItem>d__8 <CreateAndAddSlotItem>d__;
		<CreateAndAddSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAndAddSlotItem>d__.<>4__this = this;
		<CreateAndAddSlotItem>d__.slot = slot;
		<CreateAndAddSlotItem>d__.<>1__state = -1;
		<CreateAndAddSlotItem>d__.<>t__builder.Start<VisionRecoverySlotPanel.<CreateAndAddSlotItem>d__8>(ref <CreateAndAddSlotItem>d__);
		return <CreateAndAddSlotItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD2B RID: 44331 RVA: 0x0026EE90 File Offset: 0x0026D090
	[NullableContext(1)]
	public void RefreshUi(List<PhantomItemData> visionDataList)
	{
		for (int i = 0; i < this.VisionDataList.Length; i++)
		{
			PhantomItemData data = this.VisionDataList[i];
			if (i >= visionDataList.Count)
			{
				data = null;
			}
			else
			{
				data = visionDataList[i];
			}
			this.RecoverySlotItemList[i].RefreshUi(data);
		}
	}

	// Token: 0x04004EBA RID: 20154
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly PhantomItemData[] VisionDataList = new PhantomItemData[5];

	// Token: 0x04004EBB RID: 20155
	[Nullable(1)]
	private VisionRecoverySlotItem[] RecoverySlotItemList = new VisionRecoverySlotItem[5];

	// Token: 0x04004EBC RID: 20156
	[Nullable(2)]
	private readonly Action<bool, PhantomItemData> ClickSlotCallBack;

	// Token: 0x04004EBD RID: 20157
	private readonly bool ShowRemoveBtn;

	// Token: 0x02007D48 RID: 32072
	private enum EComponent
	{
		// Token: 0x04029066 RID: 168038
		RecoverySlotItem0,
		// Token: 0x04029067 RID: 168039
		RecoverySlotItem1,
		// Token: 0x04029068 RID: 168040
		RecoverySlotItem2,
		// Token: 0x04029069 RID: 168041
		RecoverySlotItem3,
		// Token: 0x0402906A RID: 168042
		RecoverySlotItem4
	}
}
