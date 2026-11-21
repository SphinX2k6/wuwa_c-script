using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002A7C RID: 10876
public class GameModePromise
{
	// Token: 0x17002C9C RID: 11420
	// (get) Token: 0x0601B96E RID: 113006 RVA: 0x0087FFD5 File Offset: 0x0087E1D5
	public UniTask<bool> Promise
	{
		get
		{
			if (this.HasResult)
			{
				return UniTask.FromResult<bool>(this.Result);
			}
			return this.promiseSource.GetTask();
		}
	}

	// Token: 0x0601B96F RID: 113007 RVA: 0x0087FFF8 File Offset: 0x0087E1F8
	public void SetResult(bool value)
	{
		this.HasResult = true;
		this.Result = value;
		if (GlobalData.Networking() && !Net.Instance.IsServerConnected())
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.LFJW, "账号已经登出", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.promiseSource.TrySetCanceled();
			return;
		}
		this.promiseSource.TrySetResult(value);
	}

	// Token: 0x0400EE4B RID: 61003
	[Nullable(1)]
	private readonly AkiUniTask<bool> promiseSource = new AkiUniTask<bool>();

	// Token: 0x0400EE4C RID: 61004
	private bool HasResult;

	// Token: 0x0400EE4D RID: 61005
	private bool Result;
}
