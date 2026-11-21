using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006ED RID: 1773
public class DangoMonopolyDiceBuffPanel : UiPanelBase
{
	// Token: 0x060051A7 RID: 20903 RVA: 0x001B3BB4 File Offset: 0x001B1DB4
	[NullableContext(1)]
	public UniTask Init(UUIItem parent)
	{
		DangoMonopolyDiceBuffPanel.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.parent = parent;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoMonopolyDiceBuffPanel.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060051A8 RID: 20904 RVA: 0x001B3BFF File Offset: 0x001B1DFF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x060051A9 RID: 20905 RVA: 0x001B3C24 File Offset: 0x001B1E24
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyDiceBuffPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyDiceBuffPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060051AA RID: 20906 RVA: 0x001B3C68 File Offset: 0x001B1E68
	public void UpdateShowType(EDangoMonopolyDiceBuffShowType showType)
	{
		this.SetActive(true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (showType == EDangoMonopolyDiceBuffShowType.Double)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060051AB RID: 20907 RVA: 0x001B3C9C File Offset: 0x001B1E9C
	[NullableContext(1)]
	public UniTask PlaySequence(string name)
	{
		DangoMonopolyDiceBuffPanel.<PlaySequence>d__7 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.name = name;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<DangoMonopolyDiceBuffPanel.<PlaySequence>d__7>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x04003A15 RID: 14869
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x04003A16 RID: 14870
	[Nullable(2)]
	public CustomPromise<bool> Promise;

	// Token: 0x020069AA RID: 27050
	private enum EChildType
	{
		// Token: 0x04022C9C RID: 142492
		ToggleRoot
	}
}
