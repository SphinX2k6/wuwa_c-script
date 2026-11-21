using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035AB RID: 13739
	[NullableContext(1)]
	[Nullable(0)]
	internal class InputCallback<[Nullable(2)] T>
	{
		// Token: 0x06023048 RID: 143432 RVA: 0x009F5034 File Offset: 0x009F3234
		public InputCallback(string name)
		{
			this.InputIdentification = new InputIdentification(name);
		}

		// Token: 0x06023049 RID: 143433 RVA: 0x009F506C File Offset: 0x009F326C
		public void Call(T value)
		{
			this.IsCalling = true;
			foreach (TInputHandle<T> tinputHandle in this.CallbackList)
			{
				tinputHandle(this.InputIdentification.Name, value, this.InputIdentification);
			}
			this.TryAddAllPendingCallback();
			this.TryRemoveAllPendingCallback();
			this.IsCalling = false;
		}

		// Token: 0x0602304A RID: 143434 RVA: 0x009F50E8 File Offset: 0x009F32E8
		public void Add(TInputHandle<T> callback)
		{
			if (this.IsCalling)
			{
				this.PendingAddCallbackList.Add(callback);
				return;
			}
			this.CallbackList.Add(callback);
		}

		// Token: 0x0602304B RID: 143435 RVA: 0x009F510C File Offset: 0x009F330C
		private void TryAddAllPendingCallback()
		{
			if (this.PendingAddCallbackList.Count <= 0)
			{
				return;
			}
			foreach (TInputHandle<T> item in this.PendingAddCallbackList)
			{
				this.CallbackList.Add(item);
			}
			this.PendingAddCallbackList.Clear();
		}

		// Token: 0x0602304C RID: 143436 RVA: 0x009F5180 File Offset: 0x009F3380
		public void Remove(TInputHandle<T> callback)
		{
			if (this.IsCalling)
			{
				this.PendingRemoveCallbackList.Add(callback);
				return;
			}
			int num = this.CallbackList.IndexOf(callback);
			if (num < 0)
			{
				return;
			}
			this.CallbackList.RemoveAt(num);
		}

		// Token: 0x0602304D RID: 143437 RVA: 0x009F51C0 File Offset: 0x009F33C0
		private void TryRemoveAllPendingCallback()
		{
			if (this.PendingRemoveCallbackList.Count <= 0)
			{
				return;
			}
			foreach (TInputHandle<T> item in this.PendingRemoveCallbackList)
			{
				int num = this.CallbackList.IndexOf(item);
				if (num >= 0)
				{
					this.CallbackList.RemoveAt(num);
				}
			}
			this.PendingRemoveCallbackList.Clear();
		}

		// Token: 0x0602304E RID: 143438 RVA: 0x009F5244 File Offset: 0x009F3444
		public void Clear()
		{
			this.InputIdentification = null;
			this.CallbackList.Clear();
		}

		// Token: 0x0602304F RID: 143439 RVA: 0x009F5258 File Offset: 0x009F3458
		public int Length()
		{
			return this.CallbackList.Count;
		}

		// Token: 0x04013BCC RID: 80844
		[Nullable(2)]
		private InputIdentification InputIdentification;

		// Token: 0x04013BCD RID: 80845
		private readonly List<TInputHandle<T>> CallbackList = new List<TInputHandle<T>>();

		// Token: 0x04013BCE RID: 80846
		private readonly List<TInputHandle<T>> PendingAddCallbackList = new List<TInputHandle<T>>();

		// Token: 0x04013BCF RID: 80847
		private readonly List<TInputHandle<T>> PendingRemoveCallbackList = new List<TInputHandle<T>>();

		// Token: 0x04013BD0 RID: 80848
		private bool IsCalling;
	}
}
