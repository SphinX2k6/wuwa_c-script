using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006F3 RID: 1779
public class DangoMonopolyPosition : UiPanelBase
{
	// Token: 0x06005231 RID: 21041 RVA: 0x001B5D5C File Offset: 0x001B3F5C
	[NullableContext(1)]
	public UniTask Init(UUIItem parent)
	{
		DangoMonopolyPosition.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.parent = parent;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoMonopolyPosition.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06005232 RID: 21042 RVA: 0x001B5DA7 File Offset: 0x001B3FA7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06005233 RID: 21043 RVA: 0x001B5DCA File Offset: 0x001B3FCA
	public void UpdatePosition(FVector2D vec, bool show = true)
	{
		this.SetActive(show);
		base.GetRootItem().SetAnchorOffset(vec);
	}

	// Token: 0x020069CE RID: 27086
	private enum EChildType
	{
		// Token: 0x04022D55 RID: 142677
		Item
	}
}
