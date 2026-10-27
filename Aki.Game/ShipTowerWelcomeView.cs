using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029E3 RID: 10723
public class ShipTowerWelcomeView : UiTickViewBase
{
	// Token: 0x17001DB0 RID: 7600
	// (get) Token: 0x060163BF RID: 91071 RVA: 0x0059FABD File Offset: 0x0059DCBD
	[Nullable(2)]
	public new ShipTowerWelcomeViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as ShipTowerWelcomeViewParams;
		}
	}

	// Token: 0x060163C0 RID: 91072 RVA: 0x0059FACA File Offset: 0x0059DCCA
	[NullableContext(1)]
	public ShipTowerWelcomeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060163C1 RID: 91073 RVA: 0x0059FAD3 File Offset: 0x0059DCD3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060163C2 RID: 91074 RVA: 0x0059FAF6 File Offset: 0x0059DCF6
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
		{
			ShipTowerWelcomeViewParams openParam = this.OpenParam;
			if (openParam == null)
			{
				return;
			}
			CustomPromise<bool> promise = openParam.Promise;
			if (promise == null)
			{
				return;
			}
			promise.SetResult(true);
		}, false);
	}

	// Token: 0x02009017 RID: 36887
	private static class EChildType
	{
		// Token: 0x0402EA80 RID: 191104
		public const int TxtProgress = 0;
	}
}
