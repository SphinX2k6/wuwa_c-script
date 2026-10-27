using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001758 RID: 5976
public class VisionRecoveryBatchResultView : UiViewBase
{
	// Token: 0x0600ACE1 RID: 44257 RVA: 0x0026DC98 File Offset: 0x0026BE98
	[NullableContext(1)]
	public VisionRecoveryBatchResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ACE2 RID: 44258 RVA: 0x0026DCA4 File Offset: 0x0026BEA4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIGridLayout))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickMaskBtn))
		};
	}

	// Token: 0x0600ACE3 RID: 44259 RVA: 0x0026DD50 File Offset: 0x0026BF50
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryBatchResultView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryBatchResultView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACE4 RID: 44260 RVA: 0x0026DD93 File Offset: 0x0026BF93
	[NullableContext(1)]
	private VisionRecoverySlotGridItem InitVisionRecoverySlotGridItem()
	{
		return new VisionRecoverySlotGridItem(new Action<bool, PhantomItemData>(this.OnClickRewardCallback), false);
	}

	// Token: 0x0600ACE5 RID: 44261 RVA: 0x0026DDA7 File Offset: 0x0026BFA7
	private void OnClickMaskBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600ACE6 RID: 44262 RVA: 0x0026DDB0 File Offset: 0x0026BFB0
	[NullableContext(2)]
	private void OnClickRewardCallback(bool isAddVision, PhantomItemData data)
	{
		if (data == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(data.GetUniqueId(), data.GetConfigId(), true, null);
	}

	// Token: 0x04004EA5 RID: 20133
	private const int CELLS_PER_LINE = 7;

	// Token: 0x04004EA6 RID: 20134
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecoverySlotGridItem, PhantomItemData> MainRewardLayout;

	// Token: 0x04004EA7 RID: 20135
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecoverySlotGridItem, PhantomItemData> ExtraRewardLayout;

	// Token: 0x02007D3C RID: 32060
	private enum EComponent
	{
		// Token: 0x0402901C RID: 167964
		VisionItem,
		// Token: 0x0402901D RID: 167965
		MaskBtn,
		// Token: 0x0402901E RID: 167966
		MainRewardLayout,
		// Token: 0x0402901F RID: 167967
		TipsItem,
		// Token: 0x04029020 RID: 167968
		ExtraRewardLayout
	}
}
