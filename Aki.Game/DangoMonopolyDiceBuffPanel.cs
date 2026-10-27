using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001239 RID: 4665
public class DangoMonopolyDiceBuffPanel : UiPanelBase
{
	// Token: 0x06007E10 RID: 32272 RVA: 0x001AAEF4 File Offset: 0x001A90F4
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

	// Token: 0x06007E11 RID: 32273 RVA: 0x001AAF3F File Offset: 0x001A913F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x06007E12 RID: 32274 RVA: 0x001AAF64 File Offset: 0x001A9164
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyDiceBuffPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyDiceBuffPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007E13 RID: 32275 RVA: 0x001AAFA8 File Offset: 0x001A91A8
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

	// Token: 0x06007E14 RID: 32276 RVA: 0x001AAFDC File Offset: 0x001A91DC
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

	// Token: 0x0400397D RID: 14717
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x0400397E RID: 14718
	[Nullable(2)]
	public CustomPromise<bool> Promise;

	// Token: 0x0200781F RID: 30751
	private enum EChildType
	{
		// Token: 0x0402796B RID: 162155
		ToggleRoot
	}
}
