using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02004BE5 RID: 19429
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewModelBase<[Nullable(2)] T>
	{
		// Token: 0x060323C5 RID: 205765 RVA: 0x00BAB5D0 File Offset: 0x00BA97D0
		protected void SetData(T key, object value, bool notNotify = false)
		{
			this.DataMap[key] = value;
			if (!notNotify)
			{
				this.Notify(key);
			}
		}

		// Token: 0x060323C6 RID: 205766 RVA: 0x00BAB5EC File Offset: 0x00BA97EC
		[return: Nullable(2)]
		protected object GetData(T key)
		{
			object result;
			this.DataMap.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x060323C7 RID: 205767 RVA: 0x00BAB609 File Offset: 0x00BA9809
		public void Bind(Action<T> callback)
		{
			if (!this.CallbackList.Contains(callback))
			{
				this.CallbackList.Add(callback);
			}
		}

		// Token: 0x060323C8 RID: 205768 RVA: 0x00BAB628 File Offset: 0x00BA9828
		public void UnBind(Action<T> callback)
		{
			int num = this.CallbackList.IndexOf(callback);
			if (num != -1)
			{
				this.CallbackList.RemoveAt(num);
			}
		}

		// Token: 0x060323C9 RID: 205769 RVA: 0x00BAB652 File Offset: 0x00BA9852
		public void Clear()
		{
			this.CallbackList = new List<Action<T>>();
		}

		// Token: 0x060323CA RID: 205770 RVA: 0x00BAB660 File Offset: 0x00BA9860
		protected void Notify(T key)
		{
			for (int i = 0; i < this.CallbackList.Count; i++)
			{
				this.CallbackList[i](key);
			}
		}

		// Token: 0x0401ABB7 RID: 109495
		protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

		// Token: 0x0401ABB8 RID: 109496
		protected List<Action<T>> CallbackList = new List<Action<T>>();
	}
}
