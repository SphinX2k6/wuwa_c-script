using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001318 RID: 4888
public class FloroRanchHelpView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x0600C037 RID: 49207 RVA: 0x0038C8DC File Offset: 0x0038AADC
	[NullableContext(1)]
	public FloroRanchHelpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C038 RID: 49208 RVA: 0x0038C8E8 File Offset: 0x0038AAE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C039 RID: 49209 RVA: 0x0038C974 File Offset: 0x0038AB74
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<FloroRanchHelpItem, HelpText>(base.GetVerticalLayout(1), () => new FloroRanchHelpItem(), null, false, true);
		int groupId = (int)this.OpenParam;
		IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(groupId);
		if (helpContentInfoByGroupId != null)
		{
			this.Layout.RefreshByData(helpContentInfoByGroupId, null, false);
			if (helpContentInfoByGroupId.Count > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), helpContentInfoByGroupId[0].Title, Array.Empty<object>());
			}
		}
	}

	// Token: 0x0600C03A RID: 49210 RVA: 0x0038CA0C File Offset: 0x0038AC0C
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param)
	{
		return new EUiBehaviourPopType?(EUiBehaviourPopType.FloroRanchHelp);
	}

	// Token: 0x04006E58 RID: 28248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FloroRanchHelpItem, HelpText> Layout;

	// Token: 0x0200758E RID: 30094
	private enum EComponents
	{
		// Token: 0x040262C5 RID: 156357
		TextTitle,
		// Token: 0x040262C6 RID: 156358
		ItemContent,
		// Token: 0x040262C7 RID: 156359
		ItemText
	}
}
