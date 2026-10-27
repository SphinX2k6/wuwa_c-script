using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x0200272F RID: 10031
public class RacingBetsDungeonBeginTip : UiViewBase
{
	// Token: 0x060148EE RID: 84206 RVA: 0x00531AA3 File Offset: 0x0052FCA3
	[NullableContext(1)]
	public RacingBetsDungeonBeginTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148EF RID: 84207 RVA: 0x00531AAC File Offset: 0x0052FCAC
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
