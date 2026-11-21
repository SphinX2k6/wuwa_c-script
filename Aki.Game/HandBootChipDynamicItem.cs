using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012EB RID: 4843
[NullableContext(1)]
[Nullable(0)]
public class HandBootChipDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookChipDynamicData>
{
	// Token: 0x0600BEE2 RID: 48866 RVA: 0x00385BF0 File Offset: 0x00383DF0
	public UniTask Init(UUIItem actor)
	{
		HandBootChipDynamicItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HandBootChipDynamicItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600BEE3 RID: 48867 RVA: 0x00385C3B File Offset: 0x00383E3B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BEE4 RID: 48868 RVA: 0x00385C74 File Offset: 0x00383E74
	public FVector2D GetItemSize(HandBookChipDynamicData data)
	{
		if (data.HandBookChipConfigId != null)
		{
			int? handBookChipConfigId = data.HandBookChipConfigId;
			int num = 0;
			if (!(handBookChipConfigId.GetValueOrDefault() == num & handBookChipConfigId != null))
			{
				UUIItem item = base.GetItem(1);
				return new FVector2D(item.GetWidth(), item.GetHeight());
			}
		}
		UUIItem item2 = base.GetItem(0);
		return new FVector2D(item2.GetWidth(), item2.GetHeight());
	}

	// Token: 0x0600BEE5 RID: 48869 RVA: 0x00385CDE File Offset: 0x00383EDE
	public void ClearItem()
	{
	}
}
