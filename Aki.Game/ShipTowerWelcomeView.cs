using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F5E RID: 8030
public class ShipTowerWelcomeView : UiTickViewBase
{
	// Token: 0x17001E09 RID: 7689
	// (get) Token: 0x06013DC5 RID: 81349 RVA: 0x005CAA75 File Offset: 0x005C8C75
	[Nullable(2)]
	public new ShipTowerWelcomeViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as ShipTowerWelcomeViewParams;
		}
	}

	// Token: 0x06013DC6 RID: 81350 RVA: 0x005CAA82 File Offset: 0x005C8C82
	[NullableContext(1)]
	public ShipTowerWelcomeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013DC7 RID: 81351 RVA: 0x005CAA8B File Offset: 0x005C8C8B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06013DC8 RID: 81352 RVA: 0x005CAAAE File Offset: 0x005C8CAE
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

	// Token: 0x0200825E RID: 33374
	private static class EChildType
	{
		// Token: 0x0402A178 RID: 172408
		public const int TxtProgress = 0;
	}
}
