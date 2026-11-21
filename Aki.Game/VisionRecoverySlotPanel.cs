using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C17 RID: 3095
public class VisionRecoverySlotPanel : UiPanelBase
{
	// Token: 0x0600810E RID: 33038 RVA: 0x002791BE File Offset: 0x002773BE
	[NullableContext(2)]
	public VisionRecoverySlotPanel(Action<bool, PhantomItemData> clickCallBack = null, bool showRemoveBtn = true)
	{
		this.ClickSlotCallBack = clickCallBack;
		this.ShowRemoveBtn = showRemoveBtn;
	}

	// Token: 0x0600810F RID: 33039 RVA: 0x002791EC File Offset: 0x002773EC
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

	// Token: 0x06008110 RID: 33040 RVA: 0x00279274 File Offset: 0x00277474
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoverySlotPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoverySlotPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008111 RID: 33041 RVA: 0x002792B8 File Offset: 0x002774B8
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

	// Token: 0x06008112 RID: 33042 RVA: 0x00279304 File Offset: 0x00277504
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

	// Token: 0x04004F63 RID: 20323
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly PhantomItemData[] VisionDataList = new PhantomItemData[5];

	// Token: 0x04004F64 RID: 20324
	[Nullable(1)]
	private VisionRecoverySlotItem[] RecoverySlotItemList = new VisionRecoverySlotItem[5];

	// Token: 0x04004F65 RID: 20325
	[Nullable(2)]
	private readonly Action<bool, PhantomItemData> ClickSlotCallBack;

	// Token: 0x04004F66 RID: 20326
	private readonly bool ShowRemoveBtn;

	// Token: 0x02006ECE RID: 28366
	private enum EComponent
	{
		// Token: 0x04024391 RID: 148369
		RecoverySlotItem0,
		// Token: 0x04024392 RID: 148370
		RecoverySlotItem1,
		// Token: 0x04024393 RID: 148371
		RecoverySlotItem2,
		// Token: 0x04024394 RID: 148372
		RecoverySlotItem3,
		// Token: 0x04024395 RID: 148373
		RecoverySlotItem4
	}
}
