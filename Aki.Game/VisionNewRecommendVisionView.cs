using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019D1 RID: 6609
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendVisionView : GridProxyAbstract<VisionNewRecommendVisionItemData>
{
	// Token: 0x060104CD RID: 66765 RVA: 0x004C2AE0 File Offset: 0x004C0CE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x060104CE RID: 66766 RVA: 0x004C2B50 File Offset: 0x004C0D50
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendVisionView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendVisionView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060104CF RID: 66767 RVA: 0x004C2B93 File Offset: 0x004C0D93
	private void SelectedCallback()
	{
		Action<int, VisionNewRecommendVisionItemData> onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback(base.GridIndex, this.CurrentData);
	}

	// Token: 0x060104D0 RID: 66768 RVA: 0x004C2BB4 File Offset: 0x004C0DB4
	public override void Refresh(VisionNewRecommendVisionItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		VisionNewRecommendVisionItem visionItem = this.VisionItem;
		if (visionItem != null)
		{
			visionItem.SetData(data);
		}
		this.RefreshUsageText(data.Usage);
		this.RefreshNotObtainedPanel(data.Obtained);
		VisionNewRecommendVisionItem visionItem2 = this.VisionItem;
		if (visionItem2 == null)
		{
			return;
		}
		visionItem2.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false);
	}

	// Token: 0x060104D1 RID: 66769 RVA: 0x004C2C0C File Offset: 0x004C0E0C
	private void RefreshUsageText(int usage)
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(usage > 0);
		}
		if (usage > 0)
		{
			float num = (float)(usage - usage % 10) / 100f;
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString("F1") + "%", true);
		}
	}

	// Token: 0x060104D2 RID: 66770 RVA: 0x004C2C69 File Offset: 0x004C0E69
	private void RefreshNotObtainedPanel(bool obtained)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!obtained);
	}

	// Token: 0x060104D3 RID: 66771 RVA: 0x004C2C80 File Offset: 0x004C0E80
	public override void OnSelected(bool fireEvent)
	{
		VisionNewRecommendVisionItem visionItem = this.VisionItem;
		if (visionItem == null)
		{
			return;
		}
		visionItem.SetToggleState(EToggleState.ETT_Checked, fireEvent);
	}

	// Token: 0x060104D4 RID: 66772 RVA: 0x004C2C94 File Offset: 0x004C0E94
	public override void OnDeselected(bool fireEvent)
	{
		VisionNewRecommendVisionItem visionItem = this.VisionItem;
		if (visionItem == null)
		{
			return;
		}
		visionItem.SetToggleState(EToggleState.ETT_UnChecked, fireEvent);
	}

	// Token: 0x060104D5 RID: 66773 RVA: 0x004C2CA8 File Offset: 0x004C0EA8
	public override object GetKey(VisionNewRecommendVisionItemData data, int displayIndex)
	{
		return data.VisionMonsterId;
	}

	// Token: 0x04009052 RID: 36946
	[Nullable(2)]
	private VisionNewRecommendVisionItem VisionItem;

	// Token: 0x04009053 RID: 36947
	[Nullable(2)]
	private VisionNewRecommendVisionItemData CurrentData;

	// Token: 0x04009054 RID: 36948
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, VisionNewRecommendVisionItemData> OnSelectedCallback;

	// Token: 0x02007C06 RID: 31750
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x040282B0 RID: 164528
		VisionItem,
		// Token: 0x040282B1 RID: 164529
		PnlNoHave,
		// Token: 0x040282B2 RID: 164530
		PnlUsage,
		// Token: 0x040282B3 RID: 164531
		UsageText
	}
}
