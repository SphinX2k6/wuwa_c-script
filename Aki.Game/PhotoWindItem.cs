using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002566 RID: 9574
public class PhotoWindItem : GridProxyAbstract<PhotoWindDirection>
{
	// Token: 0x0601351B RID: 79131 RVA: 0x004CE7C4 File Offset: 0x004CC9C4
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

	// Token: 0x0601351C RID: 79132 RVA: 0x004CE899 File Offset: 0x004CCA99
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601351D RID: 79133 RVA: 0x004CE8A8 File Offset: 0x004CCAA8
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

	// Token: 0x0601351E RID: 79134 RVA: 0x004CE95F File Offset: 0x004CCB5F
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601351F RID: 79135 RVA: 0x004CE97C File Offset: 0x004CCB7C
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06013520 RID: 79136 RVA: 0x004CE986 File Offset: 0x004CCB86
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06013521 RID: 79137 RVA: 0x004CE990 File Offset: 0x004CCB90
	[NullableContext(1)]
	public override object GetKey(PhotoWindDirection data, int displayIndex)
	{
		return data.IsDefault ? -1 : data.Id;
	}

	// Token: 0x06013522 RID: 79138 RVA: 0x004CE9AA File Offset: 0x004CCBAA
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnWindClick(base.GridIndex);
	}

	// Token: 0x040091B5 RID: 37301
	private PhotoWindDirection Data;

	// Token: 0x040091B6 RID: 37302
	[Nullable(1)]
	public Action<int> OnWindClick = delegate(int gridIndex)
	{
	};

	// Token: 0x02008B42 RID: 35650
	private enum EComponents
	{
		// Token: 0x0402D366 RID: 185190
		ToggleItem,
		// Token: 0x0402D367 RID: 185191
		ItemNormalState,
		// Token: 0x0402D368 RID: 185192
		ItemContent,
		// Token: 0x0402D369 RID: 185193
		TextTitle,
		// Token: 0x0402D36A RID: 185194
		SpriteIcon,
		// Token: 0x0402D36B RID: 185195
		SpriteRedDot,
		// Token: 0x0402D36C RID: 185196
		ItemLockState
	}
}
