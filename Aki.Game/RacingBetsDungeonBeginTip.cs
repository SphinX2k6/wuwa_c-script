using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001C1A RID: 7194
public class RacingBetsDungeonBeginTip : UiViewBase
{
	// Token: 0x06011DD0 RID: 73168 RVA: 0x005407BB File Offset: 0x0053E9BB
	[NullableContext(1)]
	public RacingBetsDungeonBeginTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DD1 RID: 73169 RVA: 0x005407C4 File Offset: 0x0053E9C4
	protected override void OnAfterPlayStartSequence()
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			UniTaskCompletionSource uniTaskCompletionSource = this.OpenParam as UniTaskCompletionSource;
			base.CloseMe(null);
			if (uniTaskCompletionSource == null)
			{
				return;
			}
			uniTaskCompletionSource.TrySetResult();
		}, null, null);
	}
}
