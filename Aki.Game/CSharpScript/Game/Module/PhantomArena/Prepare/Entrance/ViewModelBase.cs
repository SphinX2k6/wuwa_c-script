using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200516D RID: 20845
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewModelBase<[Nullable(2)] T>
	{
		// Token: 0x060354B6 RID: 218294 RVA: 0x00C9ED8A File Offset: 0x00C9CF8A
		protected void SetData(T key, object value, bool notNotify = false)
		{
			this.DataMap[key] = value;
			if (!notNotify)
			{
				this.Notify(key);
			}
		}

		// Token: 0x060354B7 RID: 218295 RVA: 0x00C9EDA3 File Offset: 0x00C9CFA3
		[return: Nullable(2)]
		protected object GetData(T key)
		{
			return this.DataMap.GetValueOrDefault(key);
		}

		// Token: 0x060354B8 RID: 218296 RVA: 0x00C9EDB1 File Offset: 0x00C9CFB1
		public void Bind(Action<T> callback)
		{
			if (!this.CallbackList.Contains(callback))
			{
				this.CallbackList.Add(callback);
			}
		}

		// Token: 0x060354B9 RID: 218297 RVA: 0x00C9EDCD File Offset: 0x00C9CFCD
		public void UnBind(Action<T> callback)
		{
			this.CallbackList.Remove(callback);
		}

		// Token: 0x060354BA RID: 218298 RVA: 0x00C9EDDC File Offset: 0x00C9CFDC
		public void Clear()
		{
			this.CallbackList.Clear();
		}

		// Token: 0x060354BB RID: 218299 RVA: 0x00C9EDEC File Offset: 0x00C9CFEC
		protected void Notify(T key)
		{
			foreach (Action<T> action in this.CallbackList)
			{
				action(key);
			}
		}

		// Token: 0x0401C588 RID: 116104
		protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

		// Token: 0x0401C589 RID: 116105
		protected List<Action<T>> CallbackList = new List<Action<T>>();
	}
}
