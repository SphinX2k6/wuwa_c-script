using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AA0 RID: 10912
[NullableContext(1)]
[Nullable(0)]
public class SubPackageDownLoadDynamicItem : UiPanelBase, IDynamicScrollBaseItem<SubPackageDownLoadDynamicData>
{
	// Token: 0x06016B9C RID: 93084 RVA: 0x005C3474 File Offset: 0x005C1674
	public UniTask Init(UUIItem actor)
	{
		SubPackageDownLoadDynamicItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<SubPackageDownLoadDynamicItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06016B9D RID: 93085 RVA: 0x005C34C0 File Offset: 0x005C16C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016B9E RID: 93086 RVA: 0x005C351C File Offset: 0x005C171C
	public FVector2D GetItemSize(SubPackageDownLoadDynamicData data)
	{
		if (data.Type != null && data.Type.Value != (ESubPackageDownLoadVersionType)0)
		{
			UUIItem item = base.GetItem(0);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		if (data.VersionId != null && data.VersionId.Value != 0)
		{
			UUIItem item2 = base.GetItem(1);
			return new FVector2D(item2.GetWidth(), item2.GetHeight());
		}
		UUIItem item3 = base.GetItem(2);
		return new FVector2D(item3.GetWidth(), item3.GetHeight());
	}

	// Token: 0x06016B9F RID: 93087 RVA: 0x005C35AA File Offset: 0x005C17AA
	public void ClearItem()
	{
	}
}
