using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200123F RID: 4671
public class DangoMonopolyPosition : UiPanelBase
{
	// Token: 0x06007E9A RID: 32410 RVA: 0x001AD0A4 File Offset: 0x001AB2A4
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

	// Token: 0x06007E9B RID: 32411 RVA: 0x001AD0EF File Offset: 0x001AB2EF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06007E9C RID: 32412 RVA: 0x001AD112 File Offset: 0x001AB312
	public void UpdatePosition(FVector2D vec, bool show = true)
	{
		this.SetActive(show);
		base.GetRootItem().SetAnchorOffset(vec);
	}

	// Token: 0x02007843 RID: 30787
	private enum EChildType
	{
		// Token: 0x04027A24 RID: 162340
		Item
	}
}
