using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A45 RID: 6725
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoMontageItem : GridProxyAbstract<PhotoMontageItemData>
{
	// Token: 0x06010974 RID: 67956 RVA: 0x004DADB4 File Offset: 0x004D8FB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06010975 RID: 67957 RVA: 0x004DAE5D File Offset: 0x004D905D
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010976 RID: 67958 RVA: 0x004DAE6C File Offset: 0x004D906C
	public override void Refresh(PhotoMontageItemData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		this.SetToggleState(isSelected, false);
	}

	// Token: 0x06010977 RID: 67959 RVA: 0x004DAEC3 File Offset: 0x004D90C3
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010978 RID: 67960 RVA: 0x004DAEE0 File Offset: 0x004D90E0
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06010979 RID: 67961 RVA: 0x004DAEEA File Offset: 0x004D90EA
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x0601097A RID: 67962 RVA: 0x004DAEF4 File Offset: 0x004D90F4
	public override object GetKey(PhotoMontageItemData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0601097B RID: 67963 RVA: 0x004DAF01 File Offset: 0x004D9101
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnMontageClick(base.GridIndex);
	}

	// Token: 0x040092DE RID: 37598
	public Action<int> OnMontageClick = delegate(int gridIndex)
	{
	};

	// Token: 0x02007CAC RID: 31916
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040285E6 RID: 165350
		Toggle,
		// Token: 0x040285E7 RID: 165351
		SpriteIcon,
		// Token: 0x040285E8 RID: 165352
		TextName,
		// Token: 0x040285E9 RID: 165353
		TextCondition,
		// Token: 0x040285EA RID: 165354
		ItemLock
	}
}
