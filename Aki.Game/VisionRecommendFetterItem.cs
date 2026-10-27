using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024C4 RID: 9412
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class VisionRecommendFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x06012DE6 RID: 77286 RVA: 0x004A8B84 File Offset: 0x004A6D84
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

	// Token: 0x06012DE7 RID: 77287 RVA: 0x004A8C04 File Offset: 0x004A6E04
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecommendFetterItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecommendFetterItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DE8 RID: 77288 RVA: 0x004A8C47 File Offset: 0x004A6E47
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
	}

	// Token: 0x06012DE9 RID: 77289 RVA: 0x004A8C67 File Offset: 0x004A6E67
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		VisionEquipmentRecommendFetterGroupView fetterGroupView = this.FetterGroupView;
		if (fetterGroupView != null)
		{
			fetterGroupView.Refresh(data.BuildFetterList());
		}
		this.RefreshUsage(data.GetUsageText());
	}

	// Token: 0x06012DEA RID: 77290 RVA: 0x004A8C8C File Offset: 0x004A6E8C
	private void RefreshUsage(string txt)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(txt, true);
	}

	// Token: 0x06012DEB RID: 77291 RVA: 0x004A8CA1 File Offset: 0x004A6EA1
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

	// Token: 0x06012DEC RID: 77292 RVA: 0x004A8CBD File Offset: 0x004A6EBD
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06012DED RID: 77293 RVA: 0x004A8CC7 File Offset: 0x004A6EC7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06012DEE RID: 77294 RVA: 0x004A8CD1 File Offset: 0x004A6ED1
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06012DEF RID: 77295 RVA: 0x004A8CEE File Offset: 0x004A6EEE
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data;
	}

	// Token: 0x04008E38 RID: 36408
	[Nullable(2)]
	private VisionEquipmentRecommendFetterGroupView FetterGroupView;

	// Token: 0x04008E39 RID: 36409
	[Nullable(2)]
	public Action<int> OnSelectedCallback;
}
