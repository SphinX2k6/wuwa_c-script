using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02003507 RID: 13575
public class GameModePromise
{
	// Token: 0x17002903 RID: 10499
	// (get) Token: 0x0601DC54 RID: 121940 RVA: 0x00857A0B File Offset: 0x00855C0B
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

	// Token: 0x0601DC55 RID: 121941 RVA: 0x00857A2C File Offset: 0x00855C2C
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

	// Token: 0x0400E990 RID: 59792
	[Nullable(1)]
	private readonly AkiUniTask<bool> promiseSource = new AkiUniTask<bool>();

	// Token: 0x0400E991 RID: 59793
	private bool HasResult;

	// Token: 0x0400E992 RID: 59794
	private bool Result;
}
