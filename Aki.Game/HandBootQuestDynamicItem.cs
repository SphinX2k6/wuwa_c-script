using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E2C RID: 7724
[NullableContext(1)]
[Nullable(0)]
public class HandBootQuestDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookQuestDynamicData>
{
	// Token: 0x0600EAD5 RID: 60117 RVA: 0x0037A2D4 File Offset: 0x003784D4
	public UniTask Init(UUIItem actor)
	{
		HandBootQuestDynamicItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HandBootQuestDynamicItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAD6 RID: 60118 RVA: 0x0037A31F File Offset: 0x0037851F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EAD7 RID: 60119 RVA: 0x0037A358 File Offset: 0x00378558
	public FVector2D GetItemSize(HandBookQuestDynamicData data)
	{
		UUIItem item = base.GetItem(1);
		return new FVector2D(item.GetWidth(), item.GetHeight());
	}

	// Token: 0x0600EAD8 RID: 60120 RVA: 0x0037A37E File Offset: 0x0037857E
	public void ClearItem()
	{
	}
}
