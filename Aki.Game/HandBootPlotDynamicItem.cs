using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012ED RID: 4845
[NullableContext(1)]
[Nullable(0)]
public class HandBootPlotDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookPlotDynamicData>
{
	// Token: 0x0600BEEE RID: 48878 RVA: 0x00385DF8 File Offset: 0x00383FF8
	public UniTask Init(UUIItem actor)
	{
		HandBootPlotDynamicItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HandBootPlotDynamicItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600BEEF RID: 48879 RVA: 0x00385E44 File Offset: 0x00384044
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600BEF0 RID: 48880 RVA: 0x00385EB4 File Offset: 0x003840B4
	public FVector2D GetItemSize(HandBookPlotDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.NodeText))
		{
			UUIItem item = base.GetItem(2);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		if (data.TalkOption != null)
		{
			UUIItem item2 = base.GetItem(1);
			return new FVector2D(item2.GetWidth(), item2.GetHeight());
		}
		if (data.OptionTalker.GetValueOrDefault())
		{
			UUIItem item3 = base.GetItem(3);
			return new FVector2D(item3.GetWidth(), item3.GetHeight());
		}
		UUIItem item4 = base.GetItem(0);
		return new FVector2D(item4.GetWidth(), item4.GetHeight());
	}

	// Token: 0x0600BEF1 RID: 48881 RVA: 0x00385F4A File Offset: 0x0038414A
	public void ClearItem()
	{
	}
}
