using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000518 RID: 1304
public class GuessJokerFloatTipsView : UiViewBase
{
	// Token: 0x06003F6E RID: 16238 RVA: 0x00163F74 File Offset: 0x00162174
	[NullableContext(1)]
	public GuessJokerFloatTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003F6F RID: 16239 RVA: 0x00163F7D File Offset: 0x0016217D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06003F70 RID: 16240 RVA: 0x00163FA0 File Offset: 0x001621A0
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

	// Token: 0x04003280 RID: 12928
	[Nullable(2)]
	protected IGuessJokerTipsData Data;
}
