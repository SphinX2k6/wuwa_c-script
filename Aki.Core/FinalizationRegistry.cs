using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004C RID: 76
[NullableContext(1)]
[Nullable(0)]
public class FinalizationRegistry<TValue, [Nullable(2)] TParam> where TValue : class
{
	// Token: 0x06000216 RID: 534 RVA: 0x0000C910 File Offset: 0x0000AB10
	[NullableContext(2)]
	public bool Register([Nullable(1)] TValue target, TParam param, string reason, Action<TParam, string> callback)
	{
		Finalizer<TParam> finalizer;
		if (this._Registry.TryGetValue(target, out finalizer))
		{
			finalizer.Dispose();
		}
		Finalizer<TParam> value = new Finalizer<TParam>(param, reason, callback);
		this._Registry.Set(target, value);
		return true;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000C94C File Offset: 0x0000AB4C
	public bool Unregister(TValue target)
	{
		Finalizer<TParam> finalizer;
		if (!this._Registry.TryGetValue(target, out finalizer))
		{
			return false;
		}
		finalizer.Dispose();
		return this._Registry.Remove(target);
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000C97D File Offset: 0x0000AB7D
	public void TrimExcess()
	{
		this._Registry.TrimExcess();
	}

	// Token: 0x040001BF RID: 447
	[Nullable(new byte[]
	{
		1,
		1,
		1,
		2
	})]
	private readonly WeakMap<TValue, Finalizer<TParam>> _Registry = new WeakMap<TValue, Finalizer<TParam>>();
}
