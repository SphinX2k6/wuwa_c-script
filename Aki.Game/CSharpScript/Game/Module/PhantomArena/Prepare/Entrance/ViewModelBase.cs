using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200413D RID: 16701
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewModelBase<[Nullable(2)] T>
	{
		// Token: 0x0602A3B2 RID: 172978 RVA: 0x00BEC2D6 File Offset: 0x00BEA4D6
		protected void SetData(T key, object value, bool notNotify = false)
		{
			this.DataMap[key] = value;
			if (!notNotify)
			{
				this.Notify(key);
			}
		}

		// Token: 0x0602A3B3 RID: 172979 RVA: 0x00BEC2EF File Offset: 0x00BEA4EF
		[return: Nullable(2)]
		protected object GetData(T key)
		{
			return this.DataMap.GetValueOrDefault(key);
		}

		// Token: 0x0602A3B4 RID: 172980 RVA: 0x00BEC2FD File Offset: 0x00BEA4FD
		public void Bind(Action<T> callback)
		{
			if (!this.CallbackList.Contains(callback))
			{
				this.CallbackList.Add(callback);
			}
		}

		// Token: 0x0602A3B5 RID: 172981 RVA: 0x00BEC319 File Offset: 0x00BEA519
		public void UnBind(Action<T> callback)
		{
			this.CallbackList.Remove(callback);
		}

		// Token: 0x0602A3B6 RID: 172982 RVA: 0x00BEC328 File Offset: 0x00BEA528
		public void Clear()
		{
			this.CallbackList.Clear();
		}

		// Token: 0x0602A3B7 RID: 172983 RVA: 0x00BEC338 File Offset: 0x00BEA538
		protected void Notify(T key)
		{
			foreach (Action<T> action in this.CallbackList)
			{
				action(key);
			}
		}

		// Token: 0x04016FBD RID: 94141
		protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

		// Token: 0x04016FBE RID: 94142
		protected List<Action<T>> CallbackList = new List<Action<T>>();
	}
}
