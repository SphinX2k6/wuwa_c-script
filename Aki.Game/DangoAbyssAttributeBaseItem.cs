using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A26 RID: 6694
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssAttributeBaseItem : UiPanelBase, IDynamicScrollBaseItem<DangoAbyssDefine.EquipViewAttributeData>
{
	// Token: 0x0600C4F1 RID: 50417 RVA: 0x002CABCC File Offset: 0x002C8DCC
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

	// Token: 0x0600C4F2 RID: 50418 RVA: 0x002CAC18 File Offset: 0x002C8E18
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600C4F3 RID: 50419 RVA: 0x002CAC74 File Offset: 0x002C8E74
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

	// Token: 0x0600C4F4 RID: 50420 RVA: 0x002CACDE File Offset: 0x002C8EDE
	public void ClearItem()
	{
	}
}
