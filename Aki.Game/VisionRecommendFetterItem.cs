using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019AB RID: 6571
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class VisionRecommendFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x060102A6 RID: 66214 RVA: 0x004B6738 File Offset: 0x004B4938
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060102A7 RID: 66215 RVA: 0x004B67B8 File Offset: 0x004B49B8
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecommendFetterItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecommendFetterItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060102A8 RID: 66216 RVA: 0x004B67FB File Offset: 0x004B49FB
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
	}

	// Token: 0x060102A9 RID: 66217 RVA: 0x004B681B File Offset: 0x004B4A1B
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		VisionEquipmentRecommendFetterGroupView fetterGroupView = this.FetterGroupView;
		if (fetterGroupView != null)
		{
			fetterGroupView.Refresh(data.BuildFetterList());
		}
		this.RefreshUsage(data.GetUsageText());
	}

	// Token: 0x060102AA RID: 66218 RVA: 0x004B6840 File Offset: 0x004B4A40
	private void RefreshUsage(string txt)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(txt, true);
	}

	// Token: 0x060102AB RID: 66219 RVA: 0x004B6855 File Offset: 0x004B4A55
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onSelectedCallback = this.OnSelectedCallback;
			if (onSelectedCallback == null)
			{
				return;
			}
			onSelectedCallback(base.GridIndex);
		}
	}

	// Token: 0x060102AC RID: 66220 RVA: 0x004B6871 File Offset: 0x004B4A71
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060102AD RID: 66221 RVA: 0x004B687B File Offset: 0x004B4A7B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060102AE RID: 66222 RVA: 0x004B6885 File Offset: 0x004B4A85
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060102AF RID: 66223 RVA: 0x004B68A2 File Offset: 0x004B4AA2
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data;
	}

	// Token: 0x04008F82 RID: 36738
	[Nullable(2)]
	private VisionEquipmentRecommendFetterGroupView FetterGroupView;

	// Token: 0x04008F83 RID: 36739
	[Nullable(2)]
	public Action<int> OnSelectedCallback;
}
