using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E56 RID: 7766
public class FloroRanchHelpView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x0600EC18 RID: 60440 RVA: 0x00380C2C File Offset: 0x0037EE2C
	[NullableContext(1)]
	public FloroRanchHelpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EC19 RID: 60441 RVA: 0x00380C38 File Offset: 0x0037EE38
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

	// Token: 0x0600EC1A RID: 60442 RVA: 0x00380CC4 File Offset: 0x0037EEC4
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<FloroRanchHelpItem, HelpText>(base.GetVerticalLayout(1), () => new FloroRanchHelpItem(), null, false, true);
		int groupId = (int)this.OpenParam;
		IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(groupId);
		if (helpContentInfoByGroupId != null)
		{
			this.Layout.RefreshByData(helpContentInfoByGroupId.ToList<HelpText>(), null, false);
			if (helpContentInfoByGroupId.Count > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), helpContentInfoByGroupId[0].Title, Array.Empty<object>());
			}
		}
	}

	// Token: 0x0600EC1B RID: 60443 RVA: 0x00380D61 File Offset: 0x0037EF61
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param)
	{
		return new EUiBehaviourPopType?(EUiBehaviourPopType.FloroRanchHelp);
	}

	// Token: 0x04006D77 RID: 28023
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FloroRanchHelpItem, HelpText> Layout;

	// Token: 0x02008409 RID: 33801
	private enum EComponents
	{
		// Token: 0x0402AFA1 RID: 176033
		TextTitle,
		// Token: 0x0402AFA2 RID: 176034
		ItemContent,
		// Token: 0x0402AFA3 RID: 176035
		ItemText
	}
}
