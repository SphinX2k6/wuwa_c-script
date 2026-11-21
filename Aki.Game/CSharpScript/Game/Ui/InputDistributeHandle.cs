using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035AC RID: 13740
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeHandle<[Nullable(2)] T>
	{
		// Token: 0x06023050 RID: 143440 RVA: 0x009F5265 File Offset: 0x009F3465
		public InputDistributeHandle(string inputDistributeTag, string name)
		{
			this.InputDistributeTag = inputDistributeTag;
			this.Callback = new InputCallback<T>(name);
			this.IgnoreLimitCallback = new InputCallback<T>(name);
		}

		// Token: 0x06023051 RID: 143441 RVA: 0x009F5297 File Offset: 0x009F3497
		public void Reset()
		{
			this.Callback.Clear();
			this.Callback = null;
			this.IgnoreLimitCallback.Clear();
			this.IgnoreLimitCallback = null;
		}

		// Token: 0x06023052 RID: 143442 RVA: 0x009F52BD File Offset: 0x009F34BD
		protected void Bind(TInputHandle<T> callback)
		{
			this.Callback.Add(callback);
		}

		// Token: 0x06023053 RID: 143443 RVA: 0x009F52CB File Offset: 0x009F34CB
		public void UnBind(TInputHandle<T> callback)
		{
			this.Callback.Remove(callback);
		}

		// Token: 0x06023054 RID: 143444 RVA: 0x009F52D9 File Offset: 0x009F34D9
		protected void Call(T value)
		{
			this.Callback.Call(value);
		}

		// Token: 0x06023055 RID: 143445 RVA: 0x009F52E7 File Offset: 0x009F34E7
		protected void BindIgnoreLimit(TInputHandle<T> callback)
		{
			this.IgnoreLimitCallback.Add(callback);
		}

		// Token: 0x06023056 RID: 143446 RVA: 0x009F52F5 File Offset: 0x009F34F5
		public void UnBindIgnoreLimit(TInputHandle<T> callback)
		{
			this.IgnoreLimitCallback.Remove(callback);
		}

		// Token: 0x06023057 RID: 143447 RVA: 0x009F5303 File Offset: 0x009F3503
		protected void CallIgnoreLimit(T value)
		{
			this.IgnoreLimitCallback.Call(value);
		}

		// Token: 0x06023058 RID: 143448 RVA: 0x009F5311 File Offset: 0x009F3511
		public bool HasIgnoreLimit()
		{
			return this.IgnoreLimitCallback.Length() > 0;
		}

		// Token: 0x06023059 RID: 143449 RVA: 0x009F5321 File Offset: 0x009F3521
		public bool HasCallback()
		{
			return this.Callback.Length() > 0 || this.IgnoreLimitCallback.Length() > 0;
		}

		// Token: 0x0602305A RID: 143450 RVA: 0x009F5341 File Offset: 0x009F3541
		public string GetInputDistributeTag()
		{
			return this.InputDistributeTag;
		}

		// Token: 0x04013BD1 RID: 80849
		private readonly string InputDistributeTag = "";

		// Token: 0x04013BD2 RID: 80850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private InputCallback<T> Callback;

		// Token: 0x04013BD3 RID: 80851
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private InputCallback<T> IgnoreLimitCallback;
	}
}
