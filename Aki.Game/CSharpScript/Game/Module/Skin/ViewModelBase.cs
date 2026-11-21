using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B92 RID: 15250
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewModelBase<[Nullable(2)] T>
	{
		// Token: 0x06027157 RID: 160087 RVA: 0x00AEF90F File Offset: 0x00AEDB0F
		protected void SetData(T key, object value, bool notNotify = false)
		{
			this.DataMap[key] = value;
			if (!notNotify)
			{
				this.Notify(key);
			}
		}

		// Token: 0x06027158 RID: 160088 RVA: 0x00AEF928 File Offset: 0x00AEDB28
		[return: Nullable(2)]
		protected object GetData(T key)
		{
			object result;
			this.DataMap.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06027159 RID: 160089 RVA: 0x00AEF945 File Offset: 0x00AEDB45
		public void Bind(Action<T> callback)
		{
			if (!this.CallbackList.Contains(callback))
			{
				this.CallbackList.Add(callback);
			}
		}

		// Token: 0x0602715A RID: 160090 RVA: 0x00AEF964 File Offset: 0x00AEDB64
		public void UnBind(Action<T> callback)
		{
			int num = this.CallbackList.IndexOf(callback);
			if (num != -1)
			{
				this.CallbackList.RemoveAt(num);
			}
		}

		// Token: 0x0602715B RID: 160091 RVA: 0x00AEF98E File Offset: 0x00AEDB8E
		public void Clear()
		{
			this.CallbackList = new List<Action<T>>();
		}

		// Token: 0x0602715C RID: 160092 RVA: 0x00AEF99C File Offset: 0x00AEDB9C
		protected void Notify(T key)
		{
			for (int i = 0; i < this.CallbackList.Count; i++)
			{
				this.CallbackList[i](key);
			}
		}

		// Token: 0x04015512 RID: 87314
		protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

		// Token: 0x04015513 RID: 87315
		protected List<Action<T>> CallbackList = new List<Action<T>>();
	}
}
