using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004AB6 RID: 19126
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewModelBase<[Nullable(2)] T>
	{
		// Token: 0x0602FDBE RID: 196030 RVA: 0x00D5B95E File Offset: 0x00D59B5E
		protected void SetData(T key, [Nullable(2)] object value, bool notNotify = false)
		{
			this.DataMap[key] = value;
			if (!notNotify)
			{
				this.Notify(key);
			}
		}

		// Token: 0x0602FDBF RID: 196031 RVA: 0x00D5B978 File Offset: 0x00D59B78
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

		// Token: 0x0602FDC0 RID: 196032 RVA: 0x00D5B998 File Offset: 0x00D59B98
		public void Bind(TCallback<T> callback)
		{
			if (!this.CallbackList.Contains(callback))
			{
				this.CallbackList.Add(callback);
			}
		}

		// Token: 0x0602FDC1 RID: 196033 RVA: 0x00D5B9B4 File Offset: 0x00D59BB4
		public void UnBind(TCallback<T> callback)
		{
			int num = this.CallbackList.IndexOf(callback);
			if (num != -1)
			{
				this.CallbackList.RemoveAt(num);
			}
		}

		// Token: 0x0602FDC2 RID: 196034 RVA: 0x00D5B9DE File Offset: 0x00D59BDE
		public void Clear()
		{
			this.CallbackList = new List<TCallback<T>>();
		}

		// Token: 0x0602FDC3 RID: 196035 RVA: 0x00D5B9EC File Offset: 0x00D59BEC
		protected void Notify(T key)
		{
			foreach (TCallback<T> tcallback in this.CallbackList)
			{
				tcallback(key);
			}
		}

		// Token: 0x0401968A RID: 104074
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

		// Token: 0x0401968B RID: 104075
		protected List<TCallback<T>> CallbackList = new List<TCallback<T>>();
	}
}
