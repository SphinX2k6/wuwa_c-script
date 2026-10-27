using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A52 RID: 6738
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class OnlineItem : GridProxyAbstract<OnlineData>
{
	// Token: 0x0600C653 RID: 50771 RVA: 0x002D18AB File Offset: 0x002CFAAB
	public OnlineItem(bool isShowInBottom)
	{
		this.IsShowInBottom = isShowInBottom;
	}

	// Token: 0x0600C654 RID: 50772 RVA: 0x002D18BC File Offset: 0x002CFABC
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

	// Token: 0x0600C655 RID: 50773 RVA: 0x002D1928 File Offset: 0x002CFB28
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

	// Token: 0x0600C656 RID: 50774 RVA: 0x002D19C8 File Offset: 0x002CFBC8
	private void RefreshPosTexture()
	{
		UUITexture texture = base.GetTexture(0);
		string posTexture = DangoAbyssRankItemHelper.GetPosTexture(base.GridIndex);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
		base.SetTextureByPath(resourcePath, texture, null, null);
	}

	// Token: 0x0600C657 RID: 50775 RVA: 0x002D1A07 File Offset: 0x002CFC07
	public override void Refresh(OnlineData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshName();
		this.RefreshPosTexture();
	}

	// Token: 0x04005B62 RID: 23394
	private OnlineData Data;

	// Token: 0x04005B63 RID: 23395
	private readonly bool IsShowInBottom;

	// Token: 0x02007F9A RID: 32666
	[NullableContext(0)]
	private class EOnlineItem
	{
		// Token: 0x04029A9C RID: 170652
		public const int PosTexture = 0;

		// Token: 0x04029A9D RID: 170653
		public const int Name = 1;
	}
}
