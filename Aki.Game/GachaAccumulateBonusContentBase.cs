using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x0200111F RID: 4383
public abstract class GachaAccumulateBonusContentBase : UiPanelBase
{
	// Token: 0x0600AF2B RID: 44843
	public abstract void RefreshView(int accumulateId);

	// Token: 0x0600AF2C RID: 44844
	public abstract UniTask PlayStartSequence();

	// Token: 0x0600AF2D RID: 44845
	public abstract UniTask PlayCloseSequence();

	// Token: 0x0600AF2E RID: 44846
	[NullableContext(1)]
	public abstract void SetOnClickBackButtonCallBack(Action callback);
}
