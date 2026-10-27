using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

// Token: 0x0200004B RID: 75
[NullableContext(2)]
[Nullable(0)]
internal class Finalizer<TParam>
{
	// Token: 0x06000213 RID: 531 RVA: 0x0000C887 File Offset: 0x0000AA87
	public void Dispose()
	{
		this._Callback = null;
		GC.SuppressFinalize(this);
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000C896 File Offset: 0x0000AA96
	public Finalizer(TParam param, string reason, Action<TParam, string> callback)
	{
		this._Param = param;
		this._Reason = reason;
		this._Callback = callback;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
	protected override void Finalize()
	{
		try
		{
			Action<TParam, string> callback = this._Callback;
			if (callback != null)
			{
				callback(this._Param, this._Reason);
			}
		}
		catch (Exception ex)
		{
			UnrealLogger.Error(ex.ToString());
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x040001BC RID: 444
	private readonly TParam _Param;

	// Token: 0x040001BD RID: 445
	private readonly string _Reason;

	// Token: 0x040001BE RID: 446
	private Action<TParam, string> _Callback;
}
