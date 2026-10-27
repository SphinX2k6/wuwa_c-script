using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002565 RID: 9573
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoWeatherItem : GridProxyAbstract<PhotoWeatherData>
{
	// Token: 0x06013512 RID: 79122 RVA: 0x004CE59C File Offset: 0x004CC79C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06013513 RID: 79123 RVA: 0x004CE671 File Offset: 0x004CC871
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06013514 RID: 79124 RVA: 0x004CE680 File Offset: 0x004CC880
	public override void Refresh(PhotoWeatherData data, bool isSelected, int gridIndex)
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
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		this.SetToggleState(isSelected, false);
	}

	// Token: 0x06013515 RID: 79125 RVA: 0x004CE734 File Offset: 0x004CC934
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06013516 RID: 79126 RVA: 0x004CE751 File Offset: 0x004CC951
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06013517 RID: 79127 RVA: 0x004CE75B File Offset: 0x004CC95B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06013518 RID: 79128 RVA: 0x004CE765 File Offset: 0x004CC965
	public override object GetKey(PhotoWeatherData data, int displayIndex)
	{
		return data.IsDefault ? -1 : data.WeatherId;
	}

	// Token: 0x06013519 RID: 79129 RVA: 0x004CE77D File Offset: 0x004CC97D
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnWeatherClick(base.GridIndex);
	}

	// Token: 0x040091B3 RID: 37299
	private PhotoWeatherData Data;

	// Token: 0x040091B4 RID: 37300
	public Action<int> OnWeatherClick = delegate(int gridIndex)
	{
	};

	// Token: 0x02008B40 RID: 35648
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D35C RID: 185180
		ToggleItem,
		// Token: 0x0402D35D RID: 185181
		ItemNormalPanel,
		// Token: 0x0402D35E RID: 185182
		ItemWeatherPanel,
		// Token: 0x0402D35F RID: 185183
		TextName,
		// Token: 0x0402D360 RID: 185184
		SpriteIcon,
		// Token: 0x0402D361 RID: 185185
		SpriteRedDot,
		// Token: 0x0402D362 RID: 185186
		ItemLockState
	}
}
