using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001178 RID: 4472
public class BabelTowerNewLevelTipsView : UiViewBase
{
	// Token: 0x0600762F RID: 30255 RVA: 0x001884AA File Offset: 0x001866AA
	[NullableContext(1)]
	public BabelTowerNewLevelTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007630 RID: 30256 RVA: 0x001884B4 File Offset: 0x001866B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007631 RID: 30257 RVA: 0x001884FC File Offset: 0x001866FC
	protected override void OnStart()
	{
		int levelId = (int)this.OpenParam;
		BabelTowerController.Instance.SaveNewLevelData(levelId);
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
				if (uiViewSequence3 == null)
				{
					return;
				}
				uiViewSequence3.PlaySequence("Close", false, null);
			}, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.AddSequenceFinishEvent("Close", delegate(string _)
		{
			base.CloseMe(null);
		}, false);
	}

	// Token: 0x02007749 RID: 30537
	private class EComponentDefine
	{
		// Token: 0x0402759F RID: 161183
		public const int TitleText = 0;
	}
}
