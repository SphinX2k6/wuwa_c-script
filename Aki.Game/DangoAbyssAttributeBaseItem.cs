using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EE5 RID: 3813
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssAttributeBaseItem : UiPanelBase, IDynamicScrollBaseItem<DangoAbyssDefine.EquipViewAttributeData>
{
	// Token: 0x06009901 RID: 39169 RVA: 0x002D5CEC File Offset: 0x002D3EEC
	public UniTask Init(UUIItem actor)
	{
		DangoAbyssAttributeBaseItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoAbyssAttributeBaseItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06009902 RID: 39170 RVA: 0x002D5D38 File Offset: 0x002D3F38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06009903 RID: 39171 RVA: 0x002D5D94 File Offset: 0x002D3F94
	public FVector2D GetItemSize(DangoAbyssDefine.EquipViewAttributeData data)
	{
		if (data.Attribute != null)
		{
			UUIItem item = base.GetItem(1);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		if (data.Tag != null)
		{
			UUIItem item2 = base.GetItem(2);
			return new FVector2D(item2.GetWidth(), item2.GetHeight());
		}
		UUIItem item3 = base.GetItem(0);
		return new FVector2D(item3.GetWidth(), item3.GetHeight());
	}

	// Token: 0x06009904 RID: 39172 RVA: 0x002D5DFE File Offset: 0x002D3FFE
	public void ClearItem()
	{
	}
}
