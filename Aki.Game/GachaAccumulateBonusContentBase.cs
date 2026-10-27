using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001C60 RID: 7264
public abstract class GachaAccumulateBonusContentBase : UiPanelBase
{
	// Token: 0x0600DB15 RID: 56085
	public abstract void RefreshView(int accumulateId);

	// Token: 0x0600DB16 RID: 56086
	public abstract UniTask PlayStartSequence();

	// Token: 0x0600DB17 RID: 56087
	public abstract UniTask PlayCloseSequence();

	// Token: 0x0600DB18 RID: 56088
	[NullableContext(1)]
	public abstract void SetOnClickBackButtonCallBack(Action callback);
}
