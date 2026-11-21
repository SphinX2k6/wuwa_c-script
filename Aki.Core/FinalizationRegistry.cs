using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004C RID: 76
[NullableContext(1)]
[Nullable(0)]
public class FinalizationRegistry<TValue, [Nullable(2)] TParam> where TValue : class
{
	// Token: 0x06000217 RID: 535 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
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

	// Token: 0x06000218 RID: 536 RVA: 0x0000C630 File Offset: 0x0000A830
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

	// Token: 0x06000219 RID: 537 RVA: 0x0000C661 File Offset: 0x0000A861
	public void TrimExcess()
	{
		this._Registry.TrimExcess();
	}

	// Token: 0x040001C1 RID: 449
	[Nullable(new byte[]
	{
		1,
		1,
		1,
		2
	})]
	private readonly WeakMap<TValue, Finalizer<TParam>> _Registry = new WeakMap<TValue, Finalizer<TParam>>();
}
