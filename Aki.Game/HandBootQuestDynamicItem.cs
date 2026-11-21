using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012EE RID: 4846
[NullableContext(1)]
[Nullable(0)]
public class HandBootQuestDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookQuestDynamicData>
{
	// Token: 0x0600BEF4 RID: 48884 RVA: 0x00385F60 File Offset: 0x00384160
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

	// Token: 0x0600BEF5 RID: 48885 RVA: 0x00385FAB File Offset: 0x003841AB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BEF6 RID: 48886 RVA: 0x00385FE4 File Offset: 0x003841E4
	public FVector2D GetItemSize(HandBookQuestDynamicData data)
	{
		UUIItem item = base.GetItem(1);
		return new FVector2D(item.GetWidth(), item.GetHeight());
	}

	// Token: 0x0600BEF7 RID: 48887 RVA: 0x0038600A File Offset: 0x0038420A
	public void ClearItem()
	{
	}
}
