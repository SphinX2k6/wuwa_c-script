using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F11 RID: 3857
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class OnlineItem : GridProxyAbstract<OnlineData>
{
	// Token: 0x06009A63 RID: 39523 RVA: 0x002DC9BF File Offset: 0x002DABBF
	public OnlineItem(bool isShowInBottom)
	{
		this.IsShowInBottom = isShowInBottom;
	}

	// Token: 0x06009A64 RID: 39524 RVA: 0x002DC9D0 File Offset: 0x002DABD0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009A65 RID: 39525 RVA: 0x002DCA3C File Offset: 0x002DAC3C
	private void RefreshName()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int playerId = this.Data.PlayerId;
		bool flag = id.GetValueOrDefault() == playerId & id != null;
		UUIText text = base.GetText(1);
		if (this.IsShowInBottom && flag)
		{
			string newText = PlayerInfoModel.Instance.GetAccountName(true) ?? "";
			text.SetText(newText, true);
			return;
		}
		string playerName = this.Data.PlayerName;
		if (StringUtils.IsBlank(playerName))
		{
			LguiUtil.Instance.SetLocalTextNew(text, "OnlineGymnasium_AnonymityName", Array.Empty<object>());
			return;
		}
		text.SetText(playerName, true);
	}

	// Token: 0x06009A66 RID: 39526 RVA: 0x002DCADC File Offset: 0x002DACDC
	private void RefreshPosTexture()
	{
		UUITexture texture = base.GetTexture(0);
		string posTexture = DangoAbyssRankItemHelper.GetPosTexture(base.GridIndex);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
		base.SetTextureByPath(resourcePath, texture, null, null);
	}

	// Token: 0x06009A67 RID: 39527 RVA: 0x002DCB1B File Offset: 0x002DAD1B
	public override void Refresh(OnlineData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshName();
		this.RefreshPosTexture();
	}

	// Token: 0x04005C31 RID: 23601
	private OnlineData Data;

	// Token: 0x04005C32 RID: 23602
	private readonly bool IsShowInBottom;

	// Token: 0x02007129 RID: 28969
	[NullableContext(0)]
	private class EOnlineItem
	{
		// Token: 0x04024DD9 RID: 151001
		public const int PosTexture = 0;

		// Token: 0x04024DDA RID: 151002
		public const int Name = 1;
	}
}
