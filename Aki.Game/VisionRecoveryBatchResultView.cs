using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C11 RID: 3089
public class VisionRecoveryBatchResultView : UiViewBase
{
	// Token: 0x060080C8 RID: 32968 RVA: 0x00278114 File Offset: 0x00276314
	[NullableContext(1)]
	public VisionRecoveryBatchResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060080C9 RID: 32969 RVA: 0x00278120 File Offset: 0x00276320
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

	// Token: 0x060080CA RID: 32970 RVA: 0x002781CC File Offset: 0x002763CC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryBatchResultView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryBatchResultView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060080CB RID: 32971 RVA: 0x0027820F File Offset: 0x0027640F
	[NullableContext(1)]
	private VisionRecoverySlotGridItem InitVisionRecoverySlotGridItem()
	{
		return new VisionRecoverySlotGridItem(new Action<bool, PhantomItemData>(this.OnClickRewardCallback), false);
	}

	// Token: 0x060080CC RID: 32972 RVA: 0x00278223 File Offset: 0x00276423
	private void OnClickMaskBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060080CD RID: 32973 RVA: 0x0027822C File Offset: 0x0027642C
	[NullableContext(2)]
	private void OnClickRewardCallback(bool isAddVision, PhantomItemData data)
	{
		if (data == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(data.GetUniqueId(), data.GetConfigId(), true, null);
	}

	// Token: 0x04004F4E RID: 20302
	private const int CELLS_PER_LINE = 7;

	// Token: 0x04004F4F RID: 20303
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecoverySlotGridItem, PhantomItemData> MainRewardLayout;

	// Token: 0x04004F50 RID: 20304
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecoverySlotGridItem, PhantomItemData> ExtraRewardLayout;

	// Token: 0x02006EC2 RID: 28354
	private enum EComponent
	{
		// Token: 0x04024347 RID: 148295
		VisionItem,
		// Token: 0x04024348 RID: 148296
		MaskBtn,
		// Token: 0x04024349 RID: 148297
		MainRewardLayout,
		// Token: 0x0402434A RID: 148298
		TipsItem,
		// Token: 0x0402434B RID: 148299
		ExtraRewardLayout
	}
}
