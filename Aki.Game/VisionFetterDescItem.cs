using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002441 RID: 9281
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionFetterDescItem : GridProxyAbstract<VisionFetterDescData>
{
	// Token: 0x060129C9 RID: 76233 RVA: 0x00497DEC File Offset: 0x00495FEC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060129CA RID: 76234 RVA: 0x00497E58 File Offset: 0x00496058
	[NullableContext(1)]
	public override void Refresh(VisionFetterDescData data, bool isSelected, int gridIndex)
	{
		int value = data.Value;
		this.RefreshContent(value);
		this.RefreshName(value, data.Key);
	}

	// Token: 0x060129CB RID: 76235 RVA: 0x00497E80 File Offset: 0x00496080
	private void RefreshName(int fetterId, int needNum)
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetPhantomFetterById(fetterId).Name, null);
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(localTextNew ?? "", true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "VisionFetterDetailViewName", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			needNum.ToString()
		}));
	}

	// Token: 0x060129CC RID: 76236 RVA: 0x00497EF4 File Offset: 0x004960F4
	private void RefreshContent(int fetterId)
	{
		PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(fetterId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomFetterById.EffectDescription, phantomFetterById.EffectDescriptionParam());
	}

	// Token: 0x020089CC RID: 35276
	private class EVisionFetterDescItem
	{
		// Token: 0x0402CC43 RID: 183363
		public const int TitleText = 0;

		// Token: 0x0402CC44 RID: 183364
		public const int ContentTextOne = 1;
	}
}
