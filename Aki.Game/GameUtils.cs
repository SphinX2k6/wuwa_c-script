using System;
using Cysharp.Threading.Tasks;

// Token: 0x0200028F RID: 655
public class GameUtils
{
	// Token: 0x060028AD RID: 10413 RVA: 0x000FCD98 File Offset: 0x000FAF98
	public static UniTask WaitFrame()
	{
		UniTaskCompletionSource tcs = new UniTaskCompletionSource();
		TimerSystem.Instance.Next(delegate(float _)
		{
			tcs.TrySetResult();
		}, null, null);
		return tcs.Task;
	}
}
