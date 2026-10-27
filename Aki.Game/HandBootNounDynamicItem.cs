using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E2A RID: 7722
[NullableContext(1)]
[Nullable(0)]
public class HandBootNounDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookNounDynamicData>
{
	// Token: 0x0600EAC9 RID: 60105 RVA: 0x0037A068 File Offset: 0x00378268
	public UniTask Init(UUIItem actor)
	{
		HandBootNounDynamicItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HandBootNounDynamicItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EACA RID: 60106 RVA: 0x0037A0B3 File Offset: 0x003782B3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EACB RID: 60107 RVA: 0x0037A0EC File Offset: 0x003782EC
	public FVector2D GetItemSize(HandBookNounDynamicData data)
	{
		if (data.HandBookNounConfigId != null)
		{
			int? handBookNounConfigId = data.HandBookNounConfigId;
			int num = 0;
			if (!(handBookNounConfigId.GetValueOrDefault() == num & handBookNounConfigId != null))
			{
				UUIItem item = base.GetItem(1);
				return new FVector2D(item.GetWidth(), item.GetHeight());
			}
		}
		UUIItem item2 = base.GetItem(0);
		return new FVector2D(item2.GetWidth(), item2.GetHeight());
	}

	// Token: 0x0600EACC RID: 60108 RVA: 0x0037A156 File Offset: 0x00378356
	public void ClearItem()
	{
	}
}
