using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005AD5 RID: 23253
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewModelBase<[Nullable(2)] T>
	{
		// Token: 0x0603AE4C RID: 241228 RVA: 0x00E0AC76 File Offset: 0x00E08E76
		protected void SetData(T key, [Nullable(2)] object value, bool notNotify = false)
		{
			this.DataMap[key] = value;
			if (!notNotify)
			{
				this.Notify(key);
			}
		}

		// Token: 0x0603AE4D RID: 241229 RVA: 0x00E0AC90 File Offset: 0x00E08E90
		[return: Nullable(2)]
		protected object GetData(T key)
		{
			object result;
			if (this.DataMap.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603AE4E RID: 241230 RVA: 0x00E0ACB0 File Offset: 0x00E08EB0
		public void Bind(TCallback<T> callback)
		{
			if (!this.CallbackList.Contains(callback))
			{
				this.CallbackList.Add(callback);
			}
		}

		// Token: 0x0603AE4F RID: 241231 RVA: 0x00E0ACCC File Offset: 0x00E08ECC
		public void UnBind(TCallback<T> callback)
		{
			int num = this.CallbackList.IndexOf(callback);
			if (num != -1)
			{
				this.CallbackList.RemoveAt(num);
			}
		}

		// Token: 0x0603AE50 RID: 241232 RVA: 0x00E0ACF6 File Offset: 0x00E08EF6
		public void Clear()
		{
			this.CallbackList = new List<TCallback<T>>();
		}

		// Token: 0x0603AE51 RID: 241233 RVA: 0x00E0AD04 File Offset: 0x00E08F04
		protected void Notify(T key)
		{
			foreach (TCallback<T> tcallback in this.CallbackList)
			{
				tcallback(key);
			}
		}

		// Token: 0x0401EBCE RID: 125902
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

		// Token: 0x0401EBCF RID: 125903
		protected List<TCallback<T>> CallbackList = new List<TCallback<T>>();
	}
}
