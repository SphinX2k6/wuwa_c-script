using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020008F9 RID: 2297
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class PoolScrollItem : GridProxyAbstract<ProtoGachaPoolInfo>
{
	// Token: 0x0600662B RID: 26155 RVA: 0x001FF744 File Offset: 0x001FD944
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

	// Token: 0x0600662C RID: 26156 RVA: 0x001FF7D8 File Offset: 0x001FD9D8
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

	// Token: 0x0600662D RID: 26157 RVA: 0x001FF841 File Offset: 0x001FDA41
	public void SelectedToggle()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x0600662E RID: 26158 RVA: 0x001FF853 File Offset: 0x001FDA53
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<ProtoGachaPoolInfo, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.PoolInfo, base.GetExtendToggle(0));
	}

	// Token: 0x0400418E RID: 16782
	[Nullable(2)]
	private ProtoGachaPoolInfo PoolInfo;

	// Token: 0x0400418F RID: 16783
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	public Action<ProtoGachaPoolInfo, UUIExtendToggle> OnClickToggleCallBack;
}
