using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001445 RID: 5189
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class PoolScrollItem : GridProxyAbstract<ProtoGachaPoolInfo>
{
	// Token: 0x06009296 RID: 37526 RVA: 0x001F6C08 File Offset: 0x001F4E08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06009297 RID: 37527 RVA: 0x001F6C9C File Offset: 0x001F4E9C
	public override void Refresh(ProtoGachaPoolInfo data, bool isSelected, int gridIndex)
	{
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(data.Id);
		if (gachaViewInfo == null)
		{
			return;
		}
		GachaViewInfo value = gachaViewInfo.Value;
		this.PoolInfo = data;
		this.SetSpriteByPath(value.TagNotSelectedSpritePath, base.GetSprite(1), true, null, null);
		base.GetText(2).SetText(data.Title, true);
	}

	// Token: 0x06009298 RID: 37528 RVA: 0x001F6D05 File Offset: 0x001F4F05
	public void SelectedToggle()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06009299 RID: 37529 RVA: 0x001F6D17 File Offset: 0x001F4F17
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<ProtoGachaPoolInfo, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.PoolInfo, base.GetExtendToggle(0));
	}

	// Token: 0x040040F6 RID: 16630
	[Nullable(2)]
	private ProtoGachaPoolInfo PoolInfo;

	// Token: 0x040040F7 RID: 16631
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	public Action<ProtoGachaPoolInfo, UUIExtendToggle> OnClickToggleCallBack;
}
