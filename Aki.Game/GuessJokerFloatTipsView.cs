using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001064 RID: 4196
public class GuessJokerFloatTipsView : UiViewBase
{
	// Token: 0x06006BD9 RID: 27609 RVA: 0x0015B62C File Offset: 0x0015982C
	[NullableContext(1)]
	public GuessJokerFloatTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006BDA RID: 27610 RVA: 0x0015B635 File Offset: 0x00159835
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06006BDB RID: 27611 RVA: 0x0015B658 File Offset: 0x00159858
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as IGuessJokerTipsData);
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.TextParam != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.TextId, this.Data.TextParam);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.TextId, Array.Empty<object>());
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				base.CloseMe(null);
			}, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerFloatTipTime.ToString()), null, null, true, 1f);
		}, false);
	}

	// Token: 0x040031E7 RID: 12775
	[Nullable(2)]
	protected IGuessJokerTipsData Data;
}
