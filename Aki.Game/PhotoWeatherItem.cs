using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A50 RID: 6736
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoWeatherItem : GridProxyAbstract<PhotoWeatherData>
{
	// Token: 0x060109F4 RID: 68084 RVA: 0x004DD1D4 File Offset: 0x004DB3D4
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

	// Token: 0x060109F5 RID: 68085 RVA: 0x004DD2A9 File Offset: 0x004DB4A9
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060109F6 RID: 68086 RVA: 0x004DD2B8 File Offset: 0x004DB4B8
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

	// Token: 0x060109F7 RID: 68087 RVA: 0x004DD36C File Offset: 0x004DB56C
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060109F8 RID: 68088 RVA: 0x004DD389 File Offset: 0x004DB589
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060109F9 RID: 68089 RVA: 0x004DD393 File Offset: 0x004DB593
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060109FA RID: 68090 RVA: 0x004DD39D File Offset: 0x004DB59D
	public override object GetKey(PhotoWeatherData data, int displayIndex)
	{
		return data.IsDefault ? -1 : data.WeatherId;
	}

	// Token: 0x060109FB RID: 68091 RVA: 0x004DD3B5 File Offset: 0x004DB5B5
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnWeatherClick(base.GridIndex);
	}

	// Token: 0x0400930C RID: 37644
	private PhotoWeatherData Data;

	// Token: 0x0400930D RID: 37645
	public Action<int> OnWeatherClick = delegate(int gridIndex)
	{
	};

	// Token: 0x02007CC6 RID: 31942
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028669 RID: 165481
		ToggleItem,
		// Token: 0x0402866A RID: 165482
		ItemNormalPanel,
		// Token: 0x0402866B RID: 165483
		ItemWeatherPanel,
		// Token: 0x0402866C RID: 165484
		TextName,
		// Token: 0x0402866D RID: 165485
		SpriteIcon,
		// Token: 0x0402866E RID: 165486
		SpriteRedDot,
		// Token: 0x0402866F RID: 165487
		ItemLockState
	}
}
