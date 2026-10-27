using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024EA RID: 9450
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendVisionView : GridProxyAbstract<VisionNewRecommendVisionItemData>
{
	// Token: 0x0601300E RID: 77838 RVA: 0x004B4E34 File Offset: 0x004B3034
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

	// Token: 0x0601300F RID: 77839 RVA: 0x004B4EA4 File Offset: 0x004B30A4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendVisionView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendVisionView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013010 RID: 77840 RVA: 0x004B4EE7 File Offset: 0x004B30E7
	private void SelectedCallback()
	{
		Action<int, VisionNewRecommendVisionItemData> onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback(base.GridIndex, this.CurrentData);
	}

	// Token: 0x06013011 RID: 77841 RVA: 0x004B4F08 File Offset: 0x004B3108
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

	// Token: 0x06013012 RID: 77842 RVA: 0x004B4F60 File Offset: 0x004B3160
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

	// Token: 0x06013013 RID: 77843 RVA: 0x004B4FBD File Offset: 0x004B31BD
	private void RefreshNotObtainedPanel(bool obtained)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!obtained);
	}

	// Token: 0x06013014 RID: 77844 RVA: 0x004B4FD4 File Offset: 0x004B31D4
	public override void OnSelected(bool fireEvent)
	{
		VisionNewRecommendVisionItem visionItem = this.VisionItem;
		if (visionItem == null)
		{
			return;
		}
		visionItem.SetToggleState(EToggleState.ETT_Checked, fireEvent);
	}

	// Token: 0x06013015 RID: 77845 RVA: 0x004B4FE8 File Offset: 0x004B31E8
	public override void OnDeselected(bool fireEvent)
	{
		VisionNewRecommendVisionItem visionItem = this.VisionItem;
		if (visionItem == null)
		{
			return;
		}
		visionItem.SetToggleState(EToggleState.ETT_UnChecked, fireEvent);
	}

	// Token: 0x06013016 RID: 77846 RVA: 0x004B4FFC File Offset: 0x004B31FC
	public override object GetKey(VisionNewRecommendVisionItemData data, int displayIndex)
	{
		return data.VisionMonsterId;
	}

	// Token: 0x04008F08 RID: 36616
	[Nullable(2)]
	private VisionNewRecommendVisionItem VisionItem;

	// Token: 0x04008F09 RID: 36617
	[Nullable(2)]
	private VisionNewRecommendVisionItemData CurrentData;

	// Token: 0x04008F0A RID: 36618
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, VisionNewRecommendVisionItemData> OnSelectedCallback;

	// Token: 0x02008A7E RID: 35454
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF98 RID: 184216
		VisionItem,
		// Token: 0x0402CF99 RID: 184217
		PnlNoHave,
		// Token: 0x0402CF9A RID: 184218
		PnlUsage,
		// Token: 0x0402CF9B RID: 184219
		UsageText
	}
}
