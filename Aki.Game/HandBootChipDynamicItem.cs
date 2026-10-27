using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E29 RID: 7721
[NullableContext(1)]
[Nullable(0)]
public class HandBootChipDynamicItem : UiPanelBase, IDynamicScrollBaseItem<HandBookChipDynamicData>
{
	// Token: 0x0600EAC3 RID: 60099 RVA: 0x00379F64 File Offset: 0x00378164
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

	// Token: 0x0600EAC4 RID: 60100 RVA: 0x00379FAF File Offset: 0x003781AF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EAC5 RID: 60101 RVA: 0x00379FE8 File Offset: 0x003781E8
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

	// Token: 0x0600EAC6 RID: 60102 RVA: 0x0037A052 File Offset: 0x00378252
	public void ClearItem()
	{
	}
}
