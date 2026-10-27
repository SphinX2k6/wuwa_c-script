using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200467B RID: 18043
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeHandle<[Nullable(2)] T>
	{
		// Token: 0x0602E906 RID: 190726 RVA: 0x00AC7705 File Offset: 0x00AC5905
		public InputDistributeHandle(string inputDistributeTag, string name)
		{
			this.InputDistributeTag = inputDistributeTag;
			this.Callback = new InputCallback<T>(name);
			this.IgnoreLimitCallback = new InputCallback<T>(name);
		}

		// Token: 0x0602E907 RID: 190727 RVA: 0x00AC7737 File Offset: 0x00AC5937
		public void Reset()
		{
			this.Callback.Clear();
			this.Callback = null;
			this.IgnoreLimitCallback.Clear();
			this.IgnoreLimitCallback = null;
		}

		// Token: 0x0602E908 RID: 190728 RVA: 0x00AC775D File Offset: 0x00AC595D
		protected void Bind(TInputHandle<T> callback)
		{
			this.Callback.Add(callback);
		}

		// Token: 0x0602E909 RID: 190729 RVA: 0x00AC776B File Offset: 0x00AC596B
		public void UnBind(TInputHandle<T> callback)
		{
			this.Callback.Remove(callback);
		}

		// Token: 0x0602E90A RID: 190730 RVA: 0x00AC7779 File Offset: 0x00AC5979
		protected void Call(T value)
		{
			this.Callback.Call(value);
		}

		// Token: 0x0602E90B RID: 190731 RVA: 0x00AC7787 File Offset: 0x00AC5987
		protected void BindIgnoreLimit(TInputHandle<T> callback)
		{
			this.IgnoreLimitCallback.Add(callback);
		}

		// Token: 0x0602E90C RID: 190732 RVA: 0x00AC7795 File Offset: 0x00AC5995
		public void UnBindIgnoreLimit(TInputHandle<T> callback)
		{
			this.IgnoreLimitCallback.Remove(callback);
		}

		// Token: 0x0602E90D RID: 190733 RVA: 0x00AC77A3 File Offset: 0x00AC59A3
		protected void CallIgnoreLimit(T value)
		{
			this.IgnoreLimitCallback.Call(value);
		}

		// Token: 0x0602E90E RID: 190734 RVA: 0x00AC77B1 File Offset: 0x00AC59B1
		public bool HasIgnoreLimit()
		{
			return this.IgnoreLimitCallback.Length() > 0;
		}

		// Token: 0x0602E90F RID: 190735 RVA: 0x00AC77C1 File Offset: 0x00AC59C1
		public bool HasCallback()
		{
			return this.Callback.Length() > 0 || this.IgnoreLimitCallback.Length() > 0;
		}

		// Token: 0x0602E910 RID: 190736 RVA: 0x00AC77E1 File Offset: 0x00AC59E1
		public string GetInputDistributeTag()
		{
			return this.InputDistributeTag;
		}

		// Token: 0x0401952A RID: 103722
		private readonly string InputDistributeTag = "";

		// Token: 0x0401952B RID: 103723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private InputCallback<T> Callback;

		// Token: 0x0401952C RID: 103724
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private InputCallback<T> IgnoreLimitCallback;
	}
}
