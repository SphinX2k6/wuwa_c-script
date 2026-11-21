using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001926 RID: 6438
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionFetterDescItem : GridProxyAbstract<VisionFetterDescData>
{
	// Token: 0x0600FE7F RID: 65151 RVA: 0x004A53C0 File Offset: 0x004A35C0
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

	// Token: 0x0600FE80 RID: 65152 RVA: 0x004A542C File Offset: 0x004A362C
	[NullableContext(1)]
	public override void Refresh(VisionFetterDescData data, bool isSelected, int gridIndex)
	{
		int value = data.Value;
		this.RefreshContent(value);
		this.RefreshName(value, data.Key);
	}

	// Token: 0x0600FE81 RID: 65153 RVA: 0x004A5454 File Offset: 0x004A3654
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

	// Token: 0x0600FE82 RID: 65154 RVA: 0x004A54C8 File Offset: 0x004A36C8
	private void RefreshContent(int fetterId)
	{
		PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(fetterId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomFetterById.EffectDescription, phantomFetterById.EffectDescriptionParam());
	}

	// Token: 0x02007B53 RID: 31571
	private class EVisionFetterDescItem
	{
		// Token: 0x04027F59 RID: 163673
		public const int TitleText = 0;

		// Token: 0x04027F5A RID: 163674
		public const int ContentTextOne = 1;
	}
}
