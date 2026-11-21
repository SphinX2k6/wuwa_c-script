using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019C9 RID: 6601
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x06010484 RID: 66692 RVA: 0x004C1420 File Offset: 0x004BF620
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06010485 RID: 66693 RVA: 0x004C14A0 File Offset: 0x004BF6A0
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
		this.ElementLayout = new GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData>(base.GetLayoutBase(1), new Func<FetterIconItem>(this.InitElementItem), null, false, true);
	}

	// Token: 0x06010486 RID: 66694 RVA: 0x004C14EC File Offset: 0x004BF6EC
	private FetterIconItem InitElementItem()
	{
		return new FetterIconItem();
	}

	// Token: 0x06010487 RID: 66695 RVA: 0x004C14F3 File Offset: 0x004BF6F3
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		this.ElementLayout.RefreshByData(data.BuildFetterItemDataList(), null, false);
		this.RefreshUsage(data.GetUsageText());
	}

	// Token: 0x06010488 RID: 66696 RVA: 0x004C1514 File Offset: 0x004BF714
	private void RefreshUsage(string txt)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(txt, true);
	}

	// Token: 0x06010489 RID: 66697 RVA: 0x004C1529 File Offset: 0x004BF729
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

	// Token: 0x0601048A RID: 66698 RVA: 0x004C1545 File Offset: 0x004BF745
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x0601048B RID: 66699 RVA: 0x004C154F File Offset: 0x004BF74F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x0601048C RID: 66700 RVA: 0x004C1559 File Offset: 0x004BF759
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601048D RID: 66701 RVA: 0x004C1576 File Offset: 0x004BF776
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data.GetPlanId();
	}

	// Token: 0x04009031 RID: 36913
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData> ElementLayout;

	// Token: 0x04009032 RID: 36914
	[Nullable(2)]
	public Action<int> OnSelectedCallback;

	// Token: 0x02007BF9 RID: 31737
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04028262 RID: 164450
		Toggle,
		// Token: 0x04028263 RID: 164451
		ElementLayout,
		// Token: 0x04028264 RID: 164452
		UsageText
	}
}
