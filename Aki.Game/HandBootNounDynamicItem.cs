using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012EC RID: 4844
[NullableContext(1)]
[Nullable(0)]
public class HandBootNounDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookNounDynamicData>
{
	// Token: 0x0600BEE8 RID: 48872 RVA: 0x00385CF4 File Offset: 0x00383EF4
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

	// Token: 0x0600BEE9 RID: 48873 RVA: 0x00385D3F File Offset: 0x00383F3F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BEEA RID: 48874 RVA: 0x00385D78 File Offset: 0x00383F78
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

	// Token: 0x0600BEEB RID: 48875 RVA: 0x00385DE2 File Offset: 0x00383FE2
	public void ClearItem()
	{
	}
}
