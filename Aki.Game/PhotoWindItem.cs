using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A51 RID: 6737
public class PhotoWindItem : GridProxyAbstract<PhotoWindDirection>
{
	// Token: 0x060109FD RID: 68093 RVA: 0x004DD3FC File Offset: 0x004DB5FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060109FE RID: 68094 RVA: 0x004DD4D1 File Offset: 0x004DB6D1
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060109FF RID: 68095 RVA: 0x004DD4E0 File Offset: 0x004DB6E0
	public override void Refresh(PhotoWindDirection data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool isDefault = data.IsDefault;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(isDefault);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(!isDefault);
		}
		if (!isDefault)
		{
			this.SetSpriteByPath(data.Icon, base.GetSprite(4), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Name.ToString(), Array.Empty<object>());
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		this.SetToggleState(isSelected, false);
	}

	// Token: 0x06010A00 RID: 68096 RVA: 0x004DD597 File Offset: 0x004DB797
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010A01 RID: 68097 RVA: 0x004DD5B4 File Offset: 0x004DB7B4
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06010A02 RID: 68098 RVA: 0x004DD5BE File Offset: 0x004DB7BE
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06010A03 RID: 68099 RVA: 0x004DD5C8 File Offset: 0x004DB7C8
	[NullableContext(1)]
	public override object GetKey(PhotoWindDirection data, int displayIndex)
	{
		return data.IsDefault ? -1 : data.Id;
	}

	// Token: 0x06010A04 RID: 68100 RVA: 0x004DD5E2 File Offset: 0x004DB7E2
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnWindClick(base.GridIndex);
	}

	// Token: 0x0400930E RID: 37646
	private PhotoWindDirection Data;

	// Token: 0x0400930F RID: 37647
	[Nullable(1)]
	public Action<int> OnWindClick = delegate(int gridIndex)
	{
	};

	// Token: 0x02007CC8 RID: 31944
	private enum EComponents
	{
		// Token: 0x04028673 RID: 165491
		ToggleItem,
		// Token: 0x04028674 RID: 165492
		ItemNormalState,
		// Token: 0x04028675 RID: 165493
		ItemContent,
		// Token: 0x04028676 RID: 165494
		TextTitle,
		// Token: 0x04028677 RID: 165495
		SpriteIcon,
		// Token: 0x04028678 RID: 165496
		SpriteRedDot,
		// Token: 0x04028679 RID: 165497
		ItemLockState
	}
}
