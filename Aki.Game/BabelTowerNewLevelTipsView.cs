using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200062C RID: 1580
public class BabelTowerNewLevelTipsView : UiViewBase
{
	// Token: 0x060049C6 RID: 18886 RVA: 0x0019105A File Offset: 0x0018F25A
	[NullableContext(1)]
	public BabelTowerNewLevelTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x00191064 File Offset: 0x0018F264
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

	// Token: 0x060049C8 RID: 18888 RVA: 0x001910AC File Offset: 0x0018F2AC
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

	// Token: 0x020068D6 RID: 26838
	private class EComponentDefine
	{
		// Token: 0x040228D8 RID: 141528
		public const int TitleText = 0;
	}
}
