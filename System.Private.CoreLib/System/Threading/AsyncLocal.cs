using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003C7 RID: 967
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AsyncLocal<[Nullable(2)] T> : IAsyncLocal
	{
		// Token: 0x06003F6E RID: 16238 RVA: 0x00005ACC File Offset: 0x00003CCC
		public AsyncLocal()
		{
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x000D3F9D File Offset: 0x000D219D
		public AsyncLocal([Nullable(new byte[]
		{
			2,
			0,
			1
		})] Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
		{
			this._valueChangedHandler = valueChangedHandler;
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x000D3FAC File Offset: 0x000D21AC
		// (set) Token: 0x06003F71 RID: 16241 RVA: 0x000D3FE4 File Offset: 0x000D21E4
		public T Value
		{
			[return: MaybeNull]
			get
			{
				object localValue = ExecutionContext.GetLocalValue(this);
				if (typeof(T).IsValueType && localValue == null)
				{
					return default(T);
				}
				return (T)((object)localValue);
			}
			set
			{
				ExecutionContext.SetLocalValue(this, value, this._valueChangedHandler != null);
			}
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x000D4000 File Offset: 0x000D2200
		void IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged)
		{
			T previousValue = (previousValueObj == null) ? default(T) : ((T)((object)previousValueObj));
			T currentValue = (currentValueObj == null) ? default(T) : ((T)((object)currentValueObj));
			this._valueChangedHandler(new AsyncLocalValueChangedArgs<T>(previousValue, currentValue, contextChanged));
		}

		// Token: 0x04000D16 RID: 3350
		private readonly Action<AsyncLocalValueChangedArgs<T>> _valueChangedHandler;
	}
}
